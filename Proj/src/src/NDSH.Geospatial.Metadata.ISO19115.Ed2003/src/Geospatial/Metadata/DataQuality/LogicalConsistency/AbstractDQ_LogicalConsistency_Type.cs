
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 22/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/dataQuality.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="AbstractDQ_LogicalConsistency_Type" abstract="true">
//   <xs:complexContent>
//     <xs:extension base="gmd:AbstractDQ_Element_Type"/>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="AbstractDQ_LogicalConsistency" type="gmd:AbstractDQ_LogicalConsistency_Type" abstract="true" substitutionGroup="gmd:AbstractDQ_Element"/>
// <xs:complexType name="DQ_LogicalConsistency_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:AbstractDQ_LogicalConsistency"/>
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

  #region XmlIncludes
  //[XmlInclude(typeof(DQ_ConceptualConsistency_Type))]
  //[XmlInclude(typeof(DQ_DomainConsistency_Type))]
  //[XmlInclude(typeof(DQ_FormatConsistency_Type))]
  //[XmlInclude(typeof(DQ_TopologicalConsistency_Type))]
  #endregion

  [Serializable]
  //[XmlType("AbstractDQ_LogicalConsistency", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("AbstractDQ_LogicalConsistency", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("AbstractDQ_LogicalConsistency")]
  public abstract class AbstractDQ_LogicalConsistency_Type : AbstractDQ_Element_Type {

  }

}
