
#region Imported Namespaces

using NDSH.Geospatial.Demos.SearchAndMap;
using NDSH.Geospatial.Demos.SearchAndMap.Models.Services.MetadataSemanticSearch;
using NDSH.Geospatial.Metadata.Utilities.Models;
using NDSH.Geospatial.Metadata.Utilities.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Demos.SearchAndMap.Blazor.Models.Presentation {

  /// <summary>
  /// The <see cref="Model"/> used by the <see cref="Views.MetadataSearchView"/>.
  /// </summary>
  public sealed class MetadataSearchModel : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MetadataSearchModel"/>.
    /// </summary>
    public MetadataSearchModel() {
      this.Question = "find me datasets showing precipitation in the uk for the last 20 years"; // TODO: Harcoded question.
    }

    #endregion

    #region Public Properties

    private string _question;

    /// <summary>
    /// Gets/Sets the question used to query the metadata search service.
    /// </summary>
    public string Question {
      get {
        return _question;
      }
      set {
        if (_question != value) {
          _question = value;
          OnPropertyChanged();
        }
      }
    }

    private ObservableCollection<ResultRecord> _resultRecords;

    /// <summary>
    /// Gets/Sets the <see cref="ObservableCollection{T}"/> of <see cref="ResultRecord"/>.
    /// </summary>
    public ObservableCollection<ResultRecord> ResultRecords {
      get {
        return _resultRecords;
      }
      set {
        if (_resultRecords != value) {
          _resultRecords = value;
          OnPropertyChanged();
        }
      }
    }

    private List<BgsLayer>? _bgsLayers;

    /// <summary>
    /// Gets/Sets the <see cref="List{T}"/> of <see cref="BgsLayer">BgsLayers</see>.
    /// </summary>
    public List<BgsLayer>? BgsLayers {
      get {
        return _bgsLayers;
      }
      set {
        if (_bgsLayers != value) {
          _bgsLayers = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
