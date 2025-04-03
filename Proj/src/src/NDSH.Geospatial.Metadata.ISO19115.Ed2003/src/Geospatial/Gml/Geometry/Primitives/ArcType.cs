
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
// <complexType name="ArcType">
//   <complexContent>
//     <restriction base="gml:ArcStringType">
//       <sequence>
//         <choice>
//           <choice minOccurs="3" maxOccurs="3">
//             <element ref="gml:pos"/>
//             <element ref="gml:pointProperty"/>
//             <element ref="gml:pointRep"/>
//           </choice>
//           <element ref="gml:posList"/>
//           <element ref="gml:coordinates"/>
//         </choice>
//       </sequence>
//       <attribute name="numArc" type="integer" fixed="1"/>
//     </restriction>
//   </complexContent>
// </complexType>
// <element name="Arc" type="gml:ArcType" substitutionGroup="gml:ArcString">
//   <annotation>
//     <documentation>
//       An Arc is an arc string with only one arc unit, i.e. three control points including the start and end point.
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


  //[XmlInclude(typeof(CircleType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ArcType")]
  public class ArcType : ArcStringType {

  }

}
