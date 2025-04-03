
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 29/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/metadataExtension.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:simpleType name="MD_ObligationCode_Type">
//   <xs:restriction base="xs:string">
//     <xs:enumeration value="mandatory"/>
//     <xs:enumeration value="optional"/>
//     <xs:enumeration value="conditional"/>
//   </xs:restriction>
// </xs:simpleType>
// <xs:element name="MD_ObligationCode" type="gmd:MD_ObligationCode_Type" substitutionGroup="gco:CharacterString"/>
// <xs:complexType name="MD_ObligationCode_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_ObligationCode"/>
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

namespace NDSH.Geospatial.Metadata.Extension {

  /// <summary>
  /// Obligation of the element or entity.
  /// </summary>
  [Serializable]
  //[XmlType("MD_ObligationCode", Namespace = "http://www.isotc211.org/2005/gmd")] // TODO: Should it be AnonymousType???
  //[XmlRoot("MD_ObligationCode", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)] // TODO: Should this XmlRoot be here???
  public enum MD_ObligationCode_Type {

    /// <summary>
    /// Element is always required.
    /// </summary>
    //[XmlEnum(Name = "mandatory")]
    [EnumMember(Value = "mandatory")]
    Mandatory = 1,

    /// <summary>
    /// Element is not required.
    /// </summary>
    //[XmlEnum(Name = "optional")]
    [EnumMember(Value = "optional")]
    Optional = 2,

    /// <summary>
    /// Element is required when a specific condition is met.
    /// </summary>
    //[XmlEnum(Name = "conditional")]
    [EnumMember(Value = "conditional")]
    Conditional = 3,

  }

}
