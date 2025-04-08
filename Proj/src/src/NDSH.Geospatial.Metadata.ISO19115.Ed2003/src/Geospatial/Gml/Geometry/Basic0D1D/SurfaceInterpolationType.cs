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
// <simpleType name="SurfaceInterpolationType">
//   <annotation>
//     <documentation>
//       gml:SurfaceInterpolationType is a list of codes that may be used to identify
//       the interpolation mechanisms specified by an application schema.
//     </documentation>
//   </annotation>
//   <restriction base="string">
//     <enumeration value="none"/>
//     <enumeration value="planar"/>
//     <enumeration value="spherical"/>
//     <enumeration value="elliptical"/>
//     <enumeration value="conic"/>
//     <enumeration value="tin"/>
//     <enumeration value="parametricCurve"/>
//     <enumeration value="polynomialSpline"/>
//     <enumeration value="rationalSpline"/>
//     <enumeration value="triangulatedSpline"/>
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

namespace NDSH.Geospatial.Gml.Geometry.Basic0D1D {

  /// <summary>
  /// SurfaceInterpolationType is a list of codes that may be used to identify
  /// the interpolation mechanisms specified by an application schema.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  public enum SurfaceInterpolationType {
    none,
    planar,
    spherical,
    elliptical,
    conic,
    tin,
    parametricCurve,
    polynomialSpline,
    rationalSpline,
    triangulatedSpline,
  }

}
