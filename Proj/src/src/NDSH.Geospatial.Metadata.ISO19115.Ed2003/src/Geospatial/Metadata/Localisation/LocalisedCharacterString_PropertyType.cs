
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 02/01/2023, @gisvlasta
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

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Localisation {

  // TODO: REFACTOR

  [Serializable]
  //[XmlType("LocalisedCharacterString_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("LocalisedCharacterString_PropertyType")]
  public class LocalisedCharacterString_PropertyType : ReferenceEntity {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LocalisedCharacterString_PropertyType"/>.
    /// </summary>
    public LocalisedCharacterString_PropertyType() {
      _localisedCharacterString = default; //  new LocalisedCharacterString_Type();
    }

    #endregion

    #region Public Properties

    private LocalisedCharacterString_Type _localisedCharacterString;

    //[XmlElement("LocalisedCharacterString", Order = 0)]
    [JsonProperty("LocalisedCharacterString", Order = 0)]
    public LocalisedCharacterString_Type LocalisedCharacterString {
      get => _localisedCharacterString;
      set => SetProperty(ref _localisedCharacterString, value);
    }

    #endregion

  }

}
