
#region Imported Namespaces

using NDSH.Database;
using NDSH.Geospatial.Demos.SearchAndMap.Blazor.Binders;
using NDSH.Geospatial.Demos.SearchAndMap.Blazor.Models.Presentation;
using NDSH.Geospatial.Demos.SearchAndMap.Models.Services.MetadataSemanticSearch;
using NDSH.Geospatial.Metadata.Utilities.DatabaseContext;
using NDSH.Geospatial.Metadata.Utilities.Models;
using NDSH.Geospatial.Metadata.Utilities.Utils;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
//using System.Text.Json;
using System.Windows.Input;

#endregion

namespace NDSH.Geospatial.Demos.SearchAndMap.Blazor.Commands {

  /// <summary>
  /// The <see cref="ICommand"/> to submit a query in the metadata semantic search service.
  /// </summary>
  public sealed class SubmitQueryCommand : ICommand {

    #region Member Variables

    private readonly Dictionary<NDSH.Geospatial.Demos.SearchAndMap.Models.Services.MetadataSemanticSearch.Encoding, System.Text.Encoding> _encodingsDictionary;
    MetadataDatabaseController _metadataDatabaseController;

    #endregion

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SubmitQueryCommand"/>.
    /// </summary>
    public SubmitQueryCommand() {

      _encodingsDictionary = new(5);

      _encodingsDictionary.Add(NDSH.Geospatial.Demos.SearchAndMap.Models.Services.MetadataSemanticSearch.Encoding.Ascii, System.Text.Encoding.ASCII);
      _encodingsDictionary.Add(NDSH.Geospatial.Demos.SearchAndMap.Models.Services.MetadataSemanticSearch.Encoding.Unicode, System.Text.Encoding.Unicode);
      _encodingsDictionary.Add(NDSH.Geospatial.Demos.SearchAndMap.Models.Services.MetadataSemanticSearch.Encoding.Utf7, System.Text.Encoding.UTF7);
      _encodingsDictionary.Add(NDSH.Geospatial.Demos.SearchAndMap.Models.Services.MetadataSemanticSearch.Encoding.Utf8, System.Text.Encoding.UTF8);
      _encodingsDictionary.Add(NDSH.Geospatial.Demos.SearchAndMap.Models.Services.MetadataSemanticSearch.Encoding.Utf32, System.Text.Encoding.UTF32);

      //GetAllBgsLayersFromDb

    }

    /// <summary>
    /// Destructs the <see cref="MetadataSearchBinder"/>.
    /// </summary>
    ~SubmitQueryCommand() {
      _metadataDatabaseController.CloseDatabase();
    }

    #endregion

    #region ICommand Interface

    /// <summary>
    /// The event that is raised when the conditions that determine whether
    /// the <see cref="ICommand"/> can be executed or not has been changed.
    /// </summary>
    public event EventHandler? CanExecuteChanged;

    /// <summary>
    /// Indicates whether the <see cref="AddLayersCommand"/> can be executed or not.
    /// </summary>
    /// <param name="parameter">The parameter used by the <see cref="AddLayersCommand"/>.</param>
    /// <returns>
    /// A <see cref="bool"/> indicating whether the <see cref="AddLayersCommand"/> can be executed or not.
    /// </returns>
    public bool CanExecute(object? parameter) {
      return true;
    }

    /// <summary>
    /// Executes the <see cref="SubmitQueryCommand"/>.
    /// </summary>
    /// <param name="parameter">The parameter used by the <see cref="SubmitQueryCommand"/>.</param>
    public void Execute(object? parameter) {

      if (parameter == null) {
        throw new ArgumentNullException(string.Format("The {0} parameter in null", nameof(SubmitQueryCommand)));
      }

      try {
        MetadataSearchModel metadataSearchModel = (MetadataSearchModel)parameter;
        if (_metadataDatabaseController == null) {
          this.GetAllBgsLayersFromGraphqlApi(metadataSearchModel);
        }

        PostQuery(metadataSearchModel);
      }
      catch (Exception ex) {
        throw;
        // Swallow the error.
      }

    }

