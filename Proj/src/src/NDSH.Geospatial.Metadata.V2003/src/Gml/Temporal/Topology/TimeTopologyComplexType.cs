using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Temporal.Topology {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeTopologyComplexType")]
  public abstract class TimeTopologyComplexType : AbstractTimeComplexType {
    #region Private fields
    private List<TimeTopologyPrimitivePropertyType> _primitive;
    #endregion

    /// <summary>
    /// TimeTopologyComplexType class constructor
    /// </summary>
    public TimeTopologyComplexType() {
      _primitive = new List<TimeTopologyPrimitivePropertyType>();
    }

    [XmlElement("primitive", Order = 0)]
    [JsonProperty("primitive", Order = 0)]
    public List<TimeTopologyPrimitivePropertyType> Primitive {
      get {
        return _primitive;
      }
      set {
        if (_primitive == value) {
          return;
        }
        if (_primitive == null || _primitive.Equals(value) != true) {
          _primitive = value;
          OnPropertyChanged("Primitive");
        }
      }
    }
  }

}
