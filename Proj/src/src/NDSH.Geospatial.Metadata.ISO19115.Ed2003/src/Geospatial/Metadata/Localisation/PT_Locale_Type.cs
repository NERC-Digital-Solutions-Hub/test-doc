
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 02/01/2023, @gisvlasta
// History           : 31/03/2025, @gisvlasta - Added IsoTypeAttribute, commented out xml attributes, updated getters,
//                                               corrected property nullability, and deleted namespaces.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/freeText.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="PT_Locale_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="languageCode" type="gmd:LanguageCode_PropertyType"/>
//         <xs:element name="country" type="gmd:Country_PropertyType" minOccurs="0"/>
//         <xs:element name="characterEncoding" type="gmd:MD_CharacterSetCode_PropertyType"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// 
// <xs:element name="PT_Locale" type="gmd:PT_Locale_Type"/>
// 
// <xs:complexType name="PT_Locale_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:PT_Locale"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces


using NDSH.Geospatial.Metadata.Identification;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.Localisation {

  [IsoType("PT_Locale_Type", WrapperName = "PT_Locale_PropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlType("PT_Locale", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("PT_Locale", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("PT_Locale")]
  public class PT_Locale_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="PT_Locale_Type"/>.
    /// </summary>
    public PT_Locale_Type() {
      _languageCode = default; //  new LanguageCode_PropertyType();
      _country = default; //  new Country_PropertyType();
      _characterEncoding = default; //  new MD_CharacterSetCode_PropertyType();
    }

    #endregion

    #region Public Properties

    private LanguageCode_CodeList _languageCode;

    /// <summary>
    /// Designation of the locale language.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("languageCode", Order = 0)]
    [JsonProperty("languageCode", Order = 0)]
    public required LanguageCode_CodeList LanguageCode {
      get => _languageCode;
      set => SetProperty(ref _languageCode, value);
    }

    private Country_CodeList? _country;

    /// <summary>
    /// Designation of the specific country of the locale language.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("country", Order = 1)]
    [JsonProperty("country", Order = 1)]
    public Country_CodeList? Country {
      get => _country;
      set => SetProperty(ref _country, value);
    }

    private MD_CharacterSetCode_CodeList _characterEncoding;

    /// <summary>
    /// Designation of the character set to be used to encode the textual value of the locale.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("characterEncoding", Order = 2)]
    [JsonProperty("characterEncoding", Order = 2)]
    public MD_CharacterSetCode_CodeList CharacterEncoding {
      get => _characterEncoding;
      set => SetProperty(ref _characterEncoding, value);
    }

    #endregion

  }

}
