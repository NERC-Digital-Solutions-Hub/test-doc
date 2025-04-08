
#region Header
// Title Name        : @@@@
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : Name of the medium.
// Created by        : 20/09/2022, 15:25, @gisvlasta
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
  /// Name of the medium.
  /// </summary>
  [Serializable]
  public enum MD_MediumNameCodeValue {

    /// <summary>
    /// Read-only optical disk.
    /// </summary>
    [XmlEnum(Name = "cdRom")]
    [EnumMember(Value = "cdRom")]
    CdRom,

    /// <summary>
    /// Digital versatile disk.
    /// </summary>
    [XmlEnum(Name = "dvd")]
    [EnumMember(Value = "dvd")]
    Dvd,

    /// <summary>
    /// Digital versatile disk, read only.
    /// </summary>
    [XmlEnum(Name = "dvdRom")]
    [EnumMember(Value = "dvdRom")]
    DvdRom,

    /// <summary>
    /// 3,5 inch magnetic disk.
    /// </summary>
    [XmlEnum("3halfInchFloppy")]
    [EnumMember(Value = "3halfInchFloppy")]
    Floppy3HalfInch,
    
    /// <summary>
    /// 5,25 inch magnetic disk.
    /// </summary>
    [XmlEnum("5quartherInchFloppy")]
    [EnumMember(Value = "5quartherInchFloppy")]
    Floppy5QuartherInch,
    
    /// <summary>
    /// 7 track magnetic tape.
    /// </summary>
    [XmlEnum("7trackTape")]
    [EnumMember(Value = "7trackTape")]
    Tape7Track,

    /// <summary>
    /// 9 track magnetic tape.
    /// </summary>
    [XmlEnum("9trackTape")]
    [EnumMember(Value = "9trackTape")]
    Tape9Track,

    /// <summary>
    /// 3480 cartridge tape drive.
    /// </summary>
    [XmlEnum("3480Cartridge")]
    [EnumMember(Value = "3480Cartridge")]
    Cartridge3480,

    /// <summary>
    /// 3490 cartridge tape drive.
    /// </summary>
    [XmlEnum("3490Cartridge")]
    [EnumMember(Value = "3490Cartridge")]
    Cartridge3490,

    /// <summary>
    /// 3580 cartridge tape drive.
    /// </summary>
    [XmlEnum("3580Cartridge")]
    [EnumMember(Value = "3580Cartridge")]
    Cartridge3580,

    /// <summary>
    /// 4 millimetre magnetic tape.
    /// </summary>
    [XmlEnumAttribute("4mmCartridgeTape")]
    [EnumMember(Value = "4mmCartridgeTape")]
    CartridgeTape4mm,

    /// <summary>
    /// 8 millimetre magnetic tape.
    /// </summary>
    [XmlEnumAttribute("8mmCartridgeTape")]
    [EnumMember(Value = "8mmCartridgeTape")]
    CartridgeTape8mm,

    /// <summary>
    /// 0,25 inch magnetic tape.
    /// </summary>
    [XmlEnumAttribute("1quarterInchCartridgeTape")]
    [EnumMember(Value = "1quarterInchCartridgeTape")]
    CartridgeTape1QuarterInch,

    /// <summary>
    /// Half inch cartridge streaming tape drive.
    /// </summary>
    [XmlEnum(Name = "digitalLinearTape")]
    [EnumMember(Value = "digitalLinearTape")]
    DigitalLinearTape,

    /// <summary>
    /// Direct computer linkage.
    /// </summary>
    [XmlEnum(Name = "online")] 
    [EnumMember(Value = "online")]
    Online,

    /// <summary>
    /// Llinkage through a satellite communication system.
    /// </summary>
    [XmlEnum(Name = "satellite")]
    [EnumMember(Value = "satellite")]
    Satellite,

    /// <summary>
    /// Communication through a telephone network.
    /// </summary>
    [XmlEnum(Name = "telephoneLink")]
    [EnumMember(Value = "telephoneLink")]
    TelephoneLink,

    /// <summary>
    /// Pamphlet or leaflet giving descriptive information.
    /// </summary>
    [XmlEnum(Name = "hardcopy")]
    [EnumMember(Value = "hardcopy")]
    Hardcopy,

  }

}
