
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 21/03/2025, @gisvlasta
// History           : 26/03/2025, @gisvlasta - Added AssociationEntity in the record and class implementations of the
//                                               discriminated union. The class implementation is now active.
//                   : 27/03/2025, @gisvlasta - Renamed TypeMetadata to TypeReferenceMetadata and changed the
//                                               union types to ReferenceEntity and NilReasonEntity.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/basicTypes.xsd
//                     /2005/gco/gcoBase.xsd
//                     /2005/xlink/xlinks.xsd
//                     /2005/gml/basicTypes.xsd
//                     /2005/gml/gmlBase.xsd
//                     /2005/gco/gcoBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// /2005/gml/basicTypes.xsd
// --------------------------------------------------------------------------------
// <simpleType name="NilReasonType">
//   <union memberTypes="gml:NilReasonEnumeration anyURI"/>
// </simpleType>
// 
// <simpleType name="NilReasonEnumeration">
//   <union>
//     <simpleType>
//       <restriction base="string">
//         <enumeration value="inapplicable"/>
//         <enumeration value="missing"/>
//         <enumeration value="template"/>
//         <enumeration value="unknown"/>
//         <enumeration value="withheld"/>
//       </restriction>
//     </simpleType>
//     <simpleType>
//       <restriction base="string">
//       <pattern value="other:\w{2,}"/>
//       </restriction>
//     </simpleType>
//   </union>
// </simpleType>
//
//
// /2005/gco/gcoBase.xsd
// --------------------------------------------------------------------------------
// <xs:attribute name="nilReason" type="gml:NilReasonType"/>
//
//
// /2005/xlink/xlinks.xsd
// --------------------------------------------------------------------------------
// <!-- locator attribute -->
// <attribute name="href" type="anyURI"/>
// <!-- semantic attributes -->
// <attribute name="role" type="anyURI"/>
// <attribute name="arcrole" type="anyURI"/>
// <attribute name="title" type="string"/>
// <!-- behavior attributes -->
// <attribute name="show">
//   <simpleType>
//     <restriction base="string">
//       <enumeration value="new"/>
//       <enumeration value="replace"/>
//       <enumeration value="embed"/>
//       <enumeration value="other"/>
//       <enumeration value="none"/>
//     </restriction>
//   </simpleType>
// </attribute>
// <attribute name="actuate">
//   <simpleType>
//     <restriction base="string">
//       <enumeration value="onLoad"/>
//       <enumeration value="onRequest"/>
//       <enumeration value="other"/>
//       <enumeration value="none"/>
//     </restriction>
//   </simpleType>
// </attribute>
//
// The following is also declared in ISO 19139 with name="simpleAttrs"
// --------------------------------------------------------------------------------
// <attributeGroup name="simpleLink">
//   <attribute name="type" type="string" fixed="simple" form="qualified"/>
//   <attribute ref="xlink:href" use="optional"/>
//   <attribute ref="xlink:role" use="optional"/>
//   <attribute ref="xlink:arcrole" use="optional"/>
//   <attribute ref="xlink:title" use="optional"/>
//   <attribute ref="xlink:show" use="optional"/>
//   <attribute ref="xlink:actuate" use="optional"/>
// </attributeGroup>
//
//
// /2005/gml/basicTypes.xsd
// --------------------------------------------------------------------------------
// <simpleType name="NilReasonType">
//   <union memberTypes="gml:NilReasonEnumeration anyURI"/>
// </simpleType>
// <simpleType name="NilReasonEnumeration">
//   <union>
//     <simpleType>
//       <restriction base="string">
//         <enumeration value="inapplicable"/>
//         <enumeration value="missing"/>
//         <enumeration value="template"/>
//         <enumeration value="unknown"/>
//         <enumeration value="withheld"/>
//       </restriction>
//     </simpleType>
//     <simpleType>
//       <restriction base="string">
//       <pattern value="other:\w{2,}"/>
//       </restriction>
//     </simpleType>
//   </union>
// </simpleType>
// <element name="Null" type="gml:NilReasonType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
//
// /2005/gml/gmlBase.xsd
// --------------------------------------------------------------------------------
// <attributeGroup name="AssociationAttributeGroup">
//   <attributeGroup ref="xlink:simpleLink"/>
//   <attribute name="nilReason" type="gml:NilReasonType"/>
//   <attribute ref="gml:remoteSchema"/>
// </attributeGroup>
//
// <attribute name="remoteSchema" type="anyURI">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </attribute>
//
//
// /2005/gco/gcoBase.xsd
// --------------------------------------------------------------------------------
// <xs:attributeGroup name="ObjectReference">
//   <xs:attributeGroup ref="xlink:simpleLink"/>
//   <xs:attribute name="uuidref" type="xs:string"/>
// </xs:attributeGroup>
// <xs:attribute name="nilReason" type="gml:NilReasonType"/>
// <xs:complexType name="ObjectReference_PropertyType">
//   <xs:sequence/>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml;
using NDSH.Geospatial.Gml.BasicTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata {

  // WARNING: Decide what is the best discriminated union implementation for PropertyMetadata, the record, or the class implementation.

  #region Record Implementation

  /// <summary>
  /// The <see cref="TypeReferenceMetadata"/> is a naive discriminated union implementation which ensures that
  /// it can only be either a <see cref="ReferenceEntity"/> or <see cref="NilReasonEntity"/>.
  /// </summary>
  public abstract record TypeReferenceMetadata {

    /// <summary>
    /// Represents a <see cref="TypeReferenceMetadata"/> instance of type <see cref="ReferenceEntity"/>.
    /// </summary>
    /// <param name="Value">
    /// The <see cref="ReferenceEntity"/> value used to create the <see cref="Reference"/>.
    /// </param>
    public sealed record Reference(ReferenceEntity Value) : TypeReferenceMetadata;

    /// <summary>
    /// Represents a <see cref="TypeReferenceMetadata"/> instance of type <see cref="NilReasonEntity"/>.
    /// </summary>
    /// <param name="Value">
    /// The <see cref="NilReasonEntity"/> value used to create the <see cref="NilReason"/>.
    /// </param>
    public sealed record NilReason(NilReasonEntity Value) : TypeReferenceMetadata;

  }

  #endregion

  #region Class Implementation

  ///// <summary>
  ///// The <see cref="TypeReferenceMetadata"/> is a naive discriminated union implementation which ensures that
  ///// it can only be either a <see cref="ReferenceEntity"/> or a <see cref="NilReasonEntity"/>.
  ///// </summary>
  //public abstract class TypeReferenceMetadata {

  //  /// <summary>
  //  /// Initializes the <see cref="TypeReferenceMetadata"/>
  //  /// </summary>
  //  /// <remarks>
  //  /// The <see cref="TypeReferenceMetadata"/> class can not be inherited because
  //  /// it has a <see langword="private"/> constructor.
  //  /// </remarks>
  //  private TypeReferenceMetadata() {

  //  }

  //  /// <summary>
  //  /// Represents a <see cref="TypeReferenceMetadata"/> instance of type <see cref="ReferenceEntity"/>.
  //  /// </summary>
  //  public sealed class Reference : TypeReferenceMetadata {

  //    /// <summary>
  //    /// Initializes the <see cref="Reference"/>.
  //    /// </summary>
  //    /// <param name="value">The <see cref="ReferenceEntity"/> value.</param>
  //    /// <exception cref="ArgumentNullException">
  //    /// Thrown when the <paramref name="value"/> is not of type <see cref="ReferenceEntity"/>.
  //    /// </exception>
  //    public Reference(ReferenceEntity value) {
  //      Value = value ?? throw new ArgumentNullException(nameof(value));
  //    }

  //    /// <summary>
  //    /// Gets the <see cref="ReferenceEntity"/> value.
  //    /// </summary>
  //    public ReferenceEntity Value {
  //      get;
  //    }

  //  }

  //  /// <summary>
  //  /// Represents a <see cref="TypeReferenceMetadata"/> instance of type <see cref="NilReasonEntity"/>.
  //  /// </summary>
  //  public sealed class NilReason : TypeReferenceMetadata {

  //    /// <summary>
  //    /// Initializes the <see cref="NilReason"/>.
  //    /// </summary>
  //    /// <param name="value">The <see cref="NilReasonEntity"/> value.</param>
  //    /// <exception cref="ArgumentNullException">
  //    /// Thrown when the <paramref name="value"/> is not of type <see cref="NilReasonEntity"/>.
  //    /// </exception>
  //    public NilReason(NilReasonEntity value) {
  //      Value = value ?? throw new ArgumentNullException(nameof(value));
  //    }

  //    /// <summary>
  //    /// Gets the <see cref="NilReasonEntity"/> value.
  //    /// </summary>
  //    public NilReasonEntity Value {
  //      get;
  //    }

  //  }

  //}

  #endregion

}
