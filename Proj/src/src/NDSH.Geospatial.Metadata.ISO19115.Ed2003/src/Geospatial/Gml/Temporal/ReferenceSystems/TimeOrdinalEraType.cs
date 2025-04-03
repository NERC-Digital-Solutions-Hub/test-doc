
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
// XSD               : /2005/gml/temporalReferenceSystems.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="TimeOrdinalEra" type="gml:TimeOrdinalEraType">
//   <annotation>
//     <documentation>
//       Its content model follows the pattern of gml:TimeEdge, inheriting standard
//       properties from gml:DefinitionType, and adding gml:start, gml:end and
//       gml:extent properties, a set of gml:member properties which indicate ordered
//       gml:TimeOrdinalEra elements, and a gml:group property which points to the parent era.
//       The recursive inclusion of gml:TimeOrdinalEra elements allow the construction of an
//       arbitrary depth hierarchical ordinal reference schema, such that an ordinal era at a
//       given level of the hierarchy includes a sequence of shorter, coterminous ordinal eras.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="TimeOrdinalEraType">
//   <complexContent>
//     <extension base="gml:DefinitionType">
//       <sequence>
//         <element name="relatedTime" type="gml:RelatedTimeType" minOccurs="0" maxOccurs="unbounded"/>
//         <element name="start" type="gml:TimeNodePropertyType"/>
//         <element name="end" type="gml:TimeNodePropertyType"/>
//         <element name="extent" type="gml:TimePeriodPropertyType" minOccurs="0"/>
//         <element name="member" type="gml:TimeOrdinalEraPropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <element name="group" type="gml:ReferenceType" minOccurs="0"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <complexType name="TimeOrdinalEraPropertyType">
//   <annotation>
//     <documentation>gml:TimeOrdinalEraPropertyType provides for associating a gml:TimeOrdinalEra with an object.</documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:TimeOrdinalEra"/>
//   </sequence>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using NDSH.Geospatial.Gml.Dictionary;
using NDSH.Geospatial.Gml.Temporal.Topology;
using Newtonsoft.Json;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Temporal.ReferenceSystems {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeOrdinalEraType")]
  public class TimeOrdinalEraType : DefinitionType {
    #region Private fields
    private List<RelatedTimeType> _relatedTime;
    private TimeNodePropertyType _start;
    private TimeNodePropertyType _end;
    private TimePeriodPropertyType _extent;
    private List<TimeOrdinalEraPropertyType> _member;
    private ReferenceType _group;
    #endregion

    /// <summary>
    /// TimeOrdinalEraType class constructor
    /// </summary>
    public TimeOrdinalEraType() {
      _group = new ReferenceType();
      _member = new List<TimeOrdinalEraPropertyType>();
      _extent = new TimePeriodPropertyType();
      _end = new TimeNodePropertyType();
      _start = new TimeNodePropertyType();
      _relatedTime = new List<RelatedTimeType>();
    }

    [XmlElement("relatedTime", Order = 0)]
    [JsonProperty("relatedTime", Order = 0)]
    public List<RelatedTimeType> RelatedTime {
      get {
        return _relatedTime;
      }
      set {
        if (_relatedTime == value) {
          return;
        }
        if (_relatedTime == null || _relatedTime.Equals(value) != true) {
          _relatedTime = value;
          OnPropertyChanged("RelatedTime");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("start", Order = 1)]
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

    [XmlElement(Order = 2)]
    [JsonProperty("end", Order = 2)]
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

    [XmlElement(Order = 3)]
    [JsonProperty("extent", Order = 3)]
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

    [XmlElement("member", Order = 4)]
    [JsonProperty("member", Order = 4)]
    public List<TimeOrdinalEraPropertyType> Member {
      get {
        return _member;
      }
      set {
        if (_member == value) {
          return;
        }
        if (_member == null || _member.Equals(value) != true) {
          _member = value;
          OnPropertyChanged("Member");
        }
      }
    }

    [XmlElement(Order = 5)]
    [JsonProperty("group", Order = 5)]
    public ReferenceType Group {
      get {
        return _group;
      }
      set {
        if (_group == value) {
          return;
        }
        if (_group == null || _group.Equals(value) != true) {
          _group = value;
          OnPropertyChanged("Group");
        }
      }
    }
  }
}
