using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Temporal.Topology {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeNodeType")]
  public class TimeNodeType : AbstractTimeTopologyPrimitiveType {
    #region Private fields
    private List<TimeEdgePropertyType> _previousEdge;
    private List<TimeEdgePropertyType> _nextEdge;
    private TimeInstantPropertyType _position;
    #endregion

    /// <summary>
    /// TimeNodeType class constructor
    /// </summary>
    public TimeNodeType() {
      _position = new TimeInstantPropertyType();
      _nextEdge = new List<TimeEdgePropertyType>();
      _previousEdge = new List<TimeEdgePropertyType>();
    }

    [XmlElement("previousEdge", Order = 0)]
    [JsonProperty("previousEdge", Order = 0)]
    public List<TimeEdgePropertyType> PreviousEdge {
      get {
        return _previousEdge;
      }
      set {
        if (_previousEdge == value) {
          return;
        }
        if (_previousEdge == null || _previousEdge.Equals(value) != true) {
          _previousEdge = value;
          OnPropertyChanged("PreviousEdge");
        }
      }
    }

    [XmlElement("nextEdge", Order = 1)]
    [JsonProperty("nextEdge", Order = 1)]
    public List<TimeEdgePropertyType> NextEdge {
      get {
        return _nextEdge;
      }
      set {
        if (_nextEdge == value) {
          return;
        }
        if (_nextEdge == null || _nextEdge.Equals(value) != true) {
          _nextEdge = value;
          OnPropertyChanged("NextEdge");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("position", Order = 2)]
    public TimeInstantPropertyType Position {
      get {
        return _position;
      }
      set {
        if (_position == value) {
          return;
        }
        if (_position == null || _position.Equals(value) != true) {
          _position = value;
          OnPropertyChanged("Position");
        }
      }
    }
  }

}
