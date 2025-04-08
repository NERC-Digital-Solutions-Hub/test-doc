
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/02/2023, 04:24, @gisvlasta.
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
  /// The time indeterminate values enumeration.<br></br>
  /// A value for indeterminatePosition may
  /// <list type="bullet">
  /// <item>be used either alone, or</item>
  /// <item>qualify a specific value for temporal position.</item>
  /// </list>
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  public enum TimeIndeterminateValueType {

    /// <summary>
    /// Indicates that the actual temporal position is unknown,
    /// but it is known to be after the specified value.
    /// </summary>
    [XmlEnum(Name = "after")]
    [EnumMember(Value = "after")]
    After,

    /// <summary>
    /// Indicates that the actual temporal position is unknown,
    /// but it is known to be before the specified value.
    /// </summary>
    [XmlEnum(Name = "before")]
    [EnumMember(Value = "before")]
    Before,

    /// <summary>
    /// Indicates that the specified value shall be replaced with
    /// the current temporal position whenever the value is accessed.
    /// </summary>
    [XmlEnum(Name = "now")]
    [EnumMember(Value = "now")]
    Now,

    /// <summary>
    /// Indicates that no specific value for temporal position is provided.
    /// </summary>
    [XmlEnum(Name = "unknown")]
    [EnumMember(Value = "unknown")]
    Unknown,

  }

}
