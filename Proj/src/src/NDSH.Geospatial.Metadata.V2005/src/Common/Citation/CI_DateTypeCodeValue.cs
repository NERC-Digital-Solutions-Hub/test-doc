
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : Identification of when a given event occurred.
// Created by        : 18/09/2022, 02:22, @gisvlasta.
// Updated by        : 16/12/2022, 19:19, @gisvlasta - Cleaned Xml Serialization Attributes.
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
  /// Identification of when a given event occurred.
  /// </summary>
  [Serializable]
  public enum CI_DateTypeCodeValue {

    // TODO: What about JSON serialization?

    /// <summary>
    /// Date identifies when the resource was brought into existence.
    /// </summary>
    [XmlEnum(Name="creation")]
    [EnumMember(Value="creation")]
    Creation = 1,

    /// <summary>
    /// Date identifies when the resource was issued.
    /// </summary>
    [XmlEnum(Name = "publication")]
    [EnumMember(Value = "publication")]
    Publication = 2,

    /// <summary>
    /// Date identifies when the resource was examined or re-examined and improved or amended.
    /// </summary>
    [XmlEnum(Name = "revision")]
    [EnumMember(Value = "revision")]
    Revision = 3,

  }

}
