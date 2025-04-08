
#region Imported Namespaces

using NDSH.Geospatial.Demos.SearchAndMap.Models.Presentation;
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
  /// The <see cref="ICommand"/> to toggle on/off the metadata search window.
  /// </summary>
  public sealed class ToggleMetadataSearchWindowCommand : ICommand {

    #region ICommand Interface

    /// <summary>
    /// The event that is raised when the conditions that determine whether the
    /// <see cref="ToggleMetadataSearchWindowCommand"/> can be executed or not has been changed.
    /// </summary>
    public event EventHandler? CanExecuteChanged;

    /// <summary>
    /// Indicates whether the <see cref="ToggleMetadataSearchWindowCommand"/> can be executed or not.
    /// </summary>
    /// <param name="parameter">The parameter used by the <see cref="ToggleMetadataSearchWindowCommand"/>.</param>
    /// <returns>
    /// A <see cref="bool"/> indicating whether the <see cref="ToggleMetadataSearchWindowCommand"/> can be executed or not.
    /// </returns>
    public bool CanExecute(object? parameter) {
      return true;
    }

    /// <summary>
    /// Executes the <see cref="ToggleMetadataSearchWindowCommand"/>.
    /// </summary>
    /// <param name="parameter">The parameter used by the <see cref="ToggleMetadataSearchWindowCommand"/>.</param>
    public void Execute(object? parameter) {

      if (parameter == null || parameter.GetType() != typeof(ShellModel)) {
        return;
      }

      ShellModel shellModel = (ShellModel)parameter;
      
      if (shellModel.MetadataSearchWindowVisibility == Visibility.Visible) {
        shellModel.MetadataSearchWindowVisibility = Visibility.Hidden;
      }
      else {
        shellModel.MetadataSearchWindowVisibility = Visibility.Visible;

        //// Get the storyboard from the XAML resources
        //Storyboard showRectangleStoryboard = (Storyboard)FindResource("ShowRectangleStoryboard");

        //// Start the storyboard to show the rectangle
        //showRectangleStoryboard.Begin(resultsRectangle);

      }

    }

    #endregion

  }

}
