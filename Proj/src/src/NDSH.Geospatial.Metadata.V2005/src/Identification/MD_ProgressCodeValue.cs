
#region Header
// Title Name        : @@@@
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : The status of the dataset or progress of a review.
// Created by        : 19/09/2022, 21:44, @gisvlasta
// Updated by        : 18/12/2022, 01:23, @gisvlasta - Cleaned Xml Serialization Attributes.
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
  /// The status of the dataset or progress of a review.
  /// </summary>
  [Serializable]
  public enum MD_ProgressCodeValue {

    /// <summary>
    /// Production of the data has been completed.
    /// </summary>
    [XmlEnum(Name = "completed")]
    [EnumMember(Value = "completed")]
    Completed = 1,

    /// <summary>
    /// Data has been stored in an offline storage facility.
    /// </summary>
    [XmlEnum(Name = "historicalArchive")]
    [EnumMember(Value = "historicalArchive")]
    HistoricalArchive = 2,

    /// <summary>
    /// Data is no longer relevant.
    /// </summary>
    [XmlEnum(Name = "obsolete")]
    [EnumMember(Value = "obsolete")]
    Obsolete = 3,

    /// <summary>
    /// Data is continually being updated.
    /// </summary>
    [XmlEnum(Name = "onGoing")]
    [EnumMember(Value = "onGoing")]
    OnGoing = 4,

    /// <summary>
    /// Fixed date has been established upon or by which the data will be created or updated.
    /// </summary>
    [XmlEnum(Name = "planned")]
    [EnumMember(Value = "planned")]
    Planned = 5,

    /// <summary>
    /// Data needs to be generated or updated.
    /// </summary>
    [XmlEnum(Name = "required")]
    [EnumMember(Value = "required")]
    Required = 6,

    /// <summary>
    /// Data is currently in the process of being created.
    /// </summary>
    [XmlEnum(Name = "underDevelopment")]
    [EnumMember(Value = "underDevelopment")]
    UnderDevelopment = 7,

  }

}
