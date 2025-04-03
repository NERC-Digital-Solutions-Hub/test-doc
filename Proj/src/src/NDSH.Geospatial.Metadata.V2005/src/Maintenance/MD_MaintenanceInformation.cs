
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 17:27, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.Common.Citation;
using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Primitive.Time;
using NDSH.Geospatial.Metadata.V2005;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.Maintenance {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("MD_MaintenanceInformation", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_MaintenanceInformation", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_MaintenanceInformation")]
  public class MD_MaintenanceInformation : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_MaintenanceInformation"/>.
    /// </summary>
    public MD_MaintenanceInformation() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _maintenanceAndUpdateFrequency = default; //new MD_MaintenanceFrequencyCode();
      _dateOfNextUpdate = default; // TODO: Do something for the DateTime
      _userDefinedMaintenanceFrequency = default; //new TM_PeriodDuration();
      _updateScope = default; //new List<MD_ScopeCode>();
      _updateScopeDescription = default; //new List<MD_ScopeDescription>();
      _maintenanceNote = default; //new List<string>();
      _contact = default; //new List<CI_ResponsibleParty>();

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

    private MD_MaintenanceFrequencyCode _maintenanceAndUpdateFrequency;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "maintenanceAndUpdateFrequency")]
    [JsonProperty("maintenanceAndUpdateFrequency", Order = 0)]
    public MD_MaintenanceFrequencyCode MaintenanceAndUpdateFrequency {
      get {
        return _maintenanceAndUpdateFrequency;
      }
      set {
        if (_maintenanceAndUpdateFrequency == value) {
          return;
        }
        if (_maintenanceAndUpdateFrequency == null || _maintenanceAndUpdateFrequency.Equals(value) != true) {
          _maintenanceAndUpdateFrequency = value;
          OnPropertyChanged();
        }
      }
    }

    private DateTime _dateOfNextUpdate;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "dateOfNextUpdate")]
    [RequiredAttribute()]
    [JsonProperty("dateOfNextUpdate", Order = 1)]
    public DateTime DateOfNextUpdate { // TODO: Do something for the DateTime.
      get {
        return _dateOfNextUpdate;
      }
      set {
        if (_dateOfNextUpdate.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "DateOfNextUpdate";
          Validator.ValidateProperty(value, validatorPropContext);
          _dateOfNextUpdate = value;
          OnPropertyChanged();
        }
      }
    }

    private TM_PeriodDuration _userDefinedMaintenanceFrequency;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "userDefinedMaintenanceFrequency")]
    [JsonProperty("userDefinedMaintenanceFrequency", Order = 2)]
    public TM_PeriodDuration UserDefinedMaintenanceFrequency {
      get {
        return _userDefinedMaintenanceFrequency;
      }
      set {
        if (_userDefinedMaintenanceFrequency == value) {
          return;
        }
        if (_userDefinedMaintenanceFrequency == null || _userDefinedMaintenanceFrequency.Equals(value) != true) {
          _userDefinedMaintenanceFrequency = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_ScopeCode> _updateScope;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("updateScope", Order = 3, ElementName = "updateScope")]
    [JsonProperty("updateScope", Order = 3)]
    public List<MD_ScopeCode> UpdateScope {
      get {
        return _updateScope;
      }
      set {
        if (_updateScope == value) {
          return;
        }
        if (_updateScope == null || _updateScope.Equals(value) != true) {
          _updateScope = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_ScopeDescription> _updateScopeDescription;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("updateScopeDescription", Order = 4, ElementName = "updateScopeDescription")]
    [JsonProperty("updateScopeDescription", Order = 4)]
    public List<MD_ScopeDescription> UpdateScopeDescription {
      get {
        return _updateScopeDescription;
      }
      set {
        if (_updateScopeDescription == value) {
          return;
        }
        if (_updateScopeDescription == null || _updateScopeDescription.Equals(value) != true) {
          _updateScopeDescription = value;
          OnPropertyChanged();
        }
      }
    }

    private List<string> _maintenanceNote;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("maintenanceNote", Order = 5, ElementName = "maintenanceNote")]
    [JsonProperty("maintenanceNote", Order = 5)]
    public List<string> MaintenanceNote {
      get {
        return _maintenanceNote;
      }
      set {
        if (_maintenanceNote == value) {
          return;
        }
        if (_maintenanceNote == null || _maintenanceNote.Equals(value) != true) {
          _maintenanceNote = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CI_ResponsibleParty> _contact;
    
    /// <summary>
    /// 
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
