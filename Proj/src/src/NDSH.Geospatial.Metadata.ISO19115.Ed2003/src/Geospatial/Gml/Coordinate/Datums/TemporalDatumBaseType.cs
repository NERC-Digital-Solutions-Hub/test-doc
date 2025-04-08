
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

using NDSH.Geospatial.Gml.BasicTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.Datums {

  /// <summary>
  /// The <see cref="TemporalDatumBaseType"/> partially defines the origin of a temporal coordinate reference system.
  /// This type restricts the <see cref="AbstractDatumType"/> to remove the
  /// <see cref="AbstractDatumType.AnchorDefinition">AnchorDefinition</see> (<c>anchorDefinition</c> element) and
  /// <see cref="AbstractDatumType.RealizationEpoch">RealizationEpoch</see> (<cs>realizationEpoch</cs> element).
  /// </summary>
  /// <remarks>
  /// Maps to: <c>TemporalDatumBaseType</c> ( /2005/gml/datums.xsd )
  /// </remarks>
  //[XmlInclude(typeof(ML_TemporalDatum_Type))] // GMX
  //[XmlInclude(typeof(TemporalDatumType))]
  [IsoType(
    "TemporalDatumBaseType",
    WrapperName = "TemporalDatumPropertyType",
    IsAbstract = true,
    IsoType = IsoTypes.ComplexType
  )]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TemporalDatumBaseType")]
  public abstract class TemporalDatumBaseType : AbstractDatumType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="TemporalDatumBaseType"/>.
    /// </summary>
    public TemporalDatumBaseType() {
      AnchorDefinition = null;
      RealizationEpoch = null;
    }

    #endregion

    #region Overridden Unsupported Properties

    /// <summary>
    /// Not supported for temporal datums.
    /// Use the <c>origin</c> or time reference instead.
    /// </summary>
    /// <exception cref="NotSupportedException">Always thrown when accessed.</exception>
    [Obsolete($"{nameof(AnchorDefinition)} is not applicable to {nameof(TemporalDatumBaseType)}", true)] // RESOURCE
    public sealed override CodeType? AnchorDefinition {
      get => throw new NotSupportedException(
        $"{nameof(AnchorDefinition)} is not supported in {nameof(TemporalDatumBaseType)}."
      );
      set => throw new NotSupportedException(
        $"{nameof(AnchorDefinition)} is not supported in {nameof(TemporalDatumBaseType)}."
      );
    }

    /// <summary>
    /// Not supported for temporal datums.
    /// </summary>
    /// <exception cref="NotSupportedException">Always thrown when accessed.</exception>
    [Obsolete($"{nameof(RealizationEpoch)} is not applicable to {nameof(TemporalDatumBaseType)}", true)] // RESOURCE
    public sealed override DateOnly? RealizationEpoch {
      get => throw new NotSupportedException(
        $"{nameof(RealizationEpoch)} is not supported in {nameof(TemporalDatumBaseType)}."
      );
      set => throw new NotSupportedException(
        $"{nameof(RealizationEpoch)} is not supported in {nameof(TemporalDatumBaseType)}."
      );
    }

    #endregion

  }

}
