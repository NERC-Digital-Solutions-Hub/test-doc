
#region Imported Namespaces

//using Esri.ArcGISRuntime.Mapping;
//using Esri.ArcGISRuntime.UI.Controls;
using NDSH.Geospatial.Demos.SearchAndMap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

#endregion

namespace NDSH.Geospatial.Demos.SearchAndMap.Blazor.Models.Presentation {
  
    using Visibility = Blazorise.Visibility;
    using Map = dymaptic.GeoBlazor.Core.Components.Map;
    using MapView = dymaptic.GeoBlazor.Core.Components.Views.MapView;

  /// <summary>
  /// The <see cref="Model"/> used by the <see cref="Views.ShellView"/>.
  /// </summary>
  public sealed class ShellModel : Model {
    //using Visibility = Blazorise.Visability;
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ShellModel"/>.
    /// </summary>
    public ShellModel() {
      //this.AppConfigurationCardVisibility = Visibility.Hidden;
      //this.MetadataSearchCardVisibility = Visibility.Hidden;
      this.Title = "NDSH Search and Map Demo Application"; // TODO: Move to resources.
      this.AppConfigurationCardVisibility = Visibility.Invisible;
      this.MetadataSearchCardVisibility = Visibility.Invisible;
      
      //this.PropertyChanged -= ShellModel_PropertyChanged;
      //this.PropertyChanged += ShellModel_PropertyChanged;
      
    }

    #endregion

    #region Public Properties

    private MapView _mapView;

    public MapView MapView {
      get {
        return _mapView;
      }
      set {
        if (_mapView != value) {
          _mapView = value;
          OnPropertyChanged();
        }
      }
    }


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

    //private Map _map;

    ///// <summary>
    ///// Gets/Sets the <see cref="Map"/> of the application.
    ///// </summary>
    //public Map Map {
    //  get {
    //    return _map;
    //  }
    //  set {
    //    if (_map != value) {
    //      _map = value;
    //      OnPropertyChanged();
    //    }
    //  }
    //}

    private Visibility _appConfigurationCardVisibility;

    /// <summary>
    /// Gets/Sets the <see cref="Visibility"/> of the metadata search card.
    /// </summary>
    public Visibility AppConfigurationCardVisibility {
      get {
        return _appConfigurationCardVisibility;
      }
      set {
        if (_appConfigurationCardVisibility != value) {
          _appConfigurationCardVisibility = value;
          OnPropertyChanged();
        }
      }
    }

    /// <summary>
    /// Gets whether the toggle application configuration button is checked or not.
    /// </summary>
    public bool ToggleAppConfigurationCardIsChecked {
      get {
        return _appConfigurationCardVisibility == Visibility.Visible;
      }
    }

    private Visibility _metadataSearchCardVisibility;

    /// <summary>
    /// Gets/Sets the <see cref="Visibility"/> of the metadata search card.
    /// </summary>
    public Visibility MetadataSearchCardVisibility {
      get {
        return _metadataSearchCardVisibility;
      }
      set {
        if (_metadataSearchCardVisibility != value) {
          _metadataSearchCardVisibility = value;
          OnPropertyChanged();
        }
      }
    }

    /// <summary>
    /// Gets the text of the toggle search metadata card button.
    /// </summary>
    public string ToggleMetadataSearchCardButtonText {
      get {
        return _metadataSearchCardVisibility == Visibility.Visible ? "Close Search" : "Open Search"; // TODO: Move these to resources.
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
        if (e.PropertyName == nameof(this.MetadataSearchCardVisibility)) {
          // Make sure the ToggleSearchMetadataCardButtonText property is updated.
          this.OnPropertyChanged(nameof(this.ToggleMetadataSearchCardButtonText));
        }
        else if (e.PropertyName == nameof(this.AppConfigurationCardVisibility)) {
          // Make sure the ToggleAppConfigurationCardIsChecked property is updated.
          this.OnPropertyChanged(nameof(this.ToggleAppConfigurationCardIsChecked));
        }
      }
    }

    #endregion

  }

}
