
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 28/12/2022, @gisvlasta
// History           : 16/03/2025, @gisvlasta - Added IsoTypeAttribute, update property nullability, updated code,
//                                               and updated documentation.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/applicationSchema.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MD_ApplicationSchemaInformation_Type">
//   <xs:annotation>
//     <xs:documentation>Information about the application schema used to build the dataset</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="name" type="gmd:CI_Citation_PropertyType"/>
//         <xs:element name="schemaLanguage" type="gco:CharacterString_PropertyType"/>
//         <xs:element name="constraintLanguage" type="gco:CharacterString_PropertyType"/>
//         <xs:element name="schemaAscii" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="graphicsFile" type="gco:Binary_PropertyType" minOccurs="0"/>
//         <xs:element name="softwareDevelopmentFile" type="gco:Binary_PropertyType" minOccurs="0"/>
//         <xs:element name="softwareDevelopmentFileFormat" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_ApplicationSchemaInformation" type="gmd:MD_ApplicationSchemaInformation_Type"/>
// <xs:complexType name="MD_ApplicationSchemaInformation_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_ApplicationSchemaInformation"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.ApplicationSchema {

  /// <summary>
  ///   <para>
  ///     Information about the application schema used to build the dataset.
  ///   </para>
  ///   <para>
  ///     This includes details such as the <b>schema name</b>, the <b>language</b> in which it is written,
  ///     and any <b>associated files</b> that describe the schema in various formats.
  ///   </para>
  /// </summary>
  /// <remarks>
  /// Maps to: <c>MD_ApplicationSchemaInformation_Type</c> ( /2005/gmd/applicationSchema.xsd ).
  /// </remarks>
  [IsoType("MD_ApplicationSchemaInformation_Type", IsoType = IsoTypes.ComplexType)]
  //[XmlType("MD_ApplicationSchemaInformation", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_ApplicationSchemaInformation", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_ApplicationSchemaInformation")]
  public class MD_ApplicationSchemaInformation_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_ApplicationSchemaInformation_Type"/>.
    /// </summary>
    public MD_ApplicationSchemaInformation_Type() {
      _name = default; //  new CI_Citation_Type();
      _schemaLanguage = default; //  new CharacterString();
      _constraintLanguage = default; //  new CharacterString();
      _schemaAscii = default; //  new CharacterString();
      _graphicsFile = default; //  new Binary_PropertyType();
      _softwareDevelopmentFile = default; //  new Binary_PropertyType();
      _softwareDevelopmentFileFormat = default; //  new CharacterString();
    }

    #endregion

    #region Public Properties

    private CI_Citation_Type _name;

    /// <summary>
    /// Gets/Sets the name of the application schema used.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("name", Order = 0)]
    [JsonProperty("name", Order = 0)]
    public CI_Citation_Type Name {
      get => _name;
      set => SetProperty(ref _name, value);
    }

    private CharacterString _schemaLanguage;

    /// <summary>
    /// Gets/Sets the identification of the schema language used.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("schemaLanguage", Order = 1)]
    [JsonProperty("schemaLanguage", Order = 1)]
    public CharacterString SchemaLanguage {
      get => _schemaLanguage;
      set => SetProperty(ref _schemaLanguage, value);
    }

    private CharacterString _constraintLanguage;

    /// <summary>
    /// Gets/Sets the formal language used in Application Schema.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("constraintLanguage", Order = 2)]
    [JsonProperty("constraintLanguage", Order = 2)]
    public CharacterString ConstraintLanguage {
      get => _constraintLanguage;
      set => SetProperty(ref _constraintLanguage, value);
    }

    private CharacterString? _schemaAscii;

    /// <summary>
    /// Gets/Sets the full application schema given and an ASCII file.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("schemaAscii", Order = 3)]
    [JsonProperty("schemaAscii", Order = 3)]
    public CharacterString? SchemaAscii {
      get => _schemaAscii;
      set => SetProperty(ref _schemaAscii, value);
    }

    private Binary_PropertyType? _graphicsFile;

    /// <summary>
    /// Gets/Sets the full application schema given as a graphics file.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("graphicsFile", Order = 4)]
    [JsonProperty("graphicsFile", Order = 4)]
    public Binary_PropertyType? GraphicsFile {
      get => _graphicsFile;
      set => SetProperty(ref _graphicsFile, value);
    }

    private Binary_PropertyType? _softwareDevelopmentFile;

    /// <summary>
    /// Gets/Sets the full application schema given as a software development file.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("softwareDevelopmentFile", Order = 5)]
    [JsonProperty("softwareDevelopmentFile", Order = 5)]
    public Binary_PropertyType? SoftwareDevelopmentFile {
      get => _softwareDevelopmentFile;
      set => SetProperty(ref _softwareDevelopmentFile, value);
    }

    private CharacterString? _softwareDevelopmentFileFormat;

    /// <summary>
    /// Gets/Sets the software development format used for the application schema software development file.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("softwareDevelopmentFileFormat", Order = 6)]
    [JsonProperty("softwareDevelopmentFileFormat", Order = 6)]
    public CharacterString? SoftwareDevelopmentFileFormat {
      get => _softwareDevelopmentFileFormat;
      set => SetProperty(ref _softwareDevelopmentFileFormat, value);
    }

    #endregion

  }

}
