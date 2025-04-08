
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 14/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/srv/serviceMetadata.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:element name="SV_CouplingType" type="gco:CodeListValue_Type" substitutionGroup="gco:CharacterString"/>
// <xs:complexType name="SV_CouplingType_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="srv:SV_CouplingType"/>
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

namespace NDSH.Geospatial.Metadata.Service.Metadata {

  [Serializable]
  //[XmlType("SV_CouplingType_PropertyType", Namespace = "http://www.isotc211.org/2005/srv")]
  [JsonObject("SV_CouplingType_PropertyType")]
  public class SV_CouplingType_CodeList : CodeListValue_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_CouplingType_CodeList"/>.
    /// </summary>
    public SV_CouplingType_CodeList() {
      //_sv_CouplingType = new CodeListValue_Type(); // WARNING: Set to the first member of the codelist.
    }

    #endregion

  }

}
