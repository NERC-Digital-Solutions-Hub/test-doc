
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 24/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/content.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="AbstractMD_ContentInformation_Type" abstract="true">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence/>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="AbstractMD_ContentInformation" type="gmd:AbstractMD_ContentInformation_Type" abstract="true"/>
// <xs:complexType name="MD_ContentInformation_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:AbstractMD_ContentInformation"/>
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

namespace NDSH.Geospatial.Metadata.Content {

  // TODO: IMPORTANT - Move the XmlInclude Types in their correct places.

  #region XmlIncludes
  //[XmlInclude(typeof(MI_ImageDescription_Type))]
  //[XmlInclude(typeof(MI_CoverageDescription_Type))]
  //[XmlInclude(typeof(MD_CoverageDescription_Type))]
  //[XmlInclude(typeof(MD_ImageDescription_Type))]
  //[XmlInclude(typeof(MD_FeatureCatalogueDescription_Type))]
  #endregion

  [Serializable]
  //[XmlType("AbstractMD_ContentInformation", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("AbstractMD_ContentInformation", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("AbstractMD_ContentInformation")]
  public abstract class AbstractMD_ContentInformation_Type : MetadataObject {

  }

}
