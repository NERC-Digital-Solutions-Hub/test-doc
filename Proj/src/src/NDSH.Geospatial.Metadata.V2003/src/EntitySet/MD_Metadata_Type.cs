
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 22/12/2022, 03:22, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gmd/metadataEntity.xsd
// --------------------------------------------------------------------------------
// <xs:complexType name="MD_Metadata_Type">
//   <xs:annotation>
//     <xs:documentation>Information about the metadata</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="fileIdentifier" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="language" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="characterSet" type="gmd:MD_CharacterSetCode_PropertyType" minOccurs="0"/>
//         <xs:element name="parentIdentifier" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="hierarchyLevel" type="gmd:MD_ScopeCode_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="hierarchyLevelName" type="gco:CharacterString_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="contact" type="gmd:CI_ResponsibleParty_PropertyType" maxOccurs="unbounded"/>
//         <xs:element name="dateStamp" type="gco:Date_PropertyType"/>
//         <xs:element name="metadataStandardName" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="metadataStandardVersion" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="dataSetURI" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="locale" type="gmd:PT_Locale_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="spatialRepresentationInfo" type="gmd:MD_SpatialRepresentation_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="referenceSystemInfo" type="gmd:MD_ReferenceSystem_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="metadataExtensionInfo" type="gmd:MD_MetadataExtensionInformation_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="identificationInfo" type="gmd:MD_Identification_PropertyType" maxOccurs="unbounded"/>
//         <xs:element name="contentInfo" type="gmd:MD_ContentInformation_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="distributionInfo" type="gmd:MD_Distribution_PropertyType" minOccurs="0"/>
//         <xs:element name="dataQualityInfo" type="gmd:DQ_DataQuality_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="portrayalCatalogueInfo" type="gmd:MD_PortrayalCatalogueReference_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="metadataConstraints" type="gmd:MD_Constraints_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="applicationSchemaInfo" type="gmd:MD_ApplicationSchemaInformation_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="metadataMaintenance" type="gmd:MD_MaintenanceInformation_PropertyType" minOccurs="0"/>
//         <xs:element name="series" type="gmd:DS_Aggregate_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="describes" type="gmd:DS_DataSet_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="propertyType" type="gco:ObjectReference_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="featureType" type="gco:ObjectReference_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="featureAttribute" type="gco:ObjectReference_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_Metadata" type="gmd:MD_Metadata_Type"/>
//
// <xs:element name="LanguageCode" type="gco:CodeListValue_Type" substitutionGroup="gco:CharacterString"/>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Microsoft.VisualBasic;
using NDSH.Geospatial.Metadata.V2003.Application;
using NDSH.Geospatial.Metadata.V2003.ApplicationSchema;
using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.Common.Citation;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.DateTime;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text;
using NDSH.Geospatial.Metadata.V2003.Constraint;
using NDSH.Geospatial.Metadata.V2003.Content;
using NDSH.Geospatial.Metadata.V2003.DataQuality;
using NDSH.Geospatial.Metadata.V2003.Distribution;
using NDSH.Geospatial.Metadata.V2003.Extension;
using NDSH.Geospatial.Metadata.V2003.Features.Model;
using NDSH.Geospatial.Metadata.V2003.Identification;
using NDSH.Geospatial.Metadata.V2003.Imagery.EntitySet;
using NDSH.Geospatial.Metadata.V2003.Localisation;
using NDSH.Geospatial.Metadata.V2003.Maintenance;
using NDSH.Geospatial.Metadata.V2003.PortrayalCatalogue;
using NDSH.Geospatial.Metadata.V2003.ReferenceSystem;
using NDSH.Geospatial.Metadata.V2003.SpatialRepresentation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.EntitySet {

  /// <summary>
  /// Root entity which defines metadata about a resource or resources.
  /// </summary>
  [Browsable(true)]
  //[XmlInclude(typeof(MI_Metadata_Type))] // TODO: This include here causes an error during serialization
  [Serializable]
  [XmlType("MD_Metadata", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_Metadata", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_Metadata")]
  public class MD_Metadata_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Metadata_Type"/>.
    /// </summary>
    public MD_Metadata_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");
      xmlns.Add("gco", "http://www.isotc211.org/2005/gco");
      xmlns.Add("gml", "http://www.opengis.net/gml/3.2"); // TODO: DANGER !!! - Why the namespace here is different from the namespace in GML classes?
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi"); // TODO: DANGER !!! - Does this needs to go here to allow reflection of /imagery objects?
      xmlns.Add("gmx", "http://www.isotc211.org/2005/gmx");
      xmlns.Add("gsr", "http://www.isotc211.org/2005/gsr");
      xmlns.Add("gss", "http://www.isotc211.org/2005/gss");
      xmlns.Add("gts", "http://www.isotc211.org/2005/gts");
      xmlns.Add("srv", "http://www.isotc211.org/2005/srv");
      xmlns.Add("xlink", "http://www.w3.org/1999/xlink");

      _fileIdentifier = default; // new CharacterString_PropertyType() ;
      //_language = default; // new CharacterString_PropertyType() ;
      //_characterSet = default; // new MD_CharacterSetCode_PropertyType() ;
      //_parentIdentifier = default; // new CharacterString_PropertyType() ;
      //_hierarchyLevel = default; // new List<MD_ScopeCode_PropertyType>();
      //_hierarchyLevelName = default; // new List<CharacterString_PropertyType>() ;
      //_contact = default; //  new List<CI_ResponsibleParty_PropertyType>();
      //_dateStamp = new Date_PropertyType();
      //_metadataStandardName = default; // new CharacterString_PropertyType() ;
      //_metadataStandardVersion = default; // new CharacterString_PropertyType() ;
      //_dataSetURI = default; // new CharacterString_PropertyType() ;
      //_locale = default; // new List<PT_Locale_PropertyType>() ;
      //_spatialRepresentationInfo = default; // new List<MD_SpatialRepresentation_PropertyType>() ;
      //_referenceSystemInfo = default; // new List<MD_ReferenceSystem_PropertyType>() ;
      //_metadataExtensionInfo = default; // new List<MD_MetadataExtensionInformation_PropertyType>() ;
      _identificationInfo = new List<MD_Identification_PropertyType>();
      //_contentInfo = default; // new List<MD_ContentInformation_PropertyType>() ;
      //_distributionInfo = default; // new MD_Distribution_PropertyType() ;
      //_dataQualityInfo = default; // new List<DQ_DataQuality_PropertyType>() ;
      //_portrayalCatalogueInfo = default; // new List<MD_PortrayalCatalogueReference_PropertyType>() ;
      //_metadataConstraints = default; // new List<MD_Constraints_PropertyType>() ;
      //_applicationSchemaInfo = default; // new List<MD_ApplicationSchemaInformation_PropertyType>() ;
      //_metadataMaintenance = default; // new MD_MaintenanceInformation_PropertyType() ;

      // TODO: IMPORTANT !!! = The following attributes do not exist in the specification PDF but they exist in the ISO 19136 XSD files.
      //_series = default; // new List<DS_Aggregate_PropertyType>() ;
      //_describes = default; // new List<DS_DataSet_PropertyType>() ;
      //_propertyType = default; // new List<ObjectReference_PropertyType>() ;
      //_featureType = default; // new List<ObjectReference_PropertyType>() ; // CHRIS: Resovled see prop below: private List<GF_Feature_PropertyType> _featureType;
      //_featureAttribute = default; // new List<ObjectReference_PropertyType>()  // CHRIS: Resolved. see prop below: private List<GF_Attribute_PropertyType> _featureAttribute;

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

    private CharacterString_PropertyType _fileIdentifier;

    /// <summary>
    /// Gets / Sets the unique identifier for this metadata file.
    /// </summary>
    [XmlElement("fileIdentifier", Order = 0)]
    [JsonProperty("fileIdentifier", Order = 0)]
    public CharacterString_PropertyType FileIdentifier {
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

    // Originally Language is a characterString. However NERC metadata encodes this using LanguageCode_PropertyType.

    //private CharacterString_PropertyType _language;

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlElement("language", Order = 1)]
    //[JsonProperty("language", Order = 1)]
    //public CharacterString_PropertyType Language {
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

    //private LanguageCode_PropertyType _language;

    ///// <summary>
    ///// Gets / Sets the language used for documenting metadata.
    ///// </summary>
    //[XmlElement("language", Order = 1)]
    //[JsonProperty("language", Order = 1)]
    //public LanguageCode_PropertyType Language {
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

    private SubstitutableText _language;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("language", Order = 1)]
    [JsonProperty("language", Order = 1)]
    public SubstitutableText Language {
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

    //private CharacterString _language;

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlElement("language", Order = 1)]
    //[JsonProperty("language", Order = 1)]
    //public CharacterString Language {
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




    //private ISubstitutionRelation _language;

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlElement("language", Order = 1)]
    //[JsonProperty("language", Order = 1)]
    //public ISubstitutionRelation Language {
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

    //private MD_CharacterSetCode_PropertyType _characterSet;

    ///// <summary>
    ///// Gets / Sets the full name of the character coding
    ///// standard used for the metadata set.
    ///// </summary>
    //[XmlElement("characterSet", Order = 2)]
    //[JsonProperty("characterSet", Order = 2)]
    //public MD_CharacterSetCode_PropertyType CharacterSet {
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

    //private CharacterString_PropertyType _parentIdentifier;

    ///// <summary>
    ///// Gets / Sets the file identifier of the metadata
    ///// to which this metadata is a subset (child).
    ///// </summary>
    //[XmlElement("parentIdentifier", Order = 3)]
    //[JsonProperty("parentIdentifier", Order = 3)]
    //public CharacterString_PropertyType ParentIdentifier {
    //  get {
    //    return _parentIdentifier;
    //  }
    //  set {
    //    if (_parentIdentifier == value) {
    //      return;
    //    }
    //    if (_parentIdentifier == null || _parentIdentifier.Equals(value) != true) {
    //      _parentIdentifier = value;
    //      OnPropertyChanged();
    //    }
    //  }
    //}

    //private List<MD_ScopeCode_PropertyType> _hierarchyLevel;

    ///// <summary>
    ///// Gets / Sets the scope to which the metadata applies.
    ///// </summary>
    ///// <remarks>
    ///// More information about metadata hierarchy levels can be
    ///// found in Annex H of the ISO 19115:2003 document.
    ///// </remarks>
    //[XmlElement("hierarchyLevel", Order = 4)]
    //[JsonProperty("hierarchyLevel", Order = 4)]
    //public List<MD_ScopeCode_PropertyType> HierarchyLevel {
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

    //private List<CharacterString_PropertyType> _hierarchyLevelName;

    ///// <summary>
    ///// Gets / Sets the name of the hierarchy levels for which the metadata is provided.
    ///// </summary>
    //[XmlElement("hierarchyLevelName", Order = 5)]
    //[JsonProperty("hierarchyLevelName", Order = 5)]
    //public List<CharacterString_PropertyType> HierarchyLevelName {
    //  get {
    //    return _hierarchyLevelName;
    //  }
    //  set {
    //    if (_hierarchyLevelName == value) {
    //      return;
    //    }
    //    if (_hierarchyLevelName == null || _hierarchyLevelName.Equals(value) != true) {
    //      _hierarchyLevelName = value;
    //      OnPropertyChanged();
    //    }
    //  }
    //}

    //private List<CI_ResponsibleParty_PropertyType> _contact;

    ///// <summary>
    ///// Gets / Sets the party responsible for the metadata information.
    ///// </summary>
    //[XmlElement("contact", Order = 6)]
    //[JsonProperty("contact", Order = 6)]
    //public List<CI_ResponsibleParty_PropertyType> Contact {
    //  get {
    //    return _contact;
    //  }
    //  set {
    //    if (_contact == value) {
    //      return;
    //    }
    //    if (_contact == null || _contact.Equals(value) != true) {
    //      _contact = value;
    //      OnPropertyChanged();
    //    }
    //  }
    //}

    //private Date_PropertyType _dateStamp;

    ///// <summary>
    ///// Gets / Sets the date that the metadata was created.
    ///// </summary>
    //[XmlElement("dateStamp", Order = 7)]
    //[JsonProperty("dateStamp", Order = 7)]
    //public Date_PropertyType DateStamp {
    //  get {
    //    return _dateStamp;
    //  }
    //  set {
    //    if (_dateStamp == value) {
    //      return;
    //    }
    //    if (_dateStamp == null || _dateStamp.Equals(value) != true) {
    //      _dateStamp = value;
    //      OnPropertyChanged();
    //    }
    //  }
    //}

    //private CharacterString_PropertyType _metadataStandardName;

    ///// <summary>
    ///// Gets / Sets the name of the metadata standard (including profile name) used.
    ///// </summary>
    //[XmlElement("metadataStandardName", Order = 8)]
    //[JsonProperty("metadataStandardName", Order = 8)]
    //public CharacterString_PropertyType MetadataStandardName {
    //  get {
    //    return _metadataStandardName;
    //  }
    //  set {
    //    if (_metadataStandardName == value) {
    //      return;
    //    }
    //    if (_metadataStandardName == null || _metadataStandardName.Equals(value) != true) {
    //      _metadataStandardName = value;
    //      OnPropertyChanged();
    //    }
    //  }
    //}

    //private CharacterString_PropertyType _metadataStandardVersion;

    ///// <summary>
    ///// Gets / Sets the version of the metadata standard (version of the profile) used.
    ///// </summary>
    //[XmlElement("metadataStandardVersion", Order = 9)]
    //[JsonProperty("metadataStandardVersion", Order = 9)]
    //public CharacterString_PropertyType MetadataStandardVersion {
    //  get {
    //    return _metadataStandardVersion;
    //  }
    //  set {
    //    if (_metadataStandardVersion == value) {
    //      return;
    //    }
    //    if (_metadataStandardVersion == null || _metadataStandardVersion.Equals(value) != true) {
    //      _metadataStandardVersion = value;
    //      OnPropertyChanged();
    //    }
    //  }
    //}

    //private CharacterString_PropertyType _dataSetURI;

    ///// <summary>
    ///// Uniformed Resource Identifier (URI) of the dataset to which the metadata applies.
    ///// </summary>
    //[XmlElement("dataSetURI", Order = 10)]
    //[JsonProperty("dataSetURI", Order = 10)]
    //public CharacterString_PropertyType DataSetURI {
    //  get {
    //    return _dataSetURI;
    //  }
    //  set {
    //    if (_dataSetURI == value) {
    //      return;
    //    }
    //    if (_dataSetURI == null || _dataSetURI.Equals(value) != true) {
    //      _dataSetURI = value;
    //      OnPropertyChanged();
    //    }
    //  }
    //}

    //private List<PT_Locale_PropertyType> _locale;

    ///// <summary>
    ///// Gets / Sets the information about an alternatively used localized
    ///// character string for a linguistic extension.
    ///// </summary>
    //[XmlElement("locale", Order = 11)]
    //[JsonProperty("locale", Order = 11)]
    //public List<PT_Locale_PropertyType> Locale {
    //  get {
    //    return _locale;
    //  }
    //  set {
    //    if (_locale == value) {
    //      return;
    //    }
    //    if (_locale == null || _locale.Equals(value) != true) {
    //      _locale = value;
    //      OnPropertyChanged();
    //    }
    //  }
    //}

    //private List<MD_SpatialRepresentation_PropertyType> _spatialRepresentationInfo;

    ///// <summary>
    ///// Gets / Sets the digital representation of spatial information in the dataset.
    ///// </summary>
    //[XmlElement("spatialRepresentationInfo", Order = 12)]
    //[JsonProperty("spatialRepresentationInfo", Order = 12)]
    //public List<MD_SpatialRepresentation_PropertyType> SpatialRepresentationInfo {
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

    //private List<MD_ReferenceSystem_PropertyType> _referenceSystemInfo;

    ///// <summary>
    ///// Gets / Sets the description of the spatial and
    ///// temporal reference systems used in the dataset.
    ///// </summary>
    //[XmlElement("referenceSystemInfo", Order = 13)]
    //[JsonProperty("referenceSystemInfo", Order = 13)]
    //public List<MD_ReferenceSystem_PropertyType> ReferenceSystemInfo {
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

    //private List<MD_MetadataExtensionInformation_PropertyType> _metadataExtensionInfo;

    ///// <summary>
    ///// Gets / Sets the information describing metadata extensions.
    ///// </summary>
    //[XmlElement("metadataExtensionInfo", Order = 14)]
    //[JsonProperty("metadataExtensionInfo", Order = 14)]
    //public List<MD_MetadataExtensionInformation_PropertyType> MetadataExtensionInfo {
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

    private List<MD_Identification_PropertyType> _identificationInfo;

    /// <summary>
    /// Gets / Sets the basic information about the resources to which the metadata applies.
    /// </summary>
    [XmlElement("identificationInfo", Order = 15)]
    [JsonProperty("identificationInfo", Order = 15)]
    public List<MD_Identification_PropertyType> IdentificationInfo {
      get {
        return _identificationInfo;
      }
      set {
        if (_identificationInfo == value) {
          return;
        }
        if (_identificationInfo == null || _identificationInfo.Equals(value) != true) {
          _identificationInfo = value;
          OnPropertyChanged();
        }
      }
    }

    //private List<MD_ContentInformation_PropertyType> _contentInfo;

    ///// <summary>
    ///// Gets / Sets the information about the feature catalogue and
    ///// describes the coverage and image data characteristics.
    ///// </summary>
    //[XmlElement("contentInfo", Order = 16)]
    //[JsonProperty("contentInfo", Order = 16)]
    //public List<MD_ContentInformation_PropertyType> ContentInfo {
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

    //private MD_Distribution_PropertyType _distributionInfo;

    ///// <summary>
    ///// Gets / Sets the information about the distributor
    ///// of and options for obtaining the resources.
    ///// </summary>
    //[XmlElement("distributionInfo", Order = 17)]
    //[JsonProperty("distributionInfo", Order = 17)]
    //public MD_Distribution_PropertyType DistributionInfo {
    //  get {
    //    return _distributionInfo;
    //  }
    //  set {
    //    if (_distributionInfo == value) {
    //      return;
    //    }
    //    if (_distributionInfo == null || _distributionInfo.Equals(value) != true) {
    //      _distributionInfo = value;
    //      OnPropertyChanged();
    //    }
    //  }
    //}

    //private List<DQ_DataQuality_PropertyType> _dataQualityInfo;

    ///// <summary>
    ///// Gets / Sets the overall assessment of quality of resources.
    ///// </summary>
    //[XmlElement("dataQualityInfo", Order = 18)]
    //[JsonProperty("dataQualityInfo", Order = 18)]
    //public List<DQ_DataQuality_PropertyType> DataQualityInfo {
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

    //private List<MD_PortrayalCatalogueReference_PropertyType> _portrayalCatalogueInfo;

    ///// <summary>
    ///// Gets / Sets the information about the catalogue
    ///// of rules defined for the portrayal of a resource/
    ///// </summary>
    //[XmlElement("portrayalCatalogueInfo", Order = 19)]
    //[JsonProperty("portrayalCatalogueInfo", Order = 19)]
    //public List<MD_PortrayalCatalogueReference_PropertyType> PortrayalCatalogueInfo {
    //  get {
    //    return _portrayalCatalogueInfo;
    //  }
    //  set {
    //    if (_portrayalCatalogueInfo == value) {
    //      return;
    //    }
    //    if (_portrayalCatalogueInfo == null || _portrayalCatalogueInfo.Equals(value) != true) {
    //      _portrayalCatalogueInfo = value;
    //      OnPropertyChanged();
    //    }
    //  }
    //}

    //private List<MD_Constraints_PropertyType> _metadataConstraints;

    ///// <summary>
    ///// Gets / Sets the restrictions on the access and use of metadata.
    ///// </summary>
    //[XmlElement("metadataConstraints", Order = 20)]
    //[JsonProperty("metadataConstraints", Order = 20)]
    //public List<MD_Constraints_PropertyType> MetadataConstraints {
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

    //private List<MD_ApplicationSchemaInformation_PropertyType> _applicationSchemaInfo;

    ///// <summary>
    ///// Gets / Sets the information about the conceptual schema of a dataset.
    ///// </summary>
    //[XmlElement("applicationSchemaInfo", Order = 21)]
    //[JsonProperty("applicationSchemaInfo", Order = 21)]
    //public List<MD_ApplicationSchemaInformation_PropertyType> ApplicationSchemaInfo {
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

    //private MD_MaintenanceInformation_PropertyType _metadataMaintenance;

    ///// <summary>
    ///// Gets / Sets information about the frequency of metadata updates,
    ///// and the scope of those updates.
    ///// </summary>
    //[XmlElement("metadataMaintenance", Order = 22)]
    //[JsonProperty("metadataMaintenance", Order = 22)]
    //public MD_MaintenanceInformation_PropertyType MetadataMaintenance {
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

    //private List<DS_Aggregate_PropertyType> _series;

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlElement("series", Order = 23)]
    //[JsonProperty("series", Order = 23)]
    //public List<DS_Aggregate_PropertyType> Series {
    //  get {
    //    return _series;
    //  }
    //  set {
    //    if (_series == value) {
    //      return;
    //    }
    //    if (_series == null || _series.Equals(value) != true) {
    //      _series = value;
    //      OnPropertyChanged();
    //    }
    //  }
    //}

    //private List<DS_DataSet_PropertyType> _describes;

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlElement("describes", Order = 24)]
    //[JsonProperty("describes", Order = 24)]
    //public List<DS_DataSet_PropertyType> Describes {
    //  get {
    //    return _describes;
    //  }
    //  set {
    //    if (_describes == value) {
    //      return;
    //    }
    //    if (_describes == null || _describes.Equals(value) != true) {
    //      _describes = value;
    //      OnPropertyChanged();
    //    }
    //  }
    //}




    //private List<GF_Property_PropertyType> _propertyType;

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlElement("propertyType", Order = 25)]
    //[JsonProperty("propertyType", Order = 25)]
    //public List<GF_Property_PropertyType> PropertyType {
    //  get {
    //    return _propertyType;
    //  }
    //  set {
    //    if (_propertyType == value) {
    //      return;
    //    }
    //    if (_propertyType == null || _propertyType.Equals(value) != true) {
    //      _propertyType = value;
    //      OnPropertyChanged();
    //    }
    //  }
    //}

    //private List<GF_Feature_PropertyType> _featureType;

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlElement("featureType", Order = 26)]
    //[JsonProperty("featureType", Order = 26)]
    //public List<GF_Feature_PropertyType> FeatureType {
    //  get {
    //    return _featureType;
    //  }
    //  set {
    //    if (_featureType == value) {
    //      return;
    //    }
    //    if (_featureType == null || _featureType.Equals(value) != true) {
    //      _featureType = value;
    //      OnPropertyChanged();
    //    }
    //  }
    //}

    //private List<GF_Attribute_PropertyType> _featureAttribute;

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlElement("featureAttribute", Order = 27)]
    //[JsonProperty("featureAttribute", Order = 27)]
    //public List<GF_Attribute_PropertyType> FeatureAttribute {
    //  get {
    //    return _featureAttribute;
    //  }
    //  set {
    //    if (_featureAttribute == value) {
    //      return;
    //    }
    //    if (_featureAttribute == null || _featureAttribute.Equals(value) != true) {
    //      _featureAttribute = value;
    //      OnPropertyChanged();
    //    }
    //  }
    //}

    #endregion

  }

}