
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 02/01/2023, @gisvlasta
// History           : 14/03/2025, @gisvlasta - Updated inheritance to CharacterString and refactored code accordingly.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/freeText.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="LocalisedCharacterString_Type">
//   <xs:simpleContent>
//     <xs:extension base="xs:string">
//       <xs:attribute name="id" type="xs:ID"/>
//       <xs:attribute name="locale" type="xs:anyURI"/>
//     </xs:extension>
//   </xs:simpleContent>
// </xs:complexType>
// <xs:element name="LocalisedCharacterString"
//             type="gmd:LocalisedCharacterString_Type" substitutionGroup="gco:CharacterString"/>
// <xs:complexType name="LocalisedCharacterString_PropertyType">
//   <xs:complexContent>
//     <xs:extension base="gco:ObjectReference_PropertyType">
//       <xs:sequence minOccurs="0">
//         <xs:element ref="gmd:LocalisedCharacterString"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.Localisation {

  [Serializable]
  //[XmlType("LocalisedCharacterString", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("LocalisedCharacterString", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("LocalisedCharacterString")]
  public class LocalisedCharacterString_Type : CharacterString, INullableId {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LocalisedCharacterString_Type"/>.
    /// </summary>
    public LocalisedCharacterString_Type() {

    }

    #endregion

    #region INullableId Interface

    private string? _id;

    //[XmlAttribute(AttributeName = "id", DataType = "ID")]
    [JsonProperty("id")]
    public string? Id {
      get => _id;
      set => SetProperty(ref _id, value);
    }

    #endregion

    #region Public Properties

    private string _locale;

    //[XmlAttribute(AttributeName = "locale", DataType = "anyURI")]
    [JsonProperty("locale")]
    public string Locale {
      get => _locale;
      set => SetProperty(ref _locale, value);
    }

    #endregion

  }

}
