
#region Imported Namespaces

using Esri.ArcGISRuntime.Mapping;
using Esri.ArcGISRuntime.UI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

#endregion

namespace NDSH.Geospatial.Demos.SearchAndMap.Models.Presentation {

  /// <summary>
  /// The <see cref="Model"/> used by the <see cref="Views.ShellView"/>.
  /// </summary>
  public sealed class ShellModel : Model {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ShellModel"/>.
    /// </summary>
    public ShellModel() {
      this.AppConfigurationWindowVisibility = Visibility.Hidden;
      this.MetadataSearchWindowVisibility = Visibility.Hidden;
      this.Title = "NDSH Search and Map Demo Application"; // TODO: Move to resources.

      this.PropertyChanged -= ShellModel_PropertyChanged;
      this.PropertyChanged += ShellModel_PropertyChanged;
    }
    
    #endregion

    #region Public Properties

    private string _title;

    /// <summary>
    /// Gets/Sets the title of the application.
    /// </summary>
    public string Title {
      get {
        return _title;
      }
      set {
        if (_title != value) {
          _title = value;
          OnPropertyChanged();
        }
      }
    }
    
    private Map _map;

    /// <summary>
    /// Gets/Sets the <see cref="Map"/> of the application.
    /// </summary>
    public Map Map {
      get {
        return _map;
      }
      set {
        if (_map != value) {
          _map = value;
          OnPropertyChanged();
        }
      }
    }

    private bool _isAppConfigurationWindowVisible;

    /// <summary>
    /// Gets/Sets whether the application configuration window is visible or not.
    /// </summary>
    public bool IsAppconfigurationWindowVisible {
      get {
        return _isAppConfigurationWindowVisible;
      }
      set {
        if (_isAppConfigurationWindowVisible != value) {
          _isAppConfigurationWindowVisible = value;
          OnPropertyChanged();
        }
      }
    }


    private Visibility _appConfigurationWindowVisibility;

    /// <summary>
    /// Gets/Sets the <see cref="Visibility"/> of the application configuration window.
    /// </summary>
    public Visibility AppConfigurationWindowVisibility {
      get {
        return _appConfigurationWindowVisibility;
      }
      set {
        if (_appConfigurationWindowVisibility != value) {
          _appConfigurationWindowVisibility = value;
          OnPropertyChanged();
        }
      }
    }

    /// <summary>
    /// Gets whether the toggle application configuration button is checked or not.
    /// </summary>
    public bool ToggleAppConfigurationWindowIsChecked {
      get {
        return _appConfigurationWindowVisibility == Visibility.Visible;
      }
    }

    private bool _isMetadataSearchWindowVisible;

    /// <summary>
    /// Gets/Sets whether the the metadata search window is visible or not.
    /// </summary>
    public bool IsMetadataSearchWindowVisible {
      get {
        return _isMetadataSearchWindowVisible;
      }
      set {
        if (_isMetadataSearchWindowVisible != value) {
          _isMetadataSearchWindowVisible = value;
          OnPropertyChanged();
        }
      }
    }

    private Visibility _metadataSearchWindowVisibility;

    /// <summary>
    /// Gets/Sets the <see cref="Visibility"/> of the metadata search window.
    /// </summary>
    public Visibility MetadataSearchWindowVisibility {
      get {
        return _metadataSearchWindowVisibility;
      }
      set {
        if (_metadataSearchWindowVisibility != value) {
          _metadataSearchWindowVisibility = value;
          OnPropertyChanged();
        }
      }
    }

    /// <summary>
    /// Gets the text of the toggle search metadata window button.
    /// </summary>
    public string ToggleMetadataSearchWindowButtonText {
      get {
        return _metadataSearchWindowVisibility == Visibility.Visible ? "Close Search" : "Open Search"; // TODO: Move these to resources.
      }
    }

    #endregion

    #region Event Procedures

    /// <summary>
    /// Occurs when a <see cref="ShellModel"/> property has been changed.
    /// </summary>
    /// <param name="sender">The sender of the event.</param>
    /// <param name="e">The <see cref="PropertyChangedEventArgs"/>.</param>
    private void ShellModel_PropertyChanged(object? sender, PropertyChangedEventArgs e) {
      if (sender != null) {
        if (e.PropertyName == nameof(this.MetadataSearchWindowVisibility)) {
          // Make sure the ToggleSearchMetadataWindowButtonText property is updated.
          this.OnPropertyChanged(nameof(this.ToggleMetadataSearchWindowButtonText));
        }
        else if (e.PropertyName == nameof(this.AppConfigurationWindowVisibility)) {
          // Make sure the ToggleAppConfigurationWindowIsChecked property is updated.
          this.OnPropertyChanged(nameof(this.ToggleAppConfigurationWindowIsChecked));
        }

        //if (e.PropertyName == nameof(this.IsMetadataSearchWindowVisible)) {
        //  // Make sure the ToggleSearchMetadataWindowButtonText property is updated.
        //  this.OnPropertyChanged(nameof(this.ToggleMetadataSearchWindowButtonText));
        //}
        //else if (e.PropertyName == nameof(this.IsAppconfigurationWindowVisible)) {
        //  // Make sure the ToggleAppConfigurationWindowIsChecked property is updated.
        //  this.OnPropertyChanged(nameof(this.ToggleAppConfigurationWindowIsChecked));
        //}

      }
    }

    #endregion

  }

}
