
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

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.Datums {

  /// <summary>
  /// Represents the second defining parameter of an <see cref="EllipsoidType"/> when the <see cref="EllipsoidType"/>
  /// is degenerate and is actually a sphere.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     In the context of GML and ISO 19111, an ellipsoid can be represented as a sphere when only a
  ///     single defining parameter is required:<br></br>
  ///     the semi-major axis, which degenerates into the radius of the sphere.
  ///   </para>
  ///   <para>
  ///     This class models the use of the <c>gml:isSphere</c> element, which signals that the reference body
  ///     is not an ellipsoid but a perfect sphere.
  ///   </para>
  ///   <para>
  ///     Example:
  ///     <code>
  ///       &lt;gml:secondDefiningParameter&gt;
  ///         &lt;gml:SecondDefiningParameter&gt;
  ///           &lt;gml:isSphere&gt;sphere&lt;/gml:isSphere&gt;
  ///         &lt;/gml:SecondDefiningParameter&gt;
  ///       &lt;/gml:secondDefiningParameter&gt;
  ///     </code>
  ///   </para>
  /// </remarks>
  public class IsSphereParameter : SecondDefiningParameter {

    #region Public Properties

    private SecondDefiningParameters _isSphere;

    /// <summary>
    /// Gets/Sets the enumeration value that indicates the <see cref="EllipsoidType"/> is a degenerate sphere.
    /// </summary>
    /// <remarks>
    /// The only valid value is <c>sphere</c>, which indicates that the <see cref="EllipsoidType">ellipsoid's</see>
    /// second parameter is not required and that the semi-major axis serves as the sphere’s radius.
    /// </remarks>
    //[XmlElement("isSphere", typeof(SecondDefiningParameters), Order = 0)]
    [JsonProperty("isSphere", Order = 0)]
    public SecondDefiningParameters IsSphere {
      get => _isSphere;
      set => SetProperty(ref _isSphere, value);
    }

    #endregion

  }

}
