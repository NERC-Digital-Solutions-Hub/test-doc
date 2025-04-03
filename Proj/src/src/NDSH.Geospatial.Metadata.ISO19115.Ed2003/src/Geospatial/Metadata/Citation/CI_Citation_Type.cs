
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 21/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/citation.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="CI_Citation_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="title"
//                     type="gco:CharacterString_PropertyType"/>
//         <xs:element name="alternateTitle"
//                     type="gco:CharacterString_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="date"
//                     type="gmd:CI_Date_PropertyType" maxOccurs="unbounded"/>
//         <xs:element name="edition"
//                     type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="editionDate"
//                     type="gco:Date_PropertyType" minOccurs="0"/>
//         <xs:element name="identifier"
//                     type="gmd:MD_Identifier_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="citedResponsibleParty"
//                     type="gmd:CI_ResponsibleParty_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="presentationForm"
//                     type="gmd:CI_PresentationFormCode_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="series"
//                     type="gmd:CI_Series_PropertyType" minOccurs="0"/>
//         <xs:element name="otherCitationDetails"
//                     type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="collectiveTitle"
//                     type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="ISBN"
//                     type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="ISSN"
//                     type="gco:CharacterString_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="CI_Citation" type="gmd:CI_Citation_Type"/>
// <xs:complexType name="CI_Citation_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:CI_Citation"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.DateTime;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;

