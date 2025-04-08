
#region Header
// Title Name        : @@@@
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : Code which indicates conditions which may affect the image.
// Created by        : 20/09/2022, 15:08, @gisvlasta
// Updated by        : 18/12/2022, 01:59, @gisvlasta - Cleaned Xml Serialization Attributes.
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

namespace NDSH.Geospatial.Metadata.V2005.Content {

  /// <summary>
  /// Code which indicates conditions which may affect the image.
  /// </summary>
  [Serializable]
  public enum MD_ImagingConditionCodeValue {

    /// <summary>
    /// Portion of the image is blurred.
    /// </summary>
    [XmlEnum(Name = "blurredImage")]
    [EnumMember(Value = "blurredImage")]
    BlurredImage = 1,

    /// <summary>
    /// Portion of the image is partially obscured by cloud cover.
    /// </summary>
    [XmlEnum(Name = "cloud")]
    [EnumMember(Value = "cloud")]
    Cloud = 2,

    /// <summary>
    /// Acute angle between the plane of the ecliptic (the plane of the Earth’s orbit)
    /// and the plane of the celestial equator.
    /// </summary>
    [XmlEnum(Name = "degradingObliquity")]
    [EnumMember(Value = "degradingObliquity")]
    DegradingObliquity = 3,

    /// <summary>
    /// Portion of the image is partially obscured by fog.
    /// </summary>
    [XmlEnum(Name = "fog")]
    [EnumMember(Value = "fog")]
    Fog = 4,

    /// <summary>
    /// Portion of the image is partially obscured by heavy smoke or dust.
    /// </summary>
    [XmlEnum(Name = "heavySmokeOrDust")]
    [EnumMember(Value = "heavySmokeOrDust")]
    HeavySmokeOrDust = 5,

    /// <summary>
    /// Image was taken at night.
    /// </summary>
    [XmlEnum(Name = "night")]
    [EnumMember(Value = "night")]
    Night = 6,

    /// <summary>
    /// Image was taken during rainfall.
    /// </summary>
    [XmlEnum(Name = "rain")]
    [EnumMember(Value = "rain")]
    Rain = 7,

    /// <summary>
    /// Image was taken during semi-dark conditions—twilight conditions.
    /// </summary>
    [XmlEnum(Name = "semiDarkness")]
    [EnumMember(Value = "semiDarkness")]
    SemiDarkness = 8,

    /// <summary>
    /// Portion of the image is obscured by shadow.
    /// </summary>
    [XmlEnum(Name = "shadow")]
    [EnumMember(Value = "shadow")]
    Shadow = 9,

    /// <summary>
    /// Portion of the image is obscured by snow.
    /// </summary>
    [XmlEnum(Name = "snow")]
    [EnumMember(Value = "snow")]
    Snow = 10,

    /// <summary>
    /// The absence of collection data of a given point or area caused by the
    /// relative location of topographic features which obstruct the collection
    /// path between the collector(s) and the subject(s) of interest.
    /// </summary>
    [XmlEnum(Name = "terrainMasking")]
    [EnumMember(Value = "terrainMasking")]
    TerrainMasking = 11,

  }

}
