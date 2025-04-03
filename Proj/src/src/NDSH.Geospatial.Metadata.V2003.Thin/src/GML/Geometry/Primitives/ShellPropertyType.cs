using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Primitives {


  /// <summary>
  /// A property with the content model of gml:ShellPropertyType encapsulates a shell to represent a component of a solid boundary.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ShellPropertyType")]
  public class ShellPropertyType : Model {
    #region Private fields
    private ShellType _shell;
    #endregion

    /// <summary>
    /// ShellPropertyType class constructor
    /// </summary>
    public ShellPropertyType() {
      _shell = new ShellType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("Shell", Order = 0)]
    public ShellType Shell {
      get {
        return _shell;
      }
      set {
        if (_shell == value) {
          return;
        }
        if (_shell == null || _shell.Equals(value) != true) {
          _shell = value;
          OnPropertyChanged("Shell");
        }
      }
    }
  }

}
