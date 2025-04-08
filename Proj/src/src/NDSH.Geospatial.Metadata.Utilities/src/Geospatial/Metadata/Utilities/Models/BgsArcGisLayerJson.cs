
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
  [Table("BgsArcGisLayerJsons")]
  public class BgsArcGisLayerJson {

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
    public int? RecordId { // match with the metadata by fileId
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
    public int? BgsLayerId {
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
