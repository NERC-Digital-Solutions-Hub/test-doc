
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
  public class UniqueFileTypeSource {

    /// <summary>
    /// 
    /// </summary>
    public string FileType {
      get; set;
    }

    /// <summary>
    /// 
    /// </summary>
    public string FileTypesCount {
      get; set;
    }

    /// <summary>
    /// 
    /// </summary>
    public string NewFileType {
      get; set;
    }

  }

}
