
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 02/01/2023, 17:46, @gisvlasta.
// Updated by        : 09/01/2023, 20:10, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common.Citation;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Localisation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("PT_LocaleContainer", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("PT_LocaleContainer", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("PT_LocaleContainer")]
  public class PT_LocaleContainer_Type : Model { // TODO: Danger!!! Why Model??? Check inheritance.
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="PT_LocaleContainer_Type"/>.
    /// </summary>
    public PT_LocaleContainer_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _description  = default; //  new CharacterString_PropertyType();
      _locale  = default; //  new PT_Locale_PropertyType();
      _date  = default; //  new List<CI_Date_PropertyType>();
      _responsibleParty  = default; //  new List<CI_ResponsibleParty_PropertyType>();
      _localisedString  = default; //  new List<LocalisedCharacterString_PropertyType>();

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

    private CharacterString _description;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("description", Order = 0)]
    [JsonProperty("description", Order = 0)]
    public CharacterString Description {
      get {
        return _description;
      }
      set {
        if (_description == value) {
          return;
        }
        if (_description == null || _description.Equals(value) != true) {
          _description = value;
          OnPropertyChanged();
        }
      }
    }

    private PT_Locale_PropertyType _locale;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("locale", Order = 1)]
    [JsonProperty("locale", Order = 1)]
    public PT_Locale_PropertyType Locale {
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

    private List<CI_Date_PropertyType> _date;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("date", Order = 2)]
    [JsonProperty("date", Order = 2)]
    public List<CI_Date_PropertyType> Date {
      get {
        return _date;
      }
      set {
        if (_date == value) {
          return;
        }
        if (_date == null || _date.Equals(value) != true) {
          _date = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CI_ResponsibleParty_PropertyType> _responsibleParty;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("responsibleParty", Order = 3)]
    [JsonProperty("responsibleParty", Order = 3)]
    public List<CI_ResponsibleParty_PropertyType> ResponsibleParty {
      get {
        return _responsibleParty;
      }
      set {
        if (_responsibleParty == value) {
          return;
        }
        if (_responsibleParty == null || _responsibleParty.Equals(value) != true) {
          _responsibleParty = value;
          OnPropertyChanged();
        }
      }
    }

    private List<LocalisedCharacterString_PropertyType> _localisedString;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("localisedString", Order = 4)]
    [JsonProperty("localisedString", Order = 4)]
    public List<LocalisedCharacterString_PropertyType> LocalisedString {
      get {
        return _localisedString;
      }
      set {
        if (_localisedString == value) {
          return;
        }
        if (_localisedString == null || _localisedString.Equals(value) != true) {
          _localisedString = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
