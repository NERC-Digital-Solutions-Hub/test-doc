
#region Header
// Title Name        : @@@@
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : Point in a pixel corresponding to the Earth location of the pixel.
// Created by        : 20/09/2022, 15:28, @gisvlasta.
// Updated by        : 16/12/2022, 15:07, @EttoreM - Cleaned Xml Serialization Attributes.
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

namespace NDSH.Geospatial.Metadata.V2005.SpatialRepresentation {

  /// <summary>
  /// Point in a pixel corresponding to the Earth location of the pixel.
  /// </summary>
  [Serializable]
  public enum MD_PixelOrientationCodeValue {

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
