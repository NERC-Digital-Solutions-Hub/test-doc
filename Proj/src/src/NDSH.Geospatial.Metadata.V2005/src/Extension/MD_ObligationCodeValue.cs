
#region Header
// Title Name        : @@@@
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : Obligation of the element or entity.
// Created by        : 20/09/2022, 15:26, @gisvlasta
// Updated by        : 18/12/2022, 03:51, @gisvlasta - Cleaned Xml Serialization Attributes.
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

namespace NDSH.Geospatial.Metadata.V2005.Extension {

  /// <summary>
  /// Obligation of the element or entity.
  /// </summary>
  [Serializable]
  public enum MD_ObligationCodeValue {

    /// <summary>
    /// Element is always required.
    /// </summary>
    [XmlEnum(Name = "mandatory")]
    [EnumMember(Value = "mandatory")]
    Mandatory = 1,

    /// <summary>
    /// Element is not required.
    /// </summary>
    [XmlEnum(Name = "optional")]
    [EnumMember(Value = "optional")]
    Optional = 2,

    /// <summary>
    /// Element is required when a specific condition is met.
    /// </summary>
    [XmlEnum(Name = "conditional")]
    [EnumMember(Value = "conditional")]
    Conditional = 3,

  }

}