    #endregion

    #region Private Procedures

    /// <summary>
    /// Posts a query to the metadata semantic search service.
    /// </summary>
    /// <param name="metadataSearchModel">The <see cref="MetadataSearchModel"/>.</param>
    private async void PostQuery(MetadataSearchModel metadataSearchModel) {

      metadataSearchModel.ResultRecords = new ObservableCollection<ResultRecord>();

      Service service = AppEngine.Instance.ApplicationModel.Service;

      List<Request> requests = service.Requests.Where(r => r.IsUsed).ToList();

      if (requests == null) {
        throw new Exception("No available requests found. Please check application configuration."); // TODO: Move to Resources.
      }

      HttpClient client = new HttpClient();

      Dictionary<Request, Tuple<Result?, HttpStatusCode, string?>> results = new(requests.Count);

      foreach (Request request in requests) {

        request.Query = metadataSearchModel.Question;
        Dictionary<string, object> requestDictionary = request.ToDictionary();

        string json = System.Text.Json.JsonSerializer.Serialize(requestDictionary); // This performs better than NewtonSoft
        StringContent content = new StringContent(json, _encodingsDictionary[service.Content.Encoding], service.Content.MediaType);
        HttpResponseMessage? response = await client.PostAsync(service.Url, content);

        // Check if the request was executed successfully.
        if (response.IsSuccessStatusCode) {
          var responseJson = await response.Content.ReadAsStringAsync();

          // Deserialize the response JSON into an object and add it in the results dictionary.
          results.Add(
            request,
            new(JsonConvert.DeserializeObject<Result>(responseJson), response.StatusCode, response.ReasonPhrase)
          );
        }
        else {
          // Add the error in the results dictionary.
          results.Add(request, new(null, response.StatusCode, response.ReasonPhrase));
        }

      }

      CreateResultRecords(metadataSearchModel, results);

    }

