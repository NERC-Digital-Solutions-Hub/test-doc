
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 31/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/measures.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="DegreesType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <simpleContent>
//     <extension base="gml:DegreeValueType">
//       <attribute name="direction">
//         <simpleType>
//           <restriction base="string">
//             <enumeration value="N"/>
//             <enumeration value="E"/>
//             <enumeration value="S"/>
//             <enumeration value="W"/>
//             <enumeration value="+"/>
//             <enumeration value="-"/>
//           </restriction>
//         </simpleType>
//       </attribute>
//     </extension>
//   </simpleContent>
// </complexType>
// <simpleType name="DegreeValueType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <restriction base="nonNegativeInteger">
//     <maxInclusive value="359"/>
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

namespace NDSH.Geospatial.Gml.Measures {

  /// <summary>
  /// Enumerates the directional or sign indicators applicable to a <see cref="DegreesType"/> measurement. 
  /// This reflects the cardinal (N, E, S, W) or sign (+, -)
  /// choices specified in the deprecated GML <c>DegreesType</c>.
  /// </summary>
  /// <remarks>
  /// In the context of the GML schema, these values indicate the direction for a degrees measurement
  /// (e.g., latitude, longitude, bearing). Although marked as deprecated in the schema,
  /// they remain supported for backward compatibility with older GML datasets.
  /// </remarks>
  //[Serializable]
  //[XmlType(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
  public enum DegreesTypeDirection {

    /// <summary>
    /// Indicates a northern direction (N).
    /// </summary>
    //[XmlEnum(Name = "N")]
    //[EnumMember(Value = "N")]
    North,

    /// <summary>
    /// Indicates an eastern direction (E).
    /// </summary>
    //[XmlEnum(Name = "E")]
    //[EnumMember(Value = "E")]
    East,

    /// <summary>
    /// Indicates a southern direction (S).
    /// </summary>
    //[XmlEnum(Name = "S")]
    //[EnumMember(Value = "S")]
    South,

    /// <summary>
    /// Indicates a western direction (W).
    /// </summary>
    //[XmlEnum(Name = "W")]
    //[EnumMember(Value = "W")]
    West,

    /// <summary>
    /// Indicates a positive sign (+).
    /// </summary>
    //[XmlEnum("+")]
    //[EnumMember(Value = "+")]
    Plus,

    /// <summary>
    /// Indicates a negative sign (-).
    /// </summary>
    //[XmlEnum("-")]
    //[EnumMember(Value = "-")]
    Minus,

  }

}
