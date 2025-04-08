
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
// <complexType name="BezierType">
//   <complexContent>
//     <restriction base="gml:BSplineType">
//       <sequence>
//         <choice>
//           <choice minOccurs="0" maxOccurs="unbounded">
//             <element ref="gml:pos"/>
//             <element ref="gml:pointProperty"/>
//             <element ref="gml:pointRep"/>
//           </choice>
//           <element ref="gml:posList"/>
//           <element ref="gml:coordinates"/>
//         </choice>
//         <element name="degree" type="nonNegativeInteger"/>
//         <element name="knot" type="gml:KnotPropertyType" minOccurs="2" maxOccurs="2"/>
//       </sequence>
//       <attribute name="interpolation" type="gml:CurveInterpolationType" fixed="polynomialSpline"/>
//       <attribute name="isPolynomial" type="boolean" fixed="true"/>
//       <attribute name="knotType" type="gml:KnotTypesType" use="prohibited"/>
//     </restriction>
//   </complexContent>
// </complexType>
// <element name="Bezier" type="gml:BezierType" substitutionGroup="gml:BSpline">
//   <annotation>
//     <documentation>
//       Bezier curves are polynomial splines that use Bezier or Bernstein polynomials for interpolation purposes.
//       It is a special case of the B-Spline curve with two knots.
//       degree shall be the degree of the polynomial used for interpolation in this spline.
//       knot shall be the sequence of distinct knots used to define the spline basis functions.
//       interpolation is fixed as "polynomialSpline".
//       isPolynomial is fixed as “true”.
//       knotType is not relevant for Bezier curve segments.
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
  [JsonObject("BezierType")]
  public class BezierType : BSplineType {

  }

}
