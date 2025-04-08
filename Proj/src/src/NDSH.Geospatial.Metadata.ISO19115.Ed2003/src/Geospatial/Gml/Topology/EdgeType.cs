
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : date, @gisvlasta
// History           : 
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/topology.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="EdgeType">
//   <complexContent>
//     <extension base="gml:AbstractTopoPrimitiveType">
//       <sequence>
//         <element ref="gml:directedNode" minOccurs="2" maxOccurs="2"/>
//         <element ref="gml:directedFace" minOccurs="0" maxOccurs="unbounded"/>
//         <element ref="gml:curveProperty" minOccurs="0"/>
//       </sequence>
//       <attributeGroup ref="gml:AggregationAttributeGroup"/>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="Edge" type="gml:EdgeType" substitutionGroup="gml:AbstractTopoPrimitive">
//   <annotation>
//     <documentation>
//       gml:Edge represents the 1-dimensional primitive.
//       The topological boundary of an Edge (gml:directedNode) consists of a negatively
//       directed start Node and a positively directed end Node.   
//       The optional coboundary of an edge (gml:directedFace) is a circular sequence of
//       directed faces which are incident on this edge in document order. In the 2D case,
//       the orientation of the face on the left of the edge is "+"; the orientation of the
//       face on the right on its right is "-". 
//       If provided, the aggregationType attribute shall have the value “sequence”.
//       An edge may optionally be realised by a 1-dimensional geometric primitive (gml:curveProperty).
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Geometry.Basic0D1D;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Topology {

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
