
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : date, @gisvlasta
// History           : 
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/coverage.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <simpleType name="IncrementOrder">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <restriction base="string">
//     <enumeration value="+x+y"/>
//     <enumeration value="+y+x"/>
//     <enumeration value="+x-y"/>
//     <enumeration value="-x-y"/>
//   </restriction>
// </simpleType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Coverage {

  [IsoType("IncrementOrder", IsoType = IsoTypes.SimpleType)]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  public enum IncrementOrder {

    [XmlEnumAttribute("+x+y")]
    [EnumMember(Value = "+x+y")]
    xy,

    [XmlEnumAttribute("+y+x")]
    [EnumMember(Value = "+y+x")]
    yx,

    [XmlEnumAttribute("+x-y")]
    [EnumMember(Value = "+x-y")]
    xy1,

    [XmlEnumAttribute("-x-y")]
    [EnumMember(Value = "-x-y")]
    xy2,

  }

}
