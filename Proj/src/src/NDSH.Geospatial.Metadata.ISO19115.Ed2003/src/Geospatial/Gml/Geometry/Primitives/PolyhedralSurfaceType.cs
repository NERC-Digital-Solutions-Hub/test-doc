
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
// <complexType name="PolyhedralSurfaceType">
//   <complexContent>
//     <restriction base="gml:SurfaceType">
//       <sequence>
//         <group ref="gml:StandardObjectProperties"/>
//         <element ref="gml:polygonPatches"/>
//       </sequence>
//     </restriction>
//   </complexContent>
// </complexType>
// <element name="PolyhedralSurface" type="gml:PolyhedralSurfaceType" substitutionGroup="gml:Surface">
//   <annotation>
//     <documentation>
//       A polyhedral surface is a surface composed of polygon patches connected along
//       their common boundary curves. This differs from the surface type only in the
//       restriction on the types of surface patches acceptable.
//       polygonPatches encapsulates the polygon patches of the polyhedral surface.
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

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("PolyhedralSurfaceType")]
  public class PolyhedralSurfaceType : SurfaceType {

  }

}
