
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 31/03/2025, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/datums.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="secondDefiningParameter">
//   <annotation>
//     <documentation>
//       gml:secondDefiningParameter is a property containing the definition of the second parameter that
//       defines the shape of an ellipsoid. An ellipsoid requires two defining parameters:
//       semi-major axis and inverse flattening or semi-major axis and semi-minor axis.
//       When the reference body is a sphere rather than an ellipsoid, only a single defining parameter is required,
//       namely the radius of the sphere; in that case, the semi-major axis "degenerates" into the radius of the sphere.
//       The inverseFlattening element contains the inverse flattening value of the ellipsoid.
//       This value is a scale factor (or ratio). It uses gml:LengthType with the restriction that
//       the unit of measure referenced by the uom attribute must be suitable for a scale factor,
//       such as percent, permil, or parts-per-million.
//       The semiMinorAxis element contains the length of the semi-minor axis of the ellipsoid.
//       When the isSphere element is included, the ellipsoid is degenerate and is actually a sphere.
//       The sphere is completely defined by the semi-major axis, which is the radius of the sphere.
//     </documentation>
//   </annotation>
//   <complexType>
//     <sequence>
//       <element ref="gml:SecondDefiningParameter"/>
//     </sequence>
//   </complexType>
// </element>  
// 
// <element name="SecondDefiningParameter">
//   <complexType>
//     <choice>
//       <element name="inverseFlattening" type="gml:MeasureType"/>
//       <element name="semiMinorAxis" type="gml:LengthType"/>
//       <element name="isSphere">
//         <simpleType>
//           <restriction base="string">
//             <enumeration value="sphere"/>
//           </restriction>
//         </simpleType>
//       </element>
//     </choice>
//   </complexType>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.Datums {

  /// <summary>
  /// The enumeration of second defining parameters.
  /// </summary>
  //[XmlType(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
  public enum SecondDefiningParameters {

    /// <summary>
    /// Sphere.
    /// </summary>
    [EnumMember(Value = "sphere")]
    //[XmlEnum("sphere")]
    Sphere,

  }

}
