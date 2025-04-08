using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic2D {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("PolygonType")]
  public class PolygonType : AbstractSurfaceType {
    #region Private fields
    private AbstractRingPropertyType _exterior;
    private List<AbstractRingPropertyType> _interior;
    #endregion

    /// <summary>
    /// PolygonType class constructor
    /// </summary>
    public PolygonType() {
      _interior = new List<AbstractRingPropertyType>();
      _exterior = new AbstractRingPropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("exterior", Order = 0)]
    public AbstractRingPropertyType Exterior {
      get {
        return _exterior;
      }
      set {
        if (_exterior == value) {
          return;
        }
        if (_exterior == null || _exterior.Equals(value) != true) {
          _exterior = value;
          OnPropertyChanged("Exterior");
        }
      }
    }

    [XmlElement("interior", Order = 1)]
    [JsonProperty("interior", Order = 1)]
    public List<AbstractRingPropertyType> Interior {
      get {
        return _interior;
      }
      set {
        if (_interior == value) {
          return;
        }
        if (_interior == null || _interior.Equals(value) != true) {
          _interior = value;
          OnPropertyChanged("Interior");
        }
      }
    }
  }
}
