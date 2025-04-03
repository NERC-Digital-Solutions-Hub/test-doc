
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
// <xs:complexType name="DQ_TopologicalConsistency_Type">
//   <xs:complexContent>
//     <xs:extension base="gmd:AbstractDQ_LogicalConsistency_Type"/>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="DQ_TopologicalConsistency" type="gmd:DQ_TopologicalConsistency_Type" substitutionGroup="gmd:AbstractDQ_LogicalConsistency"/>
// <xs:complexType name="DQ_TopologicalConsistency_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:DQ_TopologicalConsistency"/>
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

namespace NDSH.Geospatial.Metadata.DataQuality.LogicalConsistency {

  [Serializable]
  //[XmlType("DQ_TopologicalConsistency", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("DQ_TopologicalConsistency", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("DQ_TopologicalConsistency")]
  public class DQ_TopologicalConsistency_Type : AbstractDQ_LogicalConsistency_Type {

  }

}
