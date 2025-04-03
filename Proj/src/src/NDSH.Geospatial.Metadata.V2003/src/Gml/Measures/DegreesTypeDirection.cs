
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 31/01/2023, 21:00, @gisvlasta.
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
  [XmlType(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
  public enum DegreesTypeDirection {

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "N")]
    [EnumMember(Value = "N")]
    North,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "E")]
    [EnumMember(Value = "E")]
    East,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "S")]
    [EnumMember(Value = "S")]
    South,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "W")]
    [EnumMember(Value = "W")]
    West,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum("+")]
    [EnumMember(Value = "+")]
    Plus,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum("-")]
    [EnumMember(Value = "-")]
    Minus,

  }

}
