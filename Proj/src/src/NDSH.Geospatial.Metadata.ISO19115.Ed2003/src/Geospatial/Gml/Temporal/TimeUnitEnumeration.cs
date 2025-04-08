
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 02/04/2025, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/temporal.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <simpleType name="TimeUnitType">
//   <union>
//     <simpleType>
//       <restriction base="string">
//         <enumeration value="year"/>
//         <enumeration value="month"/>
//         <enumeration value="day"/>
//         <enumeration value="hour"/>
//         <enumeration value="minute"/>
//         <enumeration value="second"/>
//       </restriction>
//     </simpleType>
//     <simpleType>
//       <restriction base="string">
//         <pattern value="other:\w{2,}"/>
//       </restriction>
//     </simpleType>
//   </union>
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

namespace NDSH.Geospatial.Gml.Temporal {

  /// <summary>
  /// Enumerates the standard temporal units supported by GML for describing time intervals or durations.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     This enumeration represents valid values for GML temporal units used in elements such as durations
  ///     or temporal resolutions. These units align with the ISO 19108 model and can be extended using a pattern
  ///     like <c>other:*</c> for non-standard units (handled separately, not in this enumeration).
  ///   </para>
  ///   <para>
  ///     Maps to: <c>TimeUnitType</c> ( /2005/gml/temporal.xsd )
  ///   </para>
  /// </remarks>
  [IsoType("TimeUnitType", IsoType = IsoTypes.SimpleType)]
  public enum TimeUnitEnumeration {

    /// <summary>
    /// The time unit is the year.
    /// </summary>
    [XmlEnum(Name = "year")]
    [EnumMember(Value = "year")]
    Year,

    /// <summary>
    /// The time unit is the month.
    /// </summary>
    [XmlEnum(Name = "month")]
    [EnumMember(Value = "month")]
    Month,

    /// <summary>
    /// The time unit is the day.
    /// </summary>
    [XmlEnum(Name = "day")]
    [EnumMember(Value = "day")]
    Day,

    /// <summary>
    /// The time unit is the hour.
    /// </summary>
    [XmlEnum(Name = "hour")]
    [EnumMember(Value = "hour")]
    Hour,

    /// <summary>
    /// The time unit is the minute.
    /// </summary>
    [XmlEnum(Name = "minute")]
    [EnumMember(Value = "minute")]
    Minute,

    /// <summary>
    /// The time unit is the second.
    /// </summary>
    [XmlEnum(Name = "second")]
    [EnumMember(Value = "second")]
    Second,

  }

}
