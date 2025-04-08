
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

//using NDSH.Geospatial.Metadata.V2005.ApplicationSchema;
using NDSH.Geospatial.Metadata.V2005.Common.Citation;
//using NDSH.Geospatial.Metadata.V2005.Constraint;
//using NDSH.Geospatial.Metadata.V2005.Content;
//using NDSH.Geospatial.Metadata.V2005.DataQuality;
using NDSH.Geospatial.Metadata.V2005.Distribution;
//using NDSH.Geospatial.Metadata.V2005.Extension;
//using NDSH.Geospatial.Metadata.V2005.Identification;
//using NDSH.Geospatial.Metadata.V2005.Maintenance;
//using NDSH.Geospatial.Metadata.V2005.ReferenceSystem;
//using NDSH.Geospatial.Metadata.V2005.SpatialRepresentation;
using NDSH.Geospatial.Metadata.V2005;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.EntitySet {

  /// <summary>
  /// Root entity which defines metadata about a resource or resources.
  /// </summary>
  [Serializable]
  [DebuggerStepThrough]
  [XmlRoot("MD_Metadata", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_Metadata", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_Metadata")]
  public class MD_Metadata : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Metadata"/>.
    /// </summary>
    public MD_Metadata() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");
      xmlns.Add("gco", "http://www.isotc211.org/2005/gco");
      xmlns.Add("gml", "http://www.opengis.net/gml/3.2");
      xmlns.Add("gmx", "http://www.isotc211.org/2005/gmx");
      xmlns.Add("gsr", "http://www.isotc211.org/2005/gsr");
      xmlns.Add("gss", "http://www.isotc211.org/2005/gss");
      xmlns.Add("gts", "http://www.isotc211.org/2005/gts");
      xmlns.Add("srv", "http://www.isotc211.org/2005/srv");
      xmlns.Add("xlink", "http://www.w3.org/1999/xlink");

      // TODO: IMPORTANT - UNCOMMENT ALL THESE
      _fileIdentifier = default;
      //_language = new LanguageCode();
      //_characterSet = new MD_CharacterSetCode();
      _parentIdentifier = default;
      //_hierarchyLevel = new List<MD_ScopeCode>();
      _hierarchyLevelName = default; //new List<string>();
      _contact = default; //new List<CI_ResponsibleParty>();
      //_dateStamp - default;
      _metadataStandardName = default;
      _metadataStandardVersion = default;
      _datasetURI = default;
      //_spatialRepresentationInfo = new List<MD_SpatialRepresentation>();
      //_referenceSystemInfo = new List<Parent_MD_ReferenceSystem>();
      //_metadataExtensionInfo = new List<MD_MetadataExtensionInformation>();
      //_identificationInfo = new List<Parent_MD_Identification>();
      //_contentInfo = new List<MD_ContentInformation>();
      _distributionInfo = default; //new MD_Distribution();
      //_dataQualityInfo = new List<DQ_DataQuality>();
      //_metadataConstraints = new List<Parent_MD_Constraints>();
      //_applicationSchemaInfo = new List<MD_ApplicationSchemaInformation>();
      //_metadataMaintenance = new MD_MaintenanceInformation();

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

    private string _fileIdentifier;

    /// <summary>
    /// Unique identifier for this metadata file.
    /// </summary>
    /// 
    [XmlElement(Order = 0, ElementName = "fileIdentifier")]
    [JsonProperty("fileIdentifier", Order = 0)]
    public string FileIdentifier {
      get {
        return _fileIdentifier;
      }
      set {
        if (_fileIdentifier == value) {
          return;
        }
        if (_fileIdentifier == null || _fileIdentifier.Equals(value) != true) {
          _fileIdentifier = value;
          OnPropertyChanged();
        }
      }
    }

    //private LanguageCode _language;

    ///// <summary>
    ///// Language used for documenting metadata.
    ///// </summary>
    //[XmlElement(Order = 1, ElementName = "language")]
    //[JsonProperty("language", Order = 1)]
    //public LanguageCode Language {
    //  get {
    //    return _language;
    //  }
    //  set {
    //    if (_language == value) {
    //      return;
    //    }
    //    if (_language == null || _language.Equals(value) != true) {
    //      _language = value;
    //      OnPropertyChanged();
    //    }
    //  }
    //}

    //private MD_CharacterSetCode _characterSet;

    ///// <summary>
    ///// Full name of the character coding standard used for the metadata set.
    ///// </summary>
    //[XmlElement(Order = 2, ElementName = "characterSet")]
    //[JsonProperty("characterSet", Order = 2)]
    //public MD_CharacterSetCode CharacterSet {
    //  get {
    //    return _characterSet;
    //  }
    //  set {
    //    if (_characterSet == value) {
    //      return;
    //    }
    //    if (_characterSet == null || _characterSet.Equals(value) != true) {
    //      _characterSet = value;
    //      OnPropertyChanged();
    //    }
    //  }
    //}

    private string _parentIdentifier;

    /// <summary>
    /// File identifier of the metadata to which this metadata is a subset (child).
    /// </summary>
    [XmlElement(Order = 3, ElementName = "parentIdentifier")]
    [JsonProperty("parentIdentifier", Order = 3)]
    public string ParentIdentifier {
      get {
        return _parentIdentifier;
      }
      set {
        if (_parentIdentifier == value) {
          return;
        }
        if (_parentIdentifier == null || _parentIdentifier.Equals(value) != true) {
          _parentIdentifier = value;
          OnPropertyChanged();
        }
      }
    }

    //private List<MD_ScopeCode> _hierarchyLevel;

    ///// <summary>
    ///// Scope to which the metadata applies(see Annex H for more 
    ///// information about metadata hierarchy levels).
    ///// </summary>
    //[XmlElement("hierarchyLevel", Order = 4, ElementName = "hierarchyLevel")]
    //[JsonProperty("hierarchyLevel", Order = 4)]
    //public List<MD_ScopeCode> HierarchyLevel {
    //  get {
    //    return _hierarchyLevel;
    //  }
    //  set {
    //    if (_hierarchyLevel == value) {
    //      return;
    //    }
    //    if (_hierarchyLevel == null || _hierarchyLevel.Equals(value) != true) {
    //      _hierarchyLevel = value;
    //      OnPropertyChanged();
    //    }
    //  }
    //}

    private List<string> _hierarchyLevelName;

    /// <summary>
    /// Name of the hierarchy levels for which the metadata is provided.
    /// </summary>
    [XmlElement("hierarchyLevelName", Order = 5, ElementName = "hierarchyLevelName")]
    [JsonProperty("hierarchyLevelName", Order = 5)]
    public List<string> HierarchyLevelName {
      get {
        return _hierarchyLevelName;
      }
      set {
        if (_hierarchyLevelName == value) {
          return;
        }
        if (_hierarchyLevelName == null || _hierarchyLevelName.Equals(value) != true) {
          _hierarchyLevelName = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CI_ResponsibleParty> _contact;

    /// <summary>
    /// Party responsible for the metadata information.
    /// </summary>
    [XmlElement("contact", Order = 6, ElementName = "contact")]
    [JsonProperty("contact", Order = 6)]
    public List<CI_ResponsibleParty> Contact {
      get {
        return _contact;
      }
      set {
        if (_contact == value) {
          return;
        }
        if (_contact == null || _contact.Equals(value) != true) {
          _contact = value;
          OnPropertyChanged();
        }
      }
    }

    private DateTime _dateStamp;

    /// <summary>
    /// Date that the metadata was created.
    /// </summary>
    [XmlElement(Order = 7, ElementName = "dateStamp")]
    [Required()]
    [JsonProperty("dateStamp", Order = 7)]
    public DateTime DateStamp {
      get {
        return _dateStamp;
      }
      set {
        if (_dateStamp.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "DateStamp";
          Validator.ValidateProperty(value, validatorPropContext);
          _dateStamp = value;
          OnPropertyChanged();
        }
      }
    }

    private string _metadataStandardName;

    /// <summary>
    /// Name of the metadata standard (including profile name) used.
    /// </summary>
    [XmlElement(Order = 8, ElementName = "metadataStandardName")]
    [JsonProperty("metadataStandardName", Order = 8)]
    public string MetadataStandardName {
      get {
        return _metadataStandardName;
      }
      set {
        if (_metadataStandardName == value) {
          return;
        }
        if (_metadataStandardName == null || _metadataStandardName.Equals(value) != true) {
          _metadataStandardName = value;
          OnPropertyChanged();
        }
      }
    }

    private string _metadataStandardVersion;

    /// <summary>
    /// Version of the metadata standard (version of the profile) used.
    /// </summary>
    [XmlElement(Order = 9, ElementName = "metadataStandardVersion")]
    [JsonProperty("metadataStandardVersion", Order = 9)]
    public string MetadataStandardVersion {
      get {
        return _metadataStandardVersion;
      }
      set {
        if (_metadataStandardVersion == value) {
          return;
        }
        if (_metadataStandardVersion == null || _metadataStandardVersion.Equals(value) != true) {
          _metadataStandardVersion = value;
          OnPropertyChanged();
        }
      }
    }

    private string _datasetURI;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 10, ElementName = "datasetURI")]
    [JsonProperty("datasetURI", Order = 10)]
    public string DatasetURI {
      get {
        return _datasetURI;
      }
      set {
        if (_datasetURI == value) {
          return;
        }
        if (_datasetURI == null || _datasetURI.Equals(value) != true) {
          _datasetURI = value;
          OnPropertyChanged();
        }
      }
    }

    //private List<MD_SpatialRepresentation> _spatialRepresentationInfo;

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlElement("spatialRepresentationInfo", Order = 11, ElementName = "spatialRepresentationInfo")]
    //[JsonProperty("spatialRepresentationInfo", Order = 11)]
    //public List<MD_SpatialRepresentation> SpatialRepresentationInfo {
    //  get {
    //    return _spatialRepresentationInfo;
    //  }
    //  set {
    //    if (_spatialRepresentationInfo == value) {
    //      return;
    //    }
    //    if (_spatialRepresentationInfo == null || _spatialRepresentationInfo.Equals(value) != true) {
    //      _spatialRepresentationInfo = value;
    //      OnPropertyChanged();
    //    }
    //  }
    //}

    //private List<Parent_MD_ReferenceSystem> _referenceSystemInfo;

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlElement("referenceSystemInfo", Order = 12, ElementName = "referenceSystemInfo")]
    //[JsonProperty("referenceSystemInfo", Order = 12)]
    //public List<Parent_MD_ReferenceSystem> ReferenceSystemInfo {
    //  get {
    //    return _referenceSystemInfo;
    //  }
    //  set {
    //    if (_referenceSystemInfo == value) {
    //      return;
    //    }
    //    if (_referenceSystemInfo == null || _referenceSystemInfo.Equals(value) != true) {
    //      _referenceSystemInfo = value;
    //      OnPropertyChanged();
    //    }
    //  }
    //}

    //private List<MD_MetadataExtensionInformation> _metadataExtensionInfo;

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlElement("metadataExtensionInfo", Order = 13, ElementName = "metadataExtensionInfo")]
    //[JsonProperty("metadataExtensionInfo", Order = 13)]
    //public List<MD_MetadataExtensionInformation> MetadataExtensionInfo {
    //  get {
    //    return _metadataExtensionInfo;
    //  }
    //  set {
    //    if (_metadataExtensionInfo == value) {
    //      return;
    //    }
    //    if (_metadataExtensionInfo == null || _metadataExtensionInfo.Equals(value) != true) {
    //      _metadataExtensionInfo = value;
    //      OnPropertyChanged();
    //    }
    //  }
    //}

    //private List<Parent_MD_Identification> _identificationInfo;

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlElement("identificationInfo", Order = 14, ElementName = "identificationInfo")]
    //[JsonProperty("identificationInfo", Order = 14)]
    //public List<Parent_MD_Identification> IdentificationInfo {
    //  get {
    //    return _identificationInfo;
    //  }
    //  set {
    //    if (_identificationInfo == value) {
    //      return;
    //    }
    //    if (_identificationInfo == null || _identificationInfo.Equals(value) != true) {
    //      _identificationInfo = value;
    //      OnPropertyChanged();
    //    }
    //  }
    //}

    //private List<MD_ContentInformation> _contentInfo;

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlElement("contentInfo", Order = 15, ElementName = "contentInfo")]
    //[JsonProperty("contentInfo", Order = 15)]
    //public List<MD_ContentInformation> ContentInfo {
    //  get {
    //    return _contentInfo;
    //  }
    //  set {
    //    if (_contentInfo == value) {
    //      return;
    //    }
    //    if (_contentInfo == null || _contentInfo.Equals(value) != true) {
    //      _contentInfo = value;
    //      OnPropertyChanged();
    //    }
    //  }
    //}

    private MD_Distribution _distributionInfo;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 16, ElementName = "distributionInfo")]
    [JsonProperty("distributionInfo", Order = 16)]
    public MD_Distribution DistributionInfo {
      get {
        return _distributionInfo;
      }
      set {
        if (_distributionInfo == value) {
          return;
        }
        if (_distributionInfo == null || _distributionInfo.Equals(value) != true) {
          _distributionInfo = value;
          OnPropertyChanged();
        }
      }
    }

    //private List<DQ_DataQuality> _dataQualityInfo;

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlElement("dataQualityInfo", Order = 17, ElementName = "dataQualityInfo")]
    //[JsonProperty("dataQualityInfo", Order = 17)]
    //public List<DQ_DataQuality> DataQualityInfo {
    //  get {
    //    return _dataQualityInfo;
    //  }
    //  set {
    //    if (_dataQualityInfo == value) {
    //      return;
    //    }
    //    if (_dataQualityInfo == null || _dataQualityInfo.Equals(value) != true) {
    //      _dataQualityInfo = value;
    //      OnPropertyChanged();
    //    }
    //  }
    //}

    //private List<Parent_MD_Constraints> _metadataConstraints;

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlElement("metadataConstraints", Order = 18, ElementName = "metadataConstraints")]
    //[JsonProperty("metadataConstraints", Order = 18)]
    //public List<Parent_MD_Constraints> MetadataConstraints {
    //  get {
    //    return _metadataConstraints;
    //  }
    //  set {
    //    if (_metadataConstraints == value) {
    //      return;
    //    }
    //    if (_metadataConstraints == null || _metadataConstraints.Equals(value) != true) {
    //      _metadataConstraints = value;
    //      OnPropertyChanged();
    //    }
    //  }
    //}

    //private List<MD_ApplicationSchemaInformation> _applicationSchemaInfo;

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlElement("applicationSchemaInfo", Order = 19, ElementName = "applicationSchemaInfo")]
    //[JsonProperty("applicationSchemaInfo", Order = 19)]
    //public List<MD_ApplicationSchemaInformation> ApplicationSchemaInfo {
    //  get {
    //    return _applicationSchemaInfo;
    //  }
    //  set {
    //    if (_applicationSchemaInfo == value) {
    //      return;
    //    }
    //    if (_applicationSchemaInfo == null || _applicationSchemaInfo.Equals(value) != true) {
    //      _applicationSchemaInfo = value;
    //      OnPropertyChanged();
    //    }
    //  }
    //}

    //private MD_MaintenanceInformation _metadataMaintenance;

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlElement(Order = 20, ElementName = "metadataMaintenance")]
    //[JsonProperty("metadataMaintenance", Order = 20)]
    //public MD_MaintenanceInformation MetadataMaintenance {
    //  get {
    //    return _metadataMaintenance;
    //  }
    //  set {
    //    if (_metadataMaintenance == value) {
    //      return;
    //    }
    //    if (_metadataMaintenance == null || _metadataMaintenance.Equals(value) != true) {
    //      _metadataMaintenance = value;
    //      OnPropertyChanged();
    //    }
    //  }
    //}

    private string _id;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(DataType = "ID", AttributeName = "id")]
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
