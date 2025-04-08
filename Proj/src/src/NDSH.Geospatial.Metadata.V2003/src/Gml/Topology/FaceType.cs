
#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic2D;
using NDSH.Geospatial.Metadata.V2003.Gml.GmlBase;
using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Topology {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("FaceType")]
  public class FaceType : AbstractTopoPrimitiveType {

    #region Private fields
    private List<DirectedEdgePropertyType> _directedEdge;
    private List<DirectedTopoSolidPropertyType> _directedTopoSolid;
    private SurfacePropertyType _surfaceProperty;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// FaceType class constructor
    /// </summary>
    public FaceType() {
      _surfaceProperty = new SurfacePropertyType();
      _directedTopoSolid = new List<DirectedTopoSolidPropertyType>();
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

    [XmlElement("directedTopoSolid", Order = 1)]
    [JsonProperty("directedTopoSolid", Order = 1)]
    public List<DirectedTopoSolidPropertyType> DirectedTopoSolid {
      get {
        return _directedTopoSolid;
      }
      set {
        if (_directedTopoSolid == value) {
          return;
        }
        if (_directedTopoSolid == null || _directedTopoSolid.Equals(value) != true) {
          _directedTopoSolid = value;
          OnPropertyChanged("DirectedTopoSolid");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("surfaceProperty", Order = 2)]
    public SurfacePropertyType SurfaceProperty {
      get {
        return _surfaceProperty;
      }
      set {
        if (_surfaceProperty == value) {
          return;
        }
        if (_surfaceProperty == null || _surfaceProperty.Equals(value) != true) {
          _surfaceProperty = value;
          OnPropertyChanged("SurfaceProperty");
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
