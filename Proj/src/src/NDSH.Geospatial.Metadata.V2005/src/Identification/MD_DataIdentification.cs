
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 01:19, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.Common.Citation;
using NDSH.Geospatial.Metadata.V2005.Common.Extent;
using NDSH.Geospatial.Metadata.V2005.Constraint;
using NDSH.Geospatial.Metadata.V2005.Distribution;
using NDSH.Geospatial.Metadata.V2005.Maintenance;
using NDSH.Geospatial.Metadata.V2005.SpatialRepresentation;
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
  [XmlRoot("MD_DataIdentification", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_DataIdentification", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_DataIdentification")]
  public class MD_DataIdentification : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_DataIdentification"/>.
    /// </summary>
    public MD_DataIdentification() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _citation = default; // new CI_Citation();
      _abstract = default;
      _purpose = default;
      _credit = default; // new List<string>();
      _status = default; // new List<MD_ProgressCode>();
      _pointOfContact = default; // new List<CI_ResponsibleParty>();
      _resourceMaintenance = default; // new List<MD_MaintenanceInformation>();
      _graphicOverview = default; // new List<MD_BrowseGraphic>();
      _resourceFormat = default; // new List<MD_Format>();
      _descriptiveKeywords = default; // new List<MD_Keywords>();
      _resourceSpecificUsage = default; // new List<MD_Usage>();
      _resourceConstraints = default; // new List<Parent_MD_Constraints>();
      _aggregationInfo = default; // new List<MD_AggregateInformation>();
      _spatialRepresentationType = default; // new List<MD_SpatialRepresentationTypeCode>();
      _spatialResolution = default; // new List<MD_Resolution>();
      _language = default; // new List<LanguageCode>();
      _characterSet = default; // new MD_CharacterSetCode();
      _topicCategory = default; // new List<MD_TopicCategoryCode>();
      _environmentDescription = default;
      _extent = default; // new List<EX_Extent>();
      _supplementalInformation = default;


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

    private CI_Citation _citation;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "citation")]
    [JsonProperty("citation", Order = 0)]
    public CI_Citation Citation {
      get {
        return _citation;
      }
      set {
        if (_citation == value) {
          return;
        }
        if (_citation == null || _citation.Equals(value) != true) {
          _citation = value;
          OnPropertyChanged();
        }
      }
    }

    private string _abstract;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "abstract")]
    [JsonProperty("abstract", Order = 1)]
    public string Abstract {
      get {
        return _abstract;
      }
      set {
        if (_abstract == value) {
          return;
        }
        if (_abstract == null || _abstract.Equals(value) != true) {
          _abstract = value;
          OnPropertyChanged();
        }
      }
    }

    private string _purpose;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "purpose")]
    [JsonProperty("purpose", Order = 2)]
    public string Purpose {
      get {
        return _purpose;
      }
      set {
        if (_purpose == value) {
          return;
        }
        if (_purpose == null || _purpose.Equals(value) != true) {
          _purpose = value;
          OnPropertyChanged();
        }
      }
    }

    private List<string> _credit;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("credit", Order = 3, ElementName = "credit")]
    [JsonProperty("credit", Order = 3)]
    public List<string> Credit {
      get {
        return _credit;
      }
      set {
        if (_credit == value) {
          return;
        }
        if (_credit == null || _credit.Equals(value) != true) {
          _credit = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_ProgressCode> _status;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("status", Order = 4, ElementName = "status")]
    [JsonProperty("status", Order = 4)]
    public List<MD_ProgressCode> Status {
      get {
        return _status;
      }
      set {
        if (_status == value) {
          return;
        }
        if (_status == null || _status.Equals(value) != true) {
          _status = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CI_ResponsibleParty> _pointOfContact;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("pointOfContact", Order = 5, ElementName = "pointOfContact")]
    [JsonProperty("pointOfContact", Order = 5)]
    public List<CI_ResponsibleParty> PointOfContact {
      get {
        return _pointOfContact;
      }
      set {
        if (_pointOfContact == value) {
          return;
        }
        if (_pointOfContact == null || _pointOfContact.Equals(value) != true) {
          _pointOfContact = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_MaintenanceInformation> _resourceMaintenance;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("resourceMaintenance", Order = 6, ElementName = "resourceMaintenance")]
    [JsonProperty("resourceMaintenance", Order = 6)]
    public List<MD_MaintenanceInformation> ResourceMaintenance {
      get {
        return _resourceMaintenance;
      }
      set {
        if (_resourceMaintenance == value) {
          return;
        }
        if (_resourceMaintenance == null || _resourceMaintenance.Equals(value) != true) {
          _resourceMaintenance = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_BrowseGraphic> _graphicOverview;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("graphicOverview", Order = 7, ElementName = "graphicOverview")]
    [JsonProperty("graphicOverview", Order = 7)]
    public List<MD_BrowseGraphic> GraphicOverview {
      get {
        return _graphicOverview;
      }
      set {
        if (_graphicOverview == value) {
          return;
        }
        if (_graphicOverview == null || _graphicOverview.Equals(value) != true) {
          _graphicOverview = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_Format> _resourceFormat;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("resourceFormat", Order = 8, ElementName = "resourceFormat")]
    [JsonProperty("resourceFormat", Order = 8)]
    public List<MD_Format> ResourceFormat {
      get {
        return _resourceFormat;
      }
      set {
        if (_resourceFormat == value) {
          return;
        }
        if (_resourceFormat == null || _resourceFormat.Equals(value) != true) {
          _resourceFormat = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_Keywords> _descriptiveKeywords;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("descriptiveKeywords", Order = 9, ElementName = "descriptiveKeywords")]
    [JsonProperty("descriptiveKeywords", Order = 9)]
    public List<MD_Keywords> DescriptiveKeywords {
      get {
        return _descriptiveKeywords;
      }
      set {
        if (_descriptiveKeywords == value) {
          return;
        }
        if (_descriptiveKeywords == null || _descriptiveKeywords.Equals(value) != true) {
          _descriptiveKeywords = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_Usage> _resourceSpecificUsage;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("resourceSpecificUsage", Order = 10, ElementName = "resourceSpecificUsage")]
    [JsonProperty("resourceSpecificUsage", Order = 10)]
    public List<MD_Usage> ResourceSpecificUsage {
      get {
        return _resourceSpecificUsage;
      }
      set {
        if (_resourceSpecificUsage == value) {
          return;
        }
        if (_resourceSpecificUsage == null || _resourceSpecificUsage.Equals(value) != true) {
          _resourceSpecificUsage = value;
          OnPropertyChanged();
        }
      }
    }

    private List<Parent_MD_Constraints> _resourceConstraints;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("resourceConstraints", Order = 11, ElementName = "resourceConstraints")]
    [JsonProperty("resourceConstraints", Order = 11)]
    public List<Parent_MD_Constraints> ResourceConstraints {
      get {
        return _resourceConstraints;
      }
      set {
        if (_resourceConstraints == value) {
          return;
        }
        if (_resourceConstraints == null || _resourceConstraints.Equals(value) != true) {
          _resourceConstraints = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_AggregateInformation> _aggregationInfo;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("aggregationInfo", Order = 12, ElementName = "aggregationInfo")]
    [JsonProperty("aggregationInfo", Order = 12)]
    public List<MD_AggregateInformation> AggregationInfo {
      get {
        return _aggregationInfo;
      }
      set {
        if (_aggregationInfo == value) {
          return;
        }
        if (_aggregationInfo == null || _aggregationInfo.Equals(value) != true) {
          _aggregationInfo = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_SpatialRepresentationTypeCode> _spatialRepresentationType;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("spatialRepresentationType", Order = 13, ElementName = "spatialRepresentationType")]
    [JsonProperty("spatialRepresentationType", Order = 13)]
    public List<MD_SpatialRepresentationTypeCode> SpatialRepresentationType {
      get {
        return _spatialRepresentationType;
      }
      set {
        if (_spatialRepresentationType == value) {
          return;
        }
        if (_spatialRepresentationType == null || _spatialRepresentationType.Equals(value) != true) {
          _spatialRepresentationType = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_Resolution> _spatialResolution;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("spatialResolution", Order = 14, ElementName = "spatialResolution")]
    [JsonProperty("spatialResolution", Order = 14)]
    public List<MD_Resolution> SpatialResolution {
      get {
        return _spatialResolution;
      }
      set {
        if (_spatialResolution == value) {
          return;
        }
        if (_spatialResolution == null || _spatialResolution.Equals(value) != true) {
          _spatialResolution = value;
          OnPropertyChanged();
        }
      }
    }

    private List<LanguageCode> _language;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("language", Order = 15, ElementName = "language")]
    [JsonProperty("language", Order = 15)]
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

    private MD_CharacterSetCode _characterSet;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 16, ElementName = "characterSet")]
    [JsonProperty("characterSet", Order = 16)]
    public MD_CharacterSetCode CharacterSet {
      get {
        return _characterSet;
      }
      set {
        if (_characterSet == value) {
          return;
        }
        if (_characterSet == null || _characterSet.Equals(value) != true) {
          _characterSet = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_TopicCategoryCode> _topicCategory;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("topicCategory", Order = 17, ElementName = "topicCategory")]
    [JsonProperty("topicCategory", Order = 17)]
    public List<MD_TopicCategoryCode> TopicCategory {
      get {
        return _topicCategory;
      }
      set {
        if (_topicCategory == value) {
          return;
        }
        if (_topicCategory == null || _topicCategory.Equals(value) != true) {
          _topicCategory = value;
          OnPropertyChanged();
        }
      }
    }

    private string _environmentDescription;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 18, ElementName = "environmentDescription")]
    [JsonProperty("environmentDescription", Order = 18)]
    public string EnvironmentDescription {
      get {
        return _environmentDescription;
      }
      set {
        if (_environmentDescription == value) {
          return;
        }
        if (_environmentDescription == null || _environmentDescription.Equals(value) != true) {
          _environmentDescription = value;
          OnPropertyChanged();
        }
      }
    }

    private List<EX_Extent> _extent;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("extent", Order = 19, ElementName = "extent")]
    [JsonProperty("extent", Order = 19)]
    public List<EX_Extent> Extent {
      get {
        return _extent;
      }
      set {
        if (_extent == value) {
          return;
        }
        if (_extent == null || _extent.Equals(value) != true) {
          _extent = value;
          OnPropertyChanged();
        }
      }
    }

    private string _supplementalInformation;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 20, ElementName = "supplementalInformation")]
    [JsonProperty("supplementalInformation", Order = 20)]
    public string SupplementalInformation {
      get {
        return _supplementalInformation;
      }
      set {
        if (_supplementalInformation == value) {
          return;
        }
        if (_supplementalInformation == null || _supplementalInformation.Equals(value) != true) {
          _supplementalInformation = value;
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
