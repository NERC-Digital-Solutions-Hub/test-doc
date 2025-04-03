
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 03:00, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/temporal.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="AbstractTimePrimitive" type="gml:AbstractTimePrimitiveType" abstract="true" substitutionGroup="gml:AbstractTimeObject">
//   <annotation>
//     <documentation>gml:AbstractTimePrimitive acts as the head of a substitution group for geometric and topological temporal primitives.</documentation>
//   </annotation>
// </element>
// <complexType name="AbstractTimePrimitiveType" abstract="true">
//   <complexContent>
//     <extension base="gml:AbstractTimeObjectType">
//       <sequence>
//         <element name="relatedTime" type="gml:RelatedTimeType" minOccurs="0" maxOccurs="unbounded"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <complexType name="TimePrimitivePropertyType">
//   <annotation>
//     <documentation>
//       gml:TimePrimitivePropertyType provides a standard content model for associations between an arbitrary member
//       of the substitution group whose head is gml:AbstractTimePrimitive and another object.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:AbstractTimePrimitive"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces


using NDSH.Geospatial.Gml.Temporal.Topology;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Temporal {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  //[XmlInclude(typeof(AbstractTimeTopologyPrimitiveType))]
  //[XmlInclude(typeof(TimeEdgeType))]
  //[XmlInclude(typeof(TimeNodeType))]
  //[XmlInclude(typeof(AbstractTimeGeometricPrimitiveType))]
  //[XmlInclude(typeof(TimePeriodType))]
  //[XmlInclude(typeof(TimeInstantType))]
  //[XmlType("AbstractTimePrimitiveType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractTimePrimitiveType")]
  public abstract class AbstractTimePrimitiveType : AbstractTimeObjectType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractTimePrimitiveType"/>.
    /// </summary>
    public AbstractTimePrimitiveType() {
      _relatedTime = default; //  new List<RelatedTimeType>();
    }

    #endregion

    #region Public Properties

    private List<RelatedTimeType> _relatedTime;

    /// <summary>
    /// 
    /// </summary>
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
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
