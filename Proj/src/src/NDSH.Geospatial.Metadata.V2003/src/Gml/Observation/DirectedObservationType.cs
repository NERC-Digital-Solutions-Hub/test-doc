using NDSH.Geospatial.Metadata.V2003.Gml.Direction;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Observation {


  [XmlInclude(typeof(DirectedObservationAtDistanceType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DirectedObservationType")]
  public class DirectedObservationType : ObservationType {
    #region Private fields
    private DirectionPropertyType _direction;
    #endregion

    /// <summary>
    /// DirectedObservationType class constructor
    /// </summary>
    public DirectedObservationType() {
      _direction = new DirectionPropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("direction", Order = 0)]
    public DirectionPropertyType Direction {
      get {
        return _direction;
      }
      set {
        if (_direction == value) {
          return;
        }
        if (_direction == null || _direction.Equals(value) != true) {
          _direction = value;
          OnPropertyChanged("Direction");
        }
      }
    }
  }
}
