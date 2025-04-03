
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
// <complexType name="CircleType">
//   <complexContent>
//     <extension base="gml:ArcType"/>
//   </complexContent>
// </complexType>
// <element name="Circle" type="gml:CircleType" substitutionGroup="gml:Arc">
//   <annotation>
//     <documentation>
//       A Circle is an arc whose ends coincide to form a simple closed loop.
//       The three control points shall be distinct non-co-linear points for
//       the circle to be unambiguously defined. The arc is simply extended
//       past the third control point until the first control point is encountered.
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
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CircleType")]
  public class CircleType : ArcType {

  }

}
