
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 29/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/identification.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:element name="DS_InitiativeTypeCode" type="gco:CodeListValue_Type" substitutionGroup="gco:CharacterString"/>
// <xs:complexType name="DS_InitiativeTypeCode_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:DS_InitiativeTypeCode"/>
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
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Identification {

  [Serializable]
  //[XmlType("DS_InitiativeTypeCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DS_InitiativeTypeCode_PropertyType")]
  public class DS_InitiativeTypeCode_CodeList : CodeListValue_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DS_InitiativeTypeCode_CodeList"/>.
    /// </summary>
    public DS_InitiativeTypeCode_CodeList() {
      //_ds_InitiativeTypeCode = default; //  new CodeListValue_Type(); // WARNING: Set to the first member of the codelist.
    }

    #endregion

  }

}
