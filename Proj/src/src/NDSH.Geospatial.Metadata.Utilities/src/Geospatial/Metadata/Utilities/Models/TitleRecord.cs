
#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.Utilities.Models {

  /// <summary>
  /// Represents a Title Record.
  /// </summary>
  [Table("TitleRecords")]
  public class TitleRecord {

    #region Public Properties

    /// <summary>
    /// Gets/Sets the title records id. 
    /// </summary>
    public int Id {
      get; set;
    }

    /// <summary>
    /// Gets/Sets the title.
    /// </summary>
    public string Title {
      get; set;
    }

    /// <summary>
    /// Gets/Sets the position of the title if all titles have been concatenated.
    /// </summary>
    public int Position {
      get; set;
    }

    /// <summary>
    /// Gets/Sets the length of the title.
    /// </summary>
    public int Length {
      get; set;
    }

    #endregion

  }

}
