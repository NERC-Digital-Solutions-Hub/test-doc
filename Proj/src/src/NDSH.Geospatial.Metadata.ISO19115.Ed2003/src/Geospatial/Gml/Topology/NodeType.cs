
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
// <complexType name="NodeType">
//   <complexContent>
//     <extension base="gml:AbstractTopoPrimitiveType">
//       <sequence>
//         <element ref="gml:directedEdge" minOccurs="0" maxOccurs="unbounded"/>
//         <element ref="gml:pointProperty" minOccurs="0"/>
//       </sequence>
//       <attributeGroup ref="gml:AggregationAttributeGroup"/>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="Node" type="gml:NodeType" substitutionGroup="gml:AbstractTopoPrimitive">
//   <annotation>
//     <documentation>
//       gml:Node represents the 0-dimensional primitive.
//       The optional coboundary of a node (gml:directedEdge) is a sequence of directed
//       edges which are incident on this node. Edges emanating from this node appear in
//       the node coboundary with a negative orientation. 
//       If provided, the aggregationType attribute shall have the value “sequence”.
//       A node may optionally be realised by a 0-dimensional geometric primitive (gml:pointProperty).
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Geometry.Basic0D1D;
using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Topology {

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
