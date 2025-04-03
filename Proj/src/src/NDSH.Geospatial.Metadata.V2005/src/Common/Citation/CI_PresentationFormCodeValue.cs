
#region Header
// Title Name        : CI_PresentationFormCodeValue
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : The mode in which the data is represented.
// Created by        : 19/09/2022, 17:23, @gisvlasta.
// Updated by        : 16/12/2022, 19:07, @gisvlasta - Cleaned Xml Serialization Attributes.
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

namespace NDSH.Geospatial.Metadata.V2005.Common.Citation {

  /// <summary>
  /// The mode in which the data is represented.
  /// </summary>
  [Serializable]
  public enum CI_PresentationFormCodeValue {

    /// <summary>
    /// Digital representation of a primarily textual item (can contain illustrations also).
    /// </summary>
    [XmlEnum(Name = "documentDigital")]
    [EnumMember(Value = "documentDigital")]
    DocumentDigital = 1,

    /// <summary>
    /// Representation of a primarily textual item (can contain illustrations also) on paper,
    /// photographic material, or other media.
    /// </summary>
    [XmlEnum(Name = "documentHardcopy")]
    [EnumMember(Value = "documentHardcopy")]
    DocumentHardcopy = 2,

    /// <summary>
    /// Likeness of natural or man-made features, objects, and activities acquired through
    /// the sensing of visual or any other segment of the electromagnetic spectrum by sensors,
    /// such as thermal infrared, and high resolution radar and stored in digital format.
    /// </summary>
    [XmlEnum(Name = "imageDigital")]
    [EnumMember(Value = "imageDigital")]
    ImageDigital = 3,

    /// <summary>
    /// Likeness of natural or man-made features, objects, and activities acquired through
    /// the sensing of visual or any other segment of the electromagnetic spectrum by sensors,
    /// such as thermal infrared, and high resolution radar and reproduced on paper,
    /// photographic material, or other media for use directly by the human user.
    /// </summary>
    [XmlEnum(Name = "imageHardcopy")]
    [EnumMember(Value = "imageHardcopy")]
    ImageHardcopy = 4,

    /// <summary>
    /// Map represented in raster or vector form.
    /// </summary>
    [XmlEnum(Name = "mapDigital")]
    [EnumMember(Value = "mapDigital")]
    MapDigital = 5,

    /// <summary>
    /// Map printed on paper, photographic material, or other media for use directly by the human user.
    /// </summary>
    [XmlEnum(Name = "mapHardcopy")]
    [EnumMember(Value = "mapHardcopy")]
    MapHardcopy = 6,

    /// <summary>
    /// Multi-dimensional digital representation of a feature, process, etc. 
    /// </summary>
    [XmlEnum(Name = "modelDigital")]
    [EnumMember(Value = "modelDigital")]
    ModelDigital = 7,

    /// <summary>
    /// 3-dimensional, physical model.
    /// </summary>
    [XmlEnum(Name = "modelHardcopy")]
    [EnumMember(Value = "modelHardcopy")]
    ModelHardcopy = 8,

    /// <summary>
    /// Vertical cross-section in digital form.
    /// </summary>
    [XmlEnum(Name = "profileDigital")]
    [EnumMember(Value = "profileDigital")]
    ProfileDigital = 9,

    /// <summary>
    /// Vertical cross-section printed on paper, etc.
    /// </summary>
    [XmlEnum(Name = "profileHardcopy")]
    [EnumMember(Value = "profileHardcopy")]
    ProfileHardcopy = 10,

    /// <summary>
    /// Digital representation of facts or figures systematically displayed, especially in columns.
    /// </summary>
    [XmlEnum(Name = "tableDigital")]
    [EnumMember(Value = "tableDigital")]
    TableDigital = 11,

    /// <summary>
    /// Representation of facts or figures systematically displayed, especially in columns,
    /// printed on paper, photographic material, or other media.
    /// </summary>
    [XmlEnum(Name = "tableHardcopy")]
    [EnumMember(Value = "tableHardcopy")]
    TableHardcopy = 12,

    /// <summary>
    /// Digital video recording.
    /// </summary>
    [XmlEnum(Name = "videoDigital")]
    [EnumMember(Value = "videoDigital")]
    VideoDigital = 13,

    /// <summary>
    /// Video recording on film.
    /// </summary>
    [XmlEnum(Name = "videoHardcopy")]
    [EnumMember(Value = "videoHardcopy")]
    VideoHardcopy = 14,

  }

}
