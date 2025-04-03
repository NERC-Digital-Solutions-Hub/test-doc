
#region Header
// Title Name        : @@@@
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : Frequency with which modifications and deletions are made
//                     to the data after it is first produced.
// Created by        : 20/09/2022, 15:16, @gisvlasta
// Updated by        : 18/12/2022, 17:19, @gisvlasta - Cleaned Xml Serialization Attributes.
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

namespace NDSH.Geospatial.Metadata.V2005.Maintenance {

  /// <summary>
  /// Frequency with which modifications and deletions are made to the data after it is first produced.
  /// </summary>
  [Serializable]
  public enum MD_MaintenanceFrequencyCodeValue {

    /// <summary>
    /// Data is repeatedly and frequently updated.
    /// </summary>
    [XmlEnum(Name = "continual")]
    [EnumMember(Value = "continual")]
    Continual = 1,

    /// <summary>
    /// Data is updated each day.
    /// </summary>
    [XmlEnum(Name = "daily")]
    [EnumMember(Value = "daily")]
    Daily = 2,

    /// <summary>
    /// Data is updated on a weekly basis.
    /// </summary>
    [XmlEnum(Name = "weekly")]
    [EnumMember(Value = "weekly")]
    Weekly = 3,

    /// <summary>
    /// Data is updated every two weeks.
    /// </summary>
    [XmlEnum(Name = "fortnightly")]
    [EnumMember(Value = "fortnightly")]
    Fortnightly = 4,

    /// <summary>
    /// Data is updated each month.
    /// </summary>
    [XmlEnum(Name = "monthly")]
    [EnumMember(Value = "monthly")]
    Monthly = 5,

    /// <summary>
    /// Data is updated every three months.
    /// </summary>
    [XmlEnum(Name = "quarterly")]
    [EnumMember(Value = "quarterly")]
    Quarterly = 6,

    /// <summary>
    /// Data is updated twice each year.
    /// </summary>
    [XmlEnum(Name = "biannually")]
    [EnumMember(Value = "biannually")]
    Biannually = 7,

    /// <summary>
    /// Data is updated every year.
    /// </summary>
    [XmlEnum(Name = "annually")]
    [EnumMember(Value = "annually")]
    Annually = 8,

    /// <summary>
    /// Data is updated as deemed necessary.
    /// </summary>
    [XmlEnum(Name = "asNeeded")]
    [EnumMember(Value = "asNeeded")]
    AsNeeded = 9,

    /// <summary>
    /// Data is updated in intervals that are uneven in duration.
    /// </summary>
    [XmlEnum(Name = "irregular")]
    [EnumMember(Value = "irregular")]
    Irregular = 10,

    /// <summary>
    /// There are no plans to update the data.
    /// </summary>
    [XmlEnum(Name = "notPlanned")]
    [EnumMember(Value = "notPlanned")]
    NotPlanned = 11,

    /// <summary>
    /// Frequency of maintenance for the data is not known.
    /// </summary>
    [XmlEnum(Name = "unknown")]
    [EnumMember(Value = "unknown")]
    Unknown = 12,

  }

}
