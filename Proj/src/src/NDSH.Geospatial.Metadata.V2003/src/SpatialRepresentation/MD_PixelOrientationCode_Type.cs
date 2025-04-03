
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 04:11, @gisvlasta.
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
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.SpatialRepresentation {

  /// <summary>
  /// Point in a pixel corresponding to the Earth location of the pixel.
  /// </summary>
  [Serializable]
  [XmlType("MD_PixelOrientationCode", Namespace = "http://www.isotc211.org/2005/gmd")] // TODO: Should it be AnonymousType???
  [XmlRoot("MD_PixelOrientationCode", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)] // TODO: XmlRoot here???
  public enum MD_PixelOrientationCode_Type {

    /// <summary>
    /// Point halfway between the lower left and the upper right of the pixel.
    /// </summary>
    [XmlEnum(Name = "center")]
    [EnumMember(Value = "center")]
    Center = 1,

    /// <summary>
    /// The corner in the pixel closest to the origin of the SRS;
    /// if two are at the same distance from the origin, the one with the smallest x-value.
    /// </summary>
    [XmlEnum(Name = "lowerLeft")]
    [EnumMember(Value = "lowerLeft")]
    LowerLeft = 2,

    /// <summary>
    /// Next corner counterclockwise from the lower left.
    /// </summary>
    [XmlEnum(Name = "lowerRight")]
    [EnumMember(Value = "lowerRight")]
    LowerRight = 3,

    /// <summary>
    /// Next corner counterclockwise from the lower right.
    /// </summary>
    [XmlEnum(Name = "upperRight")]
    [EnumMember(Value = "upperRight")]
    UpperRight = 4,

    /// <summary>
    /// Next corner counterclockwise from the upper right.
    /// </summary>
    [XmlEnum(Name = "upperLeft")]
    [EnumMember(Value = "upperLeft")]
    UpperLeft = 5,

  }

}
