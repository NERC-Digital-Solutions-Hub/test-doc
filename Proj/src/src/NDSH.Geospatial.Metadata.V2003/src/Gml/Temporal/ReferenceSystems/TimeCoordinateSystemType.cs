using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Temporal.ReferenceSystems {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeCoordinateSystemType")]
  public class TimeCoordinateSystemType : TimeReferenceSystemType {
    #region Private fields
    private object _item;
    private TimeIntervalLengthType _interval;
    #endregion

    /// <summary>
    /// TimeCoordinateSystemType class constructor
    /// </summary>
    public TimeCoordinateSystemType() {
      _interval = new TimeIntervalLengthType();
    }

    [XmlElement("origin", typeof(TimeInstantPropertyType), Order = 0)]
    [XmlElement("originPosition", typeof(TimePositionType), Order = 0)]
    public object Item {
      get {
        return _item;
      }
      set {
        if (_item == value) {
          return;
        }
        if (_item == null || _item.Equals(value) != true) {
          _item = value;
          OnPropertyChanged("Item");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("interval", Order = 1)]
    public TimeIntervalLengthType Interval {
      get {
        return _interval;
      }
      set {
        if (_interval == value) {
          return;
        }
        if (_interval == null || _interval.Equals(value) != true) {
          _interval = value;
          OnPropertyChanged("Interval");
        }
      }
    }
  }
}
