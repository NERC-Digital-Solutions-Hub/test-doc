using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic2D;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.GmlBase;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Primitives {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ShellType")]
  public class ShellType : Model {
    #region Private fields
    private List<SurfacePropertyType> _surfaceMember;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// ShellType class constructor
    /// </summary>
    public ShellType() {
      _surfaceMember = new List<SurfacePropertyType>();
    }

    [XmlElement("surfaceMember", Order = 0)]
    [JsonProperty("surfaceMember", Order = 0)]
    public List<SurfacePropertyType> surfaceMember {
      get {
        return _surfaceMember;
      }
      set {
        if (_surfaceMember == value) {
          return;
        }
        if (_surfaceMember == null || _surfaceMember.Equals(value) != true) {
          _surfaceMember = value;
          OnPropertyChanged("surfaceMember");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("aggregationType")]
    public AggregationType aggregationType {
      get {
        return _aggregationType;
      }
      set {
        if (_aggregationType.Equals(value) != true) {
          _aggregationType = value;
          OnPropertyChanged("aggregationType");
        }
      }
    }
  }

}
