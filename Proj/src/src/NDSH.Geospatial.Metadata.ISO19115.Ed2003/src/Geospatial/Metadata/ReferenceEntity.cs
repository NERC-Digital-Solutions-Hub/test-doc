
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 20/12/2022, @gisvlasta
// History           : 07/03/2025, @gisvlasta - Updated property nullability, property setters, and documentation.
//                   : 16/03/2025, @gisvlasta - Changed inheritance to Association, simplified code, added IsoType,
//                                               removed namespaces, and updated header.
//                   : 21/03/2025, @gisvlasta - Corrected class documentation to reflect the changes in inheritance.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/xlink/xlinks.xsd
//                     /2005/gml/basicTypes.xsd
//                     /2005/gml/gmlBase.xsd
//                     /2005/gco/gcoBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
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
// 
// <xs:attribute name="nilReason" type="gml:NilReasonType"/>
// 
// <xs:complexType name="ObjectReference_PropertyType">
//   <xs:sequence/>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

#endregion

namespace NDSH.Geospatial.Metadata {

  /// <summary>
  /// Represents a reference to an external object within the ISO 19115 metadata framework.
  /// It provides attributes that define relationships between metadata elements,
  /// enabling linkage to remote resources via unique identifiers or hyperlinks.
  /// This class incorporates elements from the XLink standard (xlink) and supports referencing
  /// via attributes such as <c>href</c>, <c>role</c>, <c>arcrole</c>, and <c>title</c>.
  /// Additionally, it implements mechanisms for specifying missing values through the
  /// <c>nilReason</c> attribute, following the <c>gml:NilReasonType</c> convention.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     <b>Usage:</b>
  ///     <list type="bullet">
  ///       <item>Establish associations between metadata elements using href or uuidref.</item>
  ///       <item>Define the purpose of a reference with role and arcrole.</item>
  ///       <item>Control how linked resources are displayed or activated using show and actuate.</item>
  ///       <item>
  ///         Indicate missing or inapplicable data using nilReason, supporting standard enumerations or external URIs.
  ///       </item>
  ///     </list>
  ///   </para>
  ///   <para>
  ///     <b>Key Features:</b>
  ///     <list type="bullet">
  ///       <item>
  ///         Inherits from <see cref="AssociationEntity"/> and implements <see cref="INullableUuidRef"/>
  ///         interface for standardized referencing.
  ///       </item>
  ///       <item>Supports <c>xlink:simpleLink</c> attributes to define structured relationships.</item>
  ///       <item>Provides a deprecated <c>remoteSchema</c> attribute for backward compatibility.</item>
  ///     </list>
  ///   </para>
  ///   <para>
  ///      Maps to: <c>ObjectReference_PropertyType</c> ( /2005/gco/gcoBase.xsd )
  ///   </para>
  /// </remarks>
  [IsoType("ObjectReference_PropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlInclude(typeof(LocalisedCharacterString_PropertyType))] // TODO: IMPORTANT !!! - How many Includes should we put here???
  //[XmlType("ObjectReference_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")] // TODO: XmlRoot???
  [JsonObject("ObjectReference_PropertyType")]
  public class ReferenceEntity : AssociationEntity, INullableUuidRef {

    #region INullableUuidRef Interface

    private string? _uuidRef;

    /// <summary>
    /// Gets/Sets a reference to another object using its UUID.
    /// </summary>
    //[XmlAttribute("uuidref", DataType = "string")]
    [JsonProperty("uuidref")]
    public string? UuidRef {
      get => _uuidRef;
      set => SetProperty(ref _uuidRef, value);
    }

    #endregion

  }

}
