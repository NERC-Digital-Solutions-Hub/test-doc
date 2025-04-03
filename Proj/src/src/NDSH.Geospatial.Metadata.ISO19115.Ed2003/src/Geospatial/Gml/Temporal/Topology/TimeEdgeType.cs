
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
// <element name="TimeEdge" type="gml:TimeEdgeType" substitutionGroup="gml:AbstractTimeTopologyPrimitive">
//   <annotation>
//     <documentation>
//       A time edge is a one-dimensional topological primitive. It is an open interval that starts and ends at a node.
//       The edge may be realised as a geometry whose value is a time period.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="TimeEdgeType">
//   <complexContent>
//     <extension base="gml:AbstractTimeTopologyPrimitiveType">
//       <sequence>
//         <element name="start" type="gml:TimeNodePropertyType"/>
//         <element name="end" type="gml:TimeNodePropertyType"/>
//         <element name="extent" type="gml:TimePeriodPropertyType" minOccurs="0"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <complexType name="TimeEdgePropertyType">
//   <annotation>
//     <documentation>gml:TimeEdgePropertyType provides for associating a gml:TimeEdge with an object.</documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:TimeEdge"/>
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
  [JsonObject("TimeEdgeType")]
  public class TimeEdgeType : AbstractTimeTopologyPrimitiveType {
    #region Private fields
    private TimeNodePropertyType _start;
    private TimeNodePropertyType _end;
    private TimePeriodPropertyType _extent;
    #endregion

    /// <summary>
    /// TimeEdgeType class constructor
    /// </summary>
    public TimeEdgeType() {
      _extent = new TimePeriodPropertyType();
      _end = new TimeNodePropertyType();
      _start = new TimeNodePropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("start", Order = 0)]
    public TimeNodePropertyType Start {
      get {
        return _start;
      }
      set {
        if (_start == value) {
          return;
        }
        if (_start == null || _start.Equals(value) != true) {
          _start = value;
          OnPropertyChanged("Start");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("end", Order = 1)]
    public TimeNodePropertyType End {
      get {
        return _end;
      }
      set {
        if (_end == value) {
          return;
        }
        if (_end == null || _end.Equals(value) != true) {
          _end = value;
          OnPropertyChanged("End");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("extent", Order = 2)]
    public TimePeriodPropertyType Extent {
      get {
        return _extent;
      }
      set {
        if (_extent == value) {
          return;
        }
        if (_extent == null || _extent.Equals(value) != true) {
          _extent = value;
          OnPropertyChanged("Extent");
        }
      }
    }
  }

}
