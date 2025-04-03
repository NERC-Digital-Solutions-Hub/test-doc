
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 07/01/2023, 19:09, @gisvlasta.
// Updated by        : 09/01/2023, 14:02, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.DateTime;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text;
using NDSH.Geospatial.Metadata.V2003.Identification;
using NDSH.Geospatial.Metadata.V2003.Localisation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlInclude(typeof(CT_UomCatalogue_Type))]
  [XmlInclude(typeof(CT_CrsCatalogue_Type))]
  [XmlInclude(typeof(CT_CodelistCatalogue_Type))]
  [XmlType("AbstractCT_Catalogue", Namespace = "http://www.isotc211.org/2005/gmx")]
  [XmlRoot("AbstractCT_Catalogue", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  public abstract class AbstractCT_Catalogue_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractCT_Catalogue_Type"/>.
    /// </summary>
    public AbstractCT_Catalogue_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmx", "http://www.isotc211.org/2005/gmx");

      _name  = default; //  new CharacterString_PropertyType();
      _scope  = default; //  new List<CharacterString_PropertyType>();
      _fieldOfApplication  = default; //  new List<CharacterString_PropertyType>();
      _versionNumber  = default; //  new CharacterString_PropertyType();
      _versionDate  = default; //  new Date_PropertyType();
      _language  = default; //  new CharacterString_PropertyType();
      _characterSet  = default; //  new MD_CharacterSetCode_PropertyType();
      _locale  = default; //  new List<PT_Locale_PropertyType>();
      _subCatalogue  = default; //  new List<CT_Catalogue_PropertyType>();

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

    private CharacterString_PropertyType _name;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("name", Order = 0)]
    [JsonProperty("name", Order = 0)]
    public CharacterString_PropertyType Name {
      get {
        return _name;
      }
      set {
        if (_name == value) {
          return;
        }
        if (_name == null || _name.Equals(value) != true) {
          _name = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CharacterString_PropertyType> _scope;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("scope", Order = 1)]
    [JsonProperty("scope", Order = 1)]
    public List<CharacterString_PropertyType> Scope {
      get {
        return _scope;
      }
      set {
        if (_scope == value) {
          return;
        }
        if (_scope == null || _scope.Equals(value) != true) {
          _scope = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CharacterString_PropertyType> _fieldOfApplication;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("fieldOfApplication", Order = 2)]
    [JsonProperty("fieldOfApplication", Order = 2)]
    public List<CharacterString_PropertyType> FieldOfApplication {
      get {
        return _fieldOfApplication;
      }
      set {
        if (_fieldOfApplication == value) {
          return;
        }
        if (_fieldOfApplication == null || _fieldOfApplication.Equals(value) != true) {
          _fieldOfApplication = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _versionNumber;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("versionNumber", Order = 3)]
    [JsonProperty("versionNumber", Order = 3)]
    public CharacterString_PropertyType VersionNumber {
      get {
        return _versionNumber;
      }
      set {
        if (_versionNumber == value) {
          return;
        }
        if (_versionNumber == null || _versionNumber.Equals(value) != true) {
          _versionNumber = value;
          OnPropertyChanged();
        }
      }
    }

    private Date_PropertyType _versionDate;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("versionDate", Order = 4)]
    [JsonProperty("versionDate", Order = 4)]
    public Date_PropertyType VersionDate {
      get {
        return _versionDate;
      }
      set {
        if (_versionDate == value) {
          return;
        }
        if (_versionDate == null || _versionDate.Equals(value) != true) {
          _versionDate = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _language;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("language", Order = 5)]
    [JsonProperty("language", Order = 5)]
    public CharacterString_PropertyType Language {
      get {
        return _language;
      }
      set {
        if (_language == value) {
          return;
        }
        if (_language == null || _language.Equals(value) != true) {
          _language = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_CharacterSetCode_PropertyType _characterSet;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("characterSet", Order = 6)]
    [JsonProperty("characterSet", Order = 6)]
    public MD_CharacterSetCode_PropertyType CharacterSet {
      get {
        return _characterSet;
      }
      set {
        if (_characterSet == value) {
          return;
        }
        if (_characterSet == null || _characterSet.Equals(value) != true) {
          _characterSet = value;
          OnPropertyChanged();
        }
      }
    }

    private List<PT_Locale_PropertyType> _locale;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("locale", Order = 7)]
    [JsonProperty("locale", Order = 7)]
    public List<PT_Locale_PropertyType> Locale {
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

    private List<CT_Catalogue_PropertyType> _subCatalogue;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("subCatalogue", Order = 8)]
    [JsonProperty("subCatalogue", Order = 8)]
    public List<CT_Catalogue_PropertyType> SubCatalogue {
      get {
        return _subCatalogue;
      }
      set {
        if (_subCatalogue == value) {
          return;
        }
        if (_subCatalogue == null || _subCatalogue.Equals(value) != true) {
          _subCatalogue = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
