
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
// <simpleType name="KnotTypesType">
//   <annotation>
//     <documentation>This enumeration type specifies values for the knots’ type (see ISO 19107:2003, 6.4.25).</documentation>
//   </annotation>
//   <restriction base="string">
//     <enumeration value="uniform"/>
//     <enumeration value="quasiUniform"/>
//     <enumeration value="piecewiseBezier"/>
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
  /// This enumeration type specifies values for the knots� type (see ISO 19107:2003, 6.4.25).
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  public enum KnotTypesType {
    uniform,
    quasiUniform,
    piecewiseBezier,
  }
}
