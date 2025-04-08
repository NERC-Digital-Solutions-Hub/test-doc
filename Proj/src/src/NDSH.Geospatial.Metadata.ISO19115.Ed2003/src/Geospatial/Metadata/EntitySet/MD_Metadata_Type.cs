
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 22/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/metadataEntity.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MD_Metadata_Type">
//   <xs:annotation>
//     <xs:documentation>Information about the metadata</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="fileIdentifier"
//                     type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="language"
//                     type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="characterSet"
//                     type="gmd:MD_CharacterSetCode_PropertyType" minOccurs="0"/>
//         <xs:element name="parentIdentifier"
//                     type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="hierarchyLevel"
//                     type="gmd:MD_ScopeCode_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="hierarchyLevelName"
//                     type="gco:CharacterString_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="contact"
//                     type="gmd:CI_ResponsibleParty_Type" maxOccurs="unbounded"/>
//         <xs:element name="dateStamp"
//                     type="gco:Date_PropertyType"/>
//         <xs:element name="metadataStandardName"
//                     type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="metadataStandardVersion"
//                     type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="dataSetURI"
//                     type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="locale"
//                     type="gmd:PT_Locale_Type" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="spatialRepresentationInfo"
//                     type="gmd:AbstractMD_SpatialRepresentation_Type" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="referenceSystemInfo"
//                     type="gmd:MD_ReferenceSystem_Type" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="metadataExtensionInfo"
//                     type="gmd:MD_MetadataExtensionInformation_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="identificationInfo"
//                     type="gmd:AbstractMD_Identification_Type" maxOccurs="unbounded"/>
//         <xs:element name="contentInfo"
//                     type="gmd:MD_ContentInformation_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="distributionInfo"
//                     type="gmd:MD_Distribution_PropertyType" minOccurs="0"/>
//         <xs:element name="dataQualityInfo"
//                     type="gmd:DQ_DataQuality_Type" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="portrayalCatalogueInfo"
//                     type="gmd:MD_PortrayalCatalogueReference_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="metadataConstraints"
//                     type="gmd:MD_Constraints_Type" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="applicationSchemaInfo"
//                     type="gmd:MD_ApplicationSchemaInformation_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="metadataMaintenance"
//                     type="gmd:MD_MaintenanceInformation_Type" minOccurs="0"/>
//         <xs:element name="series"
//                     type="gmd:AbstractDS_Aggregate_Type" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="describes"
//                     type="gmd:DS_DataSet_Type" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="propertyType"
//                     type="gco:ObjectReference_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="featureType"
//                     type="gco:ObjectReference_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="featureAttribute"
//                     type="gco:ObjectReference_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_Metadata" type="gmd:MD_Metadata_Type"/>
// 
// <xs:element name="LanguageCode" type="gco:CodeListValue_Type" substitutionGroup="gco:CharacterString"/>
// <xs:complexType name="MD_Metadata_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_Metadata"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.DateTime;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;

