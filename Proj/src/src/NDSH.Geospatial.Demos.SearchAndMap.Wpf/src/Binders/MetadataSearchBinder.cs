
#region Imported Namespaces

using NDSH.Geospatial.Demos.SearchAndMap.Commands;
using NDSH.Geospatial.Demos.SearchAndMap.Models.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

#endregion

namespace NDSH.Geospatial.Demos.SearchAndMap.Binders {

  /// <summary>
  /// The <see cref="IBinder"/> of the <see cref="Views.MetadataSearchView"/> and
  /// the <see cref="Models.Presentation.MetadataSearchModel"/>.
  /// </summary>
  public sealed class MetadataSearchBinder : IBinder {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MetadataSearchBinder"/>.
    /// </summary>
    /// <param name="metadataSearchModel"></param>
    public MetadataSearchBinder(MetadataSearchModel metadataSearchModel) {
      _metadataSearchModel = metadataSearchModel;
    }

    #endregion

    #region Public Properties

    private MetadataSearchModel _metadataSearchModel;

    /// <summary>
    /// Gets the <see cref="Models.Presentation.MetadataSearchModel"/>.
    /// </summary>
    public MetadataSearchModel MetadataSearchModel {
      get {
        return _metadataSearchModel;
      }
    }

    private ICommand _submitQueryCommand;

    /// <summary>
    /// Gets the <see cref="SubmitQueryCommand">command</see> to post a query to the metadata search service.
    /// </summary>
    public ICommand SubmitQueryCommand {
      get {
        if (_submitQueryCommand == null) {
          _submitQueryCommand = new SubmitQueryCommand();
        }
        return _submitQueryCommand;
      }
    }

    private ICommand _addLayersCommand;

    /// <summary>
    /// Gets the <see cref="Commands.AddLayersCommand">command</see> to add layers to the map.
    /// </summary>
    public ICommand AddLayersCommand {
      get {
        if (_addLayersCommand == null) {
          _addLayersCommand = new AddLayersCommand();
        }
        return _addLayersCommand;
      }
    }
    
    #endregion

    #region IBinder Interface

    /// <summary>
    /// Gets the <see cref="MetadataSearchBinder"/> 's name.
    /// </summary>
    public string BinderName => nameof(MetadataSearchBinder);

    #endregion
    
  }

}
