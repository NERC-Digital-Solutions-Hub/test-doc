
#region Imported Namespaces

using NDSH.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Utilities.App.Models {

  /// <summary>
  /// The model of the application.
  /// </summary>
  public sealed class ApplicationModel {

    /// <summary>
    /// Gets/Sets the database connection strings.
    /// </summary>
    public ObservableCollection<DatabaseConnectionInfo> DatabaseConnectionsInfo {
      get; set;
    }

  }

}
