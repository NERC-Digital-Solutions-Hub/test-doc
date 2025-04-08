
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
// <simpleType name="CurveInterpolationType">
//   <annotation>
//     <documentation>
//       gml:CurveInterpolationType is a list of codes that may be used to identify
//       the interpolation mechanisms specified by an application schema.
//     </documentation>
//   </annotation>
//   <restriction base="string">
//     <enumeration value="linear"/>
//     <enumeration value="geodesic"/>
//     <enumeration value="circularArc3Points"/>
//     <enumeration value="circularArc2PointWithBulge"/>
//     <enumeration value="circularArcCenterPointWithRadius"/>
//     <enumeration value="elliptical"/>
//     <enumeration value="clothoid"/>
//     <enumeration value="conic"/>
//     <enumeration value="polynomialSpline"/>
//     <enumeration value="cubicSpline"/>
//     <enumeration value="rationalSpline"/>
//   </restriction>
// </simpleType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Primitives {

  /// <summary>
  /// gml:CurveInterpolationType is a list of codes that may be used to identify the interpolation mechanisms specified by an application schema.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  public enum CurveInterpolationType {
    linear,
    geodesic,
    circularArc3Points,
    circularArc2PointWithBulge,
    circularArcCenterPointWithRadius,
    elliptical,
    clothoid,
    conic,
    polynomialSpline,
    cubicSpline,
    rationalSpline,
  }

}
