
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
// <element name="AbstractTimeComplex" type="gml:AbstractTimeComplexType" abstract="true" substitutionGroup="gml:AbstractTimeObject">
//   <annotation>
//     <documentation>gml:AbstractTimeComplex is an aggregation of temporal primitives and acts as the head of a substitution group for temporal complexes.</documentation>
//   </annotation>
// </element>
// <complexType name="AbstractTimeComplexType" abstract="true">
//   <complexContent>
//     <extension base="gml:AbstractTimeObjectType"/>
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

  //[XmlInclude(typeof(TimeTopologyComplexType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractTimeComplexType")]
  public abstract class AbstractTimeComplexType : AbstractTimeObjectType {
  }

}
