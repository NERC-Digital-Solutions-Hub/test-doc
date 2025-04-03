
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 07/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmx/catalogues.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="AbstractCT_Catalogue_Type" abstract="true">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="name"
//                     type="gco:CharacterString_PropertyType"/>
//         <xs:element name="scope"
//                     type="gco:CharacterString_PropertyType" maxOccurs="unbounded"/>
//         <xs:element name="fieldOfApplication"
//                     type="gco:CharacterString_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="versionNumber"
//                     type="gco:CharacterString_PropertyType"/>
//         <xs:element name="versionDate"
//                     type="gco:Date_PropertyType"/>
//         <xs:element name="language"
//                     type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="characterSet"
//                     type="gmd:MD_CharacterSetCode_PropertyType" minOccurs="0"/>
//         <xs:element name="locale"
//                     type="gmd:PT_Locale_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="subCatalogue"
//                     type="gmx:CT_Catalogue_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="AbstractCT_Catalogue" type="gmx:AbstractCT_Catalogue_Type" abstract="true"/>
// <xs:complexType name="CT_Catalogue_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:AbstractCT_Catalogue"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.DateTime;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Identification;
using NDSH.Geospatial.Metadata.Localisation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.XmlSchema.Catalogues {

  #region XmlIncludes
  //[XmlInclude(typeof(CT_UomCatalogue_Type))]
  //[XmlInclude(typeof(CT_CrsCatalogue_Type))]
  //[XmlInclude(typeof(CT_CodelistCatalogue_Type))]
  #endregion

  [Serializable]
  //[XmlType("AbstractCT_Catalogue", Namespace = "http://www.isotc211.org/2005/gmx")]
  //[XmlRoot("AbstractCT_Catalogue", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  public abstract class AbstractCT_Catalogue_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractCT_Catalogue_Type"/>.
    /// </summary>
    public AbstractCT_Catalogue_Type() {
      _name = default; //  new CharacterString();
      _scope = default; //  new List<CharacterString>();
      _fieldOfApplication = default; //  new List<CharacterString>();
      _versionNumber = default; //  new CharacterString();
      _versionDate = default; //  new Date_PropertyType();
      _language = default; //  new CharacterString();
      _characterSet = default; //  new MD_CharacterSetCode_PropertyType();
      _locale = default; //  new List<PT_Locale_Type>();
      _subCatalogue = default; //  new List<AbstractCT_Catalogue_Type>();
    }

    #endregion

    #region Public Properties

    private CharacterString _name;

    /// <summary>
    /// Name of the catalogue.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("name", Order = 0)]
    [JsonProperty("name", Order = 0)]
    public CharacterString Name {
      get => _name;
      set => SetProperty(ref _name, value);
    }

    private ObservableCollection<CharacterString> _scope;

    /// <summary>
    /// Subject domain(s) of the catalogue content.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - N
    //[XmlElement("scope", Order = 1)]
    [JsonProperty("scope", Order = 1)]
    public ObservableCollection<CharacterString> Scope {
      get => _scope;
      set => SetProperty(ref _scope, value);
    }

    private ObservableCollection<CharacterString>? _fieldOfApplication;

    /// <summary>
    /// Description of kind(s) of use to which the catalogue may be put.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("fieldOfApplication", Order = 2)]
    [JsonProperty("fieldOfApplication", Order = 2)]
    public ObservableCollection<CharacterString>? FieldOfApplication {
      get => _fieldOfApplication;
      set => SetProperty(ref _fieldOfApplication, value);
    }

    private CharacterString _versionNumber;

    /// <summary>
    /// Version number of this catalogue, which may include both a major Version Number of letter and a sequence of
    /// minor release numbers or letters, such as "3.2.4a". The format of this attribute may differ between cataloguing
    /// authorities.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("versionNumber", Order = 3)]
    [JsonProperty("versionNumber", Order = 3)]
    public CharacterString VersionNumber {
      get => _versionNumber;
      set => SetProperty(ref _versionNumber, value);
    }

    private DateDbEntity _versionDate;

    /// <summary>
    /// Effective date of this catalogue.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("versionDate", Order = 4)]
    [JsonProperty("versionDate", Order = 4)]
    public DateDbEntity VersionDate {
      get => _versionDate;
      set => SetProperty(ref _versionDate, value);
    }

    private CharacterString? _language;

    /// <summary>
    /// Default language of the textual information contained in the catalogue.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("language", Order = 5)]
    [JsonProperty("language", Order = 5)]
    public CharacterString? Language {
      get => _language;
      set => SetProperty(ref _language, value);
    }

    private MD_CharacterSetCode_CodeList? _characterSet;

    /// <summary>
    /// Default character coding standard used for the language.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("characterSet", Order = 6)]
    [JsonProperty("characterSet", Order = 6)]
    public MD_CharacterSetCode_CodeList? CharacterSet {
      get => _characterSet;
      set => SetProperty(ref _characterSet, value);
    }

    private ObservableCollection<PT_Locale_Type> _locale;

    /// <summary>
    /// Provides the list of locale in which the free text content of the catalogue has been translated.
    /// </summary>
    // TODO: OBL - C (Mandatory when the textual content of the catalogue is provided as free text)
    // TODO: CAR - N
    //[XmlElement("locale", Order = 7)]
    [JsonProperty("locale", Order = 7)]
    public ObservableCollection<PT_Locale_Type> Locale {
      get => _locale;
      set => SetProperty(ref _locale, value);
    }

    private ObservableCollection<AbstractCT_Catalogue_Type> _subCatalogue;

    /// <summary>
    /// Catalogue which is an integral part of the current catalogue.
    /// </summary>
    /// <remarks>
    /// The intent is not to aggregate all the catalogues whose content
    /// is referred to by the content of the current catalogue.
    /// </remarks>
    //[XmlElement("subCatalogue", Order = 8)]
    [JsonProperty("subCatalogue", Order = 8)]
    public ObservableCollection<AbstractCT_Catalogue_Type> SubCatalogue {
      get => _subCatalogue;
      set => SetProperty(ref _subCatalogue, value);
    }

    #endregion

  }

}
