
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 02/04/2025, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/datums.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="origin" type="dateTime">
//   <annotation>
//     <documentation>gml:origin is the date and time origin of this temporal datum.</documentation>
//   </annotation>
// </element>
// 
// <element name="TemporalDatum" type="gml:TemporalDatumType" substitutionGroup="gml:AbstractDatum">
//   <annotation>
//     <documentation>
//       A gml:TemporalDatum defines the origin of a Temporal Reference System.
//       This type omits the "anchorDefinition" and "realizationEpoch" elements and
//       adds the "origin" element with the dateTime type.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="TemporalDatumType">
//   <complexContent>
//     <extension base="gml:TemporalDatumBaseType">
//       <sequence>
//         <element ref="gml:origin"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// 
// <complexType name="TemporalDatumBaseType" abstract="true">
//   <annotation>
//     <documentation>
//       The TemporalDatumBaseType partially defines the origin of a temporal coordinate reference system.
//       This type restricts the AbstractDatumType to remove the "anchorDefinition" and "realizationEpoch" elements.
//     </documentation>
//   </annotation>
//   <complexContent>
//     <restriction base="gml:AbstractDatumType">
//       <sequence>
//         <element ref="gml:metaDataProperty" minOccurs="0" maxOccurs="unbounded"/>
//         <element ref="gml:description" minOccurs="0"/>
//         <element ref="gml:descriptionReference" minOccurs="0"/>
//         <element ref="gml:identifier"/>
//         <element ref="gml:name" minOccurs="0" maxOccurs="unbounded"/>
//         <element ref="gml:remarks" minOccurs="0"/>
//         <element ref="gml:domainOfValidity" minOccurs="0"/>
//         <element ref="gml:scope" maxOccurs="unbounded"/>
//       </sequence>
//       <attribute ref="gml:id" use="required"/>
//     </restriction>
//   </complexContent>
// </complexType>
// 
// <complexType name="TemporalDatumPropertyType">
//   <annotation>
//     <documentation>
//       gml:TemporalDatumPropertyType is a property type for association roles to a temporal datum,
//       either referencing or containing the definition of that datum.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:TemporalDatum"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Coordinate.ReferenceSystems;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.Datums {

  /// <summary>
  /// The <see cref="TemporalDatumType"/> defines the origin of a <see cref="TemporalCRSType"/>.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     This type omits the <see cref="AbstractDatumType.AnchorDefinition">AnchorDefinition</see> and
  ///     <see cref="AbstractDatumType.RealizationEpoch">RealizationEpoch</see> elements and
  ///     adds <see cref="DateTime"/> type <see cref="Origin"/> property.
  ///   </para>
  ///   <para>
  ///     Maps to: <c>TemporalDatumType</c> ( /2005/gml/datums.xsd )
  ///   </para>
  /// </remarks>
  //[XmlInclude(typeof(ML_TemporalDatum_Type))] // GMX
  [IsoType("TemporalDatumType", WrapperName = "TemporalDatumPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TemporalDatumType")]
  public class TemporalDatumType : TemporalDatumBaseType {

    #region Public Properties

    private DateTime _origin;

    /// <summary>
    /// Gets/Sets the date and time origin of this <see cref="TemporalDatumType"/>.
    /// </summary>
    //[XmlElement(Order = 0)]
    [JsonProperty("origin", Order = 0)]
    public DateTime Origin {
      get => _origin;
      set => SetProperty(ref _origin, value);
    }

    #endregion

    #region Public Overrides

    private TypeAssociationMetadata? _typeAssociationMetadata;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see> to a <see cref="TemporalDatumType"/>.
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
