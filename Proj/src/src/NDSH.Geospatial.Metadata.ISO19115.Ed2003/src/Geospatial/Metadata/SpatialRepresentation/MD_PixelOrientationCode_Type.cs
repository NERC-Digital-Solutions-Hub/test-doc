
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 04:11, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/spatialRepresentation.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:simpleType name="MD_PixelOrientationCode_Type">
//   <xs:restriction base="xs:string">
//     <xs:enumeration value="center"/>
//     <xs:enumeration value="lowerLeft"/>
//     <xs:enumeration value="lowerRight"/>
//     <xs:enumeration value="upperRight"/>
//     <xs:enumeration value="upperLeft"/>
//   </xs:restriction>
// </xs:simpleType>
// <xs:element name="MD_PixelOrientationCode"
//             type="gmd:MD_PixelOrientationCode_Type" substitutionGroup="gco:CharacterString"/>
// <xs:complexType name="MD_PixelOrientationCode_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_PixelOrientationCode"/>
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

namespace NDSH.Geospatial.Metadata.SpatialRepresentation {

  /// <summary>
  /// Point in a pixel corresponding to the Earth location of the pixel.
  /// </summary>
  [Serializable]
  [XmlType("MD_PixelOrientationCode", Namespace = "http://www.isotc211.org/2005/gmd")] // TODO: Should it be AnonymousType???
  [XmlRoot("MD_PixelOrientationCode", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)] // TODO: XmlRoot here???
  public enum MD_PixelOrientationCode_Type {

    /// <summary>
    /// Point halfway between the lower left and the upper right of the pixel.
    /// </summary>
    [XmlEnum(Name = "center")]
    [EnumMember(Value = "center")]
    Center = 1,

    /// <summary>
    /// The corner in the pixel closest to the origin of the SRS;
    /// if two are at the same distance from the origin, the one with the smallest x-value.
    /// </summary>
    [XmlEnum(Name = "lowerLeft")]
    [EnumMember(Value = "lowerLeft")]
    LowerLeft = 2,

    /// <summary>
    /// Next corner counterclockwise from the lower left.
    /// </summary>
    [XmlEnum(Name = "lowerRight")]
    [EnumMember(Value = "lowerRight")]
    LowerRight = 3,

    /// <summary>
    /// Next corner counterclockwise from the lower right.
    /// </summary>
    [XmlEnum(Name = "upperRight")]
    [EnumMember(Value = "upperRight")]
    UpperRight = 4,

    /// <summary>
    /// Next corner counterclockwise from the upper right.
    /// </summary>
    [XmlEnum(Name = "upperLeft")]
    [EnumMember(Value = "upperLeft")]
    UpperLeft = 5,

  }

}
