
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 25/03/2025, @gisvlasta
// History           : 30/03/2025, @gisvlasta - Changed the override of the TypeAssociation property
//                                              inherited from AbstractCRSType.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/coordinateReferenceSystems.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="cartesianCS" type="gml:CartesianCSPropertyType">
//   <annotation>
//     <documentation>
//       gml:cartesianCS is an association role to the Cartesian coordinate system used by this CRS.
//     </documentation>
//   </annotation>
// </element>
// <element name="usesCartesianCS" type="gml:CartesianCSPropertyType" substitutionGroup="gml:cartesianCS">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <element name="sphericalCS" type="gml:SphericalCSPropertyType">
//   <annotation>
//     <documentation>
//       gml:sphericalCS is an association role to the spherical coordinate system used by this CRS.
//     </documentation>
//   </annotation>
// </element>
// <element name="usesSphericalCS" type="gml:SphericalCSPropertyType" substitutionGroup="gml:sphericalCS">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <element name="geodeticDatum" type="gml:GeodeticDatumPropertyType">
//   <annotation>
//     <documentation>
//       gml:geodeticDatum is an association role to the geodetic datum used by this CRS.
//     </documentation>
//   </annotation>
// </element>
// <element name="usesGeodeticDatum" type="gml:GeodeticDatumPropertyType" substitutionGroup="gml:geodeticDatum">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <element name="GeocentricCRS" type="gml:GeocentricCRSType" substitutionGroup="gml:AbstractSingleCRS">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <complexType name="GeocentricCRSType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <complexContent>
//     <extension base="gml:AbstractCRSType">
//       <sequence>
//         <choice>
//           <element ref="gml:usesCartesianCS"/>
//           <element ref="gml:usesSphericalCS"/>
//         </choice>
//         <element ref="gml:usesGeodeticDatum"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// 
// <complexType name="GeocentricCRSPropertyType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:GeocentricCRS"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.BasicTypes;
using NDSH.Geospatial.Gml.Coordinate.Datums;
using NDSH.Geospatial.Gml.Coordinate.Systems;
using NDSH.Geospatial.Gml.ReferenceSystems;
using NDSH.Geospatial.Metadata;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.ReferenceSystems {

  /// <summary>
  /// The <see cref="GeocentricCRSType"/> is defined by a geodetic datum and
  /// using either a <see cref="CartesianCSType"/> or <see cref="SphericalCSType"/>.
  /// </summary>
  /// <remarks>
  /// <para>
  /// A <see cref="GeocentricCRSType"/> uses a three-dimensional <see cref="CartesianCSType"/> or
  /// <see cref="SphericalCSType"/> to describe positions relative to the center of mass of the Earth.
  /// </para>
  /// <para>
  /// Maps to: <c>GeocentricCRSType</c> ( /2005/gml/coordinateReferenceSystems.xsd )
  /// </para>
  /// <para>"Marked 'deprecated' in /gml/coordinateReferenceSystems.xsd"</para>
  /// </remarks>
  [Obsolete("Marked 'deprecated' in /gml/coordinateReferenceSystems.xsd")]
  [IsoType("GeocentricCRSType", WrapperName = "GeocentricCRSPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GeocentricCRSType")]
  public class GeocentricCRSType : AbstractCRSType, ISingleCRS {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="GeocentricCRSType"/>.
    /// </summary>
    public GeocentricCRSType() {

    }

    #endregion

    #region Public Properties

    private IGeocentricCoordinateSystem _geocentricCoordinateSystem;

    /// <summary>
    /// Gets/Sets the <see cref="IGeocentricCoordinateSystem"/> associated with this coordinate reference system.
    /// </summary>
    //[XmlElement("usesCartesianCS", typeof(CartesianCSPropertyType), Order = 0)]
    //[XmlElement("usesSphericalCS", typeof(SphericalCSPropertyType), Order = 0)]
    public IGeocentricCoordinateSystem GeocentricCoordinateSystem {
      get => _geocentricCoordinateSystem;
      set => SetProperty(ref _geocentricCoordinateSystem, value);
    }

    private GeodeticDatumType _geodeticDatum;

    /// <summary>
    /// Gets/Sets an association role to the <see cref="GeodeticDatumType"/> used by this coordinate reference system.
    /// </summary>
    //[XmlElement(Order = 1)]
    [JsonProperty("geodeticDatum", Order = 1)]
    //[JsonProperty("usesGeodeticDatum", Order = 1)]
    public GeodeticDatumType GeodeticDatum {
      get => _geodeticDatum;
      set => SetProperty(ref _geodeticDatum, value);
    }

    #endregion

    #region Public Overrides

    private TypeAssociationMetadata? _typeAssociationMetadata;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see> to a
    /// <see cref="GeocentricCRSType">geocentric coordinate reference system</see>.
    /// </summary>
    public override TypeAssociationMetadata? TypeAssociation {
      get => _typeAssociationMetadata;
      set {
        _typeAssociationMetadata = value switch {
          null => null,
          TypeAssociationMetadata.Association => value,
          TypeAssociationMetadata.Reference => throw new InvalidOperationException(
            $"{nameof(ReferenceEntity)} is not allowed in this context. Only {nameof(AssociationEntity)} is supported." // RESOURCE
          ),
          TypeAssociationMetadata.NilReason => throw new InvalidOperationException(
            $"{nameof(NilReasonEntity)} is not allowed in this context. Only {nameof(AssociationEntity)} is supported." // RESOURCE
          ),
          _ => throw new ArgumentException(
            $"Unsupported subtype of {nameof(TypeAssociationMetadata)}: {value.GetType().Name}" // RESOURCE
          ),
        };
      }
    }

    #endregion

  }

}
