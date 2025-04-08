
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

namespace NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Derived.Measure {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot(Namespace = "", IsNullable = false)]
  public enum MeasureTypeValue {

    // TODO: Make sure what are the actual enum values (check spec)

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "area")]
    [EnumMember(Value = "area")]
    Area,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "length")]
    [EnumMember(Value = "length")]
    Length,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "angle")]
    [EnumMember(Value = "angle")]
    Angle,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "time")]
    [EnumMember(Value = "time")]
    Time,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "velocity")]
    [EnumMember(Value = "velocity")]
    Velocity,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "volume")]
    [EnumMember(Value = "volume")]
    Volume,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "scale")]
    [EnumMember(Value = "scale")]
    Scale,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "weight")]
    [EnumMember(Value = "weight")]
    Weight,

  }

}
