using NDSH.Geospatial.Metadata.V2003.Gml.GmlBase;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Temporal.ReferenceSystems {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeClockType")]
  public class TimeClockType : TimeReferenceSystemType {
    #region Private fields
    private StringOrRefType _referenceEvent;
    private DateTime _referenceTime;
    private DateTime _utcReference;
    private List<TimeCalendarPropertyType> _dateBasis;
    #endregion

    /// <summary>
    /// TimeClockType class constructor
    /// </summary>
    public TimeClockType() {
      _dateBasis = new List<TimeCalendarPropertyType>();
      _referenceEvent = new StringOrRefType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("referenceEvent", Order = 0)]
    public StringOrRefType ReferenceEvent {
      get {
        return _referenceEvent;
      }
      set {
        if (_referenceEvent == value) {
          return;
        }
        if (_referenceEvent == null || _referenceEvent.Equals(value) != true) {
          _referenceEvent = value;
          OnPropertyChanged("ReferenceEvent");
        }
      }
    }

    [XmlElement(DataType = "time", Order = 1)]
    [JsonProperty("referenceTime", Order = 1)]
    public DateTime ReferenceTime {
      get {
        return _referenceTime;
      }
      set {
        if (_referenceTime.Equals(value) != true) {
          _referenceTime = value;
          OnPropertyChanged("ReferenceTime");
        }
      }
    }

    [XmlElement(DataType = "time", Order = 2)]
    [JsonProperty("utcReference", Order = 2)]
    public DateTime UtcReference {
      get {
        return _utcReference;
      }
      set {
        if (_utcReference.Equals(value) != true) {
          _utcReference = value;
          OnPropertyChanged("UtcReference");
        }
      }
    }

    [XmlElement("dateBasis", Order = 3)]
    [JsonProperty("dateBasis", Order = 3)]
    public List<TimeCalendarPropertyType> DateBasis {
      get {
        return _dateBasis;
      }
      set {
        if (_dateBasis == value) {
          return;
        }
        if (_dateBasis == null || _dateBasis.Equals(value) != true) {
          _dateBasis = value;
          OnPropertyChanged("DateBasis");
        }
      }
    }
  }
}
