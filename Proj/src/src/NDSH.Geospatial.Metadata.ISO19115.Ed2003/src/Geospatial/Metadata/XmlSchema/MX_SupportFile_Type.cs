
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 06/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmx/gmxUsage.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MX_SupportFile_Type">
//   <xs:complexContent>
//     <xs:extension base="gmx:AbstractMX_File_Type"/>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MX_SupportFile" type="gmx:MX_SupportFile_Type" substitutionGroup="gmx:AbstractMX_File"/>
// <xs:complexType name="MX_SupportFile_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:MX_SupportFile"/>
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

namespace NDSH.Geospatial.Metadata.XmlSchema {

  [Serializable]
  //[XmlType("MX_SupportFile", Namespace = "http://www.isotc211.org/2005/gmx")]
  //[XmlRoot("MX_SupportFile", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("X_SupportFile")]
  public class MX_SupportFile_Type : AbstractMX_File_Type {

  }

}
