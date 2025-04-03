
#region Header
// Title Name        : MD_Metadata_Type
// Member of         : NDSH.Geospatial.Metadata.dll
// Description       : 
// Created by        : 09/09/2022, 20:45, Vasilis Vlastaras.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : 
// License           : 
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata {

  /// <summary>
  /// 
  /// </summary>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "http://standards.iso.org/iso/19115/-3/mdb/2.0")]
  [XmlRootAttribute("MD_Metadata", Namespace = "http://standards.iso.org/iso/19115/-3/mdb/2.0", IsNullable = false)]
  [JsonObject("MD_Metadata_Type")]
  public class MD_Metadata_Type : Abstract_Metadata_Type {

    #region Constructors - Destructors

    /// <summary>
    /// MD_Metadata_Type class constructor
    /// </summary>
    public MD_Metadata_Type() {
      //_acquisitionInformation = new List<Abstract_AcquisitionInformation_PropertyType>();
      //_metadataMaintenance = new Abstract_MaintenanceInformation_PropertyType();
      //_applicationSchemaInfo = new List<Abstract_ApplicationSchemaInformation_PropertyType>();
      //_metadataConstraints = new List<Abstract_Constraints_PropertyType>();
      //_portrayalCatalogueInfo = new List<Abstract_PortrayalCatalogueInformation_PropertyType>();
      //_resourceLineage = new List<Abstract_LineageInformation_PropertyType>();
      //_dataQualityInfo = new List<Abstract_DataQuality_PropertyType>();
      //_distributionInfo = new List<Abstract_Distribution_PropertyType>();
      //_contentInfo = new List<Abstract_ContentInformation_PropertyType>();
      //_identificationInfo = new List<Abstract_ResourceDescription_PropertyType>();
      //_metadataExtensionInfo = new List<Abstract_MetadataExtension_PropertyType>();
      //_referenceSystemInfo = new List<Abstract_ReferenceSystem_PropertyType>();
      //_spatialRepresentationInfo = new List<Abstract_SpatialRepresentation_PropertyType>();
      //_metadataLinkage = new List<Abstract_OnlineResource_PropertyType>();
      //_otherLocale = new List<PT_Locale_PropertyType>();
      //_alternativeMetadataReference = new List<Abstract_Citation_PropertyType>();
      //_metadataProfile = new List<Abstract_Citation_PropertyType>();
      //_metadataStandard = new List<Abstract_Citation_PropertyType>();
      //_dateInfo = new List<Abstract_TypedDate_PropertyType>();
      //_contact = new List<Abstract_Responsibility_PropertyType>();
      //_metadataScope = new List<MD_MetadataScope_PropertyType>();
      //_parentMetadata = new Abstract_Citation_PropertyType();
      //_defaultLocale = new PT_Locale_PropertyType();
      //_metadataIdentifier = new MD_Identifier_PropertyType();
    }

    #endregion

    #region Public Properties

    //private MD_Identifier_PropertyType _metadataIdentifier;

    //[XmlElement(Order = 0, ElementName = "metadataIdentifier")]
    //[JsonProperty("metadataIdentifier", Order = 0)]
    //public MD_Identifier_PropertyType MetadataIdentifier {
    //  get {
    //    return _metadataIdentifier;
    //  }
    //  set {
    //    if ((_metadataIdentifier == value)) {
    //      return;
    //    }
    //    if (((_metadataIdentifier == null)
    //                || (_metadataIdentifier.Equals(value) != true))) {
    //      _metadataIdentifier = value;
    //      OnPropertyChanged("MetadataIdentifier");
    //    }
    //  }
    //}

    //private PT_Locale_PropertyType _defaultLocale;
    
    ///// <summary>
    ///// Provides information about an alternatively used localized character string for a linguistic extension
    ///// </summary>
    //[XmlElement(Order = 1, ElementName = "defaultLocale")]
    //[JsonProperty("defaultLocale", Order = 1)]
    //public PT_Locale_PropertyType DefaultLocale {
    //  get {
    //    return _defaultLocale;
    //  }
    //  set {
    //    if ((_defaultLocale == value)) {
    //      return;
    //    }
    //    if (((_defaultLocale == null)
    //                || (_defaultLocale.Equals(value) != true))) {
    //      _defaultLocale = value;
    //      OnPropertyChanged("DefaultLocale");
    //    }
    //  }
    //}

    //private Abstract_Citation_PropertyType _parentMetadata;
    
    ///// <summary>
    ///// Identifier and onlineResource for a parent metadata record
    ///// </summary>
    //[XmlElement(Order = 2, ElementName = "parentMetadata")]
    //[JsonProperty("parentMetadata", Order = 2)]
    //public Abstract_Citation_PropertyType ParentMetadata {
    //  get {
    //    return _parentMetadata;
    //  }
    //  set {
    //    if ((_parentMetadata == value)) {
    //      return;
    //    }
    //    if (((_parentMetadata == null)
    //                || (_parentMetadata.Equals(value) != true))) {
    //      _parentMetadata = value;
    //      OnPropertyChanged("ParentMetadata");
    //    }
    //  }
    //}

    //private List<MD_MetadataScope_PropertyType> _metadataScope;
    
    //[XmlElement("metadataScope", Order = 3, ElementName = "metadataScope")]
    //[JsonProperty("metadataScope", Order = 3)]
    //public List<MD_MetadataScope_PropertyType> MetadataScope {
    //  get {
    //    return _metadataScope;
    //  }
    //  set {
    //    if ((_metadataScope == value)) {
    //      return;
    //    }
    //    if (((_metadataScope == null)
    //                || (_metadataScope.Equals(value) != true))) {
    //      _metadataScope = value;
    //      OnPropertyChanged("MetadataScope");
    //    }
    //  }
    //}

    //private List<Abstract_Responsibility_PropertyType> _contact;
    
    ///// <summary>
    ///// party responsible for the metadata information
    ///// </summary>
    //[XmlElement("contact", Order = 4, ElementName = "contact")]
    //[JsonProperty("contact", Order = 4)]
    //public List<Abstract_Responsibility_PropertyType> Contact {
    //  get {
    //    return _contact;
    //  }
    //  set {
    //    if ((_contact == value)) {
    //      return;
    //    }
    //    if (((_contact == null)
    //                || (_contact.Equals(value) != true))) {
    //      _contact = value;
    //      OnPropertyChanged("Contact");
    //    }
    //  }
    //}

    //private List<Abstract_TypedDate_PropertyType> _dateInfo;
    
    ///// <summary>
    ///// Date(s) other than creation dateEG: expiry date
    ///// </summary>
    //[XmlElement("dateInfo", Order = 5, ElementName = "dateInfo")]
    //[JsonProperty("dateInfo", Order = 5)]
    //public List<Abstract_TypedDate_PropertyType> DateInfo {
    //  get {
    //    return _dateInfo;
    //  }
    //  set {
    //    if ((_dateInfo == value)) {
    //      return;
    //    }
    //    if (((_dateInfo == null)
    //                || (_dateInfo.Equals(value) != true))) {
    //      _dateInfo = value;
    //      OnPropertyChanged("DateInfo");
    //    }
    //  }
    //}

    //private List<Abstract_Citation_PropertyType> _metadataStandard;
    
    ///// <summary>
    ///// Citation for the standards to which the metadata conforms
    ///// </summary>
    //[XmlElement("metadataStandard", Order = 6, ElementName = "metadataStandard")]
    //[JsonProperty("metadataStandard", Order = 6)]
    //public List<Abstract_Citation_PropertyType> MetadataStandard {
    //  get {
    //    return _metadataStandard;
    //  }
    //  set {
    //    if ((_metadataStandard == value)) {
    //      return;
    //    }
    //    if (((_metadataStandard == null)
    //                || (_metadataStandard.Equals(value) != true))) {
    //      _metadataStandard = value;
    //      OnPropertyChanged("MetadataStandard");
    //    }
    //  }
    //}

    //private List<Abstract_Citation_PropertyType> _metadataProfile;
    
    //[XmlElement("metadataProfile", Order = 7, ElementName = "metadataProfile")]
    //[JsonProperty("metadataProfile", Order = 7)]
    //public List<Abstract_Citation_PropertyType> MetadataProfile {
    //  get {
    //    return _metadataProfile;
    //  }
    //  set {
    //    if ((_metadataProfile == value)) {
    //      return;
    //    }
    //    if (((_metadataProfile == null)
    //                || (_metadataProfile.Equals(value) != true))) {
    //      _metadataProfile = value;
    //      OnPropertyChanged("MetadataProfile");
    //    }
    //  }
    //}

    //private List<Abstract_Citation_PropertyType> _alternativeMetadataReference;
    
    ///// <summary>
    ///// unique Identifier and onlineResource for alternative metadata
    ///// </summary>
    //[XmlElement("alternativeMetadataReference", Order = 8, ElementName = "alternativeMetadataReference")]
    //[JsonProperty("alternativeMetadataReference", Order = 8)]
    //public List<Abstract_Citation_PropertyType> AlternativeMetadataReference {
    //  get {
    //    return _alternativeMetadataReference;
    //  }
    //  set {
    //    if ((_alternativeMetadataReference == value)) {
    //      return;
    //    }
    //    if (((_alternativeMetadataReference == null)
    //                || (_alternativeMetadataReference.Equals(value) != true))) {
    //      _alternativeMetadataReference = value;
    //      OnPropertyChanged("AlternativeMetadataReference");
    //    }
    //  }
    //}

    //private List<PT_Locale_PropertyType> _otherLocale;
    
    //[XmlElement("otherLocale", Order = 9, ElementName = "otherLocale")]
    //[JsonProperty("otherLocale", Order = 9)]
    //public List<PT_Locale_PropertyType> OtherLocale {
    //  get {
    //    return _otherLocale;
    //  }
    //  set {
    //    if ((_otherLocale == value)) {
    //      return;
    //    }
    //    if (((_otherLocale == null)
    //                || (_otherLocale.Equals(value) != true))) {
    //      _otherLocale = value;
    //      OnPropertyChanged("OtherLocale");
    //    }
    //  }
    //}

    //private List<Abstract_OnlineResource_PropertyType> _metadataLinkage;
    
    ///// <summary>
    ///// online location where the metadata is available
    ///// </summary>
    //[XmlElement("metadataLinkage", Order = 10, ElementName = "metadataLinkage")]
    //[JsonProperty("metadataLinkage", Order = 10)]
    //public List<Abstract_OnlineResource_PropertyType> MetadataLinkage {
    //  get {
    //    return _metadataLinkage;
    //  }
    //  set {
    //    if ((_metadataLinkage == value)) {
    //      return;
    //    }
    //    if (((_metadataLinkage == null)
    //                || (_metadataLinkage.Equals(value) != true))) {
    //      _metadataLinkage = value;
    //      OnPropertyChanged("MetadataLinkage");
    //    }
    //  }
    //}

    //private List<Abstract_SpatialRepresentation_PropertyType> _spatialRepresentationInfo;
    
    //[XmlElement("spatialRepresentationInfo", Order = 11, ElementName = "spatialRepresentationInfo")]
    //[JsonProperty("spatialRepresentationInfo", Order = 11)]
    //public List<Abstract_SpatialRepresentation_PropertyType> SpatialRepresentationInfo {
    //  get {
    //    return _spatialRepresentationInfo;
    //  }
    //  set {
    //    if ((_spatialRepresentationInfo == value)) {
    //      return;
    //    }
    //    if (((_spatialRepresentationInfo == null)
    //                || (_spatialRepresentationInfo.Equals(value) != true))) {
    //      _spatialRepresentationInfo = value;
    //      OnPropertyChanged("SpatialRepresentationInfo");
    //    }
    //  }
    //}

    //private List<Abstract_ReferenceSystem_PropertyType> _referenceSystemInfo;
    
    //[XmlElement("referenceSystemInfo", Order = 12, ElementName = "referenceSystemInfo")]
    //[JsonProperty("referenceSystemInfo", Order = 12)]
    //public List<Abstract_ReferenceSystem_PropertyType> ReferenceSystemInfo {
    //  get {
    //    return _referenceSystemInfo;
    //  }
    //  set {
    //    if ((_referenceSystemInfo == value)) {
    //      return;
    //    }
    //    if (((_referenceSystemInfo == null)
    //                || (_referenceSystemInfo.Equals(value) != true))) {
    //      _referenceSystemInfo = value;
    //      OnPropertyChanged("ReferenceSystemInfo");
    //    }
    //  }
    //}

    //private List<Abstract_MetadataExtension_PropertyType> _metadataExtensionInfo;
    
    //[XmlElement("metadataExtensionInfo", Order = 13, ElementName = "metadataExtensionInfo")]
    //[JsonProperty("metadataExtensionInfo", Order = 13)]
    //public List<Abstract_MetadataExtension_PropertyType> MetadataExtensionInfo {
    //  get {
    //    return _metadataExtensionInfo;
    //  }
    //  set {
    //    if ((_metadataExtensionInfo == value)) {
    //      return;
    //    }
    //    if (((_metadataExtensionInfo == null)
    //                || (_metadataExtensionInfo.Equals(value) != true))) {
    //      _metadataExtensionInfo = value;
    //      OnPropertyChanged("MetadataExtensionInfo");
    //    }
    //  }
    //}

    //private List<Abstract_ResourceDescription_PropertyType> _identificationInfo;
    
    //[XmlElement("identificationInfo", Order = 14, ElementName = "identificationInfo")]
    //[JsonProperty("identificationInfo", Order = 14)]
    //public List<Abstract_ResourceDescription_PropertyType> IdentificationInfo {
    //  get {
    //    return _identificationInfo;
    //  }
    //  set {
    //    if ((_identificationInfo == value)) {
    //      return;
    //    }
    //    if (((_identificationInfo == null)
    //                || (_identificationInfo.Equals(value) != true))) {
    //      _identificationInfo = value;
    //      OnPropertyChanged("IdentificationInfo");
    //    }
    //  }
    //}

    //private List<Abstract_ContentInformation_PropertyType> _contentInfo;
    
    //[XmlElement("contentInfo", Order = 15, ElementName = "contentInfo")]
    //[JsonProperty("contentInfo", Order = 15)]
    //public List<Abstract_ContentInformation_PropertyType> ContentInfo {
    //  get {
    //    return _contentInfo;
    //  }
    //  set {
    //    if ((_contentInfo == value)) {
    //      return;
    //    }
    //    if (((_contentInfo == null)
    //                || (_contentInfo.Equals(value) != true))) {
    //      _contentInfo = value;
    //      OnPropertyChanged("ContentInfo");
    //    }
    //  }
    //}

    //private List<Abstract_Distribution_PropertyType> _distributionInfo;

    //[XmlElement("distributionInfo", Order = 16, ElementName = "distributionInfo")]
    //[JsonProperty("distributionInfo", Order = 16)]
    //public List<Abstract_Distribution_PropertyType> DistributionInfo {
    //  get {
    //    return _distributionInfo;
    //  }
    //  set {
    //    if ((_distributionInfo == value)) {
    //      return;
    //    }
    //    if (((_distributionInfo == null)
    //                || (_distributionInfo.Equals(value) != true))) {
    //      _distributionInfo = value;
    //      OnPropertyChanged("DistributionInfo");
    //    }
    //  }
    //}

    //private List<Abstract_DataQuality_PropertyType> _dataQualityInfo;
    
    //[XmlElement("dataQualityInfo", Order = 17, ElementName = "dataQualityInfo")]
    //[JsonProperty("dataQualityInfo", Order = 17)]
    //public List<Abstract_DataQuality_PropertyType> DataQualityInfo {
    //  get {
    //    return _dataQualityInfo;
    //  }
    //  set {
    //    if ((_dataQualityInfo == value)) {
    //      return;
    //    }
    //    if (((_dataQualityInfo == null)
    //                || (_dataQualityInfo.Equals(value) != true))) {
    //      _dataQualityInfo = value;
    //      OnPropertyChanged("DataQualityInfo");
    //    }
    //  }
    //}

    //private List<Abstract_LineageInformation_PropertyType> _resourceLineage;
    
    //[XmlElement("resourceLineage", Order = 18, ElementName = "resourceLineage")]
    //[JsonProperty("resourceLineage", Order = 18)]
    //public List<Abstract_LineageInformation_PropertyType> ResourceLineage {
    //  get {
    //    return _resourceLineage;
    //  }
    //  set {
    //    if ((_resourceLineage == value)) {
    //      return;
    //    }
    //    if (((_resourceLineage == null)
    //                || (_resourceLineage.Equals(value) != true))) {
    //      _resourceLineage = value;
    //      OnPropertyChanged("ResourceLineage");
    //    }
    //  }
    //}

    //private List<Abstract_PortrayalCatalogueInformation_PropertyType> _portrayalCatalogueInfo;
    
    //[XmlElement("portrayalCatalogueInfo", Order = 19, ElementName = "portrayalCatalogueInfo")]
    //[JsonProperty("portrayalCatalogueInfo", Order = 19)]
    //public List<Abstract_PortrayalCatalogueInformation_PropertyType> PortrayalCatalogueInfo {
    //  get {
    //    return _portrayalCatalogueInfo;
    //  }
    //  set {
    //    if ((_portrayalCatalogueInfo == value)) {
    //      return;
    //    }
    //    if (((_portrayalCatalogueInfo == null)
    //                || (_portrayalCatalogueInfo.Equals(value) != true))) {
    //      _portrayalCatalogueInfo = value;
    //      OnPropertyChanged("PortrayalCatalogueInfo");
    //    }
    //  }
    //}

    //private List<Abstract_Constraints_PropertyType> _metadataConstraints;
    
    //[XmlElement("metadataConstraints", Order = 20, ElementName = "metadataConstraints")]
    //[JsonProperty("metadataConstraints", Order = 20)]
    //public List<Abstract_Constraints_PropertyType> MetadataConstraints {
    //  get {
    //    return _metadataConstraints;
    //  }
    //  set {
    //    if ((_metadataConstraints == value)) {
    //      return;
    //    }
    //    if (((_metadataConstraints == null)
    //                || (_metadataConstraints.Equals(value) != true))) {
    //      _metadataConstraints = value;
    //      OnPropertyChanged("MetadataConstraints");
    //    }
    //  }
    //}

    //private List<Abstract_ApplicationSchemaInformation_PropertyType> _applicationSchemaInfo;
    
    //[XmlElement("applicationSchemaInfo", Order = 21, ElementName = "applicationSchemaInfo")]
    //[JsonProperty("applicationSchemaInfo", Order = 21)]
    //public List<Abstract_ApplicationSchemaInformation_PropertyType> ApplicationSchemaInfo {
    //  get {
    //    return _applicationSchemaInfo;
    //  }
    //  set {
    //    if ((_applicationSchemaInfo == value)) {
    //      return;
    //    }
    //    if (((_applicationSchemaInfo == null)
    //                || (_applicationSchemaInfo.Equals(value) != true))) {
    //      _applicationSchemaInfo = value;
    //      OnPropertyChanged("ApplicationSchemaInfo");
    //    }
    //  }
    //}

    //private Abstract_MaintenanceInformation_PropertyType _metadataMaintenance;
    
    //[XmlElement(Order = 22, ElementName = "metadataMaintenance")]
    //[JsonProperty("metadataMaintenance", Order = 22)]
    //public Abstract_MaintenanceInformation_PropertyType MetadataMaintenance {
    //  get {
    //    return _metadataMaintenance;
    //  }
    //  set {
    //    if ((_metadataMaintenance == value)) {
    //      return;
    //    }
    //    if (((_metadataMaintenance == null)
    //                || (_metadataMaintenance.Equals(value) != true))) {
    //      _metadataMaintenance = value;
    //      OnPropertyChanged("MetadataMaintenance");
    //    }
    //  }
    //}

    //private List<Abstract_AcquisitionInformation_PropertyType> _acquisitionInformation;

    //[XmlElement("acquisitionInformation", Order = 23, ElementName = "acquisitionInformation")]
    //[JsonProperty("acquisitionInformation", Order = 23)]
    //public List<Abstract_AcquisitionInformation_PropertyType> AcquisitionInformation {
    //  get {
    //    return _acquisitionInformation;
    //  }
    //  set {
    //    if ((_acquisitionInformation == value)) {
    //      return;
    //    }
    //    if (((_acquisitionInformation == null)
    //                || (_acquisitionInformation.Equals(value) != true))) {
    //      _acquisitionInformation = value;
    //      OnPropertyChanged("AcquisitionInformation");
    //    }
    //  }
    //}

    #endregion

  }

}
