
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Derived.UnitsOfMeasure {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot(Namespace = "", IsNullable = false)]
  public enum StandardUnitsValue {

    // TODO: Make sure what are the actual enum values (check spec)

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "meter")]
    [EnumMember(Value = "meter")]
    Meter,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "second")]
    [EnumMember(Value = "second")]
    Second,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "radian")]
    [EnumMember(Value = "radian")]
    Radian,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "squareMeter")]
    [EnumMember(Value = "squareMeter")]
    SquareMeter,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "cubicMeter")]
    [EnumMember(Value = "cubicMeter")]
    CubicMeter,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "meters_per_second")]
    [EnumMember(Value = "meters_per_second")]
    MetersPerSecond,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "meter_per_meter")]
    [EnumMember(Value = "meter_per_meter")]
    MeterPerMeter,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "kilogram")]
    [EnumMember(Value = "kilogram")]
    Kilogram,

  }

}
