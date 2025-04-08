
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
// <complexType name="TopoCurveType">
//   <complexContent>
//     <extension base="gml:AbstractTopologyType">
//       <sequence>
//         <element ref="gml:directedEdge" maxOccurs="unbounded"/>
//       </sequence>
//       <attributeGroup ref="gml:AggregationAttributeGroup"/>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="TopoCurve" type="gml:TopoCurveType">
//   <annotation>
//     <documentation>
//       gml:TopoCurve represents a homogeneous topological expression, a sequence of directed edges,
//       which if realised are isomorphic to a geometric curve primitive. The intended use of gml:TopoCurve
//       is to appear within a line feature to express the structural and geometric relationships of this
//       feature to other features via the shared edge definitions.
//       If provided, the aggregationType attribute shall have the value “sequence”.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="TopoCurvePropertyType">
//   <sequence>
//     <element ref="gml:TopoCurve"/>
//   </sequence>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
// <element name="topoCurveProperty" type="gml:TopoCurvePropertyType">
//   <annotation>
//     <documentation>
//       The gml:topoCurveProperty property element may be used in features to
//       express their relationship to the referenced topology edges.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Topology {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TopoCurveType")]
  public class TopoCurveType : AbstractTopologyType {

    #region Private fields
    private List<DirectedEdgePropertyType> _directedEdge;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// TopoCurveType class constructor
    /// </summary>
    public TopoCurveType() {
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
