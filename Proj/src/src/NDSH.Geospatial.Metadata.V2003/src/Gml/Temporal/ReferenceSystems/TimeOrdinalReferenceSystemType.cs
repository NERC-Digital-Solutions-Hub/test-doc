using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Temporal.ReferenceSystems {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeOrdinalReferenceSystemType")]
  public class TimeOrdinalReferenceSystemType : TimeReferenceSystemType {
    #region Private fields
    private List<TimeOrdinalEraPropertyType> _component;
    #endregion

    /// <summary>
    /// TimeOrdinalReferenceSystemType class constructor
    /// </summary>
    public TimeOrdinalReferenceSystemType() {
      _component = new List<TimeOrdinalEraPropertyType>();
    }

    [XmlElement("component", Order = 0)]
    [JsonProperty("component", Order = 0)]
    public List<TimeOrdinalEraPropertyType> Component {
      get {
        return _component;
      }
      set {
        if (_component == value) {
          return;
        }
        if (_component == null || _component.Equals(value) != true) {
          _component = value;
          OnPropertyChanged("Component");
        }
      }
    }
  }
}
