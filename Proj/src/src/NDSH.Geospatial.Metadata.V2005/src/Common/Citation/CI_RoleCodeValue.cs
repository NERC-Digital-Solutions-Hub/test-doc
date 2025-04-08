
#region Header
// Title Name        : CI_RoleCodeValue
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : The function performed by the responsible party.
// Created by        : 19/09/2022, 17:29, @gisvlasta.
// Updated by        : 16/12/2022, 19:04, @gisvlasta - Cleaned Xml Serialization Attributes.
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

namespace NDSH.Geospatial.Metadata.V2005.Common.Citation {

  /// <summary>
  /// The function performed by the responsible party.
  /// </summary>
  [Serializable]
  public enum CI_RoleCodeValue {

    /// <summary>
    /// Party that supplies the resource.
    /// </summary>
    [XmlEnum(Name = "resourceProvider")]
    [EnumMember(Value = "resourceProvider")]
    ResourceProvider = 1,

    /// <summary>
    /// Party that accepts accountability and responsibility for the data and
    /// ensures appropriate care and maintenance of the resource.
    /// </summary>
    [XmlEnum(Name = "custodian")]
    [EnumMember(Value = "custodian")]
    Custodian = 2,

    /// <summary>
    /// Party that owns the resource.
    /// </summary>
    [XmlEnum(Name = "owner")]
    [EnumMember(Value = "owner")]
    Owner = 3,

    /// <summary>
    /// Party who uses the resource.
    /// </summary>
    [XmlEnum(Name = "user")]
    [EnumMember(Value = "user")]
    User = 4,

    /// <summary>
    /// Party who distributes the resource.
    /// </summary>
    [XmlEnum(Name = "distributor")]
    [EnumMember(Value = "distributor")]
    Distributor = 5,

    /// <summary>
    /// Party who created the resource.
    /// </summary>
    [XmlEnum(Name = "originator")]
    [EnumMember(Value = "originator")]
    Originator = 6,

    /// <summary>
    /// Party who can be contacted for acquiring knowledge about or acquisition of the resource.
    /// </summary>
    [XmlEnum(Name = "pointOfContact")]
    [EnumMember(Value = "pointOfContact")]
    PointOfContact = 7,

    /// <summary>
    /// Key party responsible for gathering information and conducting research.
    /// </summary>
    [XmlEnum(Name = "principalInvestigator")]
    [EnumMember(Value = "principalInvestigator")]
    PrincipalInvestigator = 8,

    /// <summary>
    /// Party who has processed the data in a manner such that the resource has been modified.
    /// </summary>
    [XmlEnum(Name = "processor")]
    [EnumMember(Value = "processor")]
    Processor = 9,

    /// <summary>
    /// Party who published the resource.
    /// </summary>
    [XmlEnum(Name = "publisher")]
    [EnumMember(Value = "publisher")]
    Publisher = 10,

    /// <summary>
    /// Party who authored the resource.
    /// </summary>
    [XmlEnum(Name = "author")]
    [EnumMember(Value = "author")]
    Author = 11,

  }

}
