
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 02/01/2023, 17:22, @gisvlasta.
// Updated by        : 09/01/2023, 20:10, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using NDSH.Geospatial.Metadata.V2003.Thin.Identification;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
  [XmlType("PT_Locale", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("PT_Locale", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("PT_Locale")]
  public class PT_Locale_Type : AbstractObject_Type {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="PT_Locale_Type"/>.
    /// </summary>
    public PT_Locale_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _languageCode  = default; //  new LanguageCode_PropertyType();
      _country  = default; //  new Country_PropertyType();
      _characterEncoding  = default; //  new MD_CharacterSetCode_PropertyType();

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

    private LanguageCode_PropertyType _languageCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("languageCode", Order = 0)]
    [JsonProperty("languageCode", Order = 0)]
    public LanguageCode_PropertyType LanguageCode {
      get {
        return _languageCode;
      }
      set {
        if (_languageCode == value) {
          return;
        }
        if (_languageCode == null || _languageCode.Equals(value) != true) {
          _languageCode = value;
          OnPropertyChanged();
        }
      }
    }

    private Country_PropertyType _country;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("country", Order = 1)]
    [JsonProperty("country", Order = 1)]
    public Country_PropertyType Country {
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

    private MD_CharacterSetCode_PropertyType _characterEncoding;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("characterEncoding", Order = 2)]
    [JsonProperty("characterEncoding", Order = 2)]
    public MD_CharacterSetCode_PropertyType CharacterEncoding {
      get {
        return _characterEncoding;
      }
      set {
        if (_characterEncoding == value) {
          return;
        }
        if (_characterEncoding == null || _characterEncoding.Equals(value) != true) {
          _characterEncoding = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
