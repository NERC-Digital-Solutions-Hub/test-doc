
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
// <xs:complexType name="DS_Sensor_Type">
//   <xs:complexContent>
//     <xs:extension base="gmd:DS_Series_Type"/>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="DS_Sensor" type="gmd:DS_Sensor_Type" substitutionGroup="gmd:DS_Series"/>
// <xs:complexType name="DS_Sensor_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:DS_Sensor"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported  Namespaces

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
  /// Represents a sensor-based dataset series in geospatial metadata.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>DS_Sensor_Type</c> ( /2005/gmd/metadataApplication.xsd ).
  /// </remarks>
  [IsoType("DS_Sensor_Type", IsoType = IsoTypes.ComplexType)]
  //[XmlType("DS_Sensor", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("DS_Sensor", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("DS_Sensor")]
  public class DS_Sensor_Type : DS_Series_Type {

  }

}
