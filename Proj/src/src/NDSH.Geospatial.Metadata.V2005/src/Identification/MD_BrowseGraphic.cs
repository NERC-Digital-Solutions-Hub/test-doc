
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 01:14, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

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

namespace NDSH.Geospatial.Metadata.V2005.Identification {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("MD_BrowseGraphic", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_BrowseGraphic", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_BrowseGraphic")]
  public class MD_BrowseGraphic : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_BrowseGraphic"/>.
    /// </summary>
    public MD_BrowseGraphic() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _fileName = default;
      _fileDescription = default;
      _fileType = default;
      
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

    private string _fileName;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "fileName")]
    [JsonProperty("fileName", Order = 0)]
    public string FileName {
      get {
        return _fileName;
      }
      set {
        if (_fileName == value) {
          return;
        }
        if (_fileName == null || _fileName.Equals(value) != true) {
          _fileName = value;
          OnPropertyChanged();
        }
      }
    }

    private string _fileDescription;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "fileDescription")]
    [JsonProperty("fileDescription", Order = 1)]
    public string FileDescription {
      get {
        return _fileDescription;
      }
      set {
        if (_fileDescription == value) {
          return;
        }
        if (_fileDescription == null || _fileDescription.Equals(value) != true) {
          _fileDescription = value;
          OnPropertyChanged();
        }
      }
    }

    private string _fileType;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "fileType")]
    [JsonProperty("fileType", Order = 2)]
    public string FileType {
      get {
        return _fileType;
      }
      set {
        if (_fileType == value) {
          return;
        }
        if (_fileType == null || _fileType.Equals(value) != true) {
          _fileType = value;
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
