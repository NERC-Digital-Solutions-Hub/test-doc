
#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic0D1D;
using NDSH.Geospatial.Metadata.V2003.Gml.GmlBase;
using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Topology {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("NodeType")]
  public class NodeType : AbstractTopoPrimitiveType {

    #region Private fields
    private List<DirectedEdgePropertyType> _directedEdge;
    private PointPropertyType _pointProperty;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// NodeType class constructor
    /// </summary>
    public NodeType() {
      _pointProperty = new PointPropertyType();
      _directedEdge = new List<DirectedEdgePropertyType>();
    }

    [XmlElement("directedEdge", Order = 0)]
    [JsonProperty("directedEdge", Order = 0)]
    public List<DirectedEdgePropertyType> DirectedEdge {
      get {
        return _directedEdge;
      }
      set {
        if (_directedEdge == value) {
          return;
        }
        if (_directedEdge == null || _directedEdge.Equals(value) != true) {
          _directedEdge = value;
          OnPropertyChanged("DirectedEdge");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("pointProperty", Order = 1)]
    public PointPropertyType PointProperty {
      get {
        return _pointProperty;
      }
      set {
        if (_pointProperty == value) {
          return;
        }
        if (_pointProperty == null || _pointProperty.Equals(value) != true) {
          _pointProperty = value;
          OnPropertyChanged("PointProperty");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("aggregationType")]
    public AggregationType AggregationType {
      get {
        return _aggregationType;
      }
      set {
        if (_aggregationType.Equals(value) != true) {
          _aggregationType = value;
          OnPropertyChanged("AggregationType");
        }
      }
    }

  }

}
