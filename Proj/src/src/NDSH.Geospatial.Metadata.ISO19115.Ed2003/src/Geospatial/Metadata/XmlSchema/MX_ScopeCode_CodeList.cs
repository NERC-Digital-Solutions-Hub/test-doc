
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
// XSD               : /2005/gmx/gmxUsage.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:element name="MX_ScopeCode" type="gco:CodeListValue_Type" substitutionGroup="gmd:MD_ScopeCode"/>
// <xs:complexType name="MX_ScopeCode_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:MX_ScopeCode"/>
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

namespace NDSH.Geospatial.Metadata.XmlSchema {

  [Serializable]
  //[XmlType("MX_ScopeCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("MX_ScopeCode_PropertyType")]
  public class MX_ScopeCode_CodeList : CodeListValue_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MX_ScopeCode_CodeList"/>.
    /// </summary>
    public MX_ScopeCode_CodeList() {
      //_mx_ScopeCode = default; //  new CodeListValue_Type(); // WARNING: Set to the first member of the codelist.
    }

    #endregion

  }

}
