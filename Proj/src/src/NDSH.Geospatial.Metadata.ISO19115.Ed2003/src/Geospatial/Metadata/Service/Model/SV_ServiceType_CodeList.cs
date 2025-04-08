
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 11/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/srv/serviceModel.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:element name="SV_ServiceType" type="gco:CodeListValue_Type" substitutionGroup="gco:CharacterString"/>
// <xs:complexType name="SV_ServiceType_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="srv:SV_ServiceType"/>
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

namespace NDSH.Geospatial.Metadata.Service.Model {

  [Serializable]
  //[XmlType("SV_ServiceType_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("SV_ServiceType_PropertyType")]
  public class SV_ServiceType_CodeList : CodeListValue_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_ServiceType_CodeList"/>.
    /// </summary>
    public SV_ServiceType_CodeList() {
      //_sv_ServiceType = new CodeListValue_Type(); // WARNING: Set to the first member of the codelist.
    }

    #endregion

  }

}
