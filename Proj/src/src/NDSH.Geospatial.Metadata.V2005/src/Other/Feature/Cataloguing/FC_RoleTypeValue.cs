
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

namespace NDSH.Geospatial.Metadata.V2005.Other.Feature.Cataloguing {

  /// <summary>
  /// 
  /// </summary>
  [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.4084.0")]
  [Serializable]
  [XmlRoot(Namespace = "", IsNullable = false)]
  public enum FC_RoleTypeValue {

    // TODO: Make sure what are the actual enum values (check spec)

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "ordinary")]
    [EnumMember(Value = "ordinary")]
    Ordinary,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "aggregation")]
    [EnumMember(Value = "aggregation")]
    Aggregation,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "composition")]
    [EnumMember(Value = "composition")]
    Composition,

  }

}
