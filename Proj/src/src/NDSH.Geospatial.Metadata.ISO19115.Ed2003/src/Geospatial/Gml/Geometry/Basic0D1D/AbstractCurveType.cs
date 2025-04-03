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
// XSD               : /2005/gml/geometryAggregates.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="AbstractCurveType" abstract="true">
//   <annotation>
//     <documentation>
//       gml:AbstractCurveType is an abstraction of a curve to support the different levels of complexity. 
//       The curve may always be viewed as a geometric primitive, i.e. is continuous.
//     </documentation>
//   </annotation>
//   <complexContent>
//     <extension base="gml:AbstractGeometricPrimitiveType"/>
//   </complexContent>
// </complexType>
// <element name="AbstractCurve" type="gml:AbstractCurveType" abstract="true" substitutionGroup="gml:AbstractGeometricPrimitive">
//   <annotation>
//     <documentation>
//       The AbstractCurve element is the abstract head of the substitution group for all (continuous) curve elements.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Geospatial.Gml.Geometry.Complexes;
using NDSH.Geospatial.Gml.Geometry.Primitives;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Basic0D1D {


  /// <summary>
  /// gml:AbstractCurveType is an abstraction of a curve to support the different levels of complexity. The curve may always be viewed as a geometric primitive, i.e. is continuous.
  /// </summary>
  //[XmlInclude(typeof(CompositeCurveType))]
  //[XmlInclude(typeof(OrientableCurveType))]
  //[XmlInclude(typeof(CurveType))]
  //[XmlInclude(typeof(LineStringType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractCurveType")]
  public abstract class AbstractCurveType : AbstractGeometricPrimitiveType {

  }

}
