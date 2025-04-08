
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 06/02/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/direction.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <simpleType name="CompassPointEnumeration">
//   <annotation>
//     <documentation>
//       These directions are necessarily approximate, giving direction with a precision of 22.5°.
//       It is thus generally unnecessary to specify the reference frame, though this may be
//       detailed in the definition of a GML application language.
//     </documentation>
//   </annotation>
//   <restriction base="string">
//     <enumeration value="N"/>
//     <enumeration value="NNE"/>
//     <enumeration value="NE"/>
//     <enumeration value="ENE"/>
//     <enumeration value="E"/>
//     <enumeration value="ESE"/>
//     <enumeration value="SE"/>
//     <enumeration value="SSE"/>
//     <enumeration value="S"/>
//     <enumeration value="SSW"/>
//     <enumeration value="SW"/>
//     <enumeration value="WSW"/>
//     <enumeration value="W"/>
//     <enumeration value="WNW"/>
//     <enumeration value="NW"/>
//     <enumeration value="NNW"/>
//   </restriction>
// </simpleType>
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

namespace NDSH.Geospatial.Gml.Direction {

  /// <summary>
  /// These directions are necessarily approximate, giving direction with a precision of 22.5 degrees.
  /// It is thus generally unnecessary to specify the reference frame, though this may
  /// be detailed in the definition of a GML application language.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  public enum CompassPointEnumeration {

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "N")]
    [EnumMember(Value = "N")]
    North,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "NNE")]
    [EnumMember(Value = "N")]
    NorthNorthEast,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "NE")]
    [EnumMember(Value = "NE")]
    NorthEast,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "ENE")]
    [EnumMember(Value = "ENE")]
    EastNorthEast,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "E")]
    [EnumMember(Value = "E")]
    East,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "ESE")]
    [EnumMember(Value = "ESE")]
    EastSouthEast,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "SE")]
    [EnumMember(Value = "SE")]
    SouthEast,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "SSE")]
    [EnumMember(Value = "SSE")]
    SouthSouthEast,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "S")]
    [EnumMember(Value = "S")]
    South,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "SSW")]
    [EnumMember(Value = "SSW")]
    SouthSouthWest,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "SW")]
    [EnumMember(Value = "SW")]
    SouthWest,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "WSW")]
    [EnumMember(Value = "WSW")]
    WestSouthWest,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "W")]
    [EnumMember(Value = "W")]
    West,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "WNW")]
    [EnumMember(Value = "WNW")]
    WestNorthWest,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "NW")]
    [EnumMember(Value = "NW")]
    NorthWest,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "NNW")]
    [EnumMember(Value = "NNW")]
    NorthNorthWest,

  }

}
