
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
// <xs:complexType name="DS_Series_Type">
//   <xs:complexContent>
//     <xs:extension base="gmd:AbstractDS_Aggregate_Type"/>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="DS_Series" type="gmd:DS_Series_Type" substitutionGroup="gmd:AbstractDS_Aggregate"/>
// <xs:complexType name="DS_Series_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:DS_Series"/>
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
  /// Represents a series of datasets in geospatial metadata.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>DS_Series_Type</c> ( /2005/gmd/metadataApplication.xsd ).
  /// </remarks>
  [IsoType("DS_Series_Type", IsoType = IsoTypes.ComplexType)]
  //[XmlInclude(typeof(DS_ProductionSeries_Type))]
  //[XmlInclude(typeof(DS_Sensor_Type))]
  //[XmlInclude(typeof(DS_Platform_Type))]
  //[XmlType("DS_Series", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("DS_Series", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("DS_Series")]
  public class DS_Series_Type : AbstractDS_Aggregate_Type {

  }

}
