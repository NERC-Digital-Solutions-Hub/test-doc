
#region Imported Namespaces

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
  /// The <see cref="ICommand"/> to close the window.
  /// </summary>
  public sealed class CloseWindowCommand : ICommand {

    #region ICommand Interface

    /// <summary>
    /// The event that is raised when the conditions that determine whether the
    /// <see cref="CloseWindowCommand"/> can be executed or not has been changed.
    /// </summary>
    public event EventHandler? CanExecuteChanged;

    /// <summary>
    /// Indicates whether the <see cref="CloseWindowCommand"/> can be executed or not.
    /// </summary>
    /// <param name="parameter">The parameter used by the <see cref="CloseWindowCommand"/>.</param>
    /// <returns>
    /// A <see cref="bool"/> indicating whether the <see cref="CloseWindowCommand"/> can be executed or not.
    /// </returns>
    public bool CanExecute(object? parameter) {
      return true;
    }

    /// <summary>
    /// Executes the <see cref="CloseWindowCommand"/>.
    /// </summary>
    /// <param name="parameter">The parameter used by the <see cref="CloseWindowCommand"/>.</param>
    public void Execute(object? parameter) {
      
      if (parameter == null) {
        return;
      }

      try {
        Window window = (Window)parameter;
        if (window != null) {
          window.Close();
        }
      }
      catch {
        // Swallow the error.
      }
      
    }

    #endregion
    
  }

}
