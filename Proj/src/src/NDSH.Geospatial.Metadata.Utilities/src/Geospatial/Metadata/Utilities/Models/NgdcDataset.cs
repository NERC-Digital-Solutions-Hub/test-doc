
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
  [Table("NgdcDatasets")]
  public class NgdcDataset {

    /// <summary>
    /// 
    /// </summary>
    public int Id {
      get; set;
    }

    /// <summary>
    /// 
    /// </summary>
    public string FileIdentifier {
      get; set;
    }

    /// <summary>
    /// 
    /// </summary>
    public string DatasetTitle {
      get; set;
    }

    /// <summary>
    /// 
    /// </summary>
    public string DatasetAuthors {
      get; set;
    }

    /// <summary>
    /// 
    /// </summary>
    public string DigitalObjectIdentifier {
      get; set;
    }

    /// <summary>
    /// 
    /// </summary>
    public string DiscoveryLink {
      get; set;
    }

    /// <summary>
    /// 
    /// </summary>
    public string DoiPageLink {
      get; set;
    }

  }

}
