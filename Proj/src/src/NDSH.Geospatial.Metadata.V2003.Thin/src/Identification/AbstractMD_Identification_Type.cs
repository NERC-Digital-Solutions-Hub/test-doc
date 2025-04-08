
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 02:37, @gisvlasta.
// Updated by        : 09/01/2023, 19:37, @gisvlasta. - 1.0.1: Added xmlns field.
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
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
using NDSH.Geospatial.Metadata.V2003.Thin.Constraint;
using NDSH.Geospatial.Metadata.V2003.Thin.Distribution;
using NDSH.Geospatial.Metadata.V2003.Thin.Maintenance;
using NDSH.Geospatial.Metadata.V2003.Thin.Service.Metadata;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Identification {

  /// <summary>
  /// Basic information about data.
  /// </summary>
  [Serializable]
  [XmlInclude(typeof(SV_ServiceIdentification_Type))]
  [XmlInclude(typeof(MD_DataIdentification_Type))]
  [XmlType("AbstractMD_Identification", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("AbstractMD_Identification", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("AbstractMD_Identification")]
  public abstract class AbstractMD_Identification_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractMD_Identification_Type"/>.
    /// </summary>
    public AbstractMD_Identification_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _citation  = default; //  new CI_Citation_PropertyType();
      _abstract  = default; //  new CharacterString_PropertyType();
      _purpose  = default; //  new CharacterString_PropertyType();
      _credit  = default; //  new List<CharacterString_PropertyType>();
      _status  = default; //  new List<MD_ProgressCode_PropertyType>();
      _pointOfContact  = default; //  new List<CI_ResponsibleParty_PropertyType>();
      _resourceMaintenance  = default; //  new List<MD_MaintenanceInformation_PropertyType>();
      _graphicOverview  = default; //  new List<MD_BrowseGraphic_PropertyType>();
      _resourceFormat  = default; //  new List<MD_Format_PropertyType>();
      _descriptiveKeywords  = default; //  new List<MD_Keywords_PropertyType>();
      _resourceSpecificUsage  = default; //  new List<MD_Usage_PropertyType>();
      _resourceConstraints  = default; //  new List<MD_Constraints_PropertyType>();
      _aggregationInfo  = default; //  new List<MD_AggregateInformation_PropertyType>();

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

    private CI_Citation_Type _citation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("citation", Order = 0)]
    [JsonProperty("citation", Order = 0)]
    public CI_Citation_Type Citation {
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

    private CharacterString _abstract;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("abstract", Order = 1)]
    [JsonProperty("abstract", Order = 1)]
    public CharacterString Abstract {
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

    private CharacterString _purpose;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("purpose", Order = 2)]
    [JsonProperty("purpose", Order = 2)]
    public CharacterString Purpose {
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

    private List<CharacterString> _credit;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("credit", Order = 3)]
    [JsonProperty("credit", Order = 3)]
    public List<CharacterString> Credit {
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

    private List<MD_ProgressCode_PropertyType> _status;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("status", Order = 4)]
    [JsonProperty("status", Order = 4)]
    public List<MD_ProgressCode_PropertyType> Status {
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

    private List<CI_ResponsibleParty_PropertyType> _pointOfContact;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("pointOfContact", Order = 5)]
    [JsonProperty("pointOfContact", Order = 5)]
    public List<CI_ResponsibleParty_PropertyType> PointOfContact {
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

    private List<MD_MaintenanceInformation_PropertyType> _resourceMaintenance;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("resourceMaintenance", Order = 6)]
    [JsonProperty("resourceMaintenance", Order = 6)]
    public List<MD_MaintenanceInformation_PropertyType> ResourceMaintenance {
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

    private List<MD_BrowseGraphic_PropertyType> _graphicOverview;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("graphicOverview", Order = 7)]
    [JsonProperty("graphicOverview", Order = 7)]
    public List<MD_BrowseGraphic_PropertyType> GraphicOverview {
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

    private List<MD_Format_PropertyType> _resourceFormat;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("resourceFormat", Order = 8)]
    [JsonProperty("resourceFormat", Order = 8)]
    public List<MD_Format_PropertyType> ResourceFormat {
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

    private List<MD_Keywords_PropertyType> _descriptiveKeywords;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("descriptiveKeywords", Order = 9)]
    [JsonProperty("descriptiveKeywords", Order = 9)]
    public List<MD_Keywords_PropertyType> DescriptiveKeywords {
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

    private List<MD_Usage_PropertyType> _resourceSpecificUsage;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("resourceSpecificUsage", Order = 10)]
    [JsonProperty("resourceSpecificUsage", Order = 10)]
    public List<MD_Usage_PropertyType> ResourceSpecificUsage {
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

    private List<MD_Constraints_PropertyType> _resourceConstraints;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("resourceConstraints", Order = 11)]
    [JsonProperty("resourceConstraints", Order = 11)]
    public List<MD_Constraints_PropertyType> ResourceConstraints {
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

    private List<MD_AggregateInformation_PropertyType> _aggregationInfo;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("aggregationInfo", Order = 12)]
    [JsonProperty("aggregationInfo", Order = 12)]
    public List<MD_AggregateInformation_PropertyType> AggregationInfo {
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

    #endregion

  }

}
