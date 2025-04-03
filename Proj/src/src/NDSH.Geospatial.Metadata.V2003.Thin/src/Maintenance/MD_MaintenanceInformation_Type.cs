
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 15:08, @gisvlasta.
// Updated by        : 09/01/2023, 20:3, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Impoerted Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common.Citation;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.DateTime;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Maintenance {

  /// <summary>
  /// Information about the scope and frequency of updating.
  /// </summary>
  [Serializable]
  [XmlType("MD_MaintenanceInformation", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_MaintenanceInformation", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_MaintenanceInformation")]
  public class MD_MaintenanceInformation_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_MaintenanceInformation_Type"/>.
    /// </summary>
    public MD_MaintenanceInformation_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _maintenanceAndUpdateFrequency  = default; //  new MD_MaintenanceFrequencyCode_PropertyType();
      _dateOfNextUpdate  = default; //  new Date_PropertyType();
      _userDefinedMaintenanceFrequency  = default; //  new TM_PeriodDuration_PropertyType();
      _updateScope  = default; //  new List<MD_ScopeCode_PropertyType>();
      _updateScopeDescription  = default; //  new List<MD_ScopeDescription_PropertyType>();
      _maintenanceNote  = default; //  new List<CharacterString_PropertyType>();
      _contact  = default; //  new List<CI_ResponsibleParty_PropertyType>();

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

    private MD_MaintenanceFrequencyCode_PropertyType _maintenanceAndUpdateFrequency;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("maintenanceAndUpdateFrequency", Order = 0)]
    [JsonProperty("maintenanceAndUpdateFrequency", Order = 0)]
    public MD_MaintenanceFrequencyCode_PropertyType MaintenanceAndUpdateFrequency {
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

    private ConceptualSchema.Primitive.DateTime.DateTime _dateOfNextUpdate;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("dateOfNextUpdate", Order = 1)]
    [JsonProperty("dateOfNextUpdate", Order = 1)]
    public ConceptualSchema.Primitive.DateTime.DateTime DateOfNextUpdate {
      get {
        return _dateOfNextUpdate;
      }
      set {
        if (_dateOfNextUpdate == value) {
          return;
        }
        if (_dateOfNextUpdate == null || _dateOfNextUpdate.Equals(value) != true) {
          _dateOfNextUpdate = value;
          OnPropertyChanged();
        }
      }
    }

    private TM_PeriodDuration_PropertyType _userDefinedMaintenanceFrequency;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("userDefinedMaintenanceFrequency", Order = 2)]
    [JsonProperty("userDefinedMaintenanceFrequency", Order = 2)]
    public TM_PeriodDuration_PropertyType UserDefinedMaintenanceFrequency {
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

    private List<MD_ScopeCode_PropertyType> _updateScope;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("updateScope", Order = 3)]
    [JsonProperty("updateScope", Order = 3)]
    public List<MD_ScopeCode_PropertyType> UpdateScope {
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

    private List<MD_ScopeDescription_PropertyType> _updateScopeDescription;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("updateScopeDescription", Order = 4)]
    [JsonProperty("updateScopeDescription", Order = 4)]
    public List<MD_ScopeDescription_PropertyType> UpdateScopeDescription {
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

    private List<CharacterString> _maintenanceNote;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("maintenanceNote", Order = 5)]
    [JsonProperty("maintenanceNote", Order = 5)]
    public List<CharacterString> MaintenanceNote {
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

    private List<CI_ResponsibleParty_PropertyType> _contact;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("contact", Order = 6)]
    [JsonProperty("contact", Order = 6)]
    public List<CI_ResponsibleParty_PropertyType> Contact {
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

    #endregion

  }

}
