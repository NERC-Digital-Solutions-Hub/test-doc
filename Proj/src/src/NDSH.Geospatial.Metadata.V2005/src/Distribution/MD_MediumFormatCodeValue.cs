
#region Header
// Title Name        : @@@@
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : Method used to write to the medium.
// Created by        : 20/09/2022, 15:19, @gisvlasta
// Updated by        : 18/12/2022, 02:50, @gisvlasta - Cleaned Xml Serialization Attributes.
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

namespace NDSH.Geospatial.Metadata.V2005.Distribution {

  /// <summary>
  /// Method used to write to the medium.
  /// </summary>
  [Serializable]
  public enum MD_MediumFormatCodeValue {

    /// <summary>
    /// CoPy In / Out (UNIX file format and command).
    /// </summary>
    [XmlEnum(Name = "cpio")]
    [EnumMember(Value = "cpio")]
    Cpio = 1,

    /// <summary>
    /// Tape Archive.
    /// </summary>
    [XmlEnum(Name = "tar")]
    [EnumMember(Value = "tar")]
    Tar = 2,

    /// <summary>
    /// High sierra file system.
    /// </summary>
    [XmlEnum(Name = "highSierra")]
    [EnumMember(Value = "highSierra")]
    HighSierra = 3,

    /// <summary>
    /// Information processing – volume and file structure of CD-ROM.
    /// </summary>
    [XmlEnum(Name = "iso9660")]
    [EnumMember(Value = "iso9660")]
    Iso9660 = 4,

    /// <summary>
    /// Rock ridge interchange protocol (UNIX).
    /// </summary>
    [XmlEnum(Name = "iso9660RockRidge")]
    [EnumMember(Value = "iso9660RockRidge")]
    Iso9660RockRidge = 5,

    /// <summary>
    /// Hierarchical file system (Macintosh).
    /// </summary>
    [XmlEnum(Name = "iso9660AppleHFS")]
    [EnumMember(Value = "iso9660AppleHFS")]
    Iso9660AppleHFS = 6,

  }

}
