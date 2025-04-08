
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
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/freeText.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="PT_LocaleContainer_Type">
//   <xs:sequence>
//     <xs:element name="description" type="gco:CharacterString_PropertyType"/>
//     <xs:element name="locale" type="gmd:PT_Locale_PropertyType"/>
//     <xs:element name="date" type="gmd:CI_Date_PropertyType" maxOccurs="unbounded"/>
//     <xs:element name="responsibleParty" type="gmd:CI_ResponsibleParty_PropertyType" maxOccurs="unbounded"/>
//     <xs:element name="localisedString" type="gmd:LocalisedCharacterString_PropertyType" maxOccurs="unbounded"/>
//   </xs:sequence>
// </xs:complexType>
// <xs:element name="PT_LocaleContainer" type="gmd:PT_LocaleContainer_Type"/>
// <xs:complexType name="PT_LocaleContainer_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:PT_LocaleContainer"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Apps;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Localisation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("PT_LocaleContainer", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("PT_LocaleContainer", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("PT_LocaleContainer")]
  public class PT_LocaleContainer_Type : ObservableModel { // TODO: Danger!!! Why Model??? Check inheritance.

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="PT_LocaleContainer_Type"/>.
    /// </summary>
    public PT_LocaleContainer_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _description = default; //  new CharacterString();
      _locale = default; //  new PT_Locale_Type();
      _date = default; //  new List<CI_Date_Type>();
      _responsibleParty = default; //  new List<CI_ResponsibleParty_Type>();
      _localisedString = default; //  new List<LocalisedCharacterString_PropertyType>();

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
    /// Designation of the locale language.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    [XmlElement("description", Order = 0)]
    [JsonProperty("description", Order = 0)]
    public CharacterString Description {
      get {
        return _description;
      }
      set => SetProperty(ref _description, value);
    }

    private PT_Locale_Type _locale;

    /// <summary>
    /// Locale in which the localized strings of the container are expressed.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    [XmlElement("locale", Order = 1)]
    [JsonProperty("locale", Order = 1)]
    public PT_Locale_Type Locale {
      get {
        return _locale;
      }
      set => SetProperty(ref _locale, value);
    }

    private List<CI_Date_Type> _date;

    /// <summary>
    /// Date of creation or revision of the locale container.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - N
    [XmlElement("date", Order = 2)]
    [JsonProperty("date", Order = 2)]
    public List<CI_Date_Type> Date {
      get {
        return _date;
      }
      set => SetProperty(ref _date, value);
    }

    private List<CI_ResponsibleParty_Type> _responsibleParty;

    /// <summary>
    /// Responsible parties of the locale container.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - N
    [XmlElement("responsibleParty", Order = 3)]
    [JsonProperty("responsibleParty", Order = 3)]
    public List<CI_ResponsibleParty_Type> ResponsibleParty {
      get {
        return _responsibleParty;
      }
      set => SetProperty(ref _responsibleParty, value);
    }

    private List<LocalisedCharacterString_PropertyType> _localisedString;

    /// <summary>
    /// Provides the list of localized character strings expressing the linguistic translation of a set of textual
    /// information in a given locale.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    [XmlElement("localisedString", Order = 4)]
    [JsonProperty("localisedString", Order = 4)]
    public List<LocalisedCharacterString_PropertyType> LocalisedString {
      get {
        return _localisedString;
      }
      set => SetProperty(ref _localisedString, value);
    }

    #endregion

  }

}
