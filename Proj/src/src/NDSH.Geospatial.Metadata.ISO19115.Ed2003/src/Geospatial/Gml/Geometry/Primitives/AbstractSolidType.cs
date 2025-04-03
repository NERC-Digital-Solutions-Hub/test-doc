
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
// XSD               : /2005/gml/geometryPrimitives.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="AbstractSolidType">
//   <annotation>
//     <documentation>
//       gml:AbstractSolidType is an abstraction of a solid to support the different levels of complexity.
//       The solid may always be viewed as a geometric primitive, i.e. is contiguous.
//     </documentation>
//   </annotation>
//   <complexContent>
//     <extension base="gml:AbstractGeometricPrimitiveType"/>
//   </complexContent>
// </complexType>
// <element name="AbstractSolid" type="gml:AbstractSolidType" abstract="true" substitutionGroup="gml:AbstractGeometricPrimitive">
//   <annotation>
//     <documentation>The AbstractSolid element is the abstract head of the substitution group for all (continuous) solid elements.</documentation>
//   </annotation>
// </element>
// <complexType name="SolidPropertyType">
//   <annotation>
//     <documentation>
//       A property that has a solid as its value domain may either be an appropriate geometry element
//       encapsulated in an element of this type or an XLink reference to a remote geometry element
//       (where remote includes geometry elements located elsewhere in the same document). Either the
//       reference or the contained element shall be given, but neither both nor none.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:AbstractSolid"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
// <element name="solidProperty" type="gml:SolidPropertyType">
//   <annotation>
//     <documentation>
//       This property element either references a solid via the XLink-attributes or contains the solid element.
//       solidProperty is the predefined property which may be used by GML Application Schemas whenever a GML
//       feature has a property with a value that is substitutable for AbstractSolid.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion


using NDSH.Geospatial.Gml.Geometry.Basic0D1D;
using NDSH.Geospatial.Gml.Geometry.Complexes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Primitives {


  /// <summary>
  /// gml:AbstractSolidType is an abstraction of a solid to support the different levels of complexity. The solid may always be viewed as a geometric primitive, i.e. is contiguous.
  /// </summary>
  [XmlInclude(typeof(CompositeSolidType))]
  [XmlInclude(typeof(SolidType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractSolidType")]
  public class AbstractSolidType : AbstractGeometricPrimitiveType {

  }

}
