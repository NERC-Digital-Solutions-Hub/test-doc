
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
// <xs:complexType name="AbstractDQ_ThematicAccuracy_Type" abstract="true">
//   <xs:complexContent>
//     <xs:extension base="gmd:AbstractDQ_Element_Type"/>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="AbstractDQ_ThematicAccuracy" type="gmd:AbstractDQ_ThematicAccuracy_Type" abstract="true" substitutionGroup="gmd:AbstractDQ_Element"/>
// <xs:complexType name="DQ_ThematicAccuracy_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:AbstractDQ_ThematicAccuracy"/>
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

  #region XmlIncludes
  //[XmlInclude(typeof(DQ_ThematicClassificationCorrectness_Type))]
  //[XmlInclude(typeof(DQ_NonQuantitativeAttributeAccuracy_Type))]
  //[XmlInclude(typeof(DQ_QuantitativeAttributeAccuracy_Type))]
  #endregion

  [Serializable]
  //[XmlType("AbstractDQ_ThematicAccuracy", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("AbstractDQ_ThematicAccuracy", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("AbstractDQ_ThematicAccuracy")]
  public abstract class AbstractDQ_ThematicAccuracy_Type : AbstractDQ_Element_Type {

  }

}
