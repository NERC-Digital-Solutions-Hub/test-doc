
#region Imported Namespaces

using HtmlAgilityPack;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using NDSH.Geospatial.Metadata.Utilities.DatabaseContext;
using NDSH.Geospatial.Metadata.Utilities.Models;
using Serilog.Core;
using Serilog.Filters;
using System.Collections.Immutable;
using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Mime;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Xml.Linq;

#endregion

namespace NDSH.Geospatial.Metadata.Utilities {

  /// <summary>
  /// Provides control over the metadata database.
  /// </summary>
  public class MetadataDatabaseController {

    #region Member Variables

    private static int _sequenceId = 0;
    private MetadataContext _context;
    private DatabaseOption _dbOption;

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets/Sets the file path to the database file.
    /// </summary>
    /// <remarks>
    /// This is the path to a file when a file database like SQLite,
    /// or a connection string if a database like an RDBMS.
    /// </remarks>
    public string DatabasePath {
      get; set;
    }

    /// <summary>
    /// Gets/Sets the <see cref="DatabaseContext.DatabaseOption"/>.
    /// </summary>
    public DatabaseOption DatabaseOption {
      get {
        return _dbOption;
      }
      set {
        _dbOption = value;
      }
    }

    /// <summary>
    /// Gets whether the database is open or not.
    /// </summary>
    public bool IsDbOpen {
      get {
        return _context != null;
      }
    }

    /// <summary>
    /// Gets the <see cref="MetadataContext"/>.
    /// </summary>
    public MetadataContext Context {
      get {
        return _context;
      }
    }

