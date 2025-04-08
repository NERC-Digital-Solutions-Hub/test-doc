
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 21/12/2022, 19:46, @gisvlasta.
// Updated by        : 09/01/2023, 13:53, @gisvlasta. - 1.0.1: Added xmlns field.
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
  /// Information required enabling contact with the responsible person and/or organisation.
  /// </summary>
  [Serializable]
  [XmlType("CI_Contact", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("CI_Contact", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("CI_Contact")]
  public class CI_Contact_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_Contact_Type"/>.
    /// </summary>
    public CI_Contact_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _phone  = default; //  new CI_Telephone_PropertyType();
      _address  = default; //  new CI_Address_PropertyType();
      _onlineResource  = default; //  new CI_OnlineResource_PropertyType();
      _hoursOfService  = default; //  new CharacterString_PropertyType();
      _contactInstructions  = default; //  new CharacterString_PropertyType();
      
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

    private CI_Telephone_PropertyType _phone;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("phone", Order = 0)]
    [JsonProperty("phone", Order = 0)]
    public CI_Telephone_PropertyType Phone {
      get {
        return _phone;
      }
      set {
        if (_phone == value) {
          return;
        }
        if (_phone == null || _phone.Equals(value) != true) {
          _phone = value;
          OnPropertyChanged();
        }
      }
    }

    private CI_Address_PropertyType _address;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("address", Order = 1)]
    [JsonProperty("address", Order = 1)]
    public CI_Address_PropertyType Address {
      get {
        return _address;
      }
      set {
        if (_address == value) {
          return;
        }
        if (_address == null || _address.Equals(value) != true) {
          _address = value;
          OnPropertyChanged();
        }
      }
    }

    private CI_OnlineResource_PropertyType _onlineResource;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("onlineResource", Order = 2)]
    [JsonProperty("onlineResource", Order = 2)]
    public CI_OnlineResource_PropertyType OnlineResource {
      get {
        return _onlineResource;
      }
      set {
        if (_onlineResource == value) {
          return;
        }
        if (_onlineResource == null || _onlineResource.Equals(value) != true) {
          _onlineResource = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _hoursOfService;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("hoursOfService", Order = 3)]
    [JsonProperty("hoursOfService", Order = 3)]
    public CharacterString HoursOfService {
      get {
        return _hoursOfService;
      }
      set {
        if (_hoursOfService == value) {
          return;
        }
        if (_hoursOfService == null || _hoursOfService.Equals(value) != true) {
          _hoursOfService = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _contactInstructions;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("contactInstructions", Order = 4)]
    [JsonProperty("contactInstructions", Order = 4)]
    public CharacterString ContactInstructions {
      get {
        return _contactInstructions;
      }
      set {
        if (_contactInstructions == value) {
          return;
        }
        if (_contactInstructions == null || _contactInstructions.Equals(value) != true) {
          _contactInstructions = value;
          OnPropertyChanged();
        }
      }
    }


    #endregion

  }

}