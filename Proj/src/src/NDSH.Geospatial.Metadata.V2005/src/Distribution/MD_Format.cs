
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 03:06, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005;
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

namespace NDSH.Geospatial.Metadata.V2005.Distribution {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("MD_Format", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_Format", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_Format")]
  public class MD_Format : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Format"/>.
    /// </summary>
    public MD_Format() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _name = default;
      _version = default;
      _amendmentNumber = default;
      _specification = default;
      _fileDecompressionTechnique = default;
      _formatDistributor = default; // new List<MD_Distributor>();

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

    private string _name;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "name")]
    [JsonProperty("name", Order = 0)]
    public string Name {
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

    private string _version;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "version")]
    [JsonProperty("version", Order = 1)]
    public string Version {
      get {
        return _version;
      }
      set {
        if (_version == value) {
          return;
        }
        if (_version == null || _version.Equals(value) != true) {
          _version = value;
          OnPropertyChanged();
        }
      }
    }

    private string _amendmentNumber;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "amendmentNumber")]
    [JsonProperty("amendmentNumber", Order = 2)]
    public string AmendmentNumber {
      get {
        return _amendmentNumber;
      }
      set {
        if (_amendmentNumber == value) {
          return;
        }
        if (_amendmentNumber == null || _amendmentNumber.Equals(value) != true) {
          _amendmentNumber = value;
          OnPropertyChanged();
        }
      }
    }

    private string _specification;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3, ElementName = "specification")]
    [JsonProperty("specification", Order = 3)]
    public string Specification {
      get {
        return _specification;
      }
      set {
        if (_specification == value) {
          return;
        }
        if (_specification == null || _specification.Equals(value) != true) {
          _specification = value;
          OnPropertyChanged();
        }
      }
    }

    private string _fileDecompressionTechnique;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4, ElementName = "fileDecompressionTechnique")]
    [JsonProperty("fileDecompressionTechnique", Order = 4)]
    public string FileDecompressionTechnique {
      get {
        return _fileDecompressionTechnique;
      }
      set {
        if (_fileDecompressionTechnique == value) {
          return;
        }
        if (_fileDecompressionTechnique == null || _fileDecompressionTechnique.Equals(value) != true) {
          _fileDecompressionTechnique = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_Distributor> _formatDistributor;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("formatDistributor", Order = 5, ElementName = "formatDistributor")]
    [JsonProperty("formatDistributor", Order = 5)]
    public List<MD_Distributor> FormatDistributor {
      get {
        return _formatDistributor;
      }
      set {
        if (_formatDistributor == value) {
          return;
        }
        if (_formatDistributor == null || _formatDistributor.Equals(value) != true) {
          _formatDistributor = value;
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
