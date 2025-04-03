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
// <complexType name="AbstractSurfaceType" abstract="true">
//   <annotation>
//     <documentation>
//       gml:AbstractSurfaceType is an abstraction of a surface to support the different levels of complexity. 
//       A surface is always a continuous region of a plane.
//     </documentation>
//   </annotation>
//   <complexContent>
//     <extension base="gml:AbstractGeometricPrimitiveType"/>
//   </complexContent>
// </complexType>
// <element name="AbstractSurface" type="gml:AbstractSurfaceType" abstract="true" substitutionGroup="gml:AbstractGeometricPrimitive">
//   <annotation>
//     <documentation>
//       The AbstractSurface element is the abstract head of the substitution group for all (continuous) surface elements.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Geospatial.Gml.Geometry.Basic0D1D;
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

namespace NDSH.Geospatial.Gml.Geometry.Basic2D {


  /// <summary>
  /// gml:AbstractSurfaceType is an abstraction of a surface to support the different levels of complexity. A surface is always a continuous region of a plane.
  /// </summary>
  //[XmlInclude(typeof(CompositeSurfaceType))]
  //[XmlInclude(typeof(OrientableSurfaceType))]
  //[XmlInclude(typeof(SurfaceType))]
  //[XmlInclude(typeof(TriangulatedSurfaceType))]
  //[XmlInclude(typeof(TinType))]
  //[XmlInclude(typeof(PolyhedralSurfaceType))]
  //[XmlInclude(typeof(PolygonType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractSurfaceType")]
  public abstract class AbstractSurfaceType : AbstractGeometricPrimitiveType {

  }

}
