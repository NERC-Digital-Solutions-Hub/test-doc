
#region Header
// Title Name        : @@@@
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : The name of the dimension.
// Created by        : 19/09/2022, 19:42, @gisvlasta.
// Updated by        : 16/12/2022, 15:15, @EttoreM - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
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

namespace NDSH.Geospatial.Metadata.V2005.SpatialRepresentation {

  /// <summary>
  /// The name of the dimension.
  /// </summary>
  [Serializable]
  public enum MD_DimensionNameTypeCodeValue {

    /// <summary>
    /// Ordinate (y) axis.
    /// </summary>
    [XmlEnum(Name = "row")]
    [EnumMember(Value = "row")]
    Row = 1,

    /// <summary>
    /// Abscissa (x) axis.
    /// </summary>
    [XmlEnum(Name = "column")]
    [EnumMember(Value = "column")]
    Column = 2,

    /// <summary>
    /// Vertical (z) axis.
    /// </summary>
    [XmlEnum(Name = "vertical")]
    [EnumMember(Value = "vertical")]
    Vertical = 3,

    /// <summary>
    /// Along the direction of motion of the scan point.
    /// </summary>
    [XmlEnum(Name = "track")]
    [EnumMember(Value = "track")]
    Track = 4,

    /// <summary>
    /// Perpendicular to the direction of motion of the scan point.
    /// </summary>
    [XmlEnum(Name = "crossTrack")]
    [EnumMember(Value = "crossTrack")]
    CrossTrack = 5,

    /// <summary>
    /// Scan line of a sensor.
    /// </summary>
    [XmlEnum(Name = "line")]
    [EnumMember(Value = "line")]
    Line = 6,

    /// <summary>
    /// Element along a scan line.
    /// </summary>
    [XmlEnum(Name = "sample")]
    [EnumMember(Value = "sample")]
    Sample = 7,

    /// <summary>
    /// Duration.
    /// </summary>
    [XmlEnum(Name = "time")]
    [EnumMember(Value = "time")]
    Time = 8,

  }

}
