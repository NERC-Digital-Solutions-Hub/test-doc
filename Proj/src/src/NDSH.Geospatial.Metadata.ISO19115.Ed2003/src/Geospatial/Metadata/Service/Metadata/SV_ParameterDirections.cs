
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 15/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/src/serviceMetadata.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:simpleType name="SV_ParameterDirection_Type">
//   <xs:restriction base="xs:string">
//     <xs:enumeration value="in"/>
//     <xs:enumeration value="out"/>
//     <xs:enumeration value="in/out"/>
//   </xs:restriction>
// </xs:simpleType>
// <xs:element name="SV_ParameterDirection"
//             type="srv:SV_ParameterDirection_Type"
//             substitutionGroup="gco:CharacterString"/>
// <xs:complexType name="SV_ParameterDirection_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="srv:SV_ParameterDirection"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Service.Metadata {

  // TODO: This is the Enum with XSD name: SV_ParameterDirection_Type

  [Serializable]
  //[XmlType("SV_ParameterDirection", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("SV_ParameterDirection", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)] // TODO: Should this XmlRoot be here???
  public enum SV_ParameterDirections {

    //[XmlEnum(Name = "in")]
    [EnumMember(Value = "in")]
    In = 1,

    //[XmlEnum(Name = "out")]
    [EnumMember(Value = "out")]
    Out = 2,

    //[XmlEnum(Name = "in/out")]
    [EnumMember(Value = "in/out")]
    InOut = 3,

  }

}
