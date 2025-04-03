
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
// <xs:complexType name="AbstractDQ_Completeness_Type" abstract="true">
//   <xs:complexContent>
//     <xs:extension base="gmd:AbstractDQ_Element_Type"/>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="AbstractDQ_Completeness" type="gmd:AbstractDQ_Completeness_Type" abstract="true" substitutionGroup="gmd:AbstractDQ_Element"/>
// <xs:complexType name="DQ_Completeness_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:AbstractDQ_Completeness"/>
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

#endregion

namespace NDSH.Geospatial.Metadata.DataQuality.Completeness {

  [Serializable]
  //[XmlInclude(typeof(DQ_CompletenessCommission_Type))]
  //[XmlInclude(typeof(DQ_CompletenessOmission_Type))]
  //[XmlType("AbstractDQ_Completeness", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("AbstractDQ_Completeness", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("AbstractDQ_Completeness")]
  public abstract class AbstractDQ_Completeness_Type : AbstractDQ_Element_Type {

  }

}
