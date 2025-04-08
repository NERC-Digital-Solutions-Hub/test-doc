
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 17/12/2022, 04:02, @gisvlasta - Cleaned Xml Serialization Attributes.
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
using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Implementation.Names;
using NDSH.Geospatial.Metadata.V2005.Constraint;
using NDSH.Geospatial.Metadata.V2005.Distribution;
using NDSH.Geospatial.Metadata.V2005.Identification;
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

namespace NDSH.Geospatial.Metadata.V2005.Service {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("SV_ServiceIdentification", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [XmlType("SV_ServiceIdentification", Namespace = "http://www.isotc211.org/2005/srv")]
  [JsonObject("SV_ServiceIdentification")]
  public class SV_ServiceIdentification : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_ServiceIdentification"/>.
    /// </summary>
    public SV_ServiceIdentification() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("srv", "http://www.isotc211.org/2005/srv");

      _citation = default; //new CI_Citation();
      _abstract = default;
      _purpose = default;
      _credit = default; //new List<string>();
      _status = default; //new List<MD_ProgressCode>();
      _pointOfContact = default; //new List<CI_ResponsibleParty>();
      _resourceMaintenance = default; //new List<MD_MaintenanceInformation>();
      _graphicOverview = default; //new List<MD_BrowseGraphic>();
      _resourceFormat = default; //new List<MD_Format>();
      _descriptiveKeywords = default; //new List<MD_Keywords>();
      _resourceSpecificUsage = default; //new List<MD_Usage>();
      _resourceConstraints = default; //new List<Parent_MD_Constraints>();
      _aggregationInfo = default; //new List<MD_AggregateInformation>();
      _serviceType = default; //new GenericName();
      _serviceTypeVersion = default; //new List<string>();
      _accessProperties = default; //new MD_StandardOrderProcess();
      _restrictions = default; //new Parent_MD_Constraints();
      _extent = default; //new EX_Extent();
      _couplingType = default; //new SV_CouplingType();
      _coupledResource = default; //new SV_CoupledResource();
      _containsOperations = default; //new List<SV_OperationMetadata>();
      _operatesOn = default; //new List<string>();
      _provider = default; //new List<SV_ServiceProvider>();

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

    private GenericName _serviceType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 13, ElementName = "serviceType")]
    [JsonProperty("serviceType", Order = 13)]
    public GenericName ServiceType {
      get {
        return _serviceType;
      }
      set {
        if (_serviceType == value) {
          return;
        }
        if (_serviceType == null || _serviceType.Equals(value) != true) {
          _serviceType = value;
          OnPropertyChanged();
        }
      }
    }

    private List<string> _serviceTypeVersion;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("serviceTypeVersion", Order = 14, ElementName = "serviceTypeVersion")]
    [JsonProperty("serviceTypeVersion", Order = 14)]
    public List<string> ServiceTypeVersion {
      get {
        return _serviceTypeVersion;
      }
      set {
        if (_serviceTypeVersion == value) {
          return;
        }
        if (_serviceTypeVersion == null || _serviceTypeVersion.Equals(value) != true) {
          _serviceTypeVersion = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_StandardOrderProcess _accessProperties;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 15, ElementName = "accessProperties")]
    [JsonProperty("accessProperties", Order = 15)]
    public MD_StandardOrderProcess AccessProperties {
      get {
        return _accessProperties;
      }
      set {
        if (_accessProperties == value) {
          return;
        }
        if (_accessProperties == null || _accessProperties.Equals(value) != true) {
          _accessProperties = value;
          OnPropertyChanged();
        }
      }
    }

    private Parent_MD_Constraints _restrictions;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 16, ElementName = "restrictions")]
    [JsonProperty("restrictions", Order = 16)]
    public Parent_MD_Constraints Restrictions {
      get {
        return _restrictions;
      }
      set {
        if (_restrictions == value) {
          return;
        }
        if (_restrictions == null || _restrictions.Equals(value) != true) {
          _restrictions = value;
          OnPropertyChanged();
        }
      }
    }

    private EX_Extent _extent;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 17, ElementName = "extent")]
    [JsonProperty("extent", Order = 17)]
    public EX_Extent Extent {
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

    private SV_CouplingType _couplingType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 18, ElementName = "couplingType")]
    [JsonProperty("couplingType", Order = 18)]
    public SV_CouplingType CouplingType {
      get {
        return _couplingType;
      }
      set {
        if (_couplingType == value) {
          return;
        }
        if (_couplingType == null || _couplingType.Equals(value) != true) {
          _couplingType = value;
          OnPropertyChanged();
        }
      }
    }

    private SV_CoupledResource _coupledResource;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 19, ElementName = "coupledResource")]
    [JsonProperty("coupledResource", Order = 19)]
    public SV_CoupledResource CoupledResource {
      get {
        return _coupledResource;
      }
      set {
        if (_coupledResource == value) {
          return;
        }
        if (_coupledResource == null || _coupledResource.Equals(value) != true) {
          _coupledResource = value;
          OnPropertyChanged();
        }
      }
    }

    private List<SV_OperationMetadata> _containsOperations;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("containsOperations", Order = 20, ElementName = "containsOperations")]
    [JsonProperty("containsOperations", Order = 20)]
    public List<SV_OperationMetadata> ContainsOperations {
      get {
        return _containsOperations;
      }
      set {
        if (_containsOperations == value) {
          return;
        }
        if (_containsOperations == null || _containsOperations.Equals(value) != true) {
          _containsOperations = value;
          OnPropertyChanged();
        }
      }
    }

    private List<string> _operatesOn;

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayAttribute(Order = 21)]
    [JsonProperty(Order = 21)]
    public List<string> OperatesOn {
      get {
        return _operatesOn;
      }
      set {
        if (_operatesOn == value) {
          return;
        }
        if (_operatesOn == null || _operatesOn.Equals(value) != true) {
          _operatesOn = value;
          OnPropertyChanged();
        }
      }
    }

    private List<SV_ServiceProvider> _provider;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("provider", Order = 22, ElementName = "provider")]
    [JsonProperty("provider", Order = 22)]
    public List<SV_ServiceProvider> Provider {
      get {
        return _provider;
      }
      set {
        if (_provider == value) {
          return;
        }
        if (_provider == null || _provider.Equals(value) != true) {
          _provider = value;
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