    /// <summary>
    /// Creates the <see cref="ObservableCollection{T}"/> <see cref="ResultRecord"/>.
    /// </summary>
    /// <param name="metadataSearchModel">The <see cref="MetadataSearchModel"/>.</param>
    /// <param name="results">The entire set of results.</param>
    private static void CreateResultRecords(MetadataSearchModel metadataSearchModel, Dictionary<Request, Tuple<Result, HttpStatusCode, string>> results) {

      // Check if the requests returned results. If at least one request returned results, the entire request session was successful.
      // The request session was unsuccesfull only if all requests returned error codes.
      var successResultsTuple = results.Where(t => t.Value.Item2 == HttpStatusCode.OK).ToList();

      if (successResultsTuple != null) {
        if (successResultsTuple.Count > 0) {

          Dictionary<int, ResultRecord> unionedRecords = new Dictionary<int, ResultRecord>();

          foreach (var tuple in successResultsTuple) {
            Result? res = tuple.Value.Item1;
            if (res != null) {
              if (res.Records != null) {
                foreach (Record r in res.Records) {
                  if (!unionedRecords.ContainsKey(r.Id)) {
                    ResultRecord rr = new ResultRecord(r.Identifier, r.Id, r.Title, r.Abstract, r.Score, false, false); // TODO: DANGER!!! this needs to add information about if it has geoservices.
                    unionedRecords.Add(rr.Id, rr);
                  }
                  else {
                    if (unionedRecords[r.Id].Score < r.Score) {
                      ResultRecord rr = new ResultRecord(r.Identifier, r.Id, r.Title, r.Abstract, r.Score, false, false); // TODO: DANGER!!! this needs to add information about if it has geoservices.
                      unionedRecords[r.Id] = rr;
                    }
                  }
                }
              }
            }
          }

          if (unionedRecords.Count > 0) {
            metadataSearchModel.ResultRecords = new(unionedRecords.Values.OrderByDescending(r => r.Score).ToList());
          }

          if (metadataSearchModel.BgsLayers != null) {
            var validList = metadataSearchModel.BgsLayers.Where(l => l.RelatedDataSetUuId !=  null).ToList();
            Console.WriteLine(validList.Count);
            // Find which datasets have associated services.
            foreach (ResultRecord resultRecord in metadataSearchModel.ResultRecords) {
              //resultRecord.HasGeoServices = metadataSearchModel.BgsLayers.Exists(lyr => lyr.RecordId == resultRecord.Id);
              resultRecord.HasGeoServices = metadataSearchModel.BgsLayers.Exists(lyr => lyr.RelatedDataSetUuId == resultRecord.Identifier);
              if (resultRecord.HasGeoServices == true) {
                Console.WriteLine("Got you.");
              }
            }

          }

        }
      }

    }
    /// <summary>
    /// The GraphQL Api layer for <see cref="GetAllBgsLayersFromDb(MetadataSearchModel)"></see>
    /// To populate the <see cref="MetadataSearchModel.BgsLayers"/>
    /// </summary>
    /// <param name="metadataSearchModel"></param>
    private async void GetAllBgsLayersFromGraphqlApi(MetadataSearchModel metadataSearchModel) {
      try {
        
        HttpClient client = new HttpClient();//
        Uri graphqlApiUri = new Uri(@"https://localhost:7089/graphql/");
        
        var queryContent = @"
query { 
  bgsLayers { 
    recordId,
    fileIdentifier,
    relatedDataSetUuId,
    operatesOnTitle,
    wmsLayerName,
    wmsLayerTitle,
    wmsLayerAbstract,
    wmsGetCapabilityUrl,
    arcGisMapServerUrl,
    arcGisLayerUrl,
    arcGisLayerName
  } 
}";
        var queryObject = new { query = queryContent };
        var queryJson = JsonConvert.SerializeObject(queryObject);
        
        var request = new HttpRequestMessage {
          RequestUri = graphqlApiUri,
          Method = HttpMethod.Post,
          Content = new StringContent(content: queryJson, encoding: System.Text.Encoding.UTF8, mediaType: "application/json"),
        };
        

        using (var response = await client.SendAsync(request)) {
          response.EnsureSuccessStatusCode();
          string responseString = await response.Content.ReadAsStringAsync();
          var obj = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, List<BgsLayer>>>>(responseString);
          metadataSearchModel.BgsLayers = obj!["data"]["bgsLayers"];
          return;
        }
      }
      catch (Exception ex) {
        throw;
      }
    }


    /// <summary>
    /// Gets all the <see cref="BgsLayer">BgsLayers</see> from the database.
    /// </summary>
    /// <param name="metadataSearchModel">The <see cref="MetadataSearchModel"/>.</param>
    private async void GetAllBgsLayersFromDb(MetadataSearchModel metadataSearchModel) {
      // cannot directly connect to Database in BlazorWASM due to security reason.

      PostgreSqlConnectionInfo pcs;

      // TODO: Check if this try - catch needs to be here, or all the way up.
      try {
        pcs = (PostgreSqlConnectionInfo)AppEngine.Instance.ApplicationModel.DatabaseConnectionsInfo.Where(
          cs => cs.Name == "PostgreSQL-AWS" // TODO: Does this Hardcode need to be here?
        ).First();
      }
      catch (Exception ex) {
        //MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        throw new Exception("Error");
        return;
      }

      _metadataDatabaseController = new MetadataDatabaseController();
      _metadataDatabaseController.OpenDatabase(pcs.ToConnectionString(), DatabaseOption.PgSqlDev); // TODO: Database option is hardcoded, it needs to be moved in the config.

      metadataSearchModel.BgsLayers = _metadataDatabaseController.GetAllBgsLayers();

    }

    #endregion

  }

}
