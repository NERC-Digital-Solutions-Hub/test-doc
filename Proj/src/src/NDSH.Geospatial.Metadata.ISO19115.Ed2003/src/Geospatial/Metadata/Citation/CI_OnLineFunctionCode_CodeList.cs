
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
// <xs:element name="CI_OnLineFunctionCode" type="gco:CodeListValue_Type" substitutionGroup="gco:CharacterString"/>
// <xs:complexType name="CI_OnLineFunctionCode_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:CI_OnLineFunctionCode"/>
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

namespace NDSH.Geospatial.Metadata.Citation {

  [Serializable]
  //[XmlType("CI_OnLineFunctionCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("CI_OnLineFunctionCode_PropertyType")]
  public class CI_OnLineFunctionCode_CodeList : CodeListValue_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_OnLineFunctionCode_CodeList"/>.
    /// </summary>
    public CI_OnLineFunctionCode_CodeList() {
      //_ci_OnLineFunctionCode = default; //  new CodeListValue_Type(); // WARNING: Set to the first member of the codelist.
    }

    #endregion

  }

}
