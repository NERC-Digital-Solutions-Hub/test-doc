
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 26/03/2025, @gisvlasta
// History           : 31/03/2025, @gisvlasta - Changed TypeAssociation override.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/datums.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="primeMeridian" type="gml:PrimeMeridianPropertyType">
//   <annotation>
//     <documentation>
//       gml:primeMeridian is an association role to the prime meridian used by this geodetic datum.
//     </documentation>
//   </annotation>
// </element>
// <element name="usesPrimeMeridian" type="gml:PrimeMeridianPropertyType" substitutionGroup="gml:primeMeridian">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <element name="ellipsoid" type="gml:EllipsoidPropertyType">
//   <annotation>
//     <documentation>
//       gml:ellipsoid is an association role to the ellipsoid used by this geodetic datum.
//     </documentation>
//   </annotation>
// </element>
// <element name="usesEllipsoid" type="gml:EllipsoidPropertyType" substitutionGroup="gml:ellipsoid">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <element name="GeodeticDatum" type="gml:GeodeticDatumType" substitutionGroup="gml:AbstractDatum">
//   <annotation>
//     <documentation>
//       gml:GeodeticDatum is a geodetic datum defines the precise location and orientation in 3-dimensional space of a
//       defined ellipsoid (or sphere), or of a Cartesian coordinate system centered in this ellipsoid (or sphere).
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="GeodeticDatumType">
//   <complexContent>
//     <extension base="gml:AbstractDatumType">
//       <sequence>
//         <element ref="gml:primeMeridian"/>
//         <element ref="gml:ellipsoid"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// 
// <complexType name="GeodeticDatumPropertyType">
//   <annotation>
//     <documentation>
//       gml:GeodeticDatumPropertyType is a property type for association roles to a geodetic datum,
//       either referencing or containing the definition of that datum.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:GeodeticDatum"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Coordinate.Systems;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.Datums {

  /// <summary>
  /// The <see cref="GeodeticDatumType"/> defines the precise location and orientation in 3-dimensional space of a
  /// defined ellipsoid (or sphere), or of a <see cref="CartesianCSType"/> centered in this ellipsoid (or sphere).
  /// </summary>
  /// <remarks>
  /// Maps to: <c>GeodeticDatumType</c> ( /2005/gml/datums.xsd )
  /// </remarks>
  //[XmlInclude(typeof(ML_GeodeticDatum_Type))] // GMX
  [IsoType("GeodeticDatumType", WrapperName = "GeodeticDatumPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GeodeticDatumType")]
  public class GeodeticDatumType : AbstractDatumType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="GeodeticDatumType"/>.
    /// </summary>
    public GeodeticDatumType() {

    }

    #endregion

    #region Public Properties

    private PrimeMeridianType _primeMeridian;

    /// <summary>
    /// Gets/Sets an association role to the <see cref="PrimeMeridianType"/>
    /// used by this <see cref="GeodeticDatumType"/>.
    /// </summary>
    //[XmlElement(Order = 0)]
    [JsonProperty("primeMeridian", Order = 0)]
    public PrimeMeridianType PrimeMeridian {
      get => _primeMeridian;
      set => SetProperty(ref _primeMeridian, value);
    }

    private EllipsoidType _ellipsoid;

    /// <summary>
    /// Gets/Sets an association role to the <see cref="EllipsoidType"/> used by this <see cref="GeodeticDatumType"/>.
    /// </summary>
    //[XmlElement(Order = 1)]
    [JsonProperty("ellipsoid", Order = 1)]
    public EllipsoidType Ellipsoid {
      get => _ellipsoid;
      set => SetProperty(ref _ellipsoid, value);
    }

    #endregion

    #region Public Overrides

    private TypeAssociationMetadata? _typeAssociationMetadata;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see> to a <see cref="GeodeticDatumType"/>.
    /// </summary>
    /// <remarks>
    /// Only <see cref="TypeAssociationMetadata.Association">Associations</see> are allowed.
    /// <see cref="TypeAssociationMetadata.Reference">References</see> and
    /// <see cref="TypeAssociationMetadata.NilReason">Nil Reasons</see> are explicitly disallowed in this context.
    /// </remarks>
    /// <exception cref="InvalidOperationException">
    /// Thrown when an <see cref="AssociationEntity"/> is used, which is not allowed.
    /// </exception>
    /// <exception cref="ArgumentException">
    /// Thrown when an unsupported subtype of <see cref="TypeAssociationMetadata"/> is provided.
    /// </exception>
    public override TypeAssociationMetadata? TypeAssociation {
      get => _typeAssociationMetadata;
      set {
        _typeAssociationMetadata = value switch {
          null => null,
          TypeAssociationMetadata.Association => value,
          TypeAssociationMetadata.Reference => throw new InvalidOperationException(
            $"{nameof(AssociationEntity)} is not allowed in this context." // RESOURCE
          ),
          TypeAssociationMetadata.NilReason => throw new InvalidOperationException(
            $"{nameof(AssociationEntity)} is not allowed in this context." // RESOURCE
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
