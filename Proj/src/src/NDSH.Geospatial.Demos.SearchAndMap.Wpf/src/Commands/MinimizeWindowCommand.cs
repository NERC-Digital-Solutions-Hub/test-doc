
#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using NDSH.Geospatial.Demos.SearchAndMap.Views;

#endregion

namespace NDSH.Geospatial.Demos.SearchAndMap.Commands {

  /// <summary>
  /// The <see cref="ICommand"/> to minimize the window.
  /// </summary>
  public sealed class MinimizeWindowCommand : ICommand {

    #region ICommand Interface

    /// <summary>
    /// The event that is raised when the conditions that determine whether the
    /// <see cref="MinimizeWindowCommand"/> can be executed or not has been changed.
    /// </summary>
    public event EventHandler? CanExecuteChanged;

    /// <summary>
    /// Indicates whether the <see cref="MinimizeWindowCommand"/> can be executed or not.
    /// </summary>
    /// <param name="parameter">The parameter used by the <see cref="MinimizeWindowCommand"/>.</param>
    /// <returns>
    /// A <see cref="bool"/> indicating whether the <see cref="MinimizeWindowCommand"/> can be executed or not.
    /// </returns>
    public bool CanExecute(object? parameter) {
      return true;
    }

    /// <summary>
    /// Executes the <see cref="MinimizeWindowCommand"/>.
    /// </summary>
    /// <param name="parameter">The parameter used by the <see cref="MinimizeWindowCommand"/>.</param>
    public void Execute(object? parameter) {
      if (parameter == null) {
        return;
      }

      try {
        ((Window)parameter).WindowState = WindowState.Minimized;
      }
      catch {
        // Swallow the error.
      }
    }

    #endregion

  }

}
