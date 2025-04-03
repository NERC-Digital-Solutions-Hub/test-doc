
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 01/02/2023, 21:04, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Gml.Direction {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml", IncludeInSchema = false)]
  public enum DirectionVectorEnumeration {

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "horizontalAngle")]
    [EnumMember(Value = "horizontalAngle")]
    HorizontalAngle,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "vector")]
    [EnumMember(Value = "vector")]
    Vector,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "verticalAngle")]
    [EnumMember(Value = "verticalAngle")]
    VerticalAngle,

  }

}
