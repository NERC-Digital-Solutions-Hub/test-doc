
#region Header
// Title Name        : MD_ClassificationCodeValue
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : The name of the handling restrictions on the dataset.
// Created by        : 19/09/2022, 17:47, @gisvlasta.
// Updated by        : 17/12/2022, 02:42, @fdq09eca - Cleaned Xml Serialization Attributes.
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

namespace NDSH.Geospatial.Metadata.V2005.Constraint {

  /// <summary>
  /// The name of the handling restrictions on the dataset.
  /// </summary>
  [Serializable]
  public enum MD_ClassificationCodeValue {

    /// <summary>
    /// Available for general disclosure.
    /// </summary>
    [XmlEnum(Name = "unclassified")]
    [EnumMember(Value = "unclassified")]
    Unclassified = 1,

    /// <summary>
    /// Not for general disclosure.
    /// </summary>
    [XmlEnum(Name = "restricted")]
    [EnumMember(Value = "restricted")]
    Restricted = 2,

    /// <summary>
    /// Available for someone who can be entrusted with information.
    /// </summary>
    [XmlEnum(Name = "confidential")]
    [EnumMember(Value = "confidential")]
    Confidential = 3,

    /// <summary>
    /// Kept or meant to be kept private, unknown, or hidden from all but a select group of people.
    /// </summary>
    [XmlEnum(Name = "secret")]
    [EnumMember(Value = "secret")]
    Secret = 4,

    /// <summary>
    /// Of the highest secrecy.
    /// </summary>
    [XmlEnum(Name = "topsecret")]
    [EnumMember(Value = "topsecret")]
    Topsecret = 5,

  }

}
