
#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.Utilities.DatabaseContext {

  /// <summary>
  /// The database used by the application.
  /// </summary>
  public enum DatabaseOption {

    /// <summary>
    /// SQLite database.
    /// </summary>
    Sqlite,

    /// <summary>
    /// PostgreSQL development database.
    /// </summary>
    PgSqlDev,

    /// <summary>
    /// PostgreSQL staging database.
    /// </summary>
    PgSqlStaging,

  }

}
