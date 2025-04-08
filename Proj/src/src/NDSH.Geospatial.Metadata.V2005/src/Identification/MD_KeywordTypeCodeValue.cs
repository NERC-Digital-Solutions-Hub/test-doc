
#region Header
// Title Name        : @@@@
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : Methods used to group similar keywords.
// Created by        : 20/09/2022, 15:13, @gisvlasta
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
  /// Methods used to group similar keywords.
  /// </summary>
  [Serializable]
  public enum MD_KeywordTypeCodeValue {

    /// <summary>
    /// Keyword identifies a branch of instruction or specialized learning.
    /// </summary>
    [XmlEnum(Name = "discipline")]
    [EnumMember(Value = "discipline")]
    Discipline = 1,

    /// <summary>
    /// Keyword identifies a location.
    /// </summary>
    [XmlEnum(Name = "place")]
    [EnumMember(Value = "place")]
    Place = 2,

    /// <summary>
    /// Keyword identifies the layer(s) of any deposited substance.
    /// </summary>
    [XmlEnum(Name = "stratum")]
    [EnumMember(Value = "stratum")]
    Stratum = 3,

    /// <summary>
    /// Keyword identifies a time period related to the dataset.
    /// </summary>
    [XmlEnum(Name = "temporal")]
    [EnumMember(Value = "temporal")]
    Temporal = 4,

    /// <summary>
    /// Keyword identifies a particular subject or topic.
    /// </summary>
    [XmlEnum(Name = "theme")]
    [EnumMember(Value = "theme")]
    Theme = 5,

  }

}
