
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 02:26, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.Common.Citation;
using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Implementation.Names;
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

namespace NDSH.Geospatial.Metadata.V2005.Content {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("MD_FeatureCatalogueDescription", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_FeatureCatalogueDescription", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_FeatureCatalogueDescription")]
  public class MD_FeatureCatalogueDescription : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_FeatureCatalogueDescription"/>.
    /// </summary>
    public MD_FeatureCatalogueDescription() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd"); // TODO: Make sure that the namespace is GMD.
      
      _complianceCode = new ComplianceCode();
      _language = new List<LanguageCode>();
      _includedWithDataset = new Boolean();
      _featureTypes = new List<GenericName>();
      _featureCatalogueCitation = new List<CI_Citation>();

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

    private ComplianceCode _complianceCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "complianceCode")]
    [JsonProperty("complianceCode", Order = 0)]
    public ComplianceCode ComplianceCode {
      get {
        return _complianceCode;
      }
      set {
        if (_complianceCode == value) {
          return;
        }
        if (_complianceCode == null || _complianceCode.Equals(value) != true) {
          _complianceCode = value;
          OnPropertyChanged();
        }
      }
    }

    private List<LanguageCode> _language;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("language", Order = 1, ElementName = "language")]
    [JsonProperty("language", Order = 1)]
    public List<LanguageCode> Language {
      get {
        return _language;
      }
      set {
        if (_language == value) {
          return;
        }
        if (_language == null || _language.Equals(value) != true) {
          _language = value;
          OnPropertyChanged();
        }
      }
    }

    private Boolean _includedWithDataset;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "includedWithDataset")]
    [JsonProperty("includedWithDataset", Order = 2)]
    public Boolean IncludedWithDataset {
      get {
        return _includedWithDataset;
      }
      set {
        if (_includedWithDataset == value) {
          return;
        }
        if (_includedWithDataset == null || _includedWithDataset.Equals(value) != true) { // TODO: Boolean check here is problematic
          _includedWithDataset = value;
          OnPropertyChanged();
        }
      }
    }

    private List<GenericName> _featureTypes;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("featureTypes", Order = 3, ElementName = "featureTypes")]
    [JsonProperty("featureTypes", Order = 3)]
    public List<GenericName> FeatureTypes {
      get {
        return _featureTypes;
      }
      set {
        if (_featureTypes == value) {
          return;
        }
        if (_featureTypes == null || _featureTypes.Equals(value) != true) {
          _featureTypes = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CI_Citation> _featureCatalogueCitation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("featureCatalogueCitation", Order = 4, ElementName = "featureCatalogueCitation")]
    [JsonProperty("featureCatalogueCitation", Order = 4)]
    public List<CI_Citation> FeatureCatalogueCitation {
      get {
        return _featureCatalogueCitation;
      }
      set {
        if (_featureCatalogueCitation == value) {
          return;
        }
        if (_featureCatalogueCitation == null || _featureCatalogueCitation.Equals(value) != true) {
          _featureCatalogueCitation = value;
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
