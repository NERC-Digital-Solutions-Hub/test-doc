
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 16/12/2022, 19:15, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.ReferenceSystem;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.Common.Citation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("CI_Citation", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("CI_Citation", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("CI_Citation")]
  public class CI_Citation : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_Citation"/>.
    /// </summary>
    public CI_Citation() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _title = default;
      _alternateTitle = default; //new List<string>();
      _date = default; //new List<CI_Date>();
      _edition = default;
      _editionDate = null; // TODO: Check Null here
      _identifier = default; //new List<Parent_MD_Identifier>();
      _identifierType = default; //new List<string>();
      _citedResponsibleParty = default; //new List<CI_ResponsibleParty>();
      _presentationForm = default; //new List<CI_PresentationFormCode>();
      _series = default; //new CI_Series();
      _otherCitationDetails = default;
      _collectiveTitle = default;
      _isbn = default;
      _issn = default;
      
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

    private string _title;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "title")]
    [JsonProperty("title", Order = 0)]
    public string Title {
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
    
    private List<string> _alternateTitle;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("alternateTitle", Order = 1, ElementName = "alternateTitle")]
    [JsonProperty("alternateTitle", Order = 1)]
    public List<string> AlternateTitle {
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

    private List<CI_Date> _date;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("date", Order = 2, ElementName = "date")]
    [JsonProperty("date", Order = 2)]
    public List<CI_Date> Date {
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

    private string _edition;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3, ElementName = "edition")]
    [JsonProperty("edition", Order = 3)]
    public string Edition {
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

    private DateTime? _editionDate;

    // TODO: IMPORTANT - Cheack for sure the use of Nullable Type here.

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4, ElementName = "editionDate")]
    [JsonProperty("editionDate", Order = 4)]
    public DateTime? EditionDate {
      get {
        return _editionDate;
      }
      set {
        if (_editionDate.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "EditionDate";
          Validator.ValidateProperty(value, validatorPropContext);
          _editionDate = value;
          OnPropertyChanged();
        }
      }
    }

    private List<Parent_MD_Identifier> _identifier;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("identifier", Order = 5, ElementName = "identifier")]
    [JsonProperty("identifier", Order = 5)]
    public List<Parent_MD_Identifier> Identifier {
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

    private List<string> _identifierType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("identifierType", Order = 6, ElementName = "identifierType")]
    [JsonProperty("identifierType", Order = 6)]
    public List<string> IdentifierType {
      get {
        return _identifierType;
      }
      set {
        if (_identifierType == value) {
          return;
        }
        if (_identifierType == null || _identifierType.Equals(value) != true) {
          _identifierType = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CI_ResponsibleParty> _citedResponsibleParty;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("citedResponsibleParty", Order = 7, ElementName = "citedResponsibleParty")]
    [JsonProperty("citedResponsibleParty", Order = 7)]
    public List<CI_ResponsibleParty> CitedResponsibleParty {
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

    private List<CI_PresentationFormCode> _presentationForm;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("presentationForm", Order = 8, ElementName = "presentationForm")]
    [JsonProperty("presentationForm", Order = 8)]
    public List<CI_PresentationFormCode> PresentationForm {
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

    private CI_Series _series;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 9, ElementName = "series")]
    [JsonProperty("series", Order = 9)]
    public CI_Series Series {
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

    private string _otherCitationDetails;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 10, ElementName = "otherCitationDetails")]
    [JsonProperty("otherCitationDetails", Order = 10)]
    public string OtherCitationDetails {
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

    private string _collectiveTitle;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 11, ElementName = "collectiveTitle")]
    [JsonProperty("collectiveTitle", Order = 11)]
    public string CollectiveTitle {
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

    private string _isbn;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 12)]
    [JsonProperty(Order = 12)]
    public string ISBN {
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

    private string _issn;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 13)]
    [JsonProperty(Order = 13)]
    public string ISSN {
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

    private string _id;

    /// <summary>
    /// 
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
    /// 
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
