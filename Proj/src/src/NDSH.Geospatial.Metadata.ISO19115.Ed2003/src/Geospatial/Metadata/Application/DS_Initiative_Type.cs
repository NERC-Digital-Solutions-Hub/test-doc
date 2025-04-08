
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 29/12/2022, @gisvlasta
// History           : 16/03/2025, @gisvlasta, Added IsoTypeAttribute, updated documentation, and header.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/metadataApplication.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="DS_Initiative_Type">
//   <xs:complexContent>
//     <xs:extension base="gmd:AbstractDS_Aggregate_Type"/>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="DS_Initiative" type="gmd:DS_Initiative_Type" substitutionGroup="gmd:AbstractDS_Aggregate"/>
// <xs:complexType name="DS_Initiative_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:DS_Initiative"/>
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

namespace NDSH.Geospatial.Metadata.Application {

  /// <summary>
  /// Represents an initiative within a dataset aggregate in geospatial metadata.
  /// This class inherits from <see cref="AbstractDS_Aggregate_Type"/> and 
  /// provides a <b>specialized dataset aggregate</b> under the ISO 19115 metadata standard.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>DS_Initiative_Type</c> ( /2005/gmd/metadataApplication.xsd ).
  /// </remarks>
  [IsoType("DS_Initiative_Type", IsoType = IsoTypes.ComplexType)]
  //[XmlType("DS_Initiative", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("DS_Initiative", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("DS_Initiative")]
  public class DS_Initiative_Type : AbstractDS_Aggregate_Type {

  }

}
