
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 21/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Common.Citation {

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

    private CharacterString_PropertyType _individualName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("individualName", Order = 0)]
    [JsonProperty("individualName", Order = 0)]
    public CharacterString_PropertyType IndividualName {
      get => _individualName;
      set {
        if (_individualName == value) {
          return;
        }
        if (_individualName == null || !_individualName.Equals(value)) {
          _individualName = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _organisationName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("organisationName", Order = 1)]
    [JsonProperty("organisationName", Order = 1)]
    public CharacterString_PropertyType OrganisationName {
      get => _organisationName;
      set {
        if (_organisationName == value) {
          return;
        }
        if (_organisationName == null || !_organisationName.Equals(value)) {
          _organisationName = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _positionName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("positionName", Order = 2)]
    [JsonProperty("positionName", Order = 2)]
    public CharacterString_PropertyType PositionName {
      get => _positionName;
      set {
        if (_positionName == value) {
          return;
        }
        if (_positionName == null || !_positionName.Equals(value)) {
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
      get => _contactInfo;
      set {
        if (_contactInfo == value) {
          return;
        }
        if (_contactInfo == null || !_contactInfo.Equals(value)) {
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
      get => _role;
      set {
        if (_role == value) {
          return;
        }
        if (_role == null || !_role.Equals(value)) {
          _role = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
