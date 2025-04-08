
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

using NDSH.Geospatial.Metadata.V2003.Common;
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
      _city = default; // new CharacterString_PropertyType();
      _administrativeArea = default; // new CharacterString_PropertyType();
      _postalCode = default; // new CharacterString_PropertyType();
      _country = default; // new CharacterString_PropertyType();
      _electronicMailAddress = default; // new List<CharacterString_PropertyType>();

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

    private List<CharacterString_PropertyType> _deliveryPoint;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("deliveryPoint", Order = 0)]
    [JsonProperty("deliveryPoint", Order = 0)]
    public List<CharacterString_PropertyType> DeliveryPoint {
      get => _deliveryPoint;
      set {
        if (_deliveryPoint == value) {
          return;
        }
        if (_deliveryPoint == null || !_deliveryPoint.Equals(value)) {
          _deliveryPoint = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _city;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("city", Order = 1)]
    [JsonProperty("city", Order = 1)]
    public CharacterString_PropertyType City {
      get => _city;
      set {
        if (_city == value) {
          return;
        }
        if (_city == null || !_city.Equals(value)) {
          _city = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _administrativeArea;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("administrativeArea", Order = 2)]
    [JsonProperty("administrativeArea", Order = 2)]
    public CharacterString_PropertyType AdministrativeArea {
      get => _administrativeArea;
      set {
        if (_administrativeArea == value) {
          return;
        }
        if (_administrativeArea == null || !_administrativeArea.Equals(value)) {
          _administrativeArea = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _postalCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("postalCode", Order = 3)]
    [JsonProperty("postalCode", Order = 3)]
    public CharacterString_PropertyType PostalCode {
      get => _postalCode;
      set {
        if (_postalCode == value) {
          return;
        }
        if (_postalCode == null || !_postalCode.Equals(value)) {
          _postalCode = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _country;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("country", Order = 4)]
    [JsonProperty("country", Order = 4)]
    public CharacterString_PropertyType Country {
      get => _country;
      set {
        if (_country == value) {
          return;
        }
        if (_country == null || !_country.Equals(value)) {
          _country = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CharacterString_PropertyType> _electronicMailAddress;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("electronicMailAddress", Order = 5)]
    [JsonProperty("electronicMailAddress", Order = 5)]
    public List<CharacterString_PropertyType> ElectronicMailAddress {
      get => _electronicMailAddress;
      set {
        if (_electronicMailAddress == value) {
          return;
        }
        if (_electronicMailAddress == null || !_electronicMailAddress.Equals(value)) {
          _electronicMailAddress = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
