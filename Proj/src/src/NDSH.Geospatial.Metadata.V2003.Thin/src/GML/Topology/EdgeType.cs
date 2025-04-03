
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
    public List<DirectedNodePropertyType> directedNode {
      get {
        return _directedNode;
      }
      set {
        if (_directedNode == value) {
          return;
        }
        if (_directedNode == null || _directedNode.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "directedNode";
          Validator.ValidateProperty(value, validatorPropContext);
          _directedNode = value;
          OnPropertyChanged("directedNode");
        }
      }
    }

    [XmlElement("directedFace", Order = 1)]
    [JsonProperty("directedFace", Order = 1)]
    public List<DirectedFacePropertyType> directedFace {
      get {
        return _directedFace;
      }
      set {
        if (_directedFace == value) {
          return;
        }
        if (_directedFace == null || _directedFace.Equals(value) != true) {
          _directedFace = value;
          OnPropertyChanged("directedFace");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("curveProperty", Order = 2)]
    public CurvePropertyType curveProperty {
      get {
        return _curveProperty;
      }
      set {
        if (_curveProperty == value) {
          return;
        }
        if (_curveProperty == null || _curveProperty.Equals(value) != true) {
          _curveProperty = value;
          OnPropertyChanged("curveProperty");
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