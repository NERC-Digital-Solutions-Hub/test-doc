
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
// <complexType name="ArcByBulgeType">
//   <complexContent>
//     <restriction base="gml:ArcStringByBulgeType">
//       <sequence>
//         <choice>
//           <choice minOccurs="2" maxOccurs="2">
//             <element ref="gml:pos"/>
//             <element ref="gml:pointProperty"/>
//             <element ref="gml:pointRep"/>
//           </choice>
//           <element ref="gml:posList"/>
//           <element ref="gml:coordinates"/>
//         </choice>
//         <element name="bulge" type="double"/>
//         <element name="normal" type="gml:VectorType"/>
//       </sequence>
//       <attribute name="numArc" type="integer" fixed="1"/>
//     </restriction>
//   </complexContent>
// </complexType>
// <element name="ArcByBulge" type="gml:ArcByBulgeType" substitutionGroup="gml:ArcStringByBulge">
//   <annotation>
//     <documentation>
//       An ArcByBulge is an arc string with only one arc unit, i.e. two control points, one bulge and one normal vector.
//       As arc is an arc string consisting of a single arc, the attribute “numArc” is fixed to "1".
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
  [XmlType("ArcByBulgeType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ArcByBulgeType")]
  public class ArcByBulgeType : ArcStringByBulgeType {

  }

}
