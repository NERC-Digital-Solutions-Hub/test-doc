
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

using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.DateTime;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text;
using NDSH.Geospatial.Metadata.V2003.ReferenceSystem;
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

      _title = default; //  new CharacterString_PropertyType();
      _alternateTitle = default; //  new List<CharacterString_PropertyType>();
      _date = default; //  new List<CI_Date_PropertyType>();
      _edition = default; //  new CharacterString_PropertyType();
      _editionDate = default; //  new Date_PropertyType();
      _identifier = default; //  new List<MD_Identifier_PropertyType>();
      _citedResponsibleParty = default; //  new List<CI_ResponsibleParty_PropertyType>();
      _presentationForm = default; //  new List<CI_PresentationFormCode_PropertyType>();
      _series = default; //  new CI_Series_PropertyType();
      _otherCitationDetails = default; //  new CharacterString_PropertyType();
      _collectiveTitle = default; //  new CharacterString_PropertyType();
      _isbn = default; //  new CharacterString_PropertyType();
      _issn = default; //  new CharacterString_PropertyType();

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

    private CharacterString_PropertyType _title;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("title", Order = 0)]
    [JsonProperty("title", Order = 0)]
    public CharacterString_PropertyType Title {
      get => _title;
      set {
        if (_title == value) {
          return;
        }
        if (_title == null || !_title.Equals(value)) {
          _title = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CharacterString_PropertyType> _alternateTitle;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("alternateTitle", Order = 1)]
    [JsonProperty("alternateTitle", Order = 1)]
    public List<CharacterString_PropertyType> AlternateTitle {
      get => _alternateTitle;
      set {
        if (_alternateTitle == value) {
          return;
        }
        if (_alternateTitle == null || !_alternateTitle.Equals(value)) {
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
      get => _date;
      set {
        if (_date == value) {
          return;
        }
        if (_date == null || !_date.Equals(value)) {
          _date = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _edition;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("edition", Order = 3)]
    [JsonProperty("edition", Order = 3)]
    public CharacterString_PropertyType Edition {
      get => _edition;
      set {
        if (_edition == value) {
          return;
        }
        if (_edition == null || !_edition.Equals(value)) {
          _edition = value;
          OnPropertyChanged();
        }
      }
    }

    private Date_PropertyType _editionDate;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("editionDate", Order = 4)]
    [JsonProperty("editionDate", Order = 4)]
    public Date_PropertyType EditionDate {
      get => _editionDate;
      set {
        if (_editionDate == value) {
          return;
        }
        if (_editionDate == null || !_editionDate.Equals(value)) {
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
      get => _identifier;
      set {
        if (_identifier == value) {
          return;
        }
        if (_identifier == null || !_identifier.Equals(value)) {
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
      get => _citedResponsibleParty;
      set {
        if (_citedResponsibleParty == value) {
          return;
        }
        if (_citedResponsibleParty == null || !_citedResponsibleParty.Equals(value)) {
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
      get => _presentationForm;
      set {
        if (_presentationForm == value) {
          return;
        }
        if (_presentationForm == null || !_presentationForm.Equals(value)) {
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
      get => _series;
      set {
        if (_series == value) {
          return;
        }
        if (_series == null || !_series.Equals(value)) {
          _series = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _otherCitationDetails;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("otherCitationDetails", Order = 9)]
    [JsonProperty("otherCitationDetails", Order = 9)]
    public CharacterString_PropertyType OtherCitationDetails {
      get => _otherCitationDetails;
      set {
        if (_otherCitationDetails == value) {
          return;
        }
        if (_otherCitationDetails == null || !_otherCitationDetails.Equals(value)) {
          _otherCitationDetails = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _collectiveTitle;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("collectiveTitle", Order = 10)]
    [JsonProperty("collectiveTitle", Order = 10)]
    public CharacterString_PropertyType CollectiveTitle {
      get => _collectiveTitle;
      set {
        if (_collectiveTitle == value) {
          return;
        }
        if (_collectiveTitle == null || !_collectiveTitle.Equals(value)) {
          _collectiveTitle = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _isbn;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ISBN", Order = 11)]
    [JsonProperty("ISBN", Order = 11)]
    public CharacterString_PropertyType ISBN {
      get => _isbn;
      set {
        if (_isbn == value) {
          return;
        }
        if (_isbn == null || !_isbn.Equals(value)) {
          _isbn = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _issn;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ISSN", Order = 12)]
    [JsonProperty("ISSN", Order = 12)]
    public CharacterString_PropertyType ISSN {
      get => _issn;
      set {
        if (_issn == value) {
          return;
        }
        if (_issn == null || !_issn.Equals(value)) {
          _issn = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
