
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : The location of the responsible individual or organization.
// Created by        : 21/10/2022, 00:34, @gisvlasta.
// Updated by        : 16/12/2022, 19:15, @gisvlasta - Cleaned Xml Serialization Attributes.
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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.Common.Citation {

  /// <summary>
  /// The location of the responsible individual or organization.
  /// </summary>
  [Serializable]
  [XmlRoot("CI_Address", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("CI_Address", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("CI_Address")]
  public class CI_Address : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_Address"/>.
    /// </summary>
    public CI_Address() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");
      
      _deliveryPoint = default;
      _city = default;
      _administrativeArea = default;
      _postalCode = default;
      _country = default;
      _electronicMailAddress = default;
      
    }

    #endregion

    #region Public Fields

    /// <summary>
    /// The <see cref="XmlSerializerNamespaces"/>.
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private List<string> _deliveryPoint;

    /// <summary>
    /// The address line for the location.
    /// </summary>
    /// <remarks>
    /// As described in ISO 11180, Annex A.
    /// </remarks>
    [XmlElement(Order = 0, ElementName = "deliveryPoint")]
    [JsonProperty("deliveryPoint", Order = 0)]
    public List<string> DeliveryPoint {
      get {
        return _deliveryPoint;
      }
      set {
        if (_deliveryPoint == value) {
          return;
        }
        if (_deliveryPoint == null || _deliveryPoint.Equals(value) != true) {
          _deliveryPoint = value;
          OnPropertyChanged();
        }
      }
    }

    private string _city;

    /// <summary>
    /// The city of the location.
    /// </summary>
    [XmlElement(Order = 1, ElementName = "city")]
    [JsonProperty("city", Order = 1)]
    public string City {
      get {
        return _city;
      }
      set {
        if (_city == value) {
          return;
        }
        if (_city == null || _city.Equals(value) != true) {
          _city = value;
          OnPropertyChanged();
        }
      }
    }

    private string _administrativeArea;
    
    /// <summary>
    /// The state, province of the location.
    /// </summary>
    [XmlElement(Order = 2, ElementName = "administrativeArea")]
    [JsonProperty("administrativeArea", Order = 2)]
    public string AdministrativeArea {
      get {
        return _administrativeArea;
      }
      set {
        if (_administrativeArea == value) {
          return;
        }
        if (_administrativeArea == null || _administrativeArea.Equals(value) != true) {
          _administrativeArea = value;
          OnPropertyChanged();
        }
      }
    }

    private string _postalCode;
    
    /// <summary>
    /// The ZIP or other postal code.
    /// </summary>
    [XmlElement(Order = 3, ElementName = "postalCode")]
    [JsonProperty("postalCode", Order = 3)]
    public string PostalCode {
      get {
        return _postalCode;
      }
      set {
        if (_postalCode == value) {
          return;
        }
        if (_postalCode == null || _postalCode.Equals(value) != true) {
          _postalCode = value;
          OnPropertyChanged();
        }
      }
    }

    private string _country;
    
    /// <summary>
    /// The country of the physical address.
    /// </summary>
    [XmlElement(Order = 4, ElementName = "country")]
    [JsonProperty("country", Order = 4)]
    public string Country {
      get {
        return _country;
      }
      set {
        if (_country == value) {
          return;
        }
        if (_country == null || _country.Equals(value) != true) {
          _country = value;
          OnPropertyChanged();
        }
      }
    }

    private List<string> _electronicMailAddress;

    /// <summary>
    /// The address of the electronic mailbox of the responsible organization or individual.
    /// </summary>
    [XmlElement(Order = 5, ElementName = "electronicMailAddress")]
    [JsonProperty("electronicMailAddress", Order = 5)]
    public List<string> ElectronicMailAddress {
      get {
        return _electronicMailAddress;
      }
      set {
        if (_electronicMailAddress == value) {
          return;
        }
        if (_electronicMailAddress == null || _electronicMailAddress.Equals(value) != true) {
          _electronicMailAddress = value;
          OnPropertyChanged();
        }
      }
    }

    private string _id;
    
    /// <summary>
    /// The identifier of the object.
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
    /// The universally unique identifier of the object.
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
