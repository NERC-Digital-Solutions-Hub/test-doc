
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
// <complexType name="PolygonPatchArrayPropertyType">
//   <annotation>
//     <documentation>gml:PolygonPatchArrayPropertyType provides a container for an array of polygon patches.</documentation>
//   </annotation>
//   <complexContent>
//     <restriction base="gml:SurfacePatchArrayPropertyType">
//       <sequence minOccurs="0" maxOccurs="unbounded">
//         <element ref="gml:PolygonPatch"/>
//       </sequence>
//     </restriction>
//   </complexContent>
// </complexType>
// <element name="polygonPatches" type="gml:PolygonPatchArrayPropertyType" substitutionGroup="gml:patches"/>
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
  /// gml:PolygonPatchArrayPropertyType provides a container for an array of polygon patches.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("PolygonPatchArrayPropertyType")]
  public class PolygonPatchArrayPropertyType : SurfacePatchArrayPropertyType {

  }

}
