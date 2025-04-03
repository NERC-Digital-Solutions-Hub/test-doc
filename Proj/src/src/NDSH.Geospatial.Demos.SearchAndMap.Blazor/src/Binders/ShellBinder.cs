
#region Imported Namespace

using NDSH.Geospatial.Demos.SearchAndMap.Blazor.Commands;
using NDSH.Geospatial.Demos.SearchAndMap;
using NDSH.Geospatial.Demos.SearchAndMap.Blazor.Models;
using NDSH.Geospatial.Demos.SearchAndMap.Blazor.Models.Presentation;
using NDSH.Geospatial.Demos.SearchAndMap.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

#endregion

namespace NDSH.Geospatial.Demos.SearchAndMap.Blazor.Binders {

  /// <summary>
  /// The <see cref="IBinder"/> of the <see cref="Views.ShellView"/> and the <see cref="Models.Presentation.ShellModel"/>.
  /// </summary>
  public sealed class ShellBinder : IBinder {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ShellBinder"/>.
    /// </summary>
    /// <param name="shellModel"></param>
    public ShellBinder(ShellModel shellModel) {
      _shellModel = shellModel;
    }

    #endregion

    #region Public Properties

    private ShellModel _shellModel;

    /// <summary>
    /// 
    /// </summary>
    public ShellModel ShellModel {
      get {
        return _shellModel;
      }
    }

    private ICommand _toggleMetadataSearchCardCommand;

    /// <summary>
    /// 
    /// </summary>
    public ICommand ToggleMetadataSearchCardCommand {
      get {
        if (_toggleMetadataSearchCardCommand == null) {
          _toggleMetadataSearchCardCommand = new ToggleMetadataSearchCardCommand();
        }
        return _toggleMetadataSearchCardCommand;
      }
    }

    private ICommand _toggleAppConfigurationCardCommand;

    /// <summary>
    /// 
    /// </summary>
    public ICommand ToggleAppConfigurationCardCommand {
      get {
        if (_toggleAppConfigurationCardCommand == null) {
          _toggleAppConfigurationCardCommand = new ToggleAppConfigurationCardCommand();
        }
        return _toggleAppConfigurationCardCommand;
      }
    }

    #endregion

    #region IBinder Interface

    /// <summary>
    /// Gets the <see cref="ShellBinder"/> 's name.
    /// </summary>
    public string BinderName => nameof(ShellBinder);

    #endregion

  }

}
