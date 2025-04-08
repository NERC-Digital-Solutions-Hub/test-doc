
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
// <element name="TimeNode" type="gml:TimeNodeType" substitutionGroup="gml:AbstractTimeTopologyPrimitive">
//   <annotation>
//     <documentation>
//       A time node is a zero-dimensional topological primitive that represents an identifiable node in time
//       (it is equivalent to a point in space). A node may act as the termination or initiation of any number
//       of time edges. A time node may be realised as a geometry, its position, whose value is a time instant.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="TimeNodeType">
//   <complexContent>
//     <extension base="gml:AbstractTimeTopologyPrimitiveType">
//       <sequence>
//         <element name="previousEdge" type="gml:TimeEdgePropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <element name="nextEdge" type="gml:TimeEdgePropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <element name="position" type="gml:TimeInstantPropertyType" minOccurs="0"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <complexType name="TimeNodePropertyType">
//   <annotation>
//     <documentation>gml:TimeNodePropertyType provides for associating a gml:TimeNode with an object</documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:TimeNode"/>
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
  [JsonObject("TimeNodeType")]
  public class TimeNodeType : AbstractTimeTopologyPrimitiveType {
    #region Private fields
    private List<TimeEdgePropertyType> _previousEdge;
    private List<TimeEdgePropertyType> _nextEdge;
    private TimeInstantPropertyType _position;
    #endregion

    /// <summary>
    /// TimeNodeType class constructor
    /// </summary>
    public TimeNodeType() {
      _position = new TimeInstantPropertyType();
      _nextEdge = new List<TimeEdgePropertyType>();
      _previousEdge = new List<TimeEdgePropertyType>();
    }

    [XmlElement("previousEdge", Order = 0)]
    [JsonProperty("previousEdge", Order = 0)]
    public List<TimeEdgePropertyType> PreviousEdge {
      get {
        return _previousEdge;
      }
      set {
        if (_previousEdge == value) {
          return;
        }
        if (_previousEdge == null || _previousEdge.Equals(value) != true) {
          _previousEdge = value;
          OnPropertyChanged("PreviousEdge");
        }
      }
    }

    [XmlElement("nextEdge", Order = 1)]
    [JsonProperty("nextEdge", Order = 1)]
    public List<TimeEdgePropertyType> NextEdge {
      get {
        return _nextEdge;
      }
      set {
        if (_nextEdge == value) {
          return;
        }
        if (_nextEdge == null || _nextEdge.Equals(value) != true) {
          _nextEdge = value;
          OnPropertyChanged("NextEdge");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("position", Order = 2)]
    public TimeInstantPropertyType Position {
      get {
        return _position;
      }
      set {
        if (_position == value) {
          return;
        }
        if (_position == null || _position.Equals(value) != true) {
          _position = value;
          OnPropertyChanged("Position");
        }
      }
    }
  }

}
