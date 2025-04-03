
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 02/01/2023, @gisvlasta
// History           : 31/03/2025, @gisvlasta - Added IsoTypeAttribute, and deleted namespaces.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/freeText.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:element name="LanguageCode" type="gco:CodeListValue_Type" substitutionGroup="gco:CharacterString"/>
// 
// <xs:complexType name="LanguageCode_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:LanguageCode"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.Localisation {

  [IsoType("LanguageCode", WrapperName = "LanguageCode_PropertyType", IsoType = IsoTypes.Element)]
  //[XmlType("LanguageCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("LanguageCode_PropertyType")]
  public class LanguageCode_CodeList : CodeListValue_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LanguageCode_CodeList"/>.
    /// </summary>
    public LanguageCode_CodeList() {
      //_languageCode = default; //  new CodeListValue_Type(); // WARNING: Set to the first member of the codelist.
    }

    #endregion

  }

}
