
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 03/02/2023, @gisvlasta
// History           : 01/04/2025, @gisvlasta - Added IsoTypeAttribute, updated code, documentation and header.
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
// 
// --------------------------------------------------------------------------------
// Examples:
// --------------------------------------------------------------------------------
// <gml:Ellipsoid gml:id="ellipsoid1" xmlns:gml="http://www.opengis.net/gml">
//   <gml:semiMajorAxis uom="m">6378137.0</gml:semiMajorAxis>
//   <gml:secondDefiningParameter>
//     <gml:SecondDefiningParameter>
//       <gml:inverseFlattening uom="ppm">298257.223563</gml:inverseFlattening>
//     </gml:SecondDefiningParameter>
//   </gml:secondDefiningParameter>
// </gml:Ellipsoid>
// 
// <gml:Ellipsoid gml:id="ellipsoid2" xmlns:gml="http://www.opengis.net/gml">
//   <gml:semiMajorAxis uom="m">6378137.0</gml:semiMajorAxis>
//   <gml:secondDefiningParameter>
//     <gml:SecondDefiningParameter>
//       <gml:semiMinorAxis uom="m">6356752.3142</gml:semiMinorAxis>
//     </gml:SecondDefiningParameter>
//   </gml:secondDefiningParameter>
// </gml:Ellipsoid>
// 
// <gml:Ellipsoid gml:id="ellipsoid3" xmlns:gml="http://www.opengis.net/gml">
//   <gml:semiMajorAxis uom="m">6371000.0</gml:semiMajorAxis>
//   <gml:secondDefiningParameter>
//     <gml:SecondDefiningParameter>
//       <gml:isSphere>sphere</gml:isSphere>
//     </gml:SecondDefiningParameter>
//   </gml:secondDefiningParameter>
// </gml:Ellipsoid>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Database.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.Datums {

  /// <summary>
  ///   <para>
  ///     The <see cref="SecondDefiningParameter"/> is a property containing the definition of the second parameter that
  ///     defines the shape of an ellipsoid. An ellipsoid requires two defining parameters:
  ///     <list type="number">
  ///       <item>Semi-major axis and Inverse flattening</item>
  ///       <item>Semi-major axis and Semi-minor axis</item>
  ///     </list>
  ///     When the reference body is a sphere rather than an <see cref="EllipsoidType"/>,
  ///     only a single defining parameter is required, namely the radius of the sphere;
  ///     in that case, the semi-major axis "degenerates" into the radius of the sphere.
  ///   </para>
  ///   <para>
  ///     The <c>inverseFlattening</c> element contains the inverse flattening value of the <see cref="EllipsoidType"/>.
  ///     This value is a scale factor (or ratio). It uses <c>gml:LengthType</c> with the restriction that
  ///     the unit of measure referenced by the uom attribute must be suitable for a scale factor,
  ///     such as percent, permil, or parts-per-million.
  ///   </para>
  ///   <para>
  ///     The <c>semiMinorAxis</c> element contains the length of the semi-minor axis of the ellipsoid.
  ///     When the isSphere element is included, the ellipsoid is degenerate and is actually a sphere.
  ///     The sphere is completely defined by the semi-major axis, which is the radius of the sphere.
  ///   </para>
  ///   <para>
  ///     Maps to: <c>SecondDefiningParameter</c> ( /2005/gml/datums.xsd )
  ///   </para>
  /// </summary>
  [IsoType(
    "SecondDefiningParameter",
    WrapperName = "secondDefiningParameter",
    IsAbstract = true,
    IsoType = IsoTypes.Element
  )]
  //[XmlType("SecondDefiningParameter", AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
  [JsonObject("SecondDefiningParameter")]
  public abstract class SecondDefiningParameter : ObservableDbEntity {

  }

}
