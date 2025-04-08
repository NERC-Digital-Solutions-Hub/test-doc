
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic2D;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Topology
{


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

    [XmlElement("directedTopoSolid", Order = 1)]
    [JsonProperty("directedTopoSolid", Order = 1)]
    public List<DirectedTopoSolidPropertyType> directedTopoSolid {
      get {
        return _directedTopoSolid;
      }
      set {
        if (_directedTopoSolid == value) {
          return;
        }
        if (_directedTopoSolid == null || _directedTopoSolid.Equals(value) != true) {
          _directedTopoSolid = value;
          OnPropertyChanged("directedTopoSolid");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("surfaceProperty", Order = 2)]
    public SurfacePropertyType surfaceProperty {
      get {
        return _surfaceProperty;
      }
      set {
        if (_surfaceProperty == value) {
          return;
        }
        if (_surfaceProperty == null || _surfaceProperty.Equals(value) != true) {
          _surfaceProperty = value;
          OnPropertyChanged("surfaceProperty");
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