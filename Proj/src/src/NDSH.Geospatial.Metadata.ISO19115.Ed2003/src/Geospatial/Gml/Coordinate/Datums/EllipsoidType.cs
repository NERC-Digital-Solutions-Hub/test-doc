
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 31/01/2023, @gisvlasta
// History           : 26/03/2025, @gisvlasta - Implemented IAssociated interface, updated code and documentation.
//                   : 31/03/2025, @gisvlasta - Updated the SecondDefiningParameter property code and documentation.
//                   : 01/04/2025, @gisvlasta - Updated constructor.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/datums.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="semiMajorAxis" type="gml:MeasureType">
//   <annotation>
//     <documentation>
//       gml:semiMajorAxis specifies the length of the semi-major axis of the ellipsoid, with its units.
//       Uses the MeasureType with the restriction that the unit of measure referenced by uom
//       must be suitable for a length, such as metres or feet.
//     </documentation>
//   </annotation>
// </element>
// 
// <element name="secondDefiningParameter">
//   <annotation>
//     <documentation>
//       gml:secondDefiningParameter is a property containing the definition of the second parameter that defines
//       the shape of an ellipsoid. An ellipsoid requires two defining parameters: semi-major axis and
//       inverse flattening or semi-major axis and semi-minor axis. When the reference body is a sphere
//       rather than an ellipsoid, only a single defining parameter is required, namely the radius of the sphere;
//       in that case, the semi-major axis "degenerates" into the radius of the sphere.
//       The inverseFlattening element contains the inverse flattening value of the ellipsoid.
//       This value is a scale factor (or ratio). It uses gml:LengthType with the restriction that
//       the unit of measure referenced by the uom attribute must be suitable for a scale factor, such as
//       percent, permil, or parts-per-million. The semiMinorAxis element contains the length of
//       the semi-minor axis of the ellipsoid. When the isSphere element is included, the ellipsoid is degenerate and
//       is actually a sphere. The sphere is completely defined by the semi-major axis,
//       which is the radius of the sphere.
//     </documentation>
//   </annotation>
//   <complexType>
//     <sequence>
//       <element ref="gml:SecondDefiningParameter"/>
//     </sequence>
//   </complexType>
// </element>
// 
// <element name="Ellipsoid" type="gml:EllipsoidType" substitutionGroup="gml:Definition">
//   <annotation>
//     <documentation>
//       A gml:Ellipsoid is a geometric figure that may be used to describe the approximate shape of the earth.
//       In mathematical terms, it is a surface formed by the rotation of an ellipse about its minor axis.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="EllipsoidType">
//   <complexContent>
//     <extension base="gml:IdentifiedObjectType">
//       <sequence>
//         <element ref="gml:semiMajorAxis"/>
//         <element ref="gml:secondDefiningParameter"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// 
// <complexType name="EllipsoidPropertyType">
//   <annotation>
//     <documentation>
//       gml:EllipsoidPropertyType is a property type for association roles to an ellipsoid,
//       either referencing or containing the definition of that ellipsoid.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:Ellipsoid"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Measures;
using NDSH.Geospatial.Gml.ReferenceSystems;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.Datums {

  /// <summary>
  /// The <see cref="EllipsoidType"/> is a geometric figure that may be used to describe the approximate shape
  /// of the earth. In mathematical terms, it is a surface formed by the rotation of an ellipse about its minor axis.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>EllipsoidType</c> ( /2005/gml/datums.xsd )
  /// </remarks>
  //[XmlInclude(typeof(ML_Ellipsoid_Type))] // GMX
  [IsoType("EllipsoidType", WrapperName = "EllipsoidPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlType("EllipsoidType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("EllipsoidType")]
  public class EllipsoidType : IdentifiedObjectType, IAssociated {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EllipsoidType"/>.
    /// </summary>
    public EllipsoidType() {

    }

    #endregion

    #region Public Properties

    private MeasureType _semiMajorAxis;

    /// <summary>
    /// The <see cref="SemiMajorAxis"/> specifies the length of the semi-major axis of the ellipsoid, with its units.
    /// It uses the <see cref="MeasureType"/> with the restriction that the unit of measure referenced by uom
    /// must be suitable for a length, such as metres or feet.
    /// </summary>
    //[XmlElement("semiMajorAxis", Order = 0)]
    [JsonProperty("semiMajorAxis", Order = 0)]
    public MeasureType SemiMajorAxis {
      get => _semiMajorAxis;
      set => SetProperty(ref _semiMajorAxis, value);
    }

    private SecondDefiningParameter _secondDefiningParameter;

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
    /// </summary>
    //[XmlElement("secondDefiningParameter", Order = 1)]
    [JsonProperty("secondDefiningParameter", Order = 1)]
    public SecondDefiningParameter SecondDefiningParameter {
      get => _secondDefiningParameter;
      set => SetProperty(ref _secondDefiningParameter, value);
    }

    #endregion

    #region Public Overrides

    private AssociationEntity? _association;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see> to an <see cref="EllipsoidType"/>.
    /// </summary>
    public AssociationEntity? Association {
      get => _association;
      set => SetProperty(ref _association, value);
    }

    #endregion

  }

}
