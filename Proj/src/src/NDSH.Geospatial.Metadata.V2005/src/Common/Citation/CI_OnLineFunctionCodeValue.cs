
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : The function performed by the resource.
// Created by        : 18/09/2022, 02:17, @gisvlasta.
// Updated by        : 16/12/2022, 19:10, @gisvlasta - Cleaned Xml Serialization Attributes.
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
  /// The function performed by the resource.
  /// </summary>
  [Serializable]
  public enum CI_OnLineFunctionCodeValue {

    // TODO: What about JSON serialization?

    /// <summary>
    /// Online instructions for transferring data from one storage device or system to another.
    /// </summary>
    [XmlEnum(Name = "download")]
    [EnumMember(Value = "download")]
    Download = 1,

    /// <summary>
    /// Online information about the resource.
    /// </summary>
    [XmlEnum(Name = "information")]
    [EnumMember(Value = "information")]
    Information = 2,

    /// <summary>
    /// Online instructions for requesting the resource from the provider.
    /// </summary>
    [XmlEnum(Name = "offlineAccess")]
    [EnumMember(Value = "offlineAccess")]
    OfflineAccess = 3,

    /// <summary>
    /// Online order process for obtaining the resource.
    /// </summary>
    [XmlEnum(Name = "order")]
    [EnumMember(Value = "order")]
    Order = 4,

    /// <summary>
    /// Online search interface for seeking out information about the resource.
    /// </summary>
    [XmlEnum(Name = "search")]
    [EnumMember(Value = "search")]
    Search = 5,

  }

}
