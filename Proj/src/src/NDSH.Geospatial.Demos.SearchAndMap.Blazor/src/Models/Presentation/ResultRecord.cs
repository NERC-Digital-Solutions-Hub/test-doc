
#region Imported Namespaces

using NDSH.Geospatial.Demos.SearchAndMap;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Demos.SearchAndMap.Blazor.Models.Presentation {

  /// <summary>
  /// 
  /// </summary>
  public sealed class ResultRecord : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ResultRecord"/>.
    /// </summary>
    /// <param name="identifier">The metadata record identifier.</param>
    /// <param name="recordId">The metadata record id.</param>
    /// <param name="title">The metadata record title.</param>
    /// <param name="abstract">The metadata record abstract.</param>
    /// <param name="score">
    /// The similarity score of the metadata record when its title or
    /// abstract is compared with the provide query question.
    /// </param>
    /// <param name="isSelected">Indicates whether the result record is selected or not.</param>
    /// <param name="hasGeoServices">Indicates whether the result record has geoservices or not.</param>
    public ResultRecord(string identifier, int recordId, string title, string @abstract, double score, bool isSelected, bool hasGeoServices) {
      this.Identifier = identifier;
      this.Id = recordId;
      this.Title = title;
      this.Abstract = @abstract;
      this.Score = score;
      this.IsSelected = isSelected;
      this.HasGeoServices = hasGeoServices;
    }

    #endregion

    #region Public Properties

    private bool _isSelected;

    /// <summary>
    /// Gets/Sets whether the result record is selected or not.
    /// </summary>
    public bool IsSelected {
      get {
        return _isSelected;
      }
      set {
        if (_isSelected != value) {
          _isSelected = value;
          //string r = _isSelected ? "true" : "false";
          //Console.WriteLine(@$"fid: {Identifier}; isSelected: {r}");
          OnPropertyChanged();
        }
      }
    }

    private bool _hasGeoServices;

    /// <summary>
    /// Gets/Sets whether the result record has geoservices or not.
    /// </summary>
    public bool HasGeoServices {
      get {
        return _hasGeoServices;
      }
      set {
        if (_hasGeoServices != value) {
          _hasGeoServices = value;
          OnPropertyChanged();
        }
      }
    }

    /// <summary>
    /// Gets the title of the metadata record.
    /// </summary>
    [JsonProperty("title")]
    public string Title {
      get; private set;
    }

    /// <summary>
    /// Gets the identifier of the metadata record.
    /// </summary>
    [JsonProperty("identifier")]
    public string Identifier {
      get; private set;
    }

    /// <summary>
    /// Gets the id of the metadata record.
    /// </summary>
    [JsonProperty("recordId")]
    public int Id {
      get; private set;
    }

    /// <summary>
    /// Gets the abstract of the metadata record.
    /// </summary>
    [JsonProperty("abstract")]
    public string Abstract {
      get; private set;
    }

    /// <summary>
    /// Gets the similarity score of the metadata record when its
    /// title or abstract is compared with the provided query question.
    /// </summary>
    [JsonProperty("scores")]
    public double Score {
      get; private set;
    }

    #endregion

  }

}
