using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Temporal.ReferenceSystems {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeCalendarType")]
  public class TimeCalendarType : TimeReferenceSystemType {
    #region Private fields
    private List<TimeCalendarEraPropertyType> _referenceFrame;
    #endregion

    /// <summary>
    /// TimeCalendarType class constructor
    /// </summary>
    public TimeCalendarType() {
      _referenceFrame = new List<TimeCalendarEraPropertyType>();
    }

    [XmlElement("referenceFrame", Order = 0)]
    [JsonProperty("referenceFrame", Order = 0)]
    public List<TimeCalendarEraPropertyType> ReferenceFrame {
      get {
        return _referenceFrame;
      }
      set {
        if (_referenceFrame == value) {
          return;
        }
        if (_referenceFrame == null || _referenceFrame.Equals(value) != true) {
          _referenceFrame = value;
          OnPropertyChanged("ReferenceFrame");
        }
      }
    }
  }
}
