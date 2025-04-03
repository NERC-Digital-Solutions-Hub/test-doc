
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 31/12/2022, @gisvlasta
// History           : 16/03/2025, @gisvlasta - Added IsoTypeAttribute.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <simpleType name="NilReasonEnumeration">
//   <union>
//     <simpleType>
//       <restriction base="string">
//         <enumeration value="inapplicable"/>
//         <enumeration value="missing"/>
//         <enumeration value="template"/>
//         <enumeration value="unknown"/>
//         <enumeration value="withheld"/>
//       </restriction>
//     </simpleType>
//     <simpleType>
//       <restriction base="string">
//       <pattern value="other:\w{2,}"/>
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

namespace NDSH.Geospatial.Gml.BasicTypes {

  /// <summary>
  /// Enumerates standardized reasons for a property or attribute to have a <see langword="null"/>
  /// (missing) value, following the GML (ISO 19136) nil-reason pattern.
  /// This provides clarity on *why* a value is unavailable or not applicable at a given time.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>TimeUnitType</c> ( /2005/gml/basicTypes.xsd )
  /// </remarks>
  [IsoType("NilReasonEnumeration", IsoType = IsoTypes.SimpleType)]
  public enum NilReasonEnumeration {

    /// <summary>
    /// There is no value.
    /// </summary>
    [XmlEnum(Name = "inapplicable")]
    [EnumMember(Value = "inapplicable")]
    Inapplicable,

    /// <summary>
    /// The correct value is not readily available to the sender of this data.
    /// Furthermore, a correct value may not exist.
    /// </summary>
		[XmlEnum(Name = "missing")]
    [EnumMember(Value = "missing")]
    Missing,

    /// <summary>
    /// The value will be available later.
    /// </summary>
		[XmlEnum(Name = "template")]
    [EnumMember(Value = "template")]
    Template,

    /// <summary>
    /// The correct value is not known to, and not computable by, the sender of this data.
    /// However, a correct value probably exists.
    /// </summary>
		[XmlEnum(Name = "unknown")]
    [EnumMember(Value = "unknown")]
    Unknown,

    /// <summary>
    /// The value is not divulged.
    /// </summary>
		[XmlEnum(Name = "withheld")]
    [EnumMember(Value = "withheld")]
    Withheld,

    /// <summary>
    /// Other brief explanation, where text is a string of two or more characters with no included spaces.
    /// </summary>
    [XmlEnum(Name = "other")]
    [EnumMember(Value = "other")]
    Other,

  }

}
