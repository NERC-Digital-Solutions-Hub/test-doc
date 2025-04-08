
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
  /// 
  /// </summary>
  [Table("BgsArcGisMapServerJsons")]
  public class BgsArcGisMapServerJson {

    #region Public Properties

    /// <summary>
    /// 
    /// </summary>
    public int Id {
      get; set;
    }

    /// <summary>
    /// 
    /// </summary>
    public int? RecordId {
      get; set;
    }

    /// <summary>
    /// 
    /// </summary>
    public string? FileIdentifier {
      get; set;
    }

    /// <summary>
    /// 
    /// </summary>
    public string? Url {
      get; set;
    }

    /// <summary>
    /// 
    /// </summary>
    public string? Content {
      get; set;
    }

    #endregion

  }

}