using NDSH.Geospatial.Metadata.ReferenceSystem;
using NDSH.Hashing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.Citation {

  /// <summary>
  /// Standardized resource reference.
  /// </summary>
  [Serializable]
  //[XmlType("CI_Citation", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("CI_Citation", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("CI_Citation")]
  public class CI_Citation_Type : MetadataObject, IComparable<CI_Citation_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_Citation_Type"/>.
    /// </summary>
    public CI_Citation_Type() {
      _title = default; //  new CharacterString();
      _alternateTitle = default; //  new List<CharacterString>();
      _date = default; //  new List<CI_Date_Type>();
      _edition = default; //  new CharacterString();
      _editionDate = default; //  new Date_PropertyType();
      _identifier = default; //  new List<MD_Identifier_Type>();
      _citedResponsibleParty = default; //  new List<CI_ResponsibleParty_Type>();
      _presentationForm = default; //  new List<CI_PresentationFormCode_PropertyType>();
      _series = default; //  new CI_Series_Type();
      _otherCitationDetails = default; //  new CharacterString();
      _collectiveTitle = default; //  new CharacterString();
      _isbn = default; //  new CharacterString();
      _issn = default; //  new CharacterString();
    }

    #endregion

    #region Public Properties

    private CharacterString _title;

    /// <summary>
    /// Name by which the cited resource is known.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("title", Order = 0)]
    [JsonProperty("title", Order = 0)]
    public CharacterString Title {
      get => _title;
      set => SetProperty(ref _title, value);
    }

    private ObservableCollection<CharacterString>? _alternateTitle;

    /// <summary>
    /// Short name or other language name by which the cited information is known.
    /// </summary>
    /// <example>"DCW" as an alternative title for "Digital Chart of the World”</example>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("alternateTitle", Order = 1)]
    [JsonProperty("alternateTitle", Order = 1)]
    public ObservableCollection<CharacterString>? AlternateTitle {
      get => _alternateTitle;
      set => SetProperty(ref _alternateTitle, value);
    }

    private ObservableCollection<CI_Date_Type> _date;

    /// <summary>
    /// Reference date for the cited resource.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - N
    //[XmlElement("date", Order = 2)]
    [JsonProperty("date", Order = 2)]
    public ObservableCollection<CI_Date_Type> Date {
      get => _date;
      set => SetProperty(ref _date, value);
    }

    private CharacterString? _edition;

    /// <summary>
    /// Version of the cited resource.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("edition", Order = 3)]
    [JsonProperty("edition", Order = 3)]
    public CharacterString? Edition {
      get => _edition;
      set => SetProperty(ref _edition, value);
    }

    private DateDbEntity? _editionDate;

    /// <summary>
    /// Date of the edition.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("editionDate", Order = 4)]
    [JsonProperty("editionDate", Order = 4)]
    public DateDbEntity? EditionDate {
      get => _editionDate;
      set => SetProperty(ref _editionDate, value);
    }

    private ObservableCollection<MD_Identifier_Type>? _identifier;

    /// <summary>
    /// Value uniquely identifying an object within a namespace.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("identifier", Order = 5)]
    [JsonProperty("identifier", Order = 5)]
    public ObservableCollection<MD_Identifier_Type>? Identifier {
      get => _identifier;
      set => SetProperty(ref _identifier, value);
    }

    private ObservableCollection<CI_ResponsibleParty_Type>? _citedResponsibleParty;

    /// <summary>
    /// Name and position information for an individual or organization that is responsible for the resource.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("citedResponsibleParty", Order = 6)]
    [JsonProperty("citedResponsibleParty", Order = 6)]
    public ObservableCollection<CI_ResponsibleParty_Type>? CitedResponsibleParty {
      get => _citedResponsibleParty;
      set => SetProperty(ref _citedResponsibleParty, value);
    }

    private ObservableCollection<CI_PresentationFormCode_CodeList>? _presentationForm;

    /// <summary>
    /// Mode in which the resource is represented.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("presentationForm", Order = 7)]
    [JsonProperty("presentationForm", Order = 7)]
    public ObservableCollection<CI_PresentationFormCode_CodeList>? PresentationForm {
      get => _presentationForm;
      set => SetProperty(ref _presentationForm, value);
    }

    private CI_Series_Type? _series;

    /// <summary>
    /// Information about the series, or aggregate dataset, of which the dataset is a part.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("series", Order = 8)]
    [JsonProperty("series", Order = 8)]
    public CI_Series_Type? Series {
      get => _series;
      set => SetProperty(ref _series, value);
    }

    private CharacterString? _otherCitationDetails;

    /// <summary>
    /// Other information required to complete the citation that is not recorded elsewhere.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("otherCitationDetails", Order = 9)]
    [JsonProperty("otherCitationDetails", Order = 9)]
    public CharacterString? OtherCitationDetails {
      get => _otherCitationDetails;
      set => SetProperty(ref _otherCitationDetails, value);
    }

    private CharacterString? _collectiveTitle;

    /// <summary>
    /// Common title with holdings note.
    /// </summary>
    /// <remarks>
    /// Title identifies elements of a series collectively, 
    /// combined with information about what volumes are available at the source cited.
    /// </remarks>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("collectiveTitle", Order = 10)]
    [JsonProperty("collectiveTitle", Order = 10)]
    public CharacterString? CollectiveTitle {
      get => _collectiveTitle;
      set => SetProperty(ref _collectiveTitle, value);
    }

    private CharacterString? _isbn;

    /// <summary>
    /// International Standard Book Number.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("ISBN", Order = 11)]
    [JsonProperty("ISBN", Order = 11)]
    public CharacterString? ISBN {
      get => _isbn;
      set => SetProperty(ref _isbn, value);
    }

    private CharacterString? _issn;

    /// <summary>
    /// International Standard Serial Number.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("ISSN", Order = 12)]
    [JsonProperty("ISSN", Order = 12)]
    public CharacterString? ISSN {
      get => _issn;
      set => SetProperty(ref _issn, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="CI_Citation_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>equal</b> if all their properties are <b>equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="CI_Citation_Type"/> to compare with.</param>
    /// <returns>
    /// An <see cref="int"/> representing the result of the comparison:
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if this instance is greater than the other.</item>
    /// <item><term>-1</term> if this instance is less than the other.</item>
    /// </list>
    /// </returns>
    public int CompareTo(CI_Citation_Type? other) {
      int result;
      return
          other is null ? 1 :
          (result = Title.CompareTo(other.Title)) != 0 ? result :
          (result = Edition?.CompareTo(other.Edition) ?? 1) != 0 ? result :
          (result = OtherCitationDetails?.CompareTo(other.OtherCitationDetails) ?? 1) != 0 ? result :
          (result = CollectiveTitle?.CompareTo(other.CollectiveTitle) ?? 1) != 0 ? result :
          (result = ISBN?.CompareTo(other.ISBN) ?? 1) != 0 ? result :
          (result = ISSN?.CompareTo(other.ISSN) ?? 1) != 0 ? result :
          (result = AlternateTitle?.Count.CompareTo(other.AlternateTitle?.Count ?? 1) ?? 1) != 0 ? result :
          (result = Date.Count.CompareTo(other.Date.Count)) != 0 ? result :
          (result = Identifier?.Count.CompareTo(other.Identifier?.Count ?? 1) ?? 1) != 0 ? result :
          (result = CitedResponsibleParty?.Count.CompareTo(other.CitedResponsibleParty?.Count ?? 1) ?? 1) != 0 ? result :
          PresentationForm?.Count.CompareTo(other.PresentationForm?.Count ?? 1) ?? 1;
    }

    #endregion

    #region Overrides

    /// <inheritdoc />
    public override bool Equals(object? obj) {
      if (obj is not CI_Citation_Type ciCitation) {
        return false;
      }

      return AlternateTitle.SequenceEqualOrdered(ciCitation.AlternateTitle) &&
       Date.SequenceEqualOrdered(ciCitation.Date) &&
       Identifier.SequenceEqualOrdered(ciCitation.Identifier) &&
       CitedResponsibleParty.SequenceEqualOrdered(ciCitation.CitedResponsibleParty) &&
       PresentationForm.SequenceEqualOrdered(ciCitation.PresentationForm) &&
       Equals(Title, ciCitation.Title) &&
       Equals(Edition, ciCitation.Edition) &&
       Equals(OtherCitationDetails, ciCitation.OtherCitationDetails) &&
       Equals(Series, ciCitation.Series) &&
       Equals(CollectiveTitle, ciCitation.CollectiveTitle) &&
       Equals(ISBN, ciCitation.ISBN) &&
       Equals(ISSN, ciCitation.ISSN);
    }

    /// <inheritdoc />
    public override int GetHashCode() {
      NdshHashCode hash = new();

      foreach (CharacterString characterString in AlternateTitle.SafeOrderBy()) {
        hash.Add(characterString);
      }

      foreach (CI_Date_Type date in Date.SafeOrderBy()) {
        hash.Add(date);
      }

      foreach (MD_Identifier_Type identifier in Identifier.SafeOrderBy()) {
        hash.Add(identifier);
      }

      foreach (CI_ResponsibleParty_Type responsibleParty in CitedResponsibleParty.SafeOrderBy()) {
        hash.Add(responsibleParty);
      }

      foreach (CI_PresentationFormCode_CodeList presentationForm in PresentationForm.SafeOrderBy()) {
        hash.Add(presentationForm);
      }

      hash.Add(Title);
      hash.Add(Edition);
      hash.Add(OtherCitationDetails);
      hash.Add(Series);
      hash.Add(CollectiveTitle);
      hash.Add(ISBN);
      hash.Add(ISSN);
      return hash.ToHashCode();
    }

    #endregion

  }

}
