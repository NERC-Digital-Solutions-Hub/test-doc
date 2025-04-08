using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDSH.Geospatial.Metadata.V2003.Thin {

  /// <summary>
  /// 
  /// </summary>
  [Table("MetadataTests")]
  public class MetadataTest : Model {

    private int _id;

    /// <summary>
    /// 
    /// </summary>
    public int Id {
      get {
        return _id;
      }
      set {
        if (_id != value) {
          _id = value;
          this.OnPropertyChanged();
        }
      }
    }

    private string _fileIdentifier;

    /// <summary>
    /// 
    /// </summary>
    public string FileIdentifier {
      get {
        return _fileIdentifier;
      }
      set {
        if (_fileIdentifier != value) {
          _fileIdentifier = value;
          this.OnPropertyChanged();
        }
      }
    }

  }

}
