
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 23/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/dataQuality.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="DQ_AbsoluteExternalPositionalAccuracy_Type">
//   <xs:complexContent>
//     <xs:extension base="gmd:AbstractDQ_PositionalAccuracy_Type"/>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="DQ_AbsoluteExternalPositionalAccuracy" type="gmd:DQ_AbsoluteExternalPositionalAccuracy_Type" substitutionGroup="gmd:AbstractDQ_PositionalAccuracy"/>
// <xs:complexType name="DQ_AbsoluteExternalPositionalAccuracy_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:DQ_AbsoluteExternalPositionalAccuracy"/>
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

namespace NDSH.Geospatial.Metadata.DataQuality.PositionalAccuracy {

  [Serializable]
  //[XmlType("DQ_AbsoluteExternalPositionalAccuracy", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("DQ_AbsoluteExternalPositionalAccuracy", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("DQ_AbsoluteExternalPositionalAccuracy")]
  public class DQ_AbsoluteExternalPositionalAccuracy_Type : AbstractDQ_PositionalAccuracy_Type {

  }

}
