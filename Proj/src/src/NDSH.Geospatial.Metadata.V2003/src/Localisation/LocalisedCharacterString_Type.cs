
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 02/01/2023, 17:35, @gisvlasta.
// Updated by        : 09/01/2023, 20:11, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Apps;
using NDSH.Geospatial.Metadata.V2003.Common;
using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Localisation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("LocalisedCharacterString", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("LocalisedCharacterString", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("LocalisedCharacterString")]
  public class LocalisedCharacterString_Type : ObservableModel, IId { // TODO: Danger!!! - Check Inheritance !!!

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LocalisedCharacterString_Type"/>.
    /// </summary>
    public LocalisedCharacterString_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region IId Interface

    private string _id;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "id", DataType = "ID")]
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

    #endregion

    #region Public Properties

    private string _locale;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "locale", DataType = "anyURI")]
    [JsonProperty("locale")]
    public string Locale {
      get {
        return _locale;
      }
      set {
        if (_locale == value) {
          return;
        }
        if (_locale == null || _locale.Equals(value) != true) {
          _locale = value;
          OnPropertyChanged();
        }
      }
    }

    private string _value;

    /// <summary>
    /// 
    /// </summary>
    [XmlText()]
    [JsonProperty("Value")]
    public string Value {
      get {
        return _value;
      }
      set {
        if (_value == value) {
          return;
        }
        if (_value == null || _value.Equals(value) != true) {
          _value = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
