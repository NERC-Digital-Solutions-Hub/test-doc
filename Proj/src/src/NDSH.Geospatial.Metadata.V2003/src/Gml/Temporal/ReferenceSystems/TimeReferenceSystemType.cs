using NDSH.Geospatial.Metadata.V2003.Gml.Dictionary;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Temporal.ReferenceSystems {


  [XmlInclude(typeof(TimeOrdinalReferenceSystemType))]
  [XmlInclude(typeof(TimeClockType))]
  [XmlInclude(typeof(TimeCalendarType))]
  [XmlInclude(typeof(TimeCoordinateSystemType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeReferenceSystemType")]
  public class TimeReferenceSystemType : DefinitionType {
    #region Private fields
    private string _domainOfValidity;
    #endregion

    [XmlElement(Order = 0)]
    [JsonProperty("domainOfValidity", Order = 0)]
    public string DomainOfValidity {
      get {
        return _domainOfValidity;
      }
      set {
        if (_domainOfValidity == value) {
          return;
        }
        if (_domainOfValidity == null || _domainOfValidity.Equals(value) != true) {
          _domainOfValidity = value;
          OnPropertyChanged("DomainOfValidity");
        }
      }
    }
  }
}