using NDSH.Geospatial.Metadata.Constraint;
using NDSH.Geospatial.Metadata.DataQuality;
using NDSH.Geospatial.Metadata.Distribution;
using NDSH.Geospatial.Metadata.Identification;
using NDSH.Geospatial.Metadata.Localisation;
using NDSH.Geospatial.Metadata.Maintenance;
using NDSH.Geospatial.Metadata.ReferenceSystem;
using NDSH.Hashing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.EntitySet {

  /// <summary>
  /// Root entity which defines metadata about a resource or resources.
  /// </summary>
  [Browsable(true)]
  [Serializable]
  //[XmlType("MD_Metadata", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_Metadata", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_Metadata")]
  public class MD_Metadata_Type : MetadataObject, IComparable<MD_Metadata_Type>, IEquatable<MD_Metadata_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Metadata_Type"/>.
    /// </summary>
    public MD_Metadata_Type() {

      //xmlns = new XmlSerializerNamespaces();
      //xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");
      //xmlns.Add("gco", "http://www.isotc211.org/2005/gco");
      //xmlns.Add("gml", "http://www.opengis.net/gml/3.2"); // TODO: DANGER !!! - Why the namespace here is different from the namespace in GML classes?
      //xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi"); // TODO: DANGER !!! - Does this needs to go here to allow reflection of /imagery objects?
      //xmlns.Add("gmx", "http://www.isotc211.org/2005/gmx");
      //xmlns.Add("gsr", "http://www.isotc211.org/2005/gsr");
      //xmlns.Add("gss", "http://www.isotc211.org/2005/gss");
      //xmlns.Add("gts", "http://www.isotc211.org/2005/gts");
      //xmlns.Add("srv", "http://www.isotc211.org/2005/srv");
      //xmlns.Add("xlink", "http://www.w3.org/1999/xlink");

      _fileIdentifier = default; // new CharacterString() ;
                                 //_language = default; // new CharacterString() ;
                                 //_characterSet = default; // new MD_CharacterSetCode_PropertyType() ;
                                 //_parentIdentifier = default; // new CharacterString() ;
                                 //_hierarchyLevel = default; // new List<MD_ScopeCode_PropertyType>();
                                 //_hierarchyLevelName = default; // new List<CharacterString>() ;
                                 //_contact = default; //  new List<CI_ResponsibleParty_Type>();
                                 //_dateStamp = new Date_PropertyType();
                                 //_metadataStandardName = default; // new CharacterString() ;
                                 //_metadataStandardVersion = default; // new CharacterString() ;
                                 //_dataSetURI = default; // new CharacterString() ;
                                 //_locale = default; // new List<PT_Locale_Type>() ;
                                 //_spatialRepresentationInfo = default; // new List<AbstractMD_SpatialRepresentation_Type>() ;
                                 //_referenceSystemInfo = default; // new List<MD_ReferenceSystem_Type>() ;
                                 //_metadataExtensionInfo = default; // new List<MD_MetadataExtensionInformation_PropertyType>() ;
                                 //_identificationInfo = new List<AbstractMD_Identification_Type>();
                                 //_contentInfo = default; // new List<MD_ContentInformation_PropertyType>() ;
                                 //_distributionInfo = default; // new MD_Distribution_PropertyType() ;
                                 //_dataQualityInfo = default; // new List<DQ_DataQuality_Type>() ;
                                 //_portrayalCatalogueInfo = default; // new List<MD_PortrayalCatalogueReference_PropertyType>() ;
                                 //_metadataConstraints = default; // new List<MD_Constraints_Type>() ;
                                 //_applicationSchemaInfo = default; // new List<MD_ApplicationSchemaInformation_PropertyType>() ;
                                 //_metadataMaintenance = default; // new MD_MaintenanceInformation_Type() ;

      // TODO: IMPORTANT !!! = The following attributes do not exist in the specification PDF but they exist in the ISO 19136 XSD files.
      //_series = default; // new List<AbstractDS_Aggregate_Type>() ;
      //_describes = default; // new List<DS_DataSet_Type>() ;
      //_propertyType = default; // new List<ObjectReference_PropertyType>() ;
      //_featureType = default; // new List<ObjectReference_PropertyType>() ; // CHRIS: Resovled see prop below: private List<GF_FeatureType> _featureType;
      //_featureAttribute = default; // new List<ObjectReference_PropertyType>()  // CHRIS: Resolved. see prop below: private List<GF_AttributeType> _featureAttribute;

    }

    #endregion

    #region Public Properties

    private CharacterString _fileIdentifier;

    /// <summary>
    /// Gets / Sets the unique identifier for this metadata file.
    /// </summary>
    [XmlElement("fileIdentifier", Order = 0)]
    [JsonProperty("fileIdentifier", Order = 0)]
    public CharacterString FileIdentifier {
      get => _fileIdentifier;
      set => SetProperty(ref _fileIdentifier, value);
    }

    private LanguageCode_CodeList _language;
    /// <summary>
    /// Gets / Sets the language used for documenting metadata.
    /// </summary>
    [XmlElement("language", Order = 1)]
    [JsonProperty("language", Order = 1)]
    public LanguageCode_CodeList Language {
      get => _language;
      set => SetProperty(ref _language, value);
    }

    private MD_CharacterSetCode_CodeList _characterSet;

    /// <summary>
    /// Gets / Sets the full name of the character coding
    /// standard used for the metadata set.
    /// </summary>
    [XmlElement("characterSet", Order = 2)]
    [JsonProperty("characterSet", Order = 2)]
    public MD_CharacterSetCode_CodeList CharacterSet {
      get => _characterSet;
      set => SetProperty(ref _characterSet, value);
    }

    private CharacterString _parentIdentifier;

    /// <summary>
    /// Gets / Sets the file identifier of the metadata
    /// to which this metadata is a subset (child).
    /// </summary>
    [XmlElement("parentIdentifier", Order = 3)]
    [JsonProperty("parentIdentifier", Order = 3)]
    public CharacterString ParentIdentifier {
      get => _parentIdentifier;
      set => SetProperty(ref _parentIdentifier, value);
    }

    private ObservableCollection<MD_ScopeCode_CodeList> _hierarchyLevel;

    /// <summary>
    /// Gets / Sets the scope to which the metadata applies.
    /// </summary>
    /// <remarks>
    /// More information about metadata hierarchy levels can be
    /// found in Annex H of the ISO 19115:2003 document.
    /// </remarks>
    [XmlElement("hierarchyLevel", Order = 4)]
    [JsonProperty("hierarchyLevel", Order = 4)]
    public ObservableCollection<MD_ScopeCode_CodeList> HierarchyLevel {
      get => _hierarchyLevel;
      set => SetProperty(ref _hierarchyLevel, value);
    }

    private ObservableCollection<CharacterString> _hierarchyLevelName;

    /// <summary>
    /// Gets / Sets the name of the hierarchy levels for which the metadata is provided.
    /// </summary>
    [XmlElement("hierarchyLevelName", Order = 5)]
    [JsonProperty("hierarchyLevelName", Order = 5)]
    public ObservableCollection<CharacterString> HierarchyLevelName {
      get => _hierarchyLevelName;
      set => SetProperty(ref _hierarchyLevelName, value);
    }

    private ObservableCollection<CI_ResponsibleParty_Type> _contact;

    /// <summary>
    /// Gets / Sets the party responsible for the metadata information.
    /// </summary>
    [XmlElement("contact", Order = 6)]
    [JsonProperty("contact", Order = 6)]
    public ObservableCollection<CI_ResponsibleParty_Type> Contact {
      get => _contact;
      set => SetProperty(ref _contact, value);
    }

    private DateDbEntity _dateStamp;

    /// <summary>
    /// Gets / Sets the date that the metadata was created.
    /// </summary>
    [XmlElement("dateStamp", Order = 7)]
    [JsonProperty("dateStamp", Order = 7)]
    public DateDbEntity DateStamp {
      get => _dateStamp;
      set => SetProperty(ref _dateStamp, value);
    }

    private CharacterString _metadataStandardName;

    /// <summary>
    /// Gets / Sets the name of the metadata standard (including profile name) used.
    /// </summary>
    [XmlElement("metadataStandardName", Order = 8)]
    [JsonProperty("metadataStandardName", Order = 8)]
    public CharacterString MetadataStandardName {
      get => _metadataStandardName;
      set => SetProperty(ref _metadataStandardName, value);
    }

    private CharacterString _metadataStandardVersion;

    /// <summary>
    /// Gets / Sets the version of the metadata standard (version of the profile) used.
    /// </summary>
    [XmlElement("metadataStandardVersion", Order = 9)]
    [JsonProperty("metadataStandardVersion", Order = 9)]
    public CharacterString MetadataStandardVersion {
      get => _metadataStandardVersion;
      set => SetProperty(ref _metadataStandardVersion, value);
    }

    private CharacterString _dataSetURI;

    /// <summary>
    /// Uniformed Resource Identifier (URI) of the dataset to which the metadata applies.
    /// </summary>
    [XmlElement("dataSetURI", Order = 10)]
    [JsonProperty("dataSetURI", Order = 10)]
    public CharacterString DataSetURI {
      get => _dataSetURI;
      set => SetProperty(ref _dataSetURI, value);
    }

    //private List<PT_Locale_Type> _locale;

    ///// <summary>
    ///// Gets / Sets the information about an alternatively used localized
    ///// character string for a linguistic extension.
    ///// </summary>
    //[XmlElement("locale", Order = 11)]
    //[JsonProperty("locale", Order = 11)]
    //public List<PT_Locale_Type> Locale {
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

    //private List<AbstractMD_SpatialRepresentation_Type> _spatialRepresentationInfo;

    ///// <summary>
    ///// Gets / Sets the digital representation of spatial information in the dataset.
    ///// </summary>
    //[XmlElement("spatialRepresentationInfo", Order = 12)]
    //[JsonProperty("spatialRepresentationInfo", Order = 12)]
    //public List<AbstractMD_SpatialRepresentation_Type> SpatialRepresentationInfo {
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

    private ObservableCollection<MD_ReferenceSystem_Type> _referenceSystemInfo;

    /// <summary>
    /// Gets / Sets the description of the spatial and
    /// temporal reference systems used in the dataset.
    /// </summary>
    [XmlElement("referenceSystemInfo", Order = 13)]
    [JsonProperty("referenceSystemInfo", Order = 13)]
    public ObservableCollection<MD_ReferenceSystem_Type> ReferenceSystemInfo {
      get => _referenceSystemInfo;
      set => SetProperty(ref _referenceSystemInfo, value);
    }

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

    private ObservableCollection<AbstractMD_Identification_Type> _identificationInfo;

    /// <summary>
    /// Gets / Sets the basic information about the resources to which the metadata applies.
    /// </summary>
    [XmlElement("identificationInfo", Order = 15)]
    [JsonProperty("identificationInfo", Order = 15)]
    public ObservableCollection<AbstractMD_Identification_Type> IdentificationInfo {
      get => _identificationInfo;
      set => SetProperty(ref _identificationInfo, value);
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

    private MD_Distribution_Type _distributionInfo;

    /// <summary>
    /// Gets / Sets the information about the distributor
    /// of and options for obtaining the resources.
    /// </summary>
    [XmlElement("distributionInfo", Order = 17)]
    [JsonProperty("distributionInfo", Order = 17)]
    public MD_Distribution_Type DistributionInfo {
      get => _distributionInfo;
      set => SetProperty(ref _distributionInfo, value);
    }

    private ObservableCollection<DQ_DataQuality_Type> _dataQualityInfo;

    /// <summary>
    /// Gets / Sets the overall assessment of quality of resources.
    /// </summary>
    [XmlElement("dataQualityInfo", Order = 18)]
    [JsonProperty("dataQualityInfo", Order = 18)]
    public ObservableCollection<DQ_DataQuality_Type> DataQualityInfo {
      get => _dataQualityInfo;
      set => SetProperty(ref _dataQualityInfo, value);
    }

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

    private ObservableCollection<MD_Constraints_Type> _metadataConstraints;

    /// <summary>
    /// Gets / Sets the restrictions on the access and use of metadata.
    /// </summary>
    [XmlElement("metadataConstraints", Order = 20)]
    [JsonProperty("metadataConstraints", Order = 20)]
    public ObservableCollection<MD_Constraints_Type> MetadataConstraints {
      get => _metadataConstraints;
      set => SetProperty(ref _metadataConstraints, value);
    }

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

    private MD_MaintenanceInformation_Type _metadataMaintenance;

    /// <summary>
    /// Gets / Sets information about the frequency of metadata updates,
    /// and the scope of those updates.
    /// </summary>
    [XmlElement("metadataMaintenance", Order = 22)]
    [JsonProperty("metadataMaintenance", Order = 22)]
    public MD_MaintenanceInformation_Type MetadataMaintenance {
      get => _metadataMaintenance;
      set => SetProperty(ref _metadataMaintenance, value);
    }

    //private List<AbstractDS_Aggregate_Type> _series;

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlElement("series", Order = 23)]
    //[JsonProperty("series", Order = 23)]
    //public List<AbstractDS_Aggregate_Type> Series {
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

    //private List<DS_DataSet_Type> _describes;

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlElement("describes", Order = 24)]
    //[JsonProperty("describes", Order = 24)]
    //public List<DS_DataSet_Type> Describes {
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




    //private List<GF_PropertyType> _propertyType;

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlElement("propertyType", Order = 25)]
    //[JsonProperty("propertyType", Order = 25)]
    //public List<GF_PropertyType> PropertyType {
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

    //private List<GF_FeatureType> _featureType;

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlElement("featureType", Order = 26)]
    //[JsonProperty("featureType", Order = 26)]
    //public List<GF_FeatureType> FeatureType {
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

    //private List<GF_AttributeType> _featureAttribute;

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlElement("featureAttribute", Order = 27)]
    //[JsonProperty("featureAttribute", Order = 27)]
    //public List<GF_AttributeType> FeatureAttribute {
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


    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="MD_Metadata_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="MD_Metadata_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(MD_Metadata_Type? other) {

      int result;

      return
        (other is null) ? 1 :
        (result = FileIdentifier.CompareTo(other.FileIdentifier)) != 0 ? result :
          (result = Language.CompareTo(other.Language)) != 0 ? result :
          (result = CharacterSet.CompareTo(other.CharacterSet)) != 0 ? result :
          (result = ParentIdentifier.CompareTo(other.ParentIdentifier)) != 0 ? result :
          (result = HierarchyLevel?.Count.CompareTo(other.HierarchyLevel?.Count ?? 0) ?? 1) != 0 ? result :
          (result = HierarchyLevelName?.Count.CompareTo(other.HierarchyLevelName?.Count ?? 1) ?? 1) != 0 ? result :
          (result = Contact?.Count.CompareTo(other.Contact?.Count ?? 0) ?? 1) != 0 ? result :
          (result = DateStamp.CompareTo(other.DateStamp)) != 0 ? result :
          (result = MetadataStandardName.CompareTo(other.MetadataStandardName)) != 0 ? result :
          (result = MetadataStandardVersion.CompareTo(other.MetadataStandardVersion)) != 0 ? result :
          (result = DataSetURI.CompareTo(other.DataSetURI)) != 0 ? result :
          (result = ReferenceSystemInfo?.Count.CompareTo(other.ReferenceSystemInfo?.Count ?? 0) ?? 1) != 0 ? result :
          (result = IdentificationInfo?.Count.CompareTo(other.IdentificationInfo?.Count ?? 0) ?? 1) != 0 ? result :
          (result = DistributionInfo.CompareTo(other.DistributionInfo)) != 0 ? result :
          (result = DataQualityInfo?.Count.CompareTo(other.DataQualityInfo?.Count ?? 0) ?? 1) != 0 ? result :
          (result = MetadataConstraints?.Count.CompareTo(other.MetadataConstraints?.Count ?? 0) ?? 1) != 0 ? result :
          MetadataMaintenance.CompareTo(other.MetadataMaintenance);
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="MD_Metadata_Type"/> is equal to the current <see cref="MD_Metadata_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="MD_Metadata_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(MD_Metadata_Type? other) {
      return other != null &&
          Equals(FileIdentifier, other.FileIdentifier) &&
          Equals(Language, other.Language) &&
          Equals(CharacterSet, other.CharacterSet) &&
          Equals(ParentIdentifier, other.ParentIdentifier) &&
          HierarchyLevel.SequenceEqualOrdered(other.HierarchyLevel) &&
          HierarchyLevelName.SequenceEqualOrdered(other.HierarchyLevelName) &&
          Contact.SequenceEqualOrdered(other.Contact) &&
          Equals(DateStamp, other.DateStamp) &&
          Equals(MetadataStandardName, other.MetadataStandardName) &&
          Equals(MetadataStandardVersion, other.MetadataStandardVersion) &&
          Equals(DataSetURI, other.DataSetURI) &&
          ReferenceSystemInfo.SequenceEqualOrdered(other.ReferenceSystemInfo) &&
          IdentificationInfo.SequenceEqualOrdered(other.IdentificationInfo) &&
          Equals(DistributionInfo, other.DistributionInfo) &&
          DataQualityInfo.SequenceEqualOrdered(other.DataQualityInfo) &&
          MetadataConstraints.SequenceEqualOrdered(other.MetadataConstraints) &&
          Equals(MetadataMaintenance, other.MetadataMaintenance);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="MD_Metadata_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as MD_Metadata_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="MD_Metadata_Type"/> using <see cref="NdshHashCode"/>. This will also order 
    /// collections before hashing them.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      hash.Add(FileIdentifier);
      hash.Add(Language);
      hash.Add(CharacterSet);
      hash.Add(ParentIdentifier);

      foreach (CharacterString characterString in HierarchyLevel.SafeOrderBy()) {
        hash.Add(characterString);
      }

      foreach (CharacterString characterString in HierarchyLevelName.SafeOrderBy()) {
        hash.Add(characterString);
      }

      foreach (CI_ResponsibleParty_Type responsibleParty in Contact.SafeOrderBy()) {
        hash.Add(responsibleParty);
      }

      hash.Add(DateStamp);
      hash.Add(MetadataStandardName);
      hash.Add(MetadataStandardVersion);
      hash.Add(DataSetURI);

      foreach (MD_ReferenceSystem_Type referenceSystem in ReferenceSystemInfo.SafeOrderBy()) {
        hash.Add(referenceSystem);
      }

      foreach (AbstractMD_Identification_Type identification in IdentificationInfo.SafeOrderBy()) {
        hash.Add(identification);
      }

      hash.Add(DistributionInfo);

      foreach (DQ_DataQuality_Type dataQuality in DataQualityInfo.SafeOrderBy()) {
        hash.Add(dataQuality);
      }

      foreach (MD_Constraints_Type constraints in MetadataConstraints.SafeOrderBy()) {
        hash.Add(constraints);
      }

      hash.Add(MetadataMaintenance);

      return hash.ToHashCode();
    }

    #endregion

  }

}
