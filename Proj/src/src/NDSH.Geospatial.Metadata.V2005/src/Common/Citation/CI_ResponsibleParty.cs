
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 16/12/2022, 19:07, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

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

namespace NDSH.Geospatial.Metadata.V2005.Common.Citation {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("CI_ResponsibleParty", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("CI_ResponsibleParty", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("CI_ResponsibleParty")]
  public class CI_ResponsibleParty : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_ResponsibleParty"/>.
    /// </summary>
    public CI_ResponsibleParty() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _individualName = default;
      _organisationName = default;
      _positionName = default;
      _contactInfo = default; //new CI_Contact();
      _role = default; //new CI_RoleCode();
      
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

    private string _individualName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "individualName")]
    [JsonProperty("individualName", Order = 0)]
    public string IndividualName {
      get {
        return _individualName;
      }
      set {
        if (_individualName == value) {
          return;
        }
        if (_individualName == null || _individualName.Equals(value) != true) {
          _individualName = value;
          OnPropertyChanged();
        }
      }
    }

    private string _organisationName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "organisationName")]
    [JsonProperty("organisationName", Order = 1)]
    public string OrganisationName {
      get {
        return _organisationName;
      }
      set {
        if (_organisationName == value) {
          return;
        }
        if (_organisationName == null || _organisationName.Equals(value) != true) {
          _organisationName = value;
          OnPropertyChanged();
        }
      }
    }

    private string _positionName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "positionName")]
    [JsonProperty("positionName", Order = 2)]
    public string PositionName {
      get {
        return _positionName;
      }
      set {
        if (_positionName == value) {
          return;
        }
        if (_positionName == null || _positionName.Equals(value) != true) {
          _positionName = value;
          OnPropertyChanged();
        }
      }
    }

    private CI_Contact _contactInfo;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3, ElementName = "contactInfo")]
    [JsonProperty("contactInfo", Order = 3)]
    public CI_Contact ContactInfo {
      get {
        return _contactInfo;
      }
      set {
        if (_contactInfo == value) {
          return;
        }
        if (_contactInfo == null || _contactInfo.Equals(value) != true) {
          _contactInfo = value;
          OnPropertyChanged();
        }
      }
    }

    private CI_RoleCode _role;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4, ElementName = "role")]
    [JsonProperty("role", Order = 4)]
    public CI_RoleCode Role {
      get {
        return _role;
      }
      set {
        if (_role == value) {
          return;
        }
        if (_role == null || _role.Equals(value) != true) {
          _role = value;
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
