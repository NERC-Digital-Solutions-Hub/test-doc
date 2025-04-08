
#region Header
// Title Name        : @@@@
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : Method used to represent geographic information in the dataset.
// Created by        : 20/09/2022, 15:31, @gisvlasta.
// Updated by        : 16/12/2022, 15:06, @EttoreM - Cleaned Xml Serialization Attributes.
//                     29/12/2022, 19:04, @gisvlasta - Moved to .Identification namespace.
// Version           : 1.0.2
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

namespace NDSH.Geospatial.Metadata.V2005.Identification {

  /// <summary>
  /// Method used to represent geographic information in the dataset.
  /// </summary>
  [Serializable]
  public enum MD_SpatialRepresentationTypeCodeValue {

    /// <summary>
    /// Vector data is used to represent geographic data.
    /// </summary>
    [XmlEnum(Name = "vector")]
    [EnumMember(Value = "vector")]
    Vector = 1,

    /// <summary>
    /// Grid data is used to represent geographic data.
    /// </summary>
    [XmlEnum(Name = "grid")]
    [EnumMember(Value = "grid")]
    Grid = 2,

    /// <summary>
    /// Textual or tabular data is used to represent geographic data.
    /// </summary>
    [XmlEnum(Name = "textTable")]
    [EnumMember(Value = "textTable")]
    TextTable = 3,

    /// <summary>
    /// Triangulated irregular network.
    /// </summary>
    [XmlEnum(Name = "tin")]
    [EnumMember(Value = "tin")]
    Tin = 4,

    /// <summary>
    /// Three-dimensional view formed by the intersecting homologous rays of an overlapping pair of images.
    /// </summary>
    [XmlEnum(Name = "stereoModel")]
    [EnumMember(Value = "stereoModel")]
    StereoModel = 5,

    /// <summary>
    /// Scene from a video recording.
    /// </summary>
    [XmlEnum(Name = "video")]
    [EnumMember(Value = "video")]
    Video = 6,

  }

}
