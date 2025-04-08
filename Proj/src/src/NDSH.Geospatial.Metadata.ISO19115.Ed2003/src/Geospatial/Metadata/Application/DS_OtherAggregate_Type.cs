
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 29/12/2022, @gisvlasta
// History           : 16/03/2025, @gisvlasta - Added IsoTypeAttribute and updated documentation.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/metadataApplication.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="DS_OtherAggregate_Type">
//   <xs:complexContent>
//     <xs:extension base="gmd:AbstractDS_Aggregate_Type"/>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="DS_OtherAggregate" type="gmd:DS_OtherAggregate_Type" substitutionGroup="gmd:AbstractDS_Aggregate"/>
// <xs:complexType name="DS_OtherAggregate_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:DS_OtherAggregate"/>
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
  /// Represents a generalized dataset aggregate in geospatial metadata.
  /// This class is used for aggregates of datasets that do not fall into predefined categories.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>DS_OtherAggregate_Type</c> ( /2005/gmd/metadataApplication.xsd ).  
  /// </remarks>
  [IsoType("DS_OtherAggregate_Type", IsoType = IsoTypes.ComplexType)]
  //[XmlInclude(typeof(DS_StereoMate_Type))]
  //[XmlType("DS_OtherAggregate", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("DS_OtherAggregate", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("DS_OtherAggregate")]
  public class DS_OtherAggregate_Type : AbstractDS_Aggregate_Type {

  }

}
