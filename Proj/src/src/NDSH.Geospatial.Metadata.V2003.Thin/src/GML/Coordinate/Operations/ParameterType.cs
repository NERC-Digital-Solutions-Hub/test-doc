
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 01/02/2023, 20:54, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Operations
{

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml", IncludeInSchema = false)]
  public enum ParameterType
  {

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "booleanValue")]
    [EnumMember(Value = "booleanValue")]
    BooleanValue,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "dmsAngleValue")]
    [EnumMember(Value = "dmsAngleValue")]
    DmsAngleValue,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "integerValue")]
    [EnumMember(Value = "integerValue")]
    IntegerValue,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "integerValueList")]
    [EnumMember(Value = "creaintegerValueListtion")]
    IntegerValueList,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "stringValue")]
    [EnumMember(Value = "stringValue")]
    StringValue,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "value")]
    [EnumMember(Value = "value")]
    Value,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "valueFile")]
    [EnumMember(Value = "valueFile")]
    ValueFile,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "valueList")]
    [EnumMember(Value = "valueList")]
    ValueList,

  }

}