    /// <summary>
    /// Gets the PostgreSQL path retrieving the environment variable's 'pgSqlPath' value.
    /// </summary>
    /// <exception cref="NullReferenceException">
    /// Thrown when the 'pgSqlPath' environment variable isassigned a null value.
    /// </exception>
    public static string GetPgSqlPathFromEnvironmentVariable {
      get {
        string? connectionString = Environment.GetEnvironmentVariable("pgSqlPath");
        if (connectionString == null) {
          throw new NullReferenceException("pgSqlPath is null. Please set the enviroment variable [pgSqlPath] and its value in the debug profile.");
        }
        return connectionString;
      }
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Gets metadata entities from an XML file.
    /// </summary>
    /// <param name="xmlFilePath">
    /// The XML file path having the metadata entity records.
    /// </param>
    /// <returns>A List of <see cref="MetadataEntity"/> instances.</returns>
    public List<MetadataEntity>? GetMetadataEntities(string xmlFilePath) {

      string cswNS = "http://www.opengis.net/cat/csw/2.0.2";
      string gmdNS = "http://www.isotc211.org/2005/gmd";
      string gcoNS = "http://www.isotc211.org/2005/gco";
      string srvNS = "http://www.isotc211.org/2005/srv";

      string getTitle(XElement md) {
        if (md is null) {
          throw new ArgumentNullException(nameof(md));
        }

        string? Title_MD_DataIdentification = md?.Element(XName.Get("identificationInfo", gmdNS))?
                                .Element(XName.Get("MD_DataIdentification", gmdNS))?
                                .Element(XName.Get("citation", gmdNS))?
                                .Element(XName.Get("CI_Citation", gmdNS))?
                                .Element(XName.Get("title", gmdNS))?.Value;
        if (Title_MD_DataIdentification is not null) {
          return Title_MD_DataIdentification;
        }

        string? Title_SV_ServiceIdentification = md?.Element(XName.Get("identificationInfo", gmdNS))?
                                .Element(XName.Get("SV_ServiceIdentification", srvNS))?
                                .Element(XName.Get("citation", gmdNS))?
                                .Element(XName.Get("CI_Citation", gmdNS))?
                                .Element(XName.Get("title", gmdNS))?.Value;

        if (Title_SV_ServiceIdentification is not null) {
          return Title_SV_ServiceIdentification;
        }

        return null;
      }

      var xe = XElement.Load(xmlFilePath);
      XName searchResultXName = XName.Get("SearchResults", cswNS);

      XElement? sr = xe.Element(searchResultXName);

      //// uncomment when you need to run LoadAllFileTypes
      //string getFileType(XElement? md) {

      //  if (md is null) { 
      //    Debug.Assert(false); 
      //    return null;
      //  }
      //  XElement? distroFmt = md?.Element(XName.Get("distributionInfo", gmdNS))?.Element(XName.Get("MD_Distribution", gmdNS))?.Element(XName.Get("distributionFormat", gmdNS));
      //    if (distroFmt is null) { 
      //      return "Missing distributionFormat";
      //    }

      //  List<XElement> mdFmts = distroFmt.Elements(XName.Get("MD_Format", gmdNS)).ToList();

      //  if (mdFmts.Count == 0) {
      //    string? nilReason = distroFmt.Attribute(XName.Get("nilReason", gcoNS))?.Value;
      //    if (nilReason is null) {
      //      Debug.Assert(false);
      //    }
      //    else {
      //      return "nilReason: " + nilReason;

      //    }

      //  }
      //  List<string> mdFmtStrs = mdFmts.Select(fmt => fmt.Value).ToList();

      //  string n = "";

      //  foreach (var fmt in mdFmtStrs) {
      //    if (fmt == null) {
      //      Debug.Assert(false);
      //    }

      //    n += fmt + "; ";
      //  }
      //  return n;
      //}




      List<MetadataEntity> mds = sr?.Elements().Select(
        md => new MetadataEntity {
          RecordId = GetSequenceId(),

          FileIdentifier = md?.Element(XName.Get("fileIdentifier", gmdNS))?.Value,

          Organisation = md?.Element(XName.Get("contact", gmdNS))?
                            .Element(XName.Get("CI_ResponsibleParty", gmdNS))?
                            .Element(XName.Get("organisationName", gmdNS))?.Value,

          Title = getTitle(md),

          Abstract = md?.Element(XName.Get("identificationInfo", gmdNS))?
                                .Element(XName.Get("MD_DataIdentification", gmdNS))?
                                .Element(XName.Get("abstract", gmdNS))?.Value,

          HierarchyLevel = md?.Element(XName.Get("hierarchyLevel", gmdNS))?.Value,

          //// uncomment when you need to run LoadAllFileTypes
          //FileType = getFileType(md),

        }
      ).ToList();

      return mds;

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="xmlFilePath"></param>
    /// <returns></returns>
    public List<BgsLayer>? GetBgsLayers(string xmlFilePath, Logger logger) {
      string cswNS = "http://www.opengis.net/cat/csw/2.0.2";
      string gmdNS = "http://www.isotc211.org/2005/gmd";
      string srvNS = "http://www.isotc211.org/2005/srv";
      string xlinkNS = "http://www.w3.org/1999/xlink";
      string wmsNS = "http://www.opengis.net/wms";

      string? getFileIdentifier(XElement md) {
        return md?.Elements(XName.Get("fileIdentifier", gmdNS)).First().Value;
      }
      string? getHierarchyLevel(XElement md) {
        return md.Element(XName.Get("hierarchyLevel", gmdNS))?.Value;
      }
      string? getResponsibleParty(XElement md) {
        return md.Element(XName.Get("contact", gmdNS))?
        .Element(XName.Get("CI_ResponsibleParty", gmdNS))?
        .Element(XName.Get("organisationName", gmdNS))?
        .Value;
      }
      string? getWmsCapabilityUrl(XElement md) {
        return md.Element(XName.Get("distributionInfo", gmdNS))?
          .Element(XName.Get("MD_Distribution", gmdNS))?
          .Element(XName.Get("transferOptions", gmdNS))?
          .Element(XName.Get("MD_DigitalTransferOptions", gmdNS))?
          .Element(XName.Get("onLine", gmdNS))?
          .Element(XName.Get("CI_OnlineResource", gmdNS))?
          .Element(XName.Get("linkage", gmdNS))?
          .Element(XName.Get("URL", gmdNS))?
          .Value;
      }
      bool isBgsWmsMetadata(XElement md) { // the missing one becoz of this predicate.
        if (md is null) {
          throw new ArgumentNullException(nameof(md));
        }

        string? hierarchyLevel = getHierarchyLevel(md);
        if (hierarchyLevel is null || hierarchyLevel != "service") {
          return false;
        }

        string? responsibleParty = getResponsibleParty(md);

        if (responsibleParty is null || responsibleParty != "British Geological Survey") {
          return false;
        }

        string? serviceUrl = getWmsCapabilityUrl(md);

        if (serviceUrl is null) {
          return false;
        }

        var serviceUrlQueryString = new Uri(serviceUrl).Query;
        System.Collections.Specialized.NameValueCollection Queries = HttpUtility.ParseQueryString(serviceUrlQueryString);
        string serviceValue = Queries["service"];
        string requestValue = Queries["request"];

        return hierarchyLevel == "service"
          && responsibleParty == "British Geological Survey"
          && serviceValue == "WMS"
          && requestValue == "GetCapabilities";
      }
      bool isValidXml(string xml) {
        try {
          XDocument.Parse(xml);
          return true;
        }
        catch {
          return false;
        }
      }

      string? getHttpGetResponseAsString(string url) {
        if (url is null) {
          return null;
        }

        string? responseBody = null;
        using HttpClient client = new HttpClient();
        try {
          HttpResponseMessage response = client.GetAsync(url).Result;
          response.EnsureSuccessStatusCode();
          responseBody = response.Content.ReadAsStringAsync().Result;
        }
        catch (Exception e) {
          logger.Error("[HttpGet request failed]. url: {0} Message :{1}", url, e.Message);
        }
        finally {
        }
        client.Dispose();

        return responseBody;
      }

      string? getWmsLayerRelatedDataSetUuid(XElement x, string fileIdentifier) {

        string? urlString = x.Element(XName.Get("MetadataURL", wmsNS))?
                             .Element(XName.Get("OnlineResource", wmsNS))?
                             .Attribute(XName.Get("href", xlinkNS))?
                             .Value;
        if (urlString is null) {
          logger.Error("[WmsGetCapability UrlString absent] RecordId: {0}", fileIdentifier);
          return null;
        }

        string urlQuery = new Uri(urlString).Query;
        if (string.IsNullOrEmpty(urlQuery)) {
          logger.Error("[WmsGetCapability UrlString Query section absent] RecordID: {0}; urlString: {1}", fileIdentifier, urlString);
          return null;
        }

        string uuid = HttpUtility.ParseQueryString(urlQuery)["ID"];
        if (uuid == null) {
          logger.Error("[WmsGetCapability UrlString Query 'ID' arguement absent] RecordID: {0}; urlString: {1}", fileIdentifier, urlString);
          return null;
        }

        return uuid;

      }

      Uri? getJsonUrl(Uri? uri) {
        if (uri is null) {
          return null;
        }

        var jsonUrl = new UriBuilder(uri);
        var query = HttpUtility.ParseQueryString(jsonUrl.Query);
        query["f"] = "pjson";
        jsonUrl.Query = query.ToString();

        var v = getHttpGetResponseAsString(jsonUrl.Uri.ToString());
        if (v == null) {
          logger.Error("[HttpGetResponse Error] arcGisServerJsonUrl: {0}", jsonUrl.Uri.ToString());
          return null;
        }
        return jsonUrl.Uri;
      }

      Uri? getArcGisMapServerUrl(string? urlString, bool jsonUrl = false) {
        if (urlString is null) {
          return null;
        }

        Uri url = new Uri(urlString);
        var arcGisMapServerUrl = new Uri(url.GetLeftPart(UriPartial.Authority));

        if (!(url.Segments.ToList().Contains("WmsServer") && url.Segments.ToList().Contains("arcgis/"))) {
          return null;
        }

        foreach (var s in url.Segments) {
          if (s == "WmsServer") {
            break;
          }

          arcGisMapServerUrl = new Uri(arcGisMapServerUrl, s);

          if (s == "arcgis/") {
            arcGisMapServerUrl = new Uri(arcGisMapServerUrl, "rest/");
          }
        }

        var v = getHttpGetResponseAsString(url.ToString());
        if (v == null) {
          logger.Error("[HttpGetResponse Error] arcGisServerUrl: {0} originalUrl: {0}", arcGisMapServerUrl.ToString(), url.ToString());
          return null;
        }

        if (jsonUrl == true) {
          return getJsonUrl(arcGisMapServerUrl);
        }

        return arcGisMapServerUrl;

      }

      Uri? getArcGisLayerUrl(Uri? arcGisMapServerUri, string? layerName, string? layerTitle, bool jsonUrl = false) {
        if (arcGisMapServerUri is null) {
          return null;
        }

        if (layerName is null && layerTitle is null) {
          return null;
        }

        string? response = getHttpGetResponseAsString(arcGisMapServerUri.ToString());

        if (response is null) {
          logger.Error(
            "[Failed to getArcGisLayerUrl] arcGisMapServerUrl response error. " +
            "LayerName: {layerName}, arcGisMapServerUrl: {arcGisMapServerUrl}",
            layerName, arcGisMapServerUri);
        }

        HtmlDocument document = new HtmlDocument();
        document.LoadHtml(response);
        HtmlNode? ulNode = document.DocumentNode.SelectSingleNode("//html/body/div/ul[1]");

        if (ulNode is null) {
          logger.Error("[ul Node is null] arcGisMapServerUrl: {arcGisMapServerUrl}", arcGisMapServerUri.ToString());
          return null;
        }

        IEnumerable<HtmlNode>? nodes = null;
        if (!string.IsNullOrEmpty(layerName)) {
          nodes = ulNode?.Elements("li").Select(li => li.Element("a")).Where(a => a.InnerText == layerName);
          if (nodes.Count() > 1) {
            logger.Error("[more than 1 layer is matched by layerName] " +
              "layerName: {layerName}, arcGisMapServerUrl: {arcGisMapServerUrl}",
              layerTitle, layerName, arcGisMapServerUri.ToString());
            return null;
          }
        }
        else if (!string.IsNullOrEmpty(layerTitle)) {
          nodes = ulNode?.Elements("li").Select(li => li.Element("a")).Where(a => a.InnerText == layerTitle);
          if (nodes.Count() > 1) {
            logger.Error("[more than 1 layer is matched by layerTitle] " +
              "layerTitle: {layerTitle}, arcGisMapServerUrl: {arcGisMapServerUrl}",
              layerTitle, layerName, arcGisMapServerUri.ToString());
            return null;
          }
        }
        else {
          logger.Error(
            "[No matching layer] Both layerTitle and layerName is null or empty " +
            "layerTitle: {layerTitle}, layerName: {layerName}, arcGisMapServerUrl: {arcGisMapServerUrl}",
            layerTitle, layerName, arcGisMapServerUri.ToString());
          return null;

        }

        if (nodes.Count() == 0) {
          logger.Error(
            "[No matching layer] " +
            "layerTitle: {layerTitle}, layerName: {layerName}, arcGisMapServerUrl: {arcGisMapServerUrl}",
            layerTitle, layerName, arcGisMapServerUri.ToString());
          return null;
        }

        string? arcGisLayerUrl = nodes?.FirstOrDefault(defaultValue: null).GetAttributeValue("href", null);

        if (arcGisLayerUrl is null) {
          return null;
        }

        Uri arcGisLayerUri = new Uri(
          baseUri: new Uri(arcGisMapServerUri.GetLeftPart(UriPartial.Authority)),
          relativeUri: arcGisLayerUrl);

        if (jsonUrl == true) {
          return getJsonUrl(arcGisLayerUri);
        }

        return arcGisLayerUri;
      }


      List<BgsLayer> getBgsLayers(XElement md) {
        string fileIdentifier = getFileIdentifier(md);
        Debug.Assert(fileIdentifier is not null);
        IEnumerable<BgsLayer>? operatesOnDataSets = md.Element(XName.Get("identificationInfo", gmdNS))?
                                                      .Element(XName.Get("SV_ServiceIdentification", srvNS))?
                                                      .Elements(XName.Get("operatesOn", srvNS))?.ToList()
                                                      .Select(x => new BgsLayer {
                                                        OperatesOnTitle = x.Attribute(XName.Get("title", xlinkNS))?.Value,
                                                        RelatedDataSetUuId = x.Attribute(XName.Get("uuidref"))?.Value,
                                                        FileIdentifier = fileIdentifier,
                                                      });
        if (operatesOnDataSets is null) {
          logger.Error("[Failed to get operatesOnDataSets Node] FileIdentifier: {fileIdentifier}", fileIdentifier, getFileIdentifier(md));
          return null;
        }

        string? wmsGetCapabilityUrl = getWmsCapabilityUrl(md: md);

        if (wmsGetCapabilityUrl is null) {
          logger.Error("[Failed to get WmsCapabilityUrl] FileIdentifier: {fileIdentifier}", fileIdentifier);
          return null;
        }
        string? wmsGetCapabilityUrlHttpGetResponse = getHttpGetResponseAsString(url: wmsGetCapabilityUrl);

        if (wmsGetCapabilityUrlHttpGetResponse is null) {
          logger.Error("[Failed to wmsGetCapabilityUrl response] FileIdentifier: {fileIdentifier}, Url: {url}", fileIdentifier, wmsGetCapabilityUrl);
          return null;
        }

        if (!isValidXml(wmsGetCapabilityUrlHttpGetResponse)) {
          logger.Error("[Invalid Xml response from wmsGetCapabilityUrl] FileIdentifier: {fileIdentifier}, Url: {url}", fileIdentifier, wmsGetCapabilityUrl);
          return null;
        }

        XElement wmsGetCapabilityXelement = XElement.Parse(wmsGetCapabilityUrlHttpGetResponse);

        IEnumerable<XElement>? wmsLayerXelements =
          wmsGetCapabilityXelement.Element(XName.Get("Capability", wmsNS))?
                                  .Element(XName.Get("Layer", wmsNS))?
                                  .Elements(XName.Get("Layer", wmsNS))?
                                  .Where(e => e?.Attribute(XName.Get("queryable")).Value == "1");

        if (wmsLayerXelements is null) {
          logger.Error(
            "[Failed to obtain wmsLayerXelements] " + "FileIdentifier: {fileIdentifier}, wmsGetCapabilityUrl: {wmsGetCapabilityUrl}",
            fileIdentifier, wmsGetCapabilityUrl
          );
          return null;
        }

        List<BgsLayer>? wmsLayers = wmsLayerXelements.Select(x => new BgsLayer {
          FileIdentifier = getFileIdentifier(md),
          RecordId = null,
          WmsLayerName = x.Element(XName.Get("Name", wmsNS))?.Value,
          WmsLayerTitle = x.Element(XName.Get("Title", wmsNS))?.Value,
          WmsLayerAbstract = x.Element(XName.Get("Abstract", wmsNS))?.Value,
          RelatedDataSetUuId = getWmsLayerRelatedDataSetUuid(x, fileIdentifier),
          WmsGetCapabilityUrl = wmsGetCapabilityUrl,
          ArcGisLayerName = x.Element(XName.Get("Name", wmsNS))?.Value,
          ArcGisMapServerUrl = getArcGisMapServerUrl(urlString: wmsGetCapabilityUrl, jsonUrl: false)?.ToString(),
          ArcGisLayerUrl = getArcGisLayerUrl(
            arcGisMapServerUri: getArcGisMapServerUrl(wmsGetCapabilityUrl),
            layerName: x.Element(XName.Get("Name", wmsNS))?.Value,
            layerTitle: x.Element(XName.Get("Title", wmsNS))?.Value,
            jsonUrl: false
          )?.ToString(),
        }).ToList();

        foreach (var wmsLayer in wmsLayers) {
          if (wmsLayer.RelatedDataSetUuId is null) {
            logger.Error("[Missing RelatedDataSetUuId] " +
              "RecordId: {0}, WmsGetCapabilityUrl: {1}, WmsLayerName: {2}, WmsLayerTitle: {3}",
              fileIdentifier, wmsLayer.WmsGetCapabilityUrl, wmsLayer.WmsLayerName, wmsLayer.WmsLayerTitle);
            continue;
          }
          var ds = operatesOnDataSets.Where(ds => ds.RelatedDataSetUuId == wmsLayer.RelatedDataSetUuId).FirstOrDefault(defaultValue: null);

          if (ds is null) {
            logger.Error("[No Match RelatedDataSetUuId]: " +
              "RecordId: {0}, WmsGetCapabilityUrl: {1}, WmsLayerName: {2}, WmsLayerTitle: {3}",
              fileIdentifier, wmsLayer.WmsGetCapabilityUrl, wmsLayer.WmsLayerName, wmsLayer.WmsLayerTitle);
            continue;
          }
          wmsLayer.OperatesOnTitle = ds.OperatesOnTitle;
        }

        return wmsLayers;
      }

      XElement xe = XElement.Load(xmlFilePath);
      XName mdXName = XName.Get("MD_Metadata", gmdNS);
      List<XElement>? mds = xe?.Descendants(mdXName).ToList();
      List<XElement>? bgsWmsMds = mds?.Where(md => isBgsWmsMetadata(md) == true).ToList();

      bgsWmsMds.Select(md => getFileIdentifier(md)).Distinct().ToList().ForEach(
        fileIdentifier => logger.Information(
          "[Found BgsWmsMetaData] fileIdentifier: " + "{fileIdentifier}",
          fileIdentifier
        )
      );

      List<BgsLayer> ret = new List<BgsLayer>();

      IEnumerable<List<BgsLayer>> _ret = bgsWmsMds.Select(md => getBgsLayers(md: md));
      _ret.Where(ls => ls != null).ToList().ForEach(ret.AddRange);

      ret.Select(layer => layer.FileIdentifier)
         .Distinct()
         .ToList()
         .ForEach(fileIdentifier => logger.Information("[Remain BgsWmsMetaData]: {fileIdentifier}", fileIdentifier));

      return ret;
    }

    /// <summary>
    /// Loads the metadata entities into the Sqlite database.
    /// </summary>
    /// <param name="xmlFilePath">
    /// The path to the XML file from which metadata entities will be loaded.
    /// </param>
    /// <param name="context">The <see cref="MetadataContext"/>.</param>
    /// <exception cref="NullReferenceException">Thrown when the no metadata entities are returned.</exception>
    public void LoadMetadataEntitiesToSqliteDb(string xmlFilePath, MetadataContext context) {

      List<MetadataEntity>? mds = GetMetadataEntities(xmlFilePath);

      if (mds == null) {
        throw new NullReferenceException(nameof(mds));
      }

      Debug.Assert(mds != null);
      context.AddRange(mds);
      context.SaveChanges();
      Debug.WriteLine(string.Format($"Added {mds.Count} metadata to db from file: {xmlFilePath}"));

    }

    /// <summary>
    /// Loads the metadata entities into the Sqlite database.
    /// </summary>
    /// <param name="xmlFilePath">
    /// The path to the XML file from which metadata entities will be loaded.
    /// </param>
    /// <param name="context">The <see cref="MetadataContext"/>.</param>
    /// /// <exception cref="NullReferenceException"></exception>
    public List<MetadataEntity> GetAllMetadataEntitiesFileTypeInMemory(string xmlFilePath, MetadataContext context) {

      List<MetadataEntity>? mds = GetMetadataEntities(xmlFilePath);

      if (mds == null) {
        throw new NullReferenceException(nameof(mds));
      }

      return mds;

    }

    /// <summary>
    /// Load the bgs layers into the Sqlite database
    /// </summary>
    /// <param name="xmlFilePath">
    /// The path to the XML file from which metadata entities will be loaded.
    /// </param>
    /// <param name="context"><see cref="MetadataContext"/>.</param>
    /// <param name="logger"><see cref="Logger"/></param>
    /// <exception cref="NullReferenceException"></exception>
    public void LoadBgsLayersToSqliteDb(string xmlFilePath, MetadataContext context, Logger logger) {

      List<BgsLayer>? lys = GetBgsLayers(xmlFilePath, logger);

      lys.ForEach(layer => layer.RecordId = context.MetadataEntities.Where(md => md.FileIdentifier == layer.FileIdentifier).First().RecordId);

      if (lys is null) {
        throw new NullReferenceException(nameof(lys));
      }

      context.AddRange(lys);
      context.SaveChanges();
      Debug.WriteLine(string.Format($"Added {lys.Count} bgsLayers to db from file: {xmlFilePath}"));

    }

    /// <summary>
    /// 
    /// </summary>
    public void LoadEmptyTitleComparisonRecords() {

      if (_context == null) {
        throw new NullReferenceException("Database context is null. Make sure the database has been opened properly.");
      }
      if (_context.MetadataEntities == null) {
        throw new NullReferenceException("The MetadataEntities table is null.");
      }

      DateTime start = DateTime.Now;

      int totalRecords = _context.MetadataEntities.Count();
      if (totalRecords <= 0) {
        throw new Exception("The MetadataEntities table has no records");
      }

      ImmutableSortedDictionary<int, string> sortedDictionary = GetAllTitles();
      List<int> recordIds = sortedDictionary.Keys.ToList();

      int saveStep = 100;
      int stepCounter = 0;

      for (int i = 0; i < recordIds.Count; i++) {
        int firstRecordId = recordIds[i];
        stepCounter++;

        Debug.WriteLine("Processing record: {0}", recordIds[i]);

        List<TitleComparison> titleComparisons = new List<TitleComparison>(recordIds.Count - i);

        for (int j = 0; j < recordIds.Count; j++) {
          int secondRecordId = recordIds[j];

          titleComparisons.Add(
            new TitleComparison() {
              RecordId1 = firstRecordId,
              RecordId2 = secondRecordId,
              HammingDistance = double.MinValue,
              JaccardDistance = double.MinValue,
              LevenshteinDistance = double.MinValue
            }
          );
        }

        _context.TitleComparisons.AddRangeAsync(titleComparisons);

        if (stepCounter == saveStep) {
          stepCounter = 0;
          Debug.WriteLine("Saving ...");
          _context.SaveChangesAsync();
        }
      }

      Debug.WriteLine("Saving ...");
      _context.SaveChanges();

      DateTime end = DateTime.Now;

      Debug.WriteLine("*** Process duration: {0}", TimeSpan.FromTicks(end.Ticks - start.Ticks));

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="context"></param>
    /// <param name="logger"></param>
    public void LoadBgsArcGisMapServerJsonsToSqliteDb(MetadataContext context, Logger logger) {

      string? getHttpGetResponseAsString(string url) {
        if (url is null) {
          return null;
        }

        string? responseBody = null;
        using HttpClient client = new HttpClient();
        try {
          HttpResponseMessage response = client.GetAsync(url).Result;
          response.EnsureSuccessStatusCode();
          responseBody = response.Content.ReadAsStringAsync().Result;
        }
        catch (Exception e) {
          logger.Error("[HttpGet request failed]. url: {0} Message :{1}", url, e.Message);
        }
        finally {
        }
        client.Dispose();

        return responseBody;
      }
      Uri? getJsonUrl(Uri? uri) {
        if (uri is null) {
          return null;
        }
        var jsonUrl = new UriBuilder(uri);
        var query = HttpUtility.ParseQueryString(jsonUrl.Query);
        query["f"] = "pjson";
        jsonUrl.Query = query.ToString();

        var v = getHttpGetResponseAsString(jsonUrl.Uri.ToString());
        if (v == null) {
          logger.Error("[HttpGetResponse Error] arcGisServerJsonUrl: {0}", jsonUrl.Uri.ToString());
          return null;
        }
        return jsonUrl.Uri;
      }
      BgsArcGisMapServerJson? getBgsArcGisMapServerJson(BgsLayer layer) {
        return new BgsArcGisMapServerJson() {
          RecordId = layer.RecordId,
          FileIdentifier = layer.FileIdentifier,
          Url = layer.ArcGisMapServerUrl,
          Content = getHttpGetResponseAsString(url: getJsonUrl(new Uri(layer.ArcGisMapServerUrl))?.ToString()),
        };
      }

      var ret = context.BgsLayers.ToList()
        .DistinctBy(layer => layer.FileIdentifier)
        .Where(layer => layer.ArcGisMapServerUrl != null)
        .Select(selector: layer => getBgsArcGisMapServerJson(layer)).ToList();
      Debug.Assert(ret.Any());
      context.BgsArcGisMapServerJsons.AddRange(ret);
      context.SaveChanges();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="context"></param>
    /// <param name="logger"></param>
    public void LoadBgsArcGisLayerJsonsToSqliteDb(MetadataContext context, Logger logger) {

      string? getHttpGetResponseAsString(string url) {
        if (url is null) {
          return null;
        }

        string? responseBody = null;
        using HttpClient client = new HttpClient();
        try {
          HttpResponseMessage response = client.GetAsync(url).Result;
          response.EnsureSuccessStatusCode();
          responseBody = response.Content.ReadAsStringAsync().Result;
        }
        catch (Exception e) {
          logger.Error("[HttpGet request failed]. url: {0} Message :{1}", url, e.Message);
        }
        finally {
        }
        client.Dispose();

        return responseBody;
      }
      Uri? getJsonUrl(Uri? uri) {
        if (uri is null) {
          return null;
        }
        var jsonUrl = new UriBuilder(uri);
        var query = HttpUtility.ParseQueryString(jsonUrl.Query);
        query["f"] = "pjson";
        jsonUrl.Query = query.ToString();

        var v = getHttpGetResponseAsString(jsonUrl.Uri.ToString());
        if (v == null) {
          logger.Error("[HttpGetResponse Error] arcGisServerJsonUrl: {0}", jsonUrl.Uri.ToString());
          return null;
        }
        return jsonUrl.Uri;
      }
      BgsArcGisLayerJson? getBgsArcGisLayerJson(BgsLayer layer) {
        return new BgsArcGisLayerJson() {
          BgsLayerId = layer.Id,
          RecordId = layer.RecordId,
          FileIdentifier = layer.FileIdentifier,
          Url = layer.ArcGisLayerUrl,
          Content = getHttpGetResponseAsString(url: getJsonUrl(new Uri(layer.ArcGisLayerUrl))?.ToString()),
        };
      }

      var ret = context.BgsLayers.ToList()
        .Where(layer => layer.ArcGisLayerUrl != null)
        .Select(layer => getBgsArcGisLayerJson(layer))
        .ToList();
      context.BgsArcGisLayerJsons.AddRange(ret);
      context.SaveChanges();
    }

    /// <summary>
    /// Loads all the contents of the metadata files in the database.
    /// </summary>
    /// <param name="directory"></param>
    public void LoadAllXmlFiles(string directory, Logger logger) {

      List<string> xmlFilePaths = Directory.GetFiles(
        path: directory, searchPattern: "*.xml").ToList();

      // Make sure that the sequence id is reset.
      ResetSequenceId();

      foreach (string xmlFilePath in xmlFilePaths) {
        _sequenceId = Convert.ToInt32(Path.GetFileName(xmlFilePath).Replace(".xml", "").Replace("nerc_", "")) - 1;
        LoadMetadataEntitiesToSqliteDb(xmlFilePath: xmlFilePath, context: _context);
        LoadBgsLayersToSqliteDb(xmlFilePath: xmlFilePath, context: _context, logger: logger);
      }
      LoadBgsArcGisMapServerJsonsToSqliteDb(context: _context, logger: logger);
      LoadBgsArcGisLayerJsonsToSqliteDb(context: _context, logger: logger);
      // match the bgs layer with metadata entity by fileId for recordID
      // match the layerJson with the bgs layer by url and for the bgsLayerID

    }

    /// <summary>
    /// Gets all the contents including FileType of the metadata files in the database.
    /// search "// uncomment when you need to run LoadAllFileTypes" 
    /// in MetadataDatabaseControllers.cs and MetadataEntry.cs
    /// </summary>
    /// <param name="directory"></param>
    public List<MetadataEntity> LoadAllFileTypes(string directory, Logger logger) {

      List<string> xmlFilePaths = Directory.GetFiles(
        path: directory, searchPattern: "*.xml").ToList();

      // Make sure that the sequence id is reset.
      ResetSequenceId();
      List<MetadataEntity> all_mds = new List<MetadataEntity>();

      foreach (string xmlFilePath in xmlFilePaths) {
        _sequenceId = Convert.ToInt32(Path.GetFileName(xmlFilePath).Replace(".xml", "").Replace("nerc_", "")) - 1;
        all_mds.AddRange(GetAllMetadataEntitiesFileTypeInMemory(xmlFilePath: xmlFilePath, context: _context));
      }

      return all_mds;

    }

    /// <summary>
    /// Loads all the <see cref="LevenshteinTitleStatistics"/> in the list.
    /// </summary>
    /// <param name="levenshteinTitleStatistics">The List of <see cref="LevenshteinTitleStatistics"/>.</param>
    /// <param name="append">
    /// Determines whether the lsit of <see cref="LevenshteinTitleStatistics"/> will be appended
    /// to the rows of the table or not. If not, the previous rows will be removed from the table.
    /// </param>
    /// <exception cref="Exception">Thrown when the database has not beeb opened.</exception>
    public void LoadLevenshteinTitleStatistics(List<LevenshteinTitleStatistics> levenshteinTitleStatistics, bool append = false) {

      if (_context == null) {
        throw new Exception("The database has not been opened");
      }

      if (!append) {
        if (_context.LevenshteinTitleStatistics != null) {
          if (_context.LevenshteinTitleStatistics.Count() > 0) {
            _context.RemoveRange(_context.LevenshteinTitleStatistics);
          }
        }
      }

      _context.AddRange(levenshteinTitleStatistics);
      _context.SaveChanges();

    }

    /// <summary>
    /// Loads all the <see cref="LevenshteinTitleComparison">LevenshteinTitleComparisons</see> in the list.
    /// </summary>
    /// <param name="levenshteinTitleComparisons">The List of <see cref="LevenshteinTitleComparison"/>.</param>
    /// <param name="append">
    /// Determines whether the lsit of <see cref="LevenshteinTitleComparison"/> will be appended
    /// to the rows of the table or not. If not, the previous rows will be removed from the table.
    /// </param>
    /// <exception cref="Exception">Thrown when the database has not beeb opened.</exception>
    public void LoadLevenshteinTitleComparisons(List<LevenshteinTitleComparison> levenshteinTitleComparisons, bool append = false) {

      if (_context == null) {
        throw new Exception("The database has not been opened");
      }

      _context.ChangeTracker.AutoDetectChangesEnabled = false;

      if (!append) {
        if (_context.LevenshteinTitleComparisons != null) {
          if (_context.LevenshteinTitleComparisons.Count() > 0) {
            _context.RemoveRange(_context.LevenshteinTitleComparisons);
          }
        }
      }

      _context.AddRange(levenshteinTitleComparisons);
      _context.SaveChanges();

    }

    /// <summary>
    /// Opens the SQLite database.
    /// </summary>
    public void OpenDatabase() {
      OpenDatabase(DatabasePath, DatabaseOption);
    }

    /// <summary>
    /// Opens the SQLite database.
    /// </summary>
    /// <param name="databasePath">The database path.</param>
    /// <param name="databaseOption">The <see cref="DatabaseOption.DatabaseOption"/>.</param>
    public void OpenDatabase(string databasePath, DatabaseOption databaseOption) {
      DatabasePath = databasePath;
      DatabaseOption = databaseOption;
      _context = new MetadataContext(DatabasePath, DatabaseOption);
    }

    /// <summary>
    /// Closes the SQLite database.
    /// </summary>
    public void CloseDatabase() {

      if (_context == null) {
        throw new Exception($"{nameof(_context)} is null");
      }

      _context.Dispose();

    }

    /// <summary>
    /// Deletes the SQLite database.
    /// </summary>
    public void DeleteDatabase() {

      if (_context == null) {
        throw new Exception($"{nameof(_context)} is null");
      }

      _context.Database.EnsureDeleted();

    }

    /// <summary>
    /// Creates a new SQLite database.
    /// </summary>
    public void CreateDatabase() {

      if (_context == null) {
        throw new Exception($"{nameof(_context)} is null");
      }

      if (File.Exists(DatabasePath)) {
        throw new Exception("File already exists.");
      }

      _context.Database.EnsureCreated();

    }

    /// <summary>
    /// Recreates the SQLite database.
    /// </summary>
    public void RecreateDatabase() {

      if (_context == null) {
        throw new Exception($"{nameof(_context)} is null");
      }

      _context.Database.EnsureDeleted();
      _context.Database.EnsureCreated();

    }

    /// <summary>
    /// Gets a dictionary of all the metadata titles found in the database.
    /// </summary>
    /// <returns>
    /// An ImmutableSortedDictionary of int and string.
    /// </returns>
    // TODO: Improve documentation here.
    public ImmutableSortedDictionary<int, string> GetAllTitles() {

      if (_context == null) {
        return null;
      }

      if (_context.MetadataEntities == null) {
        throw new NullReferenceException("MetadataEntities table is Null.");
      }

      if (_context.MetadataEntities.Count() <= 0) {
        throw new Exception("MetadataEntities table has no rows.");
      }

      return _context.MetadataEntities.ToImmutableSortedDictionary(k => k.RecordId, e => e.Title);

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="titlesDictionary"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="Exception"></exception>
    public byte[][] GetAllTitlesInByteArray(ImmutableSortedDictionary<int, string> titlesDictionary, Encoding encoding) {

      if (titlesDictionary == null) {
        throw new ArgumentNullException("The titles dictionary is null.");
      }

      if (titlesDictionary.Count() <= 0) {
        throw new Exception("The titles dictionary is empty.");
      }

      byte[][] arrayOfArrayOfBytes = new byte[titlesDictionary.Count()][];

      int index = 0;

      //foreach (KeyValuePair kvp in titlesDictionary) {
      //  byte[] bytes = encoding.GetBytes(kvp.);
      //  arrayOfArrayOfBytes[index] = bytes;
      //  index++;
      //}

      foreach (string s in titlesDictionary.Values) {
        byte[] bytes = encoding.GetBytes(s);
        arrayOfArrayOfBytes[index] = bytes;
        index++;
      }

      return arrayOfArrayOfBytes;

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="titlesDictionary"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="Exception"></exception>
    public char[][] GetAllTitlesInCharArray(ImmutableSortedDictionary<int, string> titlesDictionary) {

      if (titlesDictionary == null) {
        throw new ArgumentNullException("The titles dictionary is null.");
      }

      if (titlesDictionary.Count() <= 0) {
        throw new Exception("The titles dictionary is empty.");
      }

      char[][] arrayOfArrayOfChars = new char[titlesDictionary.Count()][];

      int index = 0;

      //foreach (KeyValuePair kvp in titlesDictionary) {
      //  byte[] bytes = encoding.GetBytes(kvp.);
      //  arrayOfArrayOfBytes[index] = bytes;
      //  index++;
      //}

      foreach (string s in titlesDictionary.Values) {
        arrayOfArrayOfChars[index] = s.ToCharArray();
        index++;
      }

      return arrayOfArrayOfChars;

    }

    /// <summary>
    /// Gets a <see cref="List{T}"/> of all the <see cref="BgsLayer">BgsLayers</see> found in the database.
    /// </summary>
    public List<BgsLayer> GetAllBgsLayers() {

      if (_context == null) {
        return null;
      }

      if (_context.BgsLayers == null) {
        throw new NullReferenceException("BgsLayers table is Null.");
      }

      if (_context.BgsLayers.Count() <= 0) {
        throw new Exception("BgsLayers table has no rows.");
      }

      return _context.BgsLayers.ToList();

    }

    #endregion

    #region Private Procedures

    /// <summary>
    /// Gets the sequence id.
    /// </summary>
    private static int GetSequenceId() {
      return ++_sequenceId;
    }

    /// <summary>
    /// Resets the sequence id.
    /// </summary>
    private static void ResetSequenceId() {
      _sequenceId = 0;
    }

    #endregion

  }

}
