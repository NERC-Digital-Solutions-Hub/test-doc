
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
// <xs:complexType name="DS_Platform_Type">
//   <xs:complexContent>
//     <xs:extension base="gmd:DS_Series_Type"/>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="DS_Platform" type="gmd:DS_Platform_Type" substitutionGroup="gmd:DS_Series"/>
// <xs:complexType name="DS_Platform_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:DS_Platform"/>
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
  /// Represents a geospatial platform used as a basis for dataset series within metadata applications.
  /// This class extends <see cref="DS_Series_Type"/>, allowing it to be part of dataset collections.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>DS_Platform_Type</c> ( /2005/gmd/metadataApplication.xsd ).
  /// </remarks>
  [IsoType("DS_Platform_Type", IsoType = IsoTypes.ComplexType)]
  //[XmlType("DS_Platform", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("DS_Platform", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("DS_Platform")]
  public class DS_Platform_Type : DS_Series_Type {

  }

}
