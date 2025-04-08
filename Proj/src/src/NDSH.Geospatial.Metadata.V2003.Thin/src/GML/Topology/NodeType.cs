
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.GmlBase;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic0D1D;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Topology
{


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
    public List<DirectedEdgePropertyType> directedEdge {
      get {
        return _directedEdge;
      }
      set {
        if (_directedEdge == value) {
          return;
        }
        if (_directedEdge == null || _directedEdge.Equals(value) != true) {
          _directedEdge = value;
          OnPropertyChanged("directedEdge");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("pointProperty", Order = 1)]
    public PointPropertyType pointProperty {
      get {
        return _pointProperty;
      }
      set {
        if (_pointProperty == value) {
          return;
        }
        if (_pointProperty == null || _pointProperty.Equals(value) != true) {
          _pointProperty = value;
          OnPropertyChanged("pointProperty");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("aggregationType")]
    public AggregationType aggregationType {
      get {
        return _aggregationType;
      }
      set {
        if (_aggregationType.Equals(value) != true) {
          _aggregationType = value;
          OnPropertyChanged("aggregationType");
        }
      }
    }
  }
}