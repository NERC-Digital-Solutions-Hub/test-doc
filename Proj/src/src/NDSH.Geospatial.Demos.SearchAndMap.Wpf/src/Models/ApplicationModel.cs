
#region Imported Namespaces

using NDSH.Database;
using NDSH.Geospatial.Demos.SearchAndMap.Models.Services.MetadataSemanticSearch;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Demos.SearchAndMap.Models {
  
  /// <summary>
  /// The model of the application.
  /// </summary>
  public sealed class ApplicationModel : Model {

    #region Public Properties

    private string _apiKey;

    /// <summary>
    /// Gets/Sets the ArcGIS Online API Key.
    /// </summary>
    public string ApiKey {
      get {
        return _apiKey;
      }
      set {
        if (_apiKey != value) {
          _apiKey = value;
          OnPropertyChanged();
        }
      }
    }

    private ObservableCollection<DatabaseConnectionInfo> _databaseConnectionsInfo;

    /// <summary>
    /// Gets/Sets the <see cref="ObservableCollection{T}"/> of
    /// <see cref="Database.DatabaseConnectionInfo">DatabaseConnectionsInfo</see>.
    /// </summary>
    public ObservableCollection<DatabaseConnectionInfo> DatabaseConnectionsInfo {
      get {
        return _databaseConnectionsInfo;
      }
      set {
        if (_databaseConnectionsInfo != value) {
          _databaseConnectionsInfo = value;
        }
      }
    }

    private Service _service;

    /// <summary>
    /// Gets/Sets the <see cref="Services.MetadataSemanticSearch.Service"/>
    /// </summary>
    public Service Service {
      get {
        return _service;
      }
      set {
        if (_service != value) {
          _service = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
