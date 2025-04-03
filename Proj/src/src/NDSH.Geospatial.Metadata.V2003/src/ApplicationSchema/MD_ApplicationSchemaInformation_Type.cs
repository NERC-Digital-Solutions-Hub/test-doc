
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 17:44, @gisvlasta.
// Updated by        : 09/01/2023, 14:01, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common.Citation;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive;
using NDSH.Geospatial.Metadata.V2003.Common;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ApplicationSchema {

  /// <summary>
  /// Information about the application schema used to build the dataset.
  /// </summary>
  [Serializable]
  [XmlType("MD_ApplicationSchemaInformation", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_ApplicationSchemaInformation", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_ApplicationSchemaInformation")]
  public class MD_ApplicationSchemaInformation_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_ApplicationSchemaInformation_Type"/>.
    /// </summary>
    public MD_ApplicationSchemaInformation_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _name  = default; //  new CI_Citation_PropertyType();
      _schemaLanguage  = default; //  new CharacterString_PropertyType();
      _constraintLanguage  = default; //  new CharacterString_PropertyType();
      _schemaAscii  = default; //  new CharacterString_PropertyType();
      _graphicsFile  = default; //  new Binary_PropertyType();
      _softwareDevelopmentFile  = default; //  new Binary_PropertyType();
      _softwareDevelopmentFileFormat  = default; //  new CharacterString_PropertyType();
      
    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private CI_Citation_PropertyType _name;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("name", Order = 0)]
    [JsonProperty("name", Order = 0)]
    public CI_Citation_PropertyType Name {
      get {
        return _name;
      }
      set {
        if (_name == value) {
          return;
        }
        if (_name == null || _name.Equals(value) != true) {
          _name = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _schemaLanguage;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("schemaLanguage", Order = 1)]
    [JsonProperty("schemaLanguage", Order = 1)]
    public CharacterString_PropertyType SchemaLanguage {
      get {
        return _schemaLanguage;
      }
      set {
        if (_schemaLanguage == value) {
          return;
        }
        if (_schemaLanguage == null || _schemaLanguage.Equals(value) != true) {
          _schemaLanguage = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _constraintLanguage;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("constraintLanguage", Order = 2)]
    [JsonProperty("constraintLanguage", Order = 2)]
    public CharacterString_PropertyType ConstraintLanguage {
      get {
        return _constraintLanguage;
      }
      set {
        if (_constraintLanguage == value) {
          return;
        }
        if (_constraintLanguage == null || _constraintLanguage.Equals(value) != true) {
          _constraintLanguage = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _schemaAscii;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("schemaAscii", Order = 3)]
    [JsonProperty("schemaAscii", Order = 3)]
    public CharacterString_PropertyType SchemaAscii {
      get {
        return _schemaAscii;
      }
      set {
        if (_schemaAscii == value) {
          return;
        }
        if (_schemaAscii == null || _schemaAscii.Equals(value) != true) {
          _schemaAscii = value;
          OnPropertyChanged();
        }
      }
    }

    private Binary_PropertyType _graphicsFile;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("graphicsFile", Order = 4)]
    [JsonProperty("graphicsFile", Order = 4)]
    public Binary_PropertyType GraphicsFile {
      get {
        return _graphicsFile;
      }
      set {
        if (_graphicsFile == value) {
          return;
        }
        if (_graphicsFile == null || _graphicsFile.Equals(value) != true) {
          _graphicsFile = value;
          OnPropertyChanged();
        }
      }
    }

    private Binary_PropertyType _softwareDevelopmentFile;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("softwareDevelopmentFile", Order = 5)]
    [JsonProperty("softwareDevelopmentFile", Order = 5)]
    public Binary_PropertyType SoftwareDevelopmentFile {
      get {
        return _softwareDevelopmentFile;
      }
      set {
        if (_softwareDevelopmentFile == value) {
          return;
        }
        if (_softwareDevelopmentFile == null || _softwareDevelopmentFile.Equals(value) != true) {
          _softwareDevelopmentFile = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _softwareDevelopmentFileFormat;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("softwareDevelopmentFileFormat", Order = 6)]
    [JsonProperty("softwareDevelopmentFileFormat", Order = 6)]
    public CharacterString_PropertyType SoftwareDevelopmentFileFormat {
      get {
        return _softwareDevelopmentFileFormat;
      }
      set {
        if (_softwareDevelopmentFileFormat == value) {
          return;
        }
        if (_softwareDevelopmentFileFormat == null || _softwareDevelopmentFileFormat.Equals(value) != true) {
          _softwareDevelopmentFileFormat = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}