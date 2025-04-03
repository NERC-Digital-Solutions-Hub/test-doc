
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 00:56, @gisvlasta.
// Updated by        : 09/01/2023, 19:16, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using NDSH.Geospatial.Metadata.V2003.Thin.Common.Citation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Extension {

  /// <summary>
  /// Information describing metadata extensions.
  /// </summary>
  [Serializable]
  [XmlType("MD_MetadataExtensionInformation", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_MetadataExtensionInformation", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_MetadataExtensionInformation")]
  public class MD_MetadataExtensionInformation_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_MetadataExtensionInformation_Type"/>.
    /// </summary>
    public MD_MetadataExtensionInformation_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _extensionOnLineResource  = default; //  new CI_OnlineResource_PropertyType();
      _extendedElementInformation  = default; //  new List<MD_ExtendedElementInformation_PropertyType>();

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

    private CI_OnlineResource_PropertyType _extensionOnLineResource;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("extensionOnLineResource", Order = 0)]
    [JsonProperty("extensionOnLineResource", Order = 0)]
    public CI_OnlineResource_PropertyType ExtensionOnLineResource {
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

    private List<MD_ExtendedElementInformation_PropertyType> _extendedElementInformation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("extendedElementInformation", Order = 1)]
    [JsonProperty("extendedElementInformation", Order = 1)]
    public List<MD_ExtendedElementInformation_PropertyType> ExtendedElementInformation {
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

    #endregion

  }

}