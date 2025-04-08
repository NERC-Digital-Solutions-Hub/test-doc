
#region Header
// --------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 31/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gml/basicTypes.xsd
// --------------------------------------------------------------------------------
// <simpleType name="nullEnumeration">
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
//         <pattern value="other:\w{2,}"/>
//       </restriction>
//     </simpleType>
//   </union>
// </simpleType>
// --------------------------------------------------------------------------------
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

namespace NDSH.Geospatial.Metadata.V2003.Gml.BasicTypes {

  /// <summary>
  /// The enumeration provides some common reasons for a null value.
  /// </summary>
  [Serializable]
  public enum NullEnumeration {

    /// <summary>
    /// The object does not have a value.
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
