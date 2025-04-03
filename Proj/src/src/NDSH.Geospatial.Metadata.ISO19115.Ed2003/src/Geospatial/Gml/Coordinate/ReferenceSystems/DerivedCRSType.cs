
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
// <element name="baseCRS" type="gml:SingleCRSPropertyType">
//   <annotation>
//     <documentation>
//       gml:baseCRS is an association role to the coordinate reference system used by this derived CRS.
//     </documentation>
//   </annotation>
// </element>
// 
// <element name="derivedCRSType" type="gml:CodeWithAuthorityType">
//   <annotation>
//     <documentation>
//       The gml:derivedCRSType property describes the type of a derived coordinate reference system.
//       The required codeSpace attribute shall reference a source of information specifying the values and
//       meanings of all the allowed string values for this property.
//     </documentation>
//   </annotation>
// </element>
// 
// <element name="coordinateSystem" type="gml:CoordinateSystemPropertyType">
//   <annotation>
//     <documentation>An association role to the coordinate system used by this CRS.</documentation>
//   </annotation>
// </element>
// 
// <element name="usesCS" type="gml:CoordinateSystemPropertyType" substitutionGroup="gml:coordinateSystem">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <element name="DerivedCRS" type="gml:DerivedCRSType" substitutionGroup="gml:AbstractGeneralDerivedCRS">
//   <annotation>
//     <documentation>
//       gml:DerivedCRS is a single coordinate reference system that is defined by its coordinate
//       conversion from another single coordinate reference system known as the base CRS.
//       The base CRS can be a projected coordinate reference system, if this DerivedCRS is
//       used for a georectified grid coverage as described in ISO 19123, Clause 8.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="DerivedCRSType">
//   <complexContent>
//     <extension base="gml:AbstractGeneralDerivedCRSType">
//       <sequence>
//         <element ref="gml:baseCRS"/>
//         <element ref="gml:derivedCRSType"/>
//         <element ref="gml:coordinateSystem"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// 
// <complexType name="DerivedCRSPropertyType">
//   <annotation>
//     <documentation>
//       gml:DerivedCRSPropertyType is a property type for association roles to a non-projected
//       derived coordinate reference system, either referencing or containing the definition of
//       that reference system.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:DerivedCRS"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.BasicTypes;
using NDSH.Geospatial.Gml.Coordinate.Systems;
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
  /// The <see cref="DerivedCRSType"/> is a single coordinate reference system that is defined by
  /// its coordinate conversion from another single coordinate reference system known as the base CRS.
  /// The base CRS can be a projected coordinate reference system, if this <see cref="DerivedCRSType"/> is
  /// used for a geo-rectified grid coverage as described in ISO 19123, Clause 8.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>DerivedCRSType</c> ( /2005/gml/coordinateReferenceSystems.xsd )
  /// </remarks>
  //[XmlInclude(typeof(ML_DerivedCRS_Type))]
  [IsoType("DerivedCRSType", WrapperName = "DerivedCRSPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DerivedCRSType")]
  public class DerivedCRSType : AbstractGeneralDerivedCRSType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DerivedCRSType"/>.
    /// </summary>
    public DerivedCRSType() {
      _baseCRS = default; // new SingleCRSPropertyType();
      _derivedCRSType = default; // new CodeWithAuthorityType();
      _coordinateSystem = default; // new CoordinateSystemPropertyType();
    }

    #endregion

    #region Public Properties

    private AbstractSingleCRS _baseCRS;

    /// <summary>
    /// Gets/Sets the <see cref="BaseCRS"/> which is an association role
    /// to the coordinate reference system used by this <see cref="DerivedCRSType"/>.
    /// </summary>
    //[XmlElement(Order = 0)]
    [JsonProperty("baseCRS", Order = 0)]
    public AbstractSingleCRS BaseCRS {
      get => _baseCRS;
      set => SetProperty(ref _baseCRS, value);
    }

    private CodeWithAuthorityType _derivedCRSType;

    /// <summary>
    /// Gets/Sets the <see cref="DerivedCRSType"/> which describes the type of a derived coordinate reference system.
    /// The required <see cref="CodeWithAuthorityType.CodeSpace"/> (codeSpace attribute) shall reference a source of
    /// information specifying the values and meanings of all the allowed string values for this property.
    /// </summary>
    //[XmlElement(Order = 1)]
    [JsonProperty("derivedCRSType", Order = 1)]
    // HACK: Renamed the property to DerivedCrsType (instead of DerivedCRSType) to avoid Compiler Error CS0542
    // 'user-defined type' : member names cannot be the same as their enclosing type
    // https://learn.microsoft.com/en-us/dotnet/csharp/misc/cs0542?f1url=%3FappId%3Droslyn%26k%3Dk(CS0542)
    public CodeWithAuthorityType DerivedCrsType {
      get => _derivedCRSType;
      set => SetProperty(ref _derivedCRSType, value);
    }

    private AbstractCoordinateSystemType _coordinateSystem;

    /// <summary>
    /// Gets/Sets an association role to the coordinate system used by this coordinate reference system.
    /// </summary>
    //[XmlElement(Order = 2)]
    [JsonProperty("coordinateSystem", Order = 2)]
    public AbstractCoordinateSystemType CoordinateSystem {
      get => _coordinateSystem;
      set => SetProperty(ref _coordinateSystem, value);
    }

    #endregion

    #region Public Overrides

    private TypeAssociationMetadata? _typeAssociationMetadata;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see> to a
    /// non-projected <see cref="DerivedCRSType">derived coordinate reference system</see>.
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
