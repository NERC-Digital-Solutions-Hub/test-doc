
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 31/01/2023, 20:28, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Measures {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml", IncludeInSchema = false)]
  public enum MinutesSecondsValueType {

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "decimalMinutes")]
    [EnumMember(Value = "decimalMinutes")]
    DecimalMinutes,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "minutes")]
    [EnumMember(Value = "minutes")]
    Minutes,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "seconds")]
    [EnumMember(Value = "seconds")]
    Seconds,

  }

}
