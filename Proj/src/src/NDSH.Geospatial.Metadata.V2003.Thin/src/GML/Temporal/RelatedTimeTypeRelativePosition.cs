
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/02/2023, 19:03, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Temporal {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
  public enum RelatedTimeTypeRelativePosition {

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "Before")]
    [EnumMember(Value = "Before")]
    Before,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "After")]
    [EnumMember(Value = "After")] 
    After,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "Begins")]
    [EnumMember(Value = "Begins")] 
    Begins,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "Ends")]
    [EnumMember(Value = "Ends")] 
    Ends,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "During")]
    [EnumMember(Value = "During")] 
    During,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "Equals")]
    [EnumMember(Value = "Equals")] 
    Equals,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "Contains")]
    [EnumMember(Value = "Contains")] 
    Contains,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "Overlaps")]
    [EnumMember(Value = "Overlaps")] 
    Overlaps,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "Meets")]
    [EnumMember(Value = "Meets")] 
    Meets,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "OverlappedBy")]
    [EnumMember(Value = "OverlappedBy")] 
    OverlappedBy,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "MetBy")]
    [EnumMember(Value = "MetBy")] 
    MetBy,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "BegunBy")]
    [EnumMember(Value = "BegunBy")] 
    BegunBy,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "EndedBy")]
    [EnumMember(Value = "EndedBy")] 
    EndedBy,

  }

}
