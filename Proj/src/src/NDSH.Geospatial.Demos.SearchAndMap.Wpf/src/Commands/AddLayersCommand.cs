
#region Imported Namespaces

using Esri.ArcGISRuntime.Mapping;
using NDSH.Geospatial.Demos.SearchAndMap.Binders;
using NDSH.Geospatial.Demos.SearchAndMap.Models.Presentation;
using NDSH.Geospatial.Metadata.Utilities.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

#endregion

namespace NDSH.Geospatial.Demos.SearchAndMap.Commands {

  /// <summary>
  /// The <see cref="ICommand"/> to add layers on the map.
  /// </summary>
  public sealed class AddLayersCommand : ICommand {

    #region ICommand Interface

    /// <summary>
    /// The event that is raised when the conditions that determine if the
    /// <see cref="AddLayersCommand"/> can be executed has been changed.
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
    /// Executes the <see cref="AddLayersCommand"/>.
    /// </summary>
    /// <param name="parameter">The parameter used by the <see cref="AddLayersCommand"/>.</param>
    public void Execute(object? parameter) {

      if (parameter == null) {
        throw new ArgumentNullException(string.Format("The {0} parameter in null", nameof(AddLayersCommand)));
      }
      
      try {
        MetadataSearchModel metadataSearchModel = (MetadataSearchModel)parameter;
        AddLayers(metadataSearchModel);
      }
      catch {
        // Swallow the error.
      }

    }

    #endregion

    #region Private Procedures

    /// <summary>
    /// Adds the selected layers on the map.
    /// </summary>
    // TODO: Check what is the problem with async here. Maybe the use of lambdas?
    private async void AddLayers(MetadataSearchModel metadataSearchModel) {

      ShellBinder shellBinder = (ShellBinder)AppEngine.Instance.Catalogue.Binders[nameof(ShellBinder)];
      ShellModel shellModel = shellBinder.ShellModel;

      if (metadataSearchModel != null) {
        if (metadataSearchModel.BgsLayers != null) {

          metadataSearchModel.ResultRecords.Where(rr => rr.IsSelected).ToList().ForEach(rr => {
            metadataSearchModel.BgsLayers.Where(lyr => lyr.RelatedDataSetUuId == rr.Identifier).ToList().ForEach(async lyr => {
              if (lyr.ArcGisMapServerUrl != null) {
                Uri serviceUri = new Uri(lyr.ArcGisMapServerUrl);
                
                // Create a new image layer from the URI.
                ArcGISMapImageLayer imageLayer = new ArcGISMapImageLayer(serviceUri) {
                  Name = lyr.FileIdentifier // TODO !!! - Make one more query here to get the name of the dataset.
                };

                shellModel.Map.OperationalLayers.Add(imageLayer);

                // Unfortunately due to poor service documentation the exact layer matching the dataset in
                // the map composition could not be retrieved with accuracy and reliability.
                // Therefore all layers of the map composition will be added and be made visible.

                try {
                  // Wait that the image layer is loaded and sublayer information is fetched
                  await imageLayer.LoadAsync(); // TODO: Make sure that the async can be awaited - Change the code!!!
                  
                  IList<ArcGISSublayer> subLayers = imageLayer.Sublayers;

                  foreach (var subLayer in subLayers) {
                    subLayer.IsVisible = true;
                    subLayer.IsPopupEnabled = true;
                  }

                  imageLayer.Opacity = 0.6;

                  // Assign sublayers to the listview
                  //SublayerListView.ItemsSource = imageLayer.Sublayers;
                }
                catch (Exception ex) {
                  MessageBox.Show(ex.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

              }
            });
          });

        }
      }

    }

    #endregion

  }

}
