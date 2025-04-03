
#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Demos.SearchAndMap {

  /// <summary>
  /// The interface which denotes a binder.
  /// </summary>
  public interface IBinder {

    #region Public Properties

    /// <summary>
    /// Gets the <see cref="IBinder"/> name.
    /// </summary>
    public string BinderName {
      get;
    }

    #endregion

  }

}
