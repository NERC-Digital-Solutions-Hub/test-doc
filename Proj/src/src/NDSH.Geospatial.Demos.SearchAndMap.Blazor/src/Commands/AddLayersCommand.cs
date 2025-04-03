
#region Imported Namespaces

using dymaptic.GeoBlazor.Core.Components;
using dymaptic.GeoBlazor.Core.Components.Layers;
using dymaptic.GeoBlazor.Core.Components.Views;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using NDSH.Geospatial.Demos.SearchAndMap.Blazor.Binders;
using NDSH.Geospatial.Demos.SearchAndMap.Blazor.Models.Presentation;
using NDSH.Geospatial.Metadata.Utilities.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

#endregion

namespace NDSH.Geospatial.Demos.SearchAndMap.Blazor.Commands {

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
    private async Task AddLayers(MetadataSearchModel metadataSearchModel) {

      ShellBinder shellBinder = (ShellBinder)AppEngine.Instance.Catalogue.Binders[nameof(ShellBinder)];
      ShellModel shellModel = shellBinder.ShellModel;

      //todo: directly get the sub layer from the database. do not rely on the arcGIS api.
#if true
      if (metadataSearchModel != null) {
        if (metadataSearchModel.BgsLayers != null) {
          IEnumerable<ResultRecord> selectedResultRecords = metadataSearchModel.ResultRecords.Where(rr => rr != null && rr.IsSelected == true);

          List<string> relatedArcGisMapServerUrls = new();

          foreach (ResultRecord rr in selectedResultRecords) {
            IEnumerable<string?> result = metadataSearchModel.BgsLayers
              .Where(lyr =>
                      lyr != null
                   && lyr.RelatedDataSetUuId == rr.Identifier
                   && lyr.ArcGisMapServerUrl != null)
              .Select(l => l.ArcGisMapServerUrl);

            if (result == null || !result.Any()) {
              continue;
            }

            relatedArcGisMapServerUrls.AddRange(result!);
          }

          List<string> relatedSubLayers = new();

          foreach (var mapServerUrl in relatedArcGisMapServerUrls) {
            var sublayers = metadataSearchModel.BgsLayers.Where(lyr => lyr.ArcGisMapServerUrl == mapServerUrl).Select(lyr => lyr.ArcGisLayerUrl);
            if (sublayers == null || !sublayers.Any()) {
              continue;
            }
            relatedSubLayers.AddRange(sublayers);
          }

          
          await clearAllLayers(shellModel);

          var featureLayers = relatedSubLayers.Select(url => new FeatureLayer(url: url, opacity: 0.6, visible: true)).ToList();
          featureLayers.ForEach(layer => shellModel.MapView!.AddLayer(layer));

        }
      }
#endif

    }
    /// <summary>
    /// clear all the layers in the <see cref="ShellBinder.ShellModel.MapView"/>
    /// </summary>
    /// <param name="shellModel"></param>
    /// <returns></returns>
    private async Task clearAllLayers(ShellModel shellModel) {

      var mapView = shellModel.MapView;

      foreach (var lyr in mapView!.Map!.Layers) {
        await mapView!.RemoveLayer(lyr);
      }
      
    }

    #endregion

  }

}
