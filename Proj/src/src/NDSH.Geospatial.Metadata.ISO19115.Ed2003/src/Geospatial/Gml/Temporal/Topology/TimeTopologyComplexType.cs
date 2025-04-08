
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/02/2023, 03:43, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/temporalTopology.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="TimeTopologyComplex" type="gml:TimeTopologyComplexType" substitutionGroup="gml:AbstractTimeComplex">
//   <annotation>
//     <documentation>
//       A temporal topology complex shall be the connected acyclic directed graph composed of temporal topological primitives,
//       i.e. time nodes and time edges. Because a time edge may not exist without two time nodes on its boundaries, static
//       features have time edges from a temporal topology complex as the values of their temporal properties, regardless of explicit declarations.
//       A temporal topology complex expresses a linear or a non-linear graph. A temporal linear graph, composed of a sequence
//       of time edges, provides a lineage described only by “substitution” of feature instances or feature element values.
//       A time node as the start or the end of the graph connects with at least one time edge. A time node other than the
//       start and the end shall connect to at least two time edges: one of starting from the node, and another ending at the node.
//       A temporal topological complex is a set of connected temporal topological primitives. The member primtives are indicated,
//       either by reference or by value, using the primitive property.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="TimeTopologyComplexType" abstract="true">
//   <complexContent>
//     <extension base="gml:AbstractTimeComplexType">
//       <sequence>
//         <element name="primitive" type="gml:TimeTopologyPrimitivePropertyType" maxOccurs="unbounded"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <complexType name="TimeTopologyComplexPropertyType">
//   <annotation>
//     <documentation>gml:TimeTopologyComplexPropertyType provides for associating a gml:TimeTopologyComplex with an object.</documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:TimeTopologyComplex"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using Newtonsoft.Json;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Temporal.Topology {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeTopologyComplexType")]
  public abstract class TimeTopologyComplexType : AbstractTimeComplexType {
    #region Private fields
    private List<TimeTopologyPrimitivePropertyType> _primitive;
    #endregion

    /// <summary>
    /// TimeTopologyComplexType class constructor
    /// </summary>
    public TimeTopologyComplexType() {
      _primitive = new List<TimeTopologyPrimitivePropertyType>();
    }

    [XmlElement("primitive", Order = 0)]
    [JsonProperty("primitive", Order = 0)]
    public List<TimeTopologyPrimitivePropertyType> Primitive {
      get {
        return _primitive;
      }
      set {
        if (_primitive == value) {
          return;
        }
        if (_primitive == null || _primitive.Equals(value) != true) {
          _primitive = value;
          OnPropertyChanged("Primitive");
        }
      }
    }
  }

}
