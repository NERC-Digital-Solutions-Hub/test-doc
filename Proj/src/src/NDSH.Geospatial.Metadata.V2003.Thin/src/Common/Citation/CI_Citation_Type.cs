
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 21/12/2022, 19:42, @gisvlasta.
// Updated by        : 09/01/2023, 13:54, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.DateTime;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
using NDSH.Geospatial.Metadata.V2003.Thin.ReferenceSystem;
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
  /// Standardized resource reference.
  /// </summary>
  [Serializable]
  [XmlType("CI_Citation", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("CI_Citation", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("CI_Citation")]
  public class CI_Citation_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_Citation_Type"/>.
    /// </summary>
    public CI_Citation_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _title  = default; //  new CharacterString_PropertyType();
      _alternateTitle  = default; //  new List<CharacterString_PropertyType>();
      _date  = default; //  new List<CI_Date_PropertyType>();
      _edition  = default; //  new CharacterString_PropertyType();
      _editionDate  = default; //  new Date_PropertyType();
      _identifier  = default; //  new List<MD_Identifier_PropertyType>();
      _citedResponsibleParty  = default; //  new List<CI_ResponsibleParty_PropertyType>();
      _presentationForm  = default; //  new List<CI_PresentationFormCode_PropertyType>();
      _series  = default; //  new CI_Series_PropertyType();
      _otherCitationDetails  = default; //  new CharacterString_PropertyType();
      _collectiveTitle  = default; //  new CharacterString_PropertyType();
      _isbn  = default; //  new CharacterString_PropertyType();
      _issn  = default; //  new CharacterString_PropertyType();
      
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

    private CharacterString _title;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("title", Order = 0)]
    [JsonProperty("title", Order = 0)]
    public CharacterString Title {
      get {
        return _title;
      }
      set {
        if (_title == value) {
          return;
        }
        if (_title == null || _title.Equals(value) != true) {
          _title = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CharacterString> _alternateTitle;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("alternateTitle", Order = 1)]
    [JsonProperty("alternateTitle", Order = 1)]
    public List<CharacterString> AlternateTitle {
      get {
        return _alternateTitle;
      }
      set {
        if (_alternateTitle == value) {
          return;
        }
        if (_alternateTitle == null || _alternateTitle.Equals(value) != true) {
          _alternateTitle = value;
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

    private CharacterString _edition;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("edition", Order = 3)]
    [JsonProperty("edition", Order = 3)]
    public CharacterString Edition {
      get {
        return _edition;
      }
      set {
        if (_edition == value) {
          return;
        }
        if (_edition == null || _edition.Equals(value) != true) {
          _edition = value;
          OnPropertyChanged();
        }
      }
    }

    private ConceptualSchema.Primitive.DateTime.DateTime _editionDate;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("editionDate", Order = 4)]
    [JsonProperty("editionDate", Order = 4)]
    public ConceptualSchema.Primitive.DateTime.DateTime EditionDate {
      get {
        return _editionDate;
      }
      set {
        if (_editionDate == value) {
          return;
        }
        if (_editionDate == null || _editionDate.Equals(value) != true) {
          _editionDate = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_Identifier_PropertyType> _identifier;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("identifier", Order = 5)]
    [JsonProperty("identifier", Order = 5)]
    public List<MD_Identifier_PropertyType> Identifier {
      get {
        return _identifier;
      }
      set {
        if (_identifier == value) {
          return;
        }
        if (_identifier == null || _identifier.Equals(value) != true) {
          _identifier = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CI_ResponsibleParty_PropertyType> _citedResponsibleParty;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("citedResponsibleParty", Order = 6)]
    [JsonProperty("citedResponsibleParty", Order = 6)]
    public List<CI_ResponsibleParty_PropertyType> CitedResponsibleParty {
      get {
        return _citedResponsibleParty;
      }
      set {
        if (_citedResponsibleParty == value) {
          return;
        }
        if (_citedResponsibleParty == null || _citedResponsibleParty.Equals(value) != true) {
          _citedResponsibleParty = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CI_PresentationFormCode_PropertyType> _presentationForm;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("presentationForm", Order = 7)]
    [JsonProperty("presentationForm", Order = 7)]
    public List<CI_PresentationFormCode_PropertyType> PresentationForm {
      get {
        return _presentationForm;
      }
      set {
        if (_presentationForm == value) {
          return;
        }
        if (_presentationForm == null || _presentationForm.Equals(value) != true) {
          _presentationForm = value;
          OnPropertyChanged();
        }
      }
    }

    private CI_Series_PropertyType _series;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("series", Order = 8)]
    [JsonProperty("series", Order = 8)]
    public CI_Series_PropertyType Series {
      get {
        return _series;
      }
      set {
        if (_series == value) {
          return;
        }
        if (_series == null || _series.Equals(value) != true) {
          _series = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _otherCitationDetails;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("otherCitationDetails", Order = 9)]
    [JsonProperty("otherCitationDetails", Order = 9)]
    public CharacterString OtherCitationDetails {
      get {
        return _otherCitationDetails;
      }
      set {
        if (_otherCitationDetails == value) {
          return;
        }
        if (_otherCitationDetails == null || _otherCitationDetails.Equals(value) != true) {
          _otherCitationDetails = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _collectiveTitle;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("collectiveTitle", Order = 10)]
    [JsonProperty("collectiveTitle", Order = 10)]
    public CharacterString CollectiveTitle {
      get {
        return _collectiveTitle;
      }
      set {
        if (_collectiveTitle == value) {
          return;
        }
        if (_collectiveTitle == null || _collectiveTitle.Equals(value) != true) {
          _collectiveTitle = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _isbn;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ISBN", Order = 11)]
    [JsonProperty("ISBN", Order = 11)]
    public CharacterString ISBN {
      get {
        return _isbn;
      }
      set {
        if (_isbn == value) {
          return;
        }
        if (_isbn == null || _isbn.Equals(value) != true) {
          _isbn = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _issn;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ISSN", Order = 12)]
    [JsonProperty("ISSN", Order = 12)]
    public CharacterString ISSN {
      get {
        return _issn;
      }
      set {
        if (_issn == value) {
          return;
        }
        if (_issn == null || _issn.Equals(value) != true) {
          _issn = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}