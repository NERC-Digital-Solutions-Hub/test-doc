
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
// <xs:complexType name="DS_StereoMate_Type">
//   <xs:complexContent>
//     <xs:extension base="gmd:DS_OtherAggregate_Type"/>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="DS_StereoMate" type="gmd:DS_StereoMate_Type" substitutionGroup="gmd:DS_OtherAggregate"/>
// <xs:complexType name="DS_StereoMate_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:DS_StereoMate"/>
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
  /// Represents a stereo mate dataset, which is a dataset that is
  /// related to another dataset through stereo imaging principles.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>DS_StereoMate_Type</c> ( /2005/gmd/metadataApplication.xsd ).
  /// </remarks>
  [IsoType("DS_StereoMate_Type", IsoType = IsoTypes.ComplexType)]
  //[XmlType("DS_StereoMate", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("DS_StereoMate", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("DS_StereoMate")]
  public class DS_StereoMate_Type : DS_OtherAggregate_Type {

  }

}
