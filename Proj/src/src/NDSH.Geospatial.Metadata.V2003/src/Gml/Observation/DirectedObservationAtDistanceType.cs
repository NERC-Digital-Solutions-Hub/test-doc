using NDSH.Geospatial.Metadata.V2003.Gml.Measures;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Observation {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DirectedObservationAtDistanceType")]
  public class DirectedObservationAtDistanceType : DirectedObservationType {
    #region Private fields
    private MeasureType _distance;
    #endregion

    /// <summary>
    /// DirectedObservationAtDistanceType class constructor
    /// </summary>
    public DirectedObservationAtDistanceType() {
      _distance = new MeasureType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("distance", Order = 0)]
    public MeasureType Distance {
      get {
        return _distance;
      }
      set {
        if (_distance == value) {
          return;
        }
        if (_distance == null || _distance.Equals(value) != true) {
          _distance = value;
          OnPropertyChanged("distance");
        }
      }
    }
  }
}
