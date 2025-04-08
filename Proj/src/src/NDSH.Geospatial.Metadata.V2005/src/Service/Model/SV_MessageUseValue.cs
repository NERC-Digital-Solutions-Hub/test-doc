
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

namespace NDSH.Geospatial.Metadata.V2005.Service.Model {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot(Namespace = "", IsNullable = false)]
  public enum SV_MessageUseValue {

    // TODO: Make sure what are the actual enum values (check spec)

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "request")]
    [EnumMember(Value = "request")]
    Request,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "responseServer")]
    [EnumMember(Value = "responseServer")]
    ResponseServer,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "solicitation")]
    [EnumMember(Value = "solicitation")]
    Solicitation,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "responseClient")]
    [EnumMember(Value = "responseClient")]
    ResponseClient,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "broadcast")]
    [EnumMember(Value = "broadcast")]
    Broadcast,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "notification")]
    [EnumMember(Value = "notification")]
    Notification,

  }

}
