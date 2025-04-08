
#region Header
// Title Name        : DS_InitiativeTypeCodeValue
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : The type of aggregation activity in which datasets are related.
// Created by        : 19/09/2022, 17:44, @gisvlasta
// Updated by        : 18/12/2022, 00:38, @gisvlasta - Cleaned Xml Serialization Attributes.
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

namespace NDSH.Geospatial.Metadata.V2005.Identification {

  /// <summary>
  /// The type of aggregation activity in which datasets are related.
  /// </summary>
  [Serializable]
  public enum DS_InitiativeTypeCodeValue {

    /// <summary>
    /// Series of organized planned actions.
    /// </summary>
    [XmlEnum(Name = "campaign")]
    [EnumMember(Value = "campaign")]
    Campaign = 1,

    /// <summary>
    /// Accumulation of datasets assembled for a specific purpose.
    /// </summary>
    [XmlEnum(Name = "collection")]
    [EnumMember(Value = "collection")]
    Collection = 2,

    /// <summary>
    /// Specific performance of a function or group of functions.
    /// </summary>
    [XmlEnum(Name = "exercise")]
    [EnumMember(Value = "exercise")]
    Exercise = 3,

    /// <summary>
    /// Process designed to find if something is effective or valid.
    /// </summary>
    [XmlEnum(Name = "experiment")]
    [EnumMember(Value = "experiment")]
    Experiment = 4,

    /// <summary>
    /// Search or systematic inquiry.
    /// </summary>
    [XmlEnum(Name = "investigation")]
    [EnumMember(Value = "investigation")]
    Investigation = 5,

    /// <summary>
    /// Mission 006 specific operation of a data collection system.
    /// </summary>
    [XmlEnum(Name = "mission")]
    [EnumMember(Value = "mission")]
    Mission = 6,

    /// <summary>
    /// Sensor 007 device or piece of equipment which detects or records.
    /// </summary>
    [XmlEnum(Name = "sensor")]
    [EnumMember(Value = "sensor")]
    Sensor = 7,

    /// <summary>
    /// Action that is part of a series of actions.
    /// </summary>
    [XmlEnum(Name = "operation")]
    [EnumMember(Value = "operation")]
    Operation = 8,

    /// <summary>
    /// Vehicle or other support base that holds a sensor.
    /// </summary>
    [XmlEnum(Name = "platform")]
    [EnumMember(Value = "platform")]
    Platform = 9,

    /// <summary>
    /// Method of doing something involving a number of steps.
    /// </summary>
    [XmlEnum(Name = "process")]
    [EnumMember(Value = "process")]
    Process = 10,

    /// <summary>
    /// Specific planned activity.
    /// </summary>
    [XmlEnum(Name = "program")]
    [EnumMember(Value = "program")]
    Program = 11,

    /// <summary>
    /// Organized undertaking, research, or development.
    /// </summary>
    [XmlEnum(Name = "project")]
    [EnumMember(Value = "project")]
    Project = 12,

    /// <summary>
    /// Examination or investigation.
    /// </summary>
    [XmlEnum(Name = "study")]
    [EnumMember(Value = "study")]
    Study = 13,

    /// <summary>
    /// Piece of work.
    /// </summary>
    [XmlEnum(Name = "task")]
    [EnumMember(Value = "task")]
    Task = 14,

    /// <summary>
    /// Process of testing to discover or demonstrate something.
    /// </summary>
    [XmlEnum(Name = "trial")]
    [EnumMember(Value = "trial")]
    Trial = 15,

  }

}
