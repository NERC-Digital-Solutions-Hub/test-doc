
#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic0D1D;
using NDSH.Geospatial.Metadata.V2003.Gml.GmlBase;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Topology {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("EdgeType")]
  public class EdgeType : AbstractTopoPrimitiveType {

    #region Private fields
    private List<DirectedNodePropertyType> _directedNode;
    private List<DirectedFacePropertyType> _directedFace;
    private CurvePropertyType _curveProperty;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// EdgeType class constructor
    /// </summary>
    public EdgeType() {
      _curveProperty = new CurvePropertyType();
      _directedFace = new List<DirectedFacePropertyType>();
      _directedNode = new List<DirectedNodePropertyType>();
    }

    [XmlElement("directedNode", Order = 0)]
    [Required()]
    [JsonProperty("directedNode", Order = 0)]
    public List<DirectedNodePropertyType> DirectedNode {
      get {
        return _directedNode;
      }
      set {
        if (_directedNode == value) {
          return;
        }
        if (_directedNode == null || _directedNode.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "DirectedNode";
          Validator.ValidateProperty(value, validatorPropContext);
          _directedNode = value;
          OnPropertyChanged("DirectedNode");
        }
      }
    }

    [XmlElement("directedFace", Order = 1)]
    [JsonProperty("directedFace", Order = 1)]
    public List<DirectedFacePropertyType> DirectedFace {
      get {
        return _directedFace;
      }
      set {
        if (_directedFace == value) {
          return;
        }
        if (_directedFace == null || _directedFace.Equals(value) != true) {
          _directedFace = value;
          OnPropertyChanged("DirectedFace");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("curveProperty", Order = 2)]
    public CurvePropertyType CurveProperty {
      get {
        return _curveProperty;
      }
      set {
        if (_curveProperty == value) {
          return;
        }
        if (_curveProperty == null || _curveProperty.Equals(value) != true) {
          _curveProperty = value;
          OnPropertyChanged("CurveProperty");
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
