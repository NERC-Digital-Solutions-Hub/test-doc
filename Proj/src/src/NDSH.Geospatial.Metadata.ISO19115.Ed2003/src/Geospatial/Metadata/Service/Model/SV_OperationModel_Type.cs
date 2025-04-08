
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
// XSD               : /2005/src/serviceModel.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:simpleType name="SV_OperationModel_Type">
//   <xs:restriction base="xs:string">
//     <xs:enumeration value="object"/>
//     <xs:enumeration value="message"/>
//   </xs:restriction>
// </xs:simpleType>
// <xs:element name="SV_OperationModel" type="srv:SV_OperationModel_Type" substitutionGroup="gco:CharacterString"/>
// <xs:complexType name="SV_OperationModel_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="srv:SV_OperationModel"/>
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
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Service.Model {

  [Serializable]
  //[XmlType("SV_OperationModel", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("SV_OperationModel", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)] // TODO: Should this XmlRoot be here???
  public enum SV_OperationModel_Type {

    //[XmlEnum(Name = "object")]
    [EnumMember(Value = "object")]
    @Object = 1,

    //[XmlEnum(Name = "message")]
    [EnumMember(Value = "message")]
    Message = 2,

  }

}
