
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
// <element name="GeographicCRS" type="gml:GeographicCRSType" substitutionGroup="gml:AbstractSingleCRS">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <complexType name="GeographicCRSType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <complexContent>
//     <extension base="gml:AbstractCRSType">
//       <sequence>
//         <element ref="gml:usesEllipsoidalCS"/>
//         <element ref="gml:usesGeodeticDatum"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// 
// <complexType name="GeographicCRSPropertyType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:GeographicCRS"/>
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
  /// The <see cref="GeographicCRSType"/> uses an ellipsoidal coordinate system
  /// and is associated with a geodetic datum. A <see cref="GeographicCRSType"/>
  /// defines positions on or near the Earth's surface using angular coordinates
  /// such as latitude and longitude.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>GeographicCRSType</c> (/2005/gml/coordinateReferenceSystems.xsd)
  /// <para>"Marked 'deprecated' in /gml/coordinateReferenceSystems.xsd"</para>
  /// </remarks>
  [Obsolete("Marked 'deprecated' in /gml/coordinateReferenceSystems.xsd")]
  [IsoType("GeographicCRSType", WrapperName = "GeographicCRSPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GeographicCRSType")]
  public class GeographicCRSType : AbstractCRSType, ISingleCRS, IProjectedCoordinateReferenceSystem {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="GeographicCRSType"/>.
    /// </summary>
    public GeographicCRSType() {

    }

    #endregion

    #region Public Properties

    private EllipsoidalCSType _ellipsoidalCS;

    /// <summary>
    /// Gets/Sets an association role to the <see cref="EllipsoidalCSType"/> used by this coordinate reference system.
    /// </summary>
    //[XmlElement(Order = 0)]
    [JsonProperty("ellipsoidalCS", Order = 0)]
    //[JsonProperty("usesEllipsoidalCS", Order = 0)]
    public EllipsoidalCSType EllipsoidalCS {
      get => _ellipsoidalCS;
      set => SetProperty(ref _ellipsoidalCS, value);
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
    /// <see cref="GeographicCRSType">geographic coordinate reference system</see>.
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
