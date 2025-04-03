
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 04:03, @gisvlasta - Cleaned Xml Serialization Attributes.
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

namespace NDSH.Geospatial.Metadata.V2005.Extension {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("MD_MetadataExtensionInformation", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_MetadataExtensionInformation", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_MetadataExtensionInformation")]
  public class MD_MetadataExtensionInformation : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_MetadataExtensionInformation"/>.
    /// </summary>
    public MD_MetadataExtensionInformation() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _extensionOnLineResource = default; //new CI_OnlineResource();
      _extendedElementInformation = default; //new List<MD_ExtendedElementInformation>();

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

    private CI_OnlineResource _extensionOnLineResource;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "extensionOnLineResource")]
    [JsonProperty("extensionOnLineResource", Order = 0)]
    public CI_OnlineResource ExtensionOnLineResource {
      get {
        return _extensionOnLineResource;
      }
      set {
        if (_extensionOnLineResource == value) {
          return;
        }
        if (_extensionOnLineResource == null || _extensionOnLineResource.Equals(value) != true) {
          _extensionOnLineResource = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_ExtendedElementInformation> _extendedElementInformation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("extendedElementInformation", Order = 1, ElementName = "extendedElementInformation")]
    [JsonProperty("extendedElementInformation", Order = 1)]
    public List<MD_ExtendedElementInformation> ExtendedElementInformation {
      get {
        return _extendedElementInformation;
      }
      set {
        if (_extendedElementInformation == value) {
          return;
        }
        if (_extendedElementInformation == null || _extendedElementInformation.Equals(value) != true) {
          _extendedElementInformation = value;
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
