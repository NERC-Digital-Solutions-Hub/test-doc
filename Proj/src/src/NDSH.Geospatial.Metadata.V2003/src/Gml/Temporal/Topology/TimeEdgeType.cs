using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Temporal.Topology {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeEdgeType")]
  public class TimeEdgeType : AbstractTimeTopologyPrimitiveType {
    #region Private fields
    private TimeNodePropertyType _start;
    private TimeNodePropertyType _end;
    private TimePeriodPropertyType _extent;
    #endregion

    /// <summary>
    /// TimeEdgeType class constructor
    /// </summary>
    public TimeEdgeType() {
      _extent = new TimePeriodPropertyType();
      _end = new TimeNodePropertyType();
      _start = new TimeNodePropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("start", Order = 0)]
    public TimeNodePropertyType Start {
      get {
        return _start;
      }
      set {
        if (_start == value) {
          return;
        }
        if (_start == null || _start.Equals(value) != true) {
          _start = value;
          OnPropertyChanged("Start");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("end", Order = 1)]
    public TimeNodePropertyType End {
      get {
        return _end;
      }
      set {
        if (_end == value) {
          return;
        }
        if (_end == null || _end.Equals(value) != true) {
          _end = value;
          OnPropertyChanged("End");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("extent", Order = 2)]
    public TimePeriodPropertyType Extent {
      get {
        return _extent;
      }
      set {
        if (_extent == value) {
          return;
        }
        if (_extent == null || _extent.Equals(value) != true) {
          _extent = value;
          OnPropertyChanged("Extent");
        }
      }
    }
  }

}
