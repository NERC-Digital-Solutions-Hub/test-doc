
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
// <complexType name="CircleByCenterPointType">
//   <complexContent>
//     <restriction base="gml:ArcByCenterPointType">
//       <sequence>
//         <choice>
//           <choice>
//             <element ref="gml:pos"/>
//             <element ref="gml:pointProperty"/>
//             <element ref="gml:pointRep"/>
//           </choice>
//           <element ref="gml:posList"/>
//           <element ref="gml:coordinates"/>
//         </choice>
//         <element name="radius" type="gml:LengthType"/>
//       </sequence>
//     </restriction>
//   </complexContent>
// </complexType>
// <element name="CircleByCenterPoint" type="gml:CircleByCenterPointType" substitutionGroup="gml:ArcByCenterPoint">
//   <annotation>
//     <documentation>
//       A gml:CircleByCenterPoint is an gml:ArcByCenterPoint with identical start and end angle to form a full circle.
//       Again, this representation can be used only in 2D.
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
  [JsonObject("CircleByCenterPointType")]
  public class CircleByCenterPointType : ArcByCenterPointType {

  }

}
