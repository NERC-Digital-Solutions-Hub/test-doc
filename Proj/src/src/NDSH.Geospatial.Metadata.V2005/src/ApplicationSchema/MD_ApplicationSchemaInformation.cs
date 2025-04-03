
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 16/12/2022, 18:56, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.Common.Citation;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.ApplicationSchema {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("MD_ApplicationSchemaInformation", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_ApplicationSchemaInformation", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_ApplicationSchemaInformation")]
  public class MD_ApplicationSchemaInformation : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_ApplicationSchemaInformation"/>.
    /// </summary>
    public MD_ApplicationSchemaInformation() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _name = default; // new CI_Citation();
      _schemaLanguage = default;
      _constraintLanguage = default;
      _schemaAscii = default;
      _graphicsFile = default;
      _softwareDevelopmentFile = default;
      _softwareDevelopmentFileFormat = default;

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

    private CI_Citation _name;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "name")]
    [JsonProperty("name", Order = 0)]
    public CI_Citation Name {
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

    private string _schemaLanguage;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "schemaLanguage")]
    [JsonProperty("schemaLanguage", Order = 1)]
    public string SchemaLanguage {
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

    private string _constraintLanguage;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "constraintLanguage")]
    [JsonProperty("constraintLanguage", Order = 2)]
    public string ConstraintLanguage {
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

    private string _schemaAscii;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3, ElementName = "schemaAscii")]
    [JsonProperty("schemaAscii", Order = 3)]
    public string SchemaAscii {
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

    private string _graphicsFile;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4, ElementName = "graphicsFile")]
    [JsonProperty("graphicsFile", Order = 4)]
    public string GraphicsFile {
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

    private string _softwareDevelopmentFile;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5, ElementName = "softwareDevelopmentFile")]
    [JsonProperty("softwareDevelopmentFile", Order = 5)]
    public string SoftwareDevelopmentFile {
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

    private string _softwareDevelopmentFileFormat;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6, ElementName = "softwareDevelopmentFileFormat")]
    [JsonProperty("softwareDevelopmentFileFormat", Order = 6)]
    public string SoftwareDevelopmentFileFormat {
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

    private string _id;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(DataType = "ID", AttributeName = "id")]
    [XmlIgnore()]
    [JsonProperty("id")]
    public string Id {
      get {
        return _id;
      }
      set {
        if (_id == value) {
          return;
        }
        if (_id == null || _id.Equals(value) != true) {
          _id = value;
          OnPropertyChanged();
        }
      }
    }

    private string _uuid;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "uuid")]
    [XmlIgnore()]
    [JsonProperty("uuid")]
    public string Uuid {
      get {
        return _uuid;
      }
      set {
        if (_uuid == value) {
          return;
        }
        if (_uuid == null || _uuid.Equals(value) != true) {
          _uuid = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
