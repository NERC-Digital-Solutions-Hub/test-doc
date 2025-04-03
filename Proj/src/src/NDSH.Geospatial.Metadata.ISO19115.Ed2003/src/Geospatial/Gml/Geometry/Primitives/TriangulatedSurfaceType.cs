
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
// <complexType name="TriangulatedSurfaceType">
//   <complexContent>
//     <restriction base="gml:SurfaceType">
//       <sequence>
//         <group ref="gml:StandardObjectProperties"/>
//         <element ref="gml:trianglePatches"/>
//       </sequence>
//     </restriction>
//   </complexContent>
// </complexType>
// <element name="TriangulatedSurface" type="gml:TriangulatedSurfaceType" substitutionGroup="gml:Surface">
//   <annotation>
//     <documentation>
//       A triangulated surface is a polyhedral surface that is composed only of triangles.
//       There is no restriction on how the triangulation is derived.
//       trianglePatches encapsulates the triangles of the triangulated surface.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  //[XmlInclude(typeof(TinType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TriangulatedSurfaceType")]
  public class TriangulatedSurfaceType : SurfaceType {

  }

}
