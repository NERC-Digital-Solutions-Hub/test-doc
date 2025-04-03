
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 01/04/2025, @gisvlasta
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
// Example:
// --------------------------------------------------------------------------------
// <gml:Ellipsoid gml:id="ellipsoid2" xmlns:gml="http://www.opengis.net/gml">
//   <gml:semiMajorAxis uom="m">6378137.0</gml:semiMajorAxis>
//   <gml:secondDefiningParameter>
//     <gml:SecondDefiningParameter>
//       <gml:semiMinorAxis uom="m">6356752.3142</gml:semiMinorAxis>
//     </gml:SecondDefiningParameter>
//   </gml:secondDefiningParameter>
// </gml:Ellipsoid>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Measures;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.Datums {

  /// <summary>
  /// Represents the second defining parameter of an <see cref="EllipsoidType"/> using the semi-minor axis value.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     According to ISO 19115 and the GML schema, an <see cref="EllipsoidType"/> requires two parameters:
  ///     <br></br>
  ///     the semi-major axis and either the inverse flattening or the semi-minor axis.
  ///   </para>
  ///   <para>
  ///     This class models the case where the second parameter is the semi-minor axis,
  ///     which defines the shorter axis of the ellipsoid orthogonal to the semi-major axis.
  ///     This is typically used when defining the shape of an ellipsoid through direct lengths.
  ///   </para>
  ///   <para>
  ///     Example:
  ///     <code>
  ///       &lt;gml:secondDefiningParameter&gt;
  ///         &lt;gml:SecondDefiningParameter&gt;
  ///           &lt;gml:semiMinorAxis uom="m"&gt;6356752.3142&lt;/gml:semiMinorAxis&gt;
  ///         &lt;/gml:SecondDefiningParameter&gt;
  ///       &lt;/gml:secondDefiningParameter&gt;
  ///     </code>
  ///   </para>
  /// </remarks>
  public class SemiMinorAxisParameter : SecondDefiningParameter {

    #region Public Properties

    private LengthType _semiMinorAxis;

    /// <summary>
    /// Gets/Sets the length of the semi-minor axis of the <see cref="EllipsoidType"/>.
    /// </summary>
    /// <remarks>
    /// The unit of measure (<c>uom</c>) must be suitable for a physical length, such as meters or feet.
    /// </remarks>
    //[XmlElement("semiMinorAxis", typeof(LengthType), Order = 0)]
    [JsonProperty("semiMinorAxis", Order = 0)]
    public LengthType SemiMinorAxis {
      get => _semiMinorAxis;
      set => SetProperty(ref _semiMinorAxis, value);
    }

    #endregion

  }

}
