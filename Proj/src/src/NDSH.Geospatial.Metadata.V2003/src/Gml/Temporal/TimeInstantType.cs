using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Temporal {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeInstantType")]
  public class TimeInstantType : AbstractTimeGeometricPrimitiveType {
    #region Private fields
    private TimePositionType _timePosition;
    #endregion

    /// <summary>
    /// TimeInstantType class constructor
    /// </summary>
    public TimeInstantType() {
      _timePosition = new TimePositionType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("timePosition", Order = 0)]
    public TimePositionType TimePosition {
      get {
        return _timePosition;
      }
      set {
        if (_timePosition == value) {
          return;
        }
        if (_timePosition == null || _timePosition.Equals(value) != true) {
          _timePosition = value;
          OnPropertyChanged("TimePosition");
        }
      }
    }
  }

}
