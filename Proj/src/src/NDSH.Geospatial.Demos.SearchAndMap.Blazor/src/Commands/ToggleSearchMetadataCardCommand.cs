
#region Imported Namespaces

using Blazorise;
using NDSH.Geospatial.Demos.SearchAndMap.Blazor.Models.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

#endregion

namespace NDSH.Geospatial.Demos.SearchAndMap.Blazor.Commands {
  

  /// <summary>
  /// The <see cref="ICommand"/> to toggle on/off the metadata search card.
  /// </summary>
  public sealed class ToggleMetadataSearchCardCommand : ICommand {

    #region ICommand Interface

    /// <summary>
    /// The event that is raised when the conditions that determine whether the
    /// <see cref="ToggleMetadataSearchCardCommand"/> can be executed or not has been changed.
    /// </summary>
    public event EventHandler? CanExecuteChanged;

    /// <summary>
    /// Indicates whether the <see cref="ToggleMetadataSearchCardCommand"/> can be executed or not.
    /// </summary>
    /// <param name="parameter">The parameter used by the <see cref="ToggleMetadataSearchCardCommand"/>.</param>
    /// <returns>
    /// A <see cref="bool"/> indicating whether the <see cref="ToggleMetadataSearchCardCommand"/> can be executed or not.
    /// </returns>
    public bool CanExecute(object? parameter) {
      return true;
    }

    /// <summary>
    /// Executes the <see cref="ToggleMetadataSearchCardCommand"/>.
    /// </summary>
    /// <param name="parameter">The parameter used by the <see cref="ToggleMetadataSearchCardCommand"/>.</param>
    public void Execute(object? parameter) {

      if (parameter == null || parameter.GetType() != typeof(ShellModel)) {
        return;
      }

      ShellModel shellModel = (ShellModel)parameter;
      
      if (shellModel.MetadataSearchCardVisibility == Blazorise.Visibility.Visible) {
        shellModel.MetadataSearchCardVisibility = Blazorise.Visibility.Invisible;
      } else {
        shellModel.MetadataSearchCardVisibility = Blazorise.Visibility.Visible;
      }

    }

    #endregion

  }

}
