
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 09/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/dataQuality.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="DQ_CompletenessOmission_Type">
//   <xs:complexContent>
//     <xs:extension base="gmd:AbstractDQ_Completeness_Type"/>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="DQ_CompletenessOmission" type="gmd:DQ_CompletenessOmission_Type" substitutionGroup="gmd:AbstractDQ_Completeness"/>
// <xs:complexType name="DQ_CompletenessOmission_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:DQ_CompletenessOmission"/>
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

namespace NDSH.Geospatial.Metadata.DataQuality.Completeness {

  [Serializable]
  //[XmlType("DQ_CompletenessOmission", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("DQ_CompletenessOmission", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("DQ_CompletenessOmission")]
  public class DQ_CompletenessOmission_Type : AbstractDQ_Completeness_Type {

  }

}
