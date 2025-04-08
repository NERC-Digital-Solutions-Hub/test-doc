
#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

#endregion

namespace NDSH.Geospatial.Demos.SearchAndMap.Commands {

  /// <summary>
  /// RelayCommand is a general purpose simple implementation of the <see cref="ICommand"/> interface.
  /// </summary>
  public class RelayCommand : ICommand {

    #region Member Variables

    private readonly Action<object> _execute;
    private readonly Predicate<object> _canExecute;

    #endregion

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="RelayCommand"/>.
    /// </summary>
    /// <param name="execute">
    /// The <see cref="Action{T}"/> to execute, where T is an <see cref="object"/>.
    /// </param>
    public RelayCommand(Action<object> execute) : this(execute, null) {

    }

    /// <summary>
    /// Initializes the <see cref="RelayCommand"/>.
    /// </summary>
    /// <param name="execute">
    /// The <see cref="Action{T}"/> to execute, where T is an <see cref="object"/>.
    /// </param>
    /// <param name="canExecute">
    /// The <see cref="Predicate{T}"/> which determines whether the <see cref="RelayCommand"/>
    /// can be executed or not, where T is an <see cref="onject."/>
    /// </param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when the <see cref="Action{T}"/> is null, where T is an <see cref="object"/>.
    /// </exception>
    public RelayCommand(Action<object> execute, Predicate<object> canExecute) {
      _execute = execute ?? throw new ArgumentNullException(nameof(execute));
      _canExecute = canExecute;
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// The method determines whether the <see cref="RelayCommand"/> can be executed or not.
    /// </summary>
    /// <param name="parameter">The <see cref="object">parameter</see> used by the method.</param>
    /// <returns>
    /// A <see cref="bool"/> indicating whether the <see cref="RelayCommand"/> can be executed or not.
    /// </returns>
    public bool CanExecute(object? parameter) {
      return _canExecute == null || _canExecute(parameter);
    }

    /// <summary>
    /// Executes the <see cref="RelayCommand"/>.
    /// </summary>
    /// <param name="parameter">The <see cref="object">parameter</see> used by the <see cref="RelayCommand"/>.</param>
    public void Execute(object? parameter) {
      _execute(parameter);
    }

    #endregion

    #region Event Procedures

    /// <summary>
    /// Occurs when the status whether the <see cref="RelayCommand">RelaySommand's</see> ability to be executed has been changed.
    /// </summary>
    public event EventHandler? CanExecuteChanged {
      add {
        CommandManager.RequerySuggested += value;
      }
      remove {
        CommandManager.RequerySuggested -= value;
      }
    }

    #endregion

  }

}
