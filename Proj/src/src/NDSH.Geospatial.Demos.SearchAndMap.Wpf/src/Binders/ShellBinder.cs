
#region Imported Namespace

using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.Mapping;
using Esri.ArcGISRuntime.Portal;
using Esri.ArcGISRuntime.UI.Controls;
using NDSH.Geospatial.Demos.SearchAndMap.Commands;
using NDSH.Geospatial.Demos.SearchAndMap.Models;
using NDSH.Geospatial.Demos.SearchAndMap.Models.Presentation;
using NDSH.Geospatial.Demos.SearchAndMap.Views;
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

    private ShellView _shellView;

    /// <summary>
    /// 
    /// </summary>
    public ShellView ShellView {
      get {
        return _shellView;
      }
      set {
        if (_shellView == value) {
          return;
        }
        if (_shellView == null || _shellView.Equals(value) != true) {
          _shellView = value;
          _shellView.Loaded -= ShellView_Loaded;
          _shellView.Loaded += ShellView_Loaded;
        }
      }
    }

    private ICommand _minimizeWindowCommand;

    /// <summary>
    /// 
    /// </summary>
    public ICommand MinimizeWindowCommand {
      get {
        if (_minimizeWindowCommand == null) {
          _minimizeWindowCommand = new MinimizeWindowCommand();
        }
        return _minimizeWindowCommand;
      }
    }

    private ICommand _maximizeWindowCommand;

    /// <summary>
    /// 
    /// </summary>
    public ICommand MaximizeWindowCommand {
      get {
        if (_maximizeWindowCommand == null) {
          _maximizeWindowCommand = new MaximizeWindowCommand();
        }
        return _maximizeWindowCommand;
      }
    }

    private ICommand _closeWindowCommand;

    /// <summary>
    /// 
    /// </summary>
    public ICommand CloseWindowCommand {
      get {
        if (_closeWindowCommand == null) {
          _closeWindowCommand = new CloseWindowCommand();
        }
        return _closeWindowCommand;
      }
    }

    private ICommand _toggleMetadataSearchWindowCommand;

    /// <summary>
    /// 
    /// </summary>
    public ICommand ToggleMetadataSearchWindowCommand {
      get {
        if (_toggleMetadataSearchWindowCommand == null) {
          _toggleMetadataSearchWindowCommand = new ToggleMetadataSearchWindowCommand();
        }
        return _toggleMetadataSearchWindowCommand;
      }
    }

    private ICommand _toggleAppConfigurationWindowCommand;

    /// <summary>
    /// 
    /// </summary>
    public ICommand ToggleAppConfigurationWindowCommand {
      get {
        if (_toggleAppConfigurationWindowCommand == null) {
          _toggleAppConfigurationWindowCommand = new ToggleAppConfigurationWindowCommand();
        }
        return _toggleAppConfigurationWindowCommand;
      }
    }

    #endregion

    #region IBinder Interface

    /// <summary>
    /// Gets the <see cref="ShellBinder"/> 's name.
    /// </summary>
    public string BinderName => nameof(ShellBinder);

    #endregion

    #region ShellView Events

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ShellView_Loaded(object sender, System.Windows.RoutedEventArgs e) {
      this.InitializeMap();
    }

    #endregion

    #region Private Procedures

    /// <summary>
    /// 
    /// </summary>
    private async void InitializeMap() {

      // Create a new Map with a new Basemap and set the InitialViewPoint to the envelope of the UK.
      _shellModel.Map = new Map(SpatialReferences.WebMercator) {
        InitialViewpoint = new Viewpoint(Wgs84CountryEnvelope.Create("GBR").Envelope),
        Basemap = new Basemap(BasemapStyle.ArcGISLightGray)
      };

      //// ================================================================================
      //// Create a WMS Layer with all its sublayers visible and render it on the map in its OperationalLayers.

      //// Create a URI to the map image layer.
      //Uri serviceUri = new Uri("https://map.bgs.ac.uk/arcgis/rest/services/GeoIndex_Onshore/hazards/MapServer");

      //// Create a new image layer from the URI.
      //ArcGISMapImageLayer imageLayer = new ArcGISMapImageLayer(serviceUri) {
      //  Name = "GeoIndex_Onshore/hazards (MapServer)"
      //};

      //_shellModel.Map.OperationalLayers.Add(imageLayer);

      //try {
      //  // Wait that the image layer is loaded and sublayer information is fetched
      //  await imageLayer.LoadAsync();

      //  IList<ArcGISSublayer> subLayers = imageLayer.Sublayers;

      //  foreach (var subLayer in subLayers) {
      //    subLayer.IsVisible = true;
      //  }

      //  // Assign sublayers to the listview
      //  //SublayerListView.ItemsSource = imageLayer.Sublayers;
      //}
      //catch (Exception e) {
      //  MessageBox.Show(e.ToString(), "Error");
      //}



      // ================================================================================

      //// Create a new map image layer using the MapServer URL and Spatial Reference id
      //Uri serviceUri = new Uri("https://map.bgs.ac.uk/arcgis/rest/services/GeoIndex_Onshore/hazards/MapServer");
      //ArcGISMapImageLayer mapImageLayer = new ArcGISMapImageLayer(serviceUri);

      //_shellModel.Map.OperationalLayers.Add(mapImageLayer);

      // ================================================================================

      //// Create an instance of the ArcGIS Portal
      //ArcGISPortal portal = await ArcGISPortal.CreateAsync(new Uri("https://www.arcgis.com"));

      //// Get the portal item ID for the basemap
      ////string itemId = "6586f86b608846cc9ee98f93eba305fc";
      ////string itemId = "fabea1acb39649ad83d523ee59ae5d19";
      //string itemId = "12f14ce55d234c698e42d66dec75a30d";

      //// Create a new portal item using the item ID
      //PortalItem portalItem = await PortalItem.CreateAsync(portal, itemId);

      //// Create a new basemap using the portal item
      //Basemap basemap = new Basemap(portalItem);

      //// Set the basemap on the MapView
      //_shellModel.Map = new Map(basemap);

      // ================================================================================

      //using Esri.ArcGISRuntime.Geometry;
      //using Esri.ArcGISRuntime.Mapping;
      //using Esri.ArcGISRuntime.Security;
      //using Esri.ArcGISRuntime.Tasks.Geocoding;
      //using Esri.ArcGISRuntime.UI.Controls;

      //// Create a new map with a WGS84 basemap
      //_shellModel.Map = new Map(BasemapStyle.OSMLightGray);

      //// Create a new map service layer representing the layer in its original coordinate system
      //ArcGISMapImageLayer originalLayer = new ArcGISMapImageLayer(new Uri("https://map.bgs.ac.uk/arcgis/rest/services/GeoIndex_Onshore/hazards/MapServer"));

      //// Define the input and output spatial references
      //SpatialReference inputSR = SpatialReference.Create(27700); // British National Grid
      //SpatialReference outputSR = SpatialReference.Create(4326); // WGS84

      //// Define the transformation to use for reprojection (optional)
      //Esri.ArcGISRuntime.Geometry.TransformationCatalog.

      //Transformation transformation = Transformation.Create(1277); // BritishNationalGrid_To_WGS_1984_Petroleum

      //// Create a new ArcGISMapImageLayer representing the reprojected layer
      //ArcGISMapImageLayer reprojectedLayer = new ArcGISMapImageLayer(new Uri("https://myserver.com/arcgis/rest/services/MyService/MapServer"));
      //reprojectedLayer.Id = "Reprojected Layer"; // Set an ID for the layer

      //// Create a new ArcGISMapImageLayer representing the basemap layer
      //ArcGISMapImageLayer basemapLayer = new ArcGISMapImageLayer(new Uri("https://services.arcgisonline.com/arcgis/rest/services/World_Imagery/MapServer"));

      //// Set the spatial reference of the map to match the WGS84 basemap
      //myMap.SpatialReference = SpatialReference.Create(4326);

      //// Project the original layer to WGS84 and add it to the reprojected layer
      //reprojectedLayer.ImageFormat = ArcGISImageFormat.Png32;
      //reprojectedLayer.Sublayers.Add(new ArcGISMapImageSublayer(originalLayer, inputSR, outputSR, transformation));

      //// Add the reprojected and basemap layers to the map
      //myMap.OperationalLayers.Add(reprojectedLayer);
      //myMap.OperationalLayers.Add(basemapLayer);

      //// Set the initial viewpoint of the map
      //myMap.InitialViewpoint = new Viewpoint(new MapPoint(-2.55, 51.47, outputSR), 100000);

      //// Create a new MapView and set its map
      //MapView myMapView = new MapView();
      //myMapView.Map = myMap;

      //// Add the MapView to a UI element (e.g. a window or page)
      //MyWindow.Content = myMapView;

      // ================================================================================









      //_shellModel.MapView.Map = new Map(SpatialReferences.WebMercator) {
      //  InitialViewpoint = new Viewpoint(new Envelope(25.2223186, 25.2241651, 55.1579517, 55.1606916, SpatialReferences.Wgs84)),
      //  Basemap = new Basemap(BasemapStyle.ArcGISStreets)
      //};

      //_shellModel.MapView.Map = new Map(SpatialReferences.WebMercator) {
      //  InitialViewpoint = new Viewpoint(Wgs84CountryEnvelope.Create("GBR").Envelope),
      //  Basemap = new Basemap(BasemapStyle.ArcGISStreets)
      //};

      //// Create uri to the map image layer
      //Uri serviceUri = new Uri("https://map.bgs.ac.uk/arcgis/rest/services/GeoIndex_Onshore/minerals_wms/MapServer/");

      //// Create new image layer from the url
      //ArcGISMapImageLayer imageLayer = new ArcGISMapImageLayer(serviceUri);

      //imageLayer.Opacity = 0.1;

      //// Add created layer to the basemaps collection
      //_map.Basemap.BaseLayers.Add(imageLayer);

      ////_map.Basemap.Add(new Basemap(BasemapStyle.ArcGISStreets));



      //_map = new Map(SpatialReference.Create(27700));

      //// Create uri to the map image layer
      //Uri serviceUri = new Uri("https://map.bgs.ac.uk/arcgis/rest/services/GeoIndex_Onshore/minerals_wms/MapServer/");

      //// Create new image layer from the url
      //ArcGISMapImageLayer imageLayer = new ArcGISMapImageLayer(serviceUri);

      //// Add created layer to the basemaps collection
      //_map.Basemap.BaseLayers.Add(imageLayer);

      //// Assign the map to the MapView

      ////MyMapView.Map = myMap;

    }

    #endregion

  }

}
