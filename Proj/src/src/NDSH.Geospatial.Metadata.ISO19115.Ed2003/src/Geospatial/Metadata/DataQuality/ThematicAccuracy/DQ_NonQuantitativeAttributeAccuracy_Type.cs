
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
// <xs:complexType name="DQ_NonQuantitativeAttributeAccuracy_Type">
//   <xs:complexContent>
//     <xs:extension base="gmd:AbstractDQ_ThematicAccuracy_Type"/>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="DQ_NonQuantitativeAttributeAccuracy" type="gmd:DQ_NonQuantitativeAttributeAccuracy_Type" substitutionGroup="gmd:AbstractDQ_ThematicAccuracy"/>
// <xs:complexType name="DQ_NonQuantitativeAttributeAccuracy_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:DQ_NonQuantitativeAttributeAccuracy"/>
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

namespace NDSH.Geospatial.Metadata.DataQuality.ThematicAccuracy {

  [Serializable]
  //[XmlType("DQ_NonQuantitativeAttributeAccuracy", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("DQ_NonQuantitativeAttributeAccuracy", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("DQ_NonQuantitativeAttributeAccuracy")]
  public class DQ_NonQuantitativeAttributeAccuracy_Type : AbstractDQ_ThematicAccuracy_Type {

  }

}
