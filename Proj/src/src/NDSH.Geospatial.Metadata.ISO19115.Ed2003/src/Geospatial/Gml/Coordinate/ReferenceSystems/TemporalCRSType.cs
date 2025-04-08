
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
// <element name="timeCS" type="gml:TimeCSPropertyType">
//   <annotation>
//     <documentation>gml:timeCS is an association role to the time coordinate system used by this CRS.</documentation>
//   </annotation>
// </element>
// <element name="usesTimeCS" type="gml:TimeCSPropertyType" substitutionGroup="gml:timeCS">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <element name="usesTemporalCS" type="gml:TemporalCSPropertyType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <element name="temporalDatum" type="gml:TemporalDatumPropertyType">
//   <annotation>
//     <documentation>gml:temporalDatum is an association role to the temporal datum used by this CRS.</documentation>
//   </annotation>
// </element>
// <element name="usesTemporalDatum" type="gml:TemporalDatumPropertyType" substitutionGroup="gml:temporalDatum">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <element name="TemporalCRS" type="gml:TemporalCRSType" substitutionGroup="gml:AbstractSingleCRS">
//   <annotation>
//     <documentation>
//       gml:TemporalCRS is a 1D coordinate reference system used for the recording of time.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="TemporalCRSType">
//   <complexContent>
//     <extension base="gml:AbstractCRSType">
//       <sequence>
//         <choice>
//           <element ref="gml:timeCS"/>
//           <element ref="gml:usesTemporalCS"/>
//         </choice>
//         <element ref="gml:temporalDatum"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// 
// <complexType name="TemporalCRSPropertyType">
//   <annotation>
//     <documentation>
//       gml:TemporalCRSPropertyType is a property type for association roles to a temporal
//       coordinate reference system, either referencing or containing the definition
//       of that reference system.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:TemporalCRS"/>
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
  /// The <see cref="TemporalCRSType"/> is a 1D coordinate reference system used for the recording of time.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>TemporalCRSType</c> ( /2005/gml/coordinateReferenceSystems.xsd )
  /// </remarks>
  [IsoType("TemporalCRSType", WrapperName = "TemporalCRSPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TemporalCRSType")]
  public class TemporalCRSType : AbstractCRSType, ISingleCRS {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="TemporalCRSType"/>.
    /// </summary>
    public TemporalCRSType() {

    }

    #endregion

    #region Public Properties

    private ITemporalCoordinateSystem _temporalCoordinateSystem;

    /// <summary>
    /// Gets/Sets the <see cref="ITemporalCoordinateSystem"/>.
    /// </summary>
    /// <remarks>
    /// The <see cref="ITemporalCoordinateSystem"/> can be either
    /// a <see cref="TimeCSType"/> or a <see cref="TemporalCSType"/>.
    /// </remarks>
    //[XmlElement("timeCS", typeof(TimeCSPropertyType), Order = 0)]
    //[XmlElement("usesTemporalCS", typeof(TemporalCSPropertyType), Order = 0)]
    public ITemporalCoordinateSystem TemporalCoordinateSystem {
      get => _temporalCoordinateSystem;
      set => SetProperty(ref _temporalCoordinateSystem, value);
    }

    private TemporalDatumType _temporalDatum;


    /// <summary>
    /// Gets/Sets the <see cref="TemporalDatumType"/> used by this temporal coordinate reference system.
    /// </summary>
    //[XmlElement(Order = 1)]
    [JsonProperty("temporalDatum", Order = 1)]
    public TemporalDatumType TemporalDatum {
      get => _temporalDatum;
      set => SetProperty(ref _temporalDatum, value);
    }

    #endregion

    #region Public Overrides

    private TypeAssociationMetadata? _typeAssociationMetadata;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see> to a
    /// <see cref="TemporalCRSType">temporal coordinate reference system</see>.
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
