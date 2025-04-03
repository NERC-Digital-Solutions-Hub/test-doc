
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 01/02/2023, @gisvlasta
// History           : 
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : 
// ---------------------------------------------------------------------------------------------------------------------
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

namespace NDSH.Geospatial.Gml.Coordinate.Operations {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml", IncludeInSchema = false)]
  public enum ParameterType {

    [XmlEnum(Name = "booleanValue")]
    [EnumMember(Value = "booleanValue")]
    BooleanValue,

    [XmlEnum(Name = "dmsAngleValue")]
    [EnumMember(Value = "dmsAngleValue")]
    DmsAngleValue,

    [XmlEnum(Name = "integerValue")]
    [EnumMember(Value = "integerValue")]
    IntegerValue,

    [XmlEnum(Name = "integerValueList")]
    [EnumMember(Value = "creaintegerValueListtion")]
    IntegerValueList,

    [XmlEnum(Name = "stringValue")]
    [EnumMember(Value = "stringValue")]
    StringValue,

    [XmlEnum(Name = "value")]
    [EnumMember(Value = "value")]
    Value,

    [XmlEnum(Name = "valueFile")]
    [EnumMember(Value = "valueFile")]
    ValueFile,

    [XmlEnum(Name = "valueList")]
    [EnumMember(Value = "valueList")]
    ValueList,

  }

}
