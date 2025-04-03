
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
// <element name="AbstractTimeTopologyPrimitive" type="gml:AbstractTimeTopologyPrimitiveType" abstract="true" substitutionGroup="gml:AbstractTimePrimitive">
//   <annotation>
//     <documentation>
//       gml:TimeTopologyPrimitive acts as the head of a substitution group for topological temporal primitives.
//       Temporal topology primitives shall imply the ordering information between features or feature properties.
//       The temporal connection of features can be examined if they have temporal topology primitives as values
//       of their properties. Usually, an instantaneous feature associates with a time node, and a static feature
//       associates with a time edge.  A feature with both modes associates with the temporal topology primitive:
//       a supertype of time nodes and time edges.
//       A topological primitive is always connected to one or more other topological primitives, and is, therefore,
//       always a member of a topological complex. In a GML instance, this will often be indicated by the primitives
//       being described by elements that are descendents of an element describing a complex. However, in order to
//       support the case where a temporal topological primitive is described in another context, the optional complex
//       property is provided, which carries a reference to the parent temporal topological complex.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="AbstractTimeTopologyPrimitiveType" abstract="true">
//   <complexContent>
//     <extension base="gml:AbstractTimePrimitiveType">
//       <sequence>
//         <element name="complex" type="gml:ReferenceType" minOccurs="0"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <complexType name="TimeTopologyPrimitivePropertyType">
//   <annotation>
//     <documentation>gml:TimeTopologyPrimitivePropertyType provides for associating a gml:AbstractTimeTopologyPrimitive with an object.</documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:AbstractTimeTopologyPrimitive"/>
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

  //[XmlInclude(typeof(TimeEdgeType))]
  //[XmlInclude(typeof(TimeNodeType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractTimeTopologyPrimitiveType")]
  public abstract class AbstractTimeTopologyPrimitiveType : AbstractTimePrimitiveType {
    #region Private fields
    private ReferenceType _complex;
    #endregion

    /// <summary>
    /// AbstractTimeTopologyPrimitiveType class constructor
    /// </summary>
    public AbstractTimeTopologyPrimitiveType() {
      _complex = new ReferenceType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("complex", Order = 0)]
    public ReferenceType Complex {
      get {
        return _complex;
      }
      set {
        if (_complex == value) {
          return;
        }
        if (_complex == null || _complex.Equals(value) != true) {
          _complex = value;
          OnPropertyChanged("Complex");
        }
      }
    }
  }

}
