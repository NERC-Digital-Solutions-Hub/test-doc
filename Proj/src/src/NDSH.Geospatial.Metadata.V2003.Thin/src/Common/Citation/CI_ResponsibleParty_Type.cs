
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 21/12/2022, 20:06, @gisvlasta.
// Updated by        : 09/01/2023, 13:51, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Common.Citation {

  /// <summary>
  /// Identification of, and means of communication with, person(s) and organisations associated with the dataset
  /// </summary>
  [Serializable]
  [XmlType("CI_ResponsibleParty", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("CI_ResponsibleParty", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("CI_ResponsibleParty")]
  public class CI_ResponsibleParty_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_ResponsibleParty_Type"/>.
    /// </summary>
    public CI_ResponsibleParty_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _individualName = default; //new CharacterString_PropertyType();
      _organisationName = default; //new CharacterString_PropertyType();
      _positionName = default; //new CharacterString_PropertyType();
      _contactInfo = default; //new CI_Contact_PropertyType();
      _role = default; //new CI_RoleCode_PropertyType();

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

    private CharacterString _individualName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("individualName", Order = 0)]
    [JsonProperty("individualName", Order = 0)]
    public CharacterString IndividualName {
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

    private CharacterString _organisationName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("organisationName", Order = 1)]
    [JsonProperty("organisationName", Order = 1)]
    public CharacterString OrganisationName {
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

    private CharacterString _positionName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("positionName", Order = 2)]
    [JsonProperty("positionName", Order = 2)]
    public CharacterString PositionName {
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

    private CI_Contact_PropertyType _contactInfo;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("contactInfo", Order = 3)]
    [JsonProperty("contactInfo", Order = 3)]
    public CI_Contact_PropertyType ContactInfo {
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

    private CI_RoleCode_PropertyType _role;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("role", Order = 4)]
    [JsonProperty("role", Order = 4)]
    public CI_RoleCode_PropertyType Role {
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

    #endregion

  }

}