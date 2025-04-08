
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
// <element name="ellipsoidalCS" type="gml:EllipsoidalCSPropertyType">
//   <annotation>
//     <documentation>
//       gml:ellipsoidalCS is an association role to the ellipsoidal coordinate system used by this CRS.
//     </documentation>
//   </annotation>
// </element>
// <element name="usesEllipsoidalCS" type="gml:EllipsoidalCSPropertyType" substitutionGroup="gml:ellipsoidalCS">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
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
// 
// <element name="GeodeticCRS" type="gml:GeodeticCRSType" substitutionGroup="gml:AbstractSingleCRS"/>
//
// <complexType name="GeodeticCRSType">
//   <annotation>
//     <documentation>gml:GeodeticCRS is a coordinate reference system based on a geodetic datum.</documentation>
//   </annotation>
//   <complexContent>
//     <extension base="gml:AbstractCRSType">
//       <sequence>
//         <choice>
//           <element ref="gml:ellipsoidalCS"/>
//           <element ref="gml:cartesianCS"/>
//           <element ref="gml:sphericalCS"/>
//         </choice>
//         <element ref="gml:geodeticDatum"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// 
// <complexType name="GeodeticCRSPropertyType">
//   <annotation>
//     <documentation>
//       gml:GeodeticCRSPropertyType is a property type for association roles to a geodetic
//       coordinate reference system, either referencing or containing the definition
//       of that reference system.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:GeodeticCRS"/>
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
  /// The <see cref="GeodeticCRSType"/> is a coordinate reference system based on a geodetic datum.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>GeodeticCRSType</c> ( /2005/gml/coordinateReferenceSystems.xsd )
  /// </remarks>
  //[XmlInclude(typeof(ML_GeodeticCRS_Type))] // GMX
  [IsoType("GeodeticCRSType", WrapperName = "GeodeticCRSPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GeodeticCRSType")]
  public class GeodeticCRSType : AbstractCRSType, ISingleCRS, IProjectedCoordinateReferenceSystem {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="GeodeticCRSType"/>.
    /// </summary>
    public GeodeticCRSType() {

    }

    #endregion

    #region Public Properties

    private IGeodeticCoordinateSystem _geodeticCoordinateSystem;

    /// <summary>
    /// Gets/Sets the <see cref="IGeodeticCoordinateSystem"/> associated with this coordinate reference system.
    /// </summary>
    //[XmlElement("cartesianCS", typeof(CartesianCSPropertyType), Order = 0)]
    //[XmlElement("ellipsoidalCS", typeof(EllipsoidalCSPropertyType), Order = 0)]
    //[XmlElement("sphericalCS", typeof(SphericalCSPropertyType), Order = 0)]
    public IGeodeticCoordinateSystem GeodeticCoordinateSystem {
      get => _geodeticCoordinateSystem;
      set => SetProperty(ref _geodeticCoordinateSystem, value);
    }

    private GeodeticDatumType _geodeticDatum;

    /// <summary>
    /// Gets/Sets an association role to the <see cref="GeodeticDatumType"/> used by this coordinate reference system.
    /// </summary>
    //[XmlElement(Order = 1)]
    [JsonProperty("geodeticDatum", Order = 1)]
    public GeodeticDatumType GeodeticDatum {
      get => _geodeticDatum;
      set => SetProperty(ref _geodeticDatum, value);
    }

    #endregion

    #region Public Overrides

    private TypeAssociationMetadata? _typeAssociationMetadata;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see> to a
    /// <see cref="GeodeticCRSType">geodetic coordinate reference system</see>.
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
