
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
// <complexType name="TrianglePatchArrayPropertyType">
//   <annotation>
//     <documentation>gml:TrianglePatchArrayPropertyType provides a container for an array of triangle patches.</documentation>
//   </annotation>
//   <complexContent>
//     <restriction base="gml:SurfacePatchArrayPropertyType">
//       <sequence minOccurs="0" maxOccurs="unbounded">
//         <element ref="gml:Triangle"/>
//       </sequence>
//     </restriction>
//   </complexContent>
// </complexType>
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
  /// gml:TrianglePatchArrayPropertyType provides a container for an array of triangle patches.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TrianglePatchArrayPropertyType")]
  public class TrianglePatchArrayPropertyType : SurfacePatchArrayPropertyType {

  }

}
