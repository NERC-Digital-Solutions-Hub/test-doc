
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 24/02/2025, @gisvlasta
// History           : 07/03/2025, @gisvlasta - Refactored the code and provided extensive documentation and header.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/gmlBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="AbstractMetadataPropertyType" abstract="true">
//   <annotation>
//     <documentation>
//       To associate metadata described by any XML Schema with a GML object,
//       a property element shall be defined whose content model is derived by extension
//       from gml:AbstractMetadataPropertyType. The value of such a property shall be metadata.
//       The content model of such a property type, i.e. the metadata application schema shall
//       be specified by the GML Application Schema. By default, this abstract property type
//       does not imply any ownership of the metadata. The owns attribute of gml:OwnershipAttributeGroup
//       may be used on a metadata property element instance to assert ownership of the metadata.
//       If metadata following the conceptual model of ISO 19115 is to be encoded in a GML document,
//       the corresponding Implementation Specification specified in ISO/TS 19139 shall be used to encode
//       the metadata information.
//     </documentation>
//   </annotation>
//   <sequence/>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
// 
// <complexType name="MetaDataPropertyType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:AbstractMetaData"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
//   <attribute name="about" type="anyURI"/>
// </complexType>
// 
// <element name="AbstractMetaData"
//          type="gml:AbstractMetaDataType" abstract="true" substitutionGroup="gml:AbstractObject">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <complexType name="AbstractMetaDataType" abstract="true" mixed="true">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <sequence/>
//   <attribute ref="gml:id"/>
// </complexType>
// 
// <complexType name="StringOrRefType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <simpleContent>
//     <extension base="string">
//       <attributeGroup ref="gml:AssociationAttributeGroup"/>
//     </extension>
//   </simpleContent>
// </complexType>
// 
// <element name="metaDataProperty" type="gml:MetaDataPropertyType"></element>
// <element name="description" type="gml:StringOrRefType"></element>
// <element name="descriptionReference" type="gml:ReferenceType"></element>
// <element name="name" type="gml:CodeType"></element>
// <element name="identifier" type="gml:CodeWithAuthorityType"></element>
// 
// <group name="StandardObjectProperties">
//   <sequence>
//     <element ref="gml:metaDataProperty" minOccurs="0" maxOccurs="unbounded"/>
//     <element ref="gml:description" minOccurs="0"/>
//     <element ref="gml:descriptionReference" minOccurs="0"/>
//     <element ref="gml:identifier" minOccurs="0"/>
//     <element ref="gml:name" minOccurs="0" maxOccurs="unbounded"/>
//   </sequence>
// </group>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.BasicTypes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml {

  /// <summary>
  /// Defines the standard set of properties that can be associated with a GML object.
  /// </summary>
  /// <remarks>
  /// This interface encapsulates the common properties defined within the
  /// <c>gml:StandardObjectProperties</c> group, which includes metadata properties, 
  /// descriptions, identifiers, and names. These properties provide essential 
  /// information about a GML object, including textual descriptions, references to 
  /// external descriptions, and authoritative identifiers.
  /// <br></br>
  /// The metadata properties allow linking to ISO 19115-compliant metadata, 
  /// and names and identifiers facilitate object identification and classification.
  /// <br></br>
  /// This interface is based on the GML 3.2 specification and aligns with the 
  /// ISO 19115 metadata standard.
  /// </remarks>
  public interface IStandardObjectProperties {

    /// <summary>
    /// Gets/Sets the <see cref="ObservableCollection{MetaDataPropertyType}">collection of metadata properties</see>
    /// associated with the object.
    /// </summary>
    /// <remarks>
    /// The <c>metaDataProperty</c> element is used to link metadata to a GML object. 
    /// It follows the <see cref="MetaDataPropertyType"/> content model, which allows for 
    /// association with metadata described by any XML Schema. This property does not 
    /// inherently imply ownership of the metadata, but ownership can be asserted using 
    /// the <see cref="IOwnership"/>.
    /// </remarks>
    //[JsonProperty("metaDataProperty", Order = 0)]
    public ObservableCollection<MetaDataPropertyType>? MetaDataProperty {
      get;
      set;
    }

    /// <summary>
    /// Gets/Sets the text description of the object.
    /// </summary>
    /// <remarks>
    /// <c>gml:description</c> uses <c>gml:StringOrRefType</c> as its content model,
    /// so it may contain a simple text string content, or carry a reference to an external description.
    /// The use of <c>gml:description</c> to reference an external description has been deprecated and
    /// replaced by the <c>gml:descriptionReference</c> property.
    /// </remarks>
    //[JsonProperty("description", Order = 1)]
    [Obsolete("Marked 'deprecated' in /gml/gmlBase.xsd")]
    public StringOrRefType? Description {
      get;
      set;
    }

    /// <summary>
    /// Gets/Sets the remote text description of the object.
    /// </summary>
    /// <remarks>
    /// The <c>xlink:href</c> attribute of the <c>gml:descriptionReference</c>
    /// property references the external description.
    /// </remarks>
    //[JsonProperty("descriptionReference", Order = 2)]
    public ReferenceType? DescriptionReference {
      get;
      set;
    }

    /// <summary>
    /// Gets/Sets the label or identifier for the object, commonly a descriptive name.
    /// </summary>
    /// <remarks>
    /// An object may have several names, typically assigned by different authorities.
    /// <c>gml:name</c> uses the <c>gml:CodeType</c> content model. The authority for a name
    /// is indicated by the value of its (optional) codeSpace attribute. The name may or may not be unique,
    /// as determined by the rules of the organization responsible for the codeSpace.
    /// In common usage there will be one name per authority, so a processing application
    /// may select the name from its preferred codeSpace.
    /// </remarks>
    //[JsonProperty("identifier", Order = 3)]
    public CodeWithAuthorityType? Identifier {
      get;
      set;
    }

    /// <summary>
    /// Gets/Sets the special identifier that is often assigned to an object by the maintaining authority 
    /// with the intention that it is used in references to the object. For such cases, the codeSpace
    /// shall be provided. That identifier is usually unique either globally or within an application domain.
    /// <c>gml:identifier</c> is a pre-defined property for such identifiers.
    /// </summary>
    //[JsonProperty("name", Order = 4)]
    public ObservableCollection<CodeType>? Name {
      get;
      set;
    }

  }

}
