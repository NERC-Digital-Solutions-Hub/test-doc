using NDSH.Geospatial.Metadata.V2003.Gml.Dictionary;
using NDSH.Geospatial.Metadata.V2003.Gml.GmlBase;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Temporal.ReferenceSystems {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeCalendarEraType")]
  public class TimeCalendarEraType : DefinitionType {
    #region Private fields
    private StringOrRefType _referenceEvent;
    private string _referenceDate;
    private decimal _julianReference;
    private TimePeriodPropertyType _epochOfUse;
    #endregion

    /// <summary>
    /// TimeCalendarEraType class constructor
    /// </summary>
    public TimeCalendarEraType() {
      _epochOfUse = new TimePeriodPropertyType();
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

    [XmlElement(Order = 1)]
    [JsonProperty("referenceDate", Order = 1)]
    public string ReferenceDate {
      get {
        return _referenceDate;
      }
      set {
        if (_referenceDate == value) {
          return;
        }
        if (_referenceDate == null || _referenceDate.Equals(value) != true) {
          _referenceDate = value;
          OnPropertyChanged("ReferenceDate");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("julianReference", Order = 2)]
    public decimal JulianReference {
      get {
        return _julianReference;
      }
      set {
        if (_julianReference.Equals(value) != true) {
          _julianReference = value;
          OnPropertyChanged("JulianReference");
        }
      }
    }

    [XmlElement(Order = 3)]
    [JsonProperty("epochOfUse", Order = 3)]
    public TimePeriodPropertyType EpochOfUse {
      get {
        return _epochOfUse;
      }
      set {
        if (_epochOfUse == value) {
          return;
        }
        if (_epochOfUse == null || _epochOfUse.Equals(value) != true) {
          _epochOfUse = value;
          OnPropertyChanged("EpochOfUse");
        }
      }
    }
  }
}
