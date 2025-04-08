
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
// XSD               : /2005/gml/temporal.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="AbstractTimeObject" type="gml:AbstractTimeObjectType" abstract="true" substitutionGroup="gml:AbstractGML">
//   <annotation>
//     <documentation>gml:AbstractTimeObject acts as the head of a substitution group for all temporal primitives and complexes.</documentation>
//   </annotation>
// </element>
// <complexType name="AbstractTimeObjectType" abstract="true">
//   <complexContent>
//     <extension base="gml:AbstractGMLType"/>
//   </complexContent>
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

  //[XmlInclude(typeof(AbstractTimeComplexType))]
  //[XmlInclude(typeof(TimeTopologyComplexType))]
  //[XmlInclude(typeof(AbstractTimePrimitiveType))]
  //[XmlInclude(typeof(AbstractTimeTopologyPrimitiveType))]
  //[XmlInclude(typeof(TimeEdgeType))]
  //[XmlInclude(typeof(TimeNodeType))]
  //[XmlInclude(typeof(AbstractTimeGeometricPrimitiveType))]
  //[XmlInclude(typeof(TimePeriodType))]
  //[XmlInclude(typeof(TimeInstantType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractTimeObjectType")]
  public abstract class AbstractTimeObjectType : AbstractGMLType {
  }
}
