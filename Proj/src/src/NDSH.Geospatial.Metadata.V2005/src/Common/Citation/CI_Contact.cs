
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 16/12/2022, 19:18, @gisvlasta - Cleaned Xml Serialization Attributes.
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
  [XmlRoot("CI_Contact", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("CI_Contact", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("CI_Contact")]
  public class CI_Contact : Model {

    #region Cosntructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_Contact"/>.
    /// </summary>
    public CI_Contact() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _phone = default; // new CI_Telephone();
      _address = default; // new CI_Address();
      _onlineResource = default; // new CI_OnlineResource();
      _hoursOfService = default;
      _contactInstructions = default;

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

    private CI_Telephone _phone;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "phone")]
    [JsonProperty("phone", Order = 0)]
    public CI_Telephone Phone {
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

    private CI_Address _address;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "address")]
    [JsonProperty("address", Order = 1)]
    public CI_Address Address {
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

    private CI_OnlineResource _onlineResource;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "onlineResource")]
    [JsonProperty("onlineResource", Order = 2)]
    public CI_OnlineResource OnlineResource {
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

    private string _hoursOfService;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3, ElementName = "hoursOfService")]
    [JsonProperty("hoursOfService", Order = 3)]
    public string HoursOfService {
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

    private string _contactInstructions;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4, ElementName = "contactInstructions")]
    [JsonProperty("contactInstructions", Order = 4)]
    public string ContactInstructions {
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
