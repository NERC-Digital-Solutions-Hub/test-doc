
#region Imported Namespaces

using NDSH.Geospatial.Demos.SearchAndMap.Blazor.Models.Presentation;
using System.Windows.Input;

#endregion

namespace NDSH.Geospatial.Demos.SearchAndMap.Blazor.Commands {

  /// <summary>
  /// The <see cref="ICommand"/> to toggle on/off the application configuration card.
  /// </summary>
  public sealed class ToggleAppConfigurationCardCommand : ICommand {

    #region ICommand Interface

    /// <summary>
    /// The event that is raised when the conditions that determine whether the
    /// <see cref="ToggleAppConfigurationCardCommand"/> can be executed or not has been changed.
    /// </summary>
    public event EventHandler? CanExecuteChanged;

    /// <summary>
    /// Indicates whether the <see cref="ToggleAppConfigurationCardCommand"/> can be executed or not.
    /// </summary>
    /// <param name="parameter">The parameter used by the <see cref="ToggleAppConfigurationCardCommand"/>.</param>
    /// <returns>
    /// A <see cref="bool"/> indicating whether the <see cref="ToggleAppConfigurationCardCommand"/> can be executed or not.
    /// </returns>
    public bool CanExecute(object? parameter) {
      return true;
    }

    /// <summary>
    /// Executes the <see cref="ToggleAppConfigurationCardCommand"/>.
    /// </summary>
    /// <param name="parameter">The parameter used by the <see cref="ToggleAppConfigurationCardCommand"/>.</param>
    public void Execute(object? parameter) {

      if (parameter == null || parameter.GetType() != typeof(ShellModel)) {
        return;
      }

      ShellModel shellModel = (ShellModel)parameter;

      if (shellModel.AppConfigurationCardVisibility == Blazorise.Visibility.Visible) {
        shellModel.AppConfigurationCardVisibility = Blazorise.Visibility.Invisible;
      }
      else {
        shellModel.AppConfigurationCardVisibility = Blazorise.Visibility.Visible;
      }

    }

    #endregion

  }

}
