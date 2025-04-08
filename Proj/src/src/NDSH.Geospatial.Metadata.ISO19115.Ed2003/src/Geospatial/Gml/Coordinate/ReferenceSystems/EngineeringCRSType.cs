
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 18/03/2025, @gisvlasta
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
// <element name="coordinateSystem" type="gml:CoordinateSystemPropertyType">
//   <annotation>
//     <documentation>An association role to the coordinate system used by this CRS.</documentation>
//   </annotation>
// </element>
// <element name="engineeringDatum" type="gml:EngineeringDatumPropertyType">
//   <annotation>
//     <documentation>
//       gml:engineeringDatum is an association role to the engineering datum used by this CRS.
//     </documentation>
//   </annotation>
// </element>
// 
// <element name="usesEngineeringDatum"
//          type="gml:EngineeringDatumPropertyType" substitutionGroup="gml:engineeringDatum">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <element name="EngineeringCRS" type="gml:EngineeringCRSType" substitutionGroup="gml:AbstractSingleCRS">
//   <annotation>
//     <documentation>
//       gml:EngineeringCRS is a contextually local coordinate reference system which can be divided
//       into two broad categories:
//           -  earth-fixed systems applied to engineering activities on or near the surface of the earth;
//           -  CRSs on moving platforms such as road vehicles, vessels, aircraft, or spacecraft,
//              see ISO 19111 8.3.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="EngineeringCRSType">
//   <complexContent>
//     <extension base="gml:AbstractCRSType">
//       <sequence>
//         <element ref="gml:coordinateSystem"/>
//         <element ref="gml:engineeringDatum"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// 
// <complexType name="EngineeringCRSPropertyType">
//   <annotation>
//     <documentation>
//       gml:EngineeringCRSPropertyType is a property type for association roles to an engineering
//       coordinate reference system, either referencing or containing the definition
//       of that reference system.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:EngineeringCRS"/>
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
  /// The <see cref="EngineeringCRSType"/> is a contextually local coordinate reference system
  /// which can be divided into two broad categories:
  /// <list type="bullet">
  ///   <item>
  ///     <term>Earth-fixed Systems</term>
  ///     <description>They are applied to engineering activities on or near the surface of the earth</description>
  ///   </item>
  ///   <item>CRSs on moving platforms</item>
  ///   <description>They include road vehicles, vessels, aircraft, or spacecraft, (see ISO 19111 8.3).</description>
  /// </list>
  /// </summary>
  /// <remarks>
  /// Maps to: <c>EngineeringCRSType</c> ( /2005/gml/coordinateReferenceSystems.xsd )
  /// </remarks>
  [IsoType("EngineeringCRSType", WrapperName = "EngineeringCRSPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlInclude(typeof(ML_EngineeringCRS_Type))]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("EngineeringCRSType")]
  public class EngineeringCRSType : AbstractCRSType, ISingleCRS {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EngineeringCRSType"/>.
    /// </summary>
    public EngineeringCRSType() {

    }

    #endregion

    #region Public Properties

    private AbstractCoordinateSystemType _coordinateSystem;

    /// <summary>
    /// Gets/Sets the coordinate system associated with the coordinate reference system.
    /// </summary>
    //[XmlElement(Order = 0)]
    [JsonProperty("coordinateSystem", Order = 0)]
    public AbstractCoordinateSystemType CoordinateSystem {
      get => _coordinateSystem;
      set => SetProperty(ref _coordinateSystem, value);
    }

    private EngineeringDatumType _engineeringDatum;

    /// <summary>
    /// Gets/Sets an association role to the <see cref="EngineeringDatumType"/>
    /// used by this coordinate reference system.
    /// </summary>
    //[XmlElement(Order = 1)]
    [JsonProperty("engineeringDatum", Order = 1)]
    public EngineeringDatumType EngineeringDatum {
      get => _engineeringDatum;
      set => SetProperty(ref _engineeringDatum, value);
    }

    #endregion

    #region Public Overrides

    private TypeAssociationMetadata? _typeAssociationMetadata;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see> to an
    /// <see cref="EngineeringCRSType">engineering coordinate reference system</see>.
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
