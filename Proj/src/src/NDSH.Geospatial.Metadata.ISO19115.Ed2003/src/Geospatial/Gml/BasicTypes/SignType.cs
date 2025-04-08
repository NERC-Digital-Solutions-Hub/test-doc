
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 11/03/2025, @gisvlasta
// History           : 16/03/2025, @gisvlasta - Added IsoTypeAttribute.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <simpleType name="SignType">
//   <annotation>
//     <documentation>gml:SignType is a convenience type with values “+” (plus) and “-“ (minus).</documentation>
//   </annotation>
//   <restriction base="string">
//     <enumeration value="-"/>
//     <enumeration value="+"/>
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

namespace NDSH.Geospatial.Gml.BasicTypes {

  /// <summary>
  /// SignType is a convenience type with values <c>+ (plus)</c> and <c>- (minus)</c>.
  /// </summary>
  [IsoType("SignType", IsoType = IsoTypes.SimpleType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  public enum SignType {

    /// <summary>
    /// Indicates a negative sign (-).
    /// </summary>
    [XmlEnum("-")]
    [EnumMember(Value = "-")]
    Minus,

    /// <summary>
    /// Indicates a positive sign (+).
    /// </summary>
    [XmlEnum("+")]
    [EnumMember(Value = "+")]
    Plus,

  }

}
