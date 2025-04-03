
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 21/12/2022, 03:47, @gisvlasta.
// Updated by        : 09/01/2023, 13:55, @gisvlasta. - 1.0.1: Added xmlns field.
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
  /// Location of the responsible individual or organisation.
  /// </summary>
  [Serializable]
  [XmlType("CI_Address", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("CI_Address", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("CI_Address")] // TODO: The JsonObject attribute is different than XmlType and XmlRoot. Is this correct?
  public class CI_Address_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_Address_Type"/>
    /// </summary>
    public CI_Address_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _deliveryPoint = default; // new List<CharacterString_PropertyType>();
      _city  = default; // new CharacterString_PropertyType();
      _administrativeArea  = default; // new CharacterString_PropertyType();
      _postalCode  = default; // new CharacterString_PropertyType();
      _country  = default; // new CharacterString_PropertyType();
      _electronicMailAddress  = default; // new List<CharacterString_PropertyType>();
      
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

    private List<CharacterString> _deliveryPoint;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("deliveryPoint", Order = 0)]
    [JsonProperty("deliveryPoint", Order = 0)]
    public List<CharacterString> DeliveryPoint {
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

    private CharacterString _city;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("city", Order = 1)]
    [JsonProperty("city", Order = 1)]
    public CharacterString City {
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

    private CharacterString _administrativeArea;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("administrativeArea", Order = 2)]
    [JsonProperty("administrativeArea", Order = 2)]
    public CharacterString AdministrativeArea {
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

    private CharacterString _postalCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("postalCode", Order = 3)]
    [JsonProperty("postalCode", Order = 3)]
    public CharacterString PostalCode {
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

    private CharacterString _country;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("country", Order = 4)]
    [JsonProperty("country", Order = 4)]
    public CharacterString Country {
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

    private List<CharacterString> _electronicMailAddress;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("electronicMailAddress", Order = 5)]
    [JsonProperty("electronicMailAddress", Order = 5)]
    public List<CharacterString> ElectronicMailAddress {
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

    #endregion

  }

}