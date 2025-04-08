
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 01/02/2023, 21:31, @gisvlasta.
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

namespace NDSH.Geospatial.Gml.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml", IncludeInSchema = false)]
  public enum PositionType {

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "coordinates")]
    [EnumMember(Value = "coordinates")]
    Coordinates,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "pointProperty")]
    [EnumMember(Value = "pointProperty")]
    PointProperty,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "pointRep")]
    [EnumMember(Value = "pointRep")]
    PointRep,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "pos")]
    [EnumMember(Value = "pos")]
    Pos,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "posList")]
    [EnumMember(Value = "posList")]
    PosList,

  }

}
