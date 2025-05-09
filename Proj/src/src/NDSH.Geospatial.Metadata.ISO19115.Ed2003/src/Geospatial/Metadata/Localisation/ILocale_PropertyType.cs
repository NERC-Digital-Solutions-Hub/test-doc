﻿
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 06/01/2023, @gisvlasta
// History           : 31/03/2025, @gisvlasta - Changed Locale property to non-nullable.
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

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Localisation {

  public interface ILocale_PropertyType {

    //[XmlElement("locale", Order = 0)] // TODO: Should these [XmlElement be in the interface?
    [JsonProperty("locale", Order = 0)]
    public PT_Locale_Type Locale {
      get;
      set;
    }

  }

}
