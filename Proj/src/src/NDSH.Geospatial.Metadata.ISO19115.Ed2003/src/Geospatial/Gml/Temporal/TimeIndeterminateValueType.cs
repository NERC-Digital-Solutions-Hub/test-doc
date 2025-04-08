
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 05/02/2023, @gisvlasta
// History           : 02/04/2025, @gisvlasta - Updated code and documentation.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/temporal.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <simpleType name="TimeIndeterminateValueType">
//   <annotation>
//     <documentation>
//       These values are interpreted as follows:
//         - “unknown” indicates that no specific value for temporal position is provided.
//         - “now” indicates that the specified value shall be replaced with the current temporal position
//             whenever the value is accessed.
//         - “before” indicates that the actual temporal position is unknown,
//             but it is known to be before the specified value.
//         - “after” indicates that the actual temporal position is unknown,
//             but it is known to be after the specified value.
//       A value for indeterminatePosition may
//         - be used either alone, or
//         - qualify a specific value for temporal position.
//     </documentation>
//   </annotation>
//   <restriction base="string">
//     <enumeration value="after"/>
//     <enumeration value="before"/>
//     <enumeration value="now"/>
//     <enumeration value="unknown"/>
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

#endregion

namespace NDSH.Geospatial.Gml.Temporal {

  /// <summary>
  /// The time indeterminate values enumeration.<br></br>
  /// A value for indeterminatePosition may
  /// <list type="bullet">
  /// <item>be used either alone, or</item>
  /// <item>qualify a specific value for temporal position.</item>
  /// </list>
  /// </summary>
  [IsoType("TimeIndeterminateValueType", IsoType = IsoTypes.SimpleType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  public enum TimeIndeterminateValueType {

    /// <summary>
    /// Indicates that the actual temporal position is unknown,
    /// but it is known to be after the specified value.
    /// </summary>
    //[XmlEnum(Name = "after")]
    [EnumMember(Value = "after")]
    After,

    /// <summary>
    /// Indicates that the actual temporal position is unknown,
    /// but it is known to be before the specified value.
    /// </summary>
    //[XmlEnum(Name = "before")]
    [EnumMember(Value = "before")]
    Before,

    /// <summary>
    /// Indicates that the specified value shall be replaced with
    /// the current temporal position whenever the value is accessed.
    /// </summary>
    //[XmlEnum(Name = "now")]
    [EnumMember(Value = "now")]
    Now,

    /// <summary>
    /// Indicates that no specific value for temporal position is provided.
    /// </summary>
    //[XmlEnum(Name = "unknown")]
    [EnumMember(Value = "unknown")]
    Unknown,

  }

}
