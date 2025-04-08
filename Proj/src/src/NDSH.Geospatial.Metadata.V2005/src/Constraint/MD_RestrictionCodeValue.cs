
#region Header
// Title Name        : @@@@
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : Limitation(s) placed upon the access or use of the data.
// Created by        : 19/09/2022, 21:37, @gisvlasta
// Updated by        : 17/12/2022, 02:52, @fdq09eca - Cleaned Xml Serialization Attributes.
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
  /// Limitation(s) placed upon the access or use of the data.
  /// </summary>
  [Serializable]
  public enum MD_RestrictionCodeValue {

    /// <summary>
    /// Exclusive right to the publication, production, or sale of the rights to a literary,
    /// dramatic, musical, or artistic work, or to the use of a commercial print or label,
    /// granted by law for a specified period of time to an author, composer, artist, distributor.
    /// </summary>
    [XmlEnum(Name = "copyright")]
    [EnumMember(Value = "copyright")]
    Copyright = 1,

    /// <summary>
    /// Government has granted exclusive right to make, sell, use or license an invention or discovery.
    /// </summary>
    [XmlEnum(Name = "patent")]
    [EnumMember(Value = "patent")]
    Patent = 2,

    /// <summary>
    /// Produced or sold information awaiting a patent.
    /// </summary>
    [XmlEnum(Name = "patentPending")]
    [EnumMember(Value = "patentPending")]
    PatentPending = 3,

    /// <summary>
    /// A name, symbol, or other device identifying a product, officially registered and legally
    /// restricted to the use of the owner or manufacturer.
    /// </summary>
    [XmlEnum(Name = "trademark")]
    [EnumMember(Value = "trademark")]
    Trademark = 4,

    /// <summary>
    /// Formal permission to do something.
    /// </summary>
    [XmlEnum(Name = "license")]
    [EnumMember(Value = "license")]
    License = 5,

    /// <summary>
    /// Rights to financial benefit from and control of distribution of non-tangible property
    /// that is a result of creativity.
    /// </summary>
    [XmlEnum(Name = "intellectualPropertyRights")]
    [EnumMember(Value = "intellectualPropertyRights")]
    IntellectualPropertyRights = 6,

    /// <summary>
    /// Withheld from general circulation or disclosure.
    /// </summary>
    [XmlEnum(Name = "restricted")]
    [EnumMember(Value = "restricted")]
    Restricted = 7,

    /// <summary>
    /// Limitation not listed.
    /// </summary>
    [XmlEnum(Name = "otherRestictions")]
    [EnumMember(Value = "otherRestictions")]
    OtherRestictions = 8,

  }

}
