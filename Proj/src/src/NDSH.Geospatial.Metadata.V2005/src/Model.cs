using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NDSH.Geospatial.Metadata.V2005 {

  /// <summary>
  /// 
  /// </summary>
  public abstract class Model : INotifyPropertyChanged {
    
    #region Public Events

    /// <summary>
    /// The event that is raised when a property value has been changed.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    #endregion

    #region Private Procedures

    /// <summary>
    /// Executed when a property value has been changed.
    /// The procedure is used to raise the <see cref="PropertyChanged"/> event.
    /// </summary>
    /// <param name="propertyName">
    /// The name of the property whose value has been changed.</param>
    public void OnPropertyChanged([CallerMemberName] string propertyName = "") {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
    
  }

}
