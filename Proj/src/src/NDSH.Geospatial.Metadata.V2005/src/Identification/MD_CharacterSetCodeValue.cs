
#region Header
// Title Name        : MD_CharacterSetCodeValue
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : The name of the character coding standard used for the resource.
// Created by        : 18/09/2022, 21:19, @gisvlasta
// Updated by        : 18/12/2022, 01:15, @gisvlasta - Cleaned Xml Serialization Attributes.
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

namespace NDSH.Geospatial.Metadata.V2005.Identification {

  /// <summary>
  /// The name of the character coding standard used for the resource.
  /// </summary>
  [Serializable]
  public enum MD_CharacterSetCodeValue {

    /// <summary>
    /// 16-bit fixed size Universal Character Set, based on ISO/IEC 10646.
    /// </summary>
    [XmlEnum(Name = "ucs2")]
    [EnumMember(Value = "ucs2")]
    UCS2 = 1,

    /// <summary>
    /// 32-bit fixed size Universal Character Set, based on ISO/IEC 10646.
    /// </summary>
    [XmlEnum(Name = "ucs4")]
    [EnumMember(Value = "ucs4")]
    UCS4 = 2,

    /// <summary>
    /// 7-bit variable size UCS Transfer Format, based on ISO/IEC 10646.
    /// </summary>
    [XmlEnum(Name = "utf7")]
    [EnumMember(Value = "utf7")]
    UTF7 = 3,

    /// <summary>
    /// 8-bit variable size UCS Transfer Format, based on ISO/IEC 10646.
    /// </summary>
    [XmlEnum(Name = "utf8")]
    [EnumMember(Value = "utf8")]
    UTF8 = 4,

    /// <summary>
    /// 16-bit variable size UCS Transfer Format, based on ISO/IEC 10646.
    /// </summary>
    [XmlEnum(Name = "utf16")]
    [EnumMember(Value = "utf16")]
    UTF16 = 5,

    /// <summary>
    /// ISO/IEC 8859-1, Information technology – 8-bit single-byte coded
    /// graphic character sets – Part 1: Latin alphabet No. 1.
    /// </summary>
    [XmlEnum(Name = "8859part1")]
    [EnumMember(Value = "8859part1")]
    IsoIec8859part1 = 6,

    /// <summary>
    /// ISO/IEC 8859-2, Information technology – 8-bit single-byte coded
    /// graphic character sets – Part 2: Latin alphabet No. 2.
    /// </summary>
    [XmlEnum(Name = "8859part2")]
    [EnumMember(Value = "8859part2")]
    IsoIec8859part2 = 7,

    /// <summary>
    /// ISO/IEC 8859-3, Information technology – 8-bit single-byte coded
    /// graphic character sets – Part 3: Latin alphabet No. 3.
    /// </summary>
    [XmlEnum(Name = "8859part3")]
    [EnumMember(Value = "8859part3")]
    IsoIec8859part3 = 8,

    /// <summary>
    /// ISO/IEC 8859-4, Information technology – 8-bit single-byte coded
    /// graphic character sets – Part 4: Latin alphabet No. 4.
    /// </summary>
    [XmlEnum(Name = "8859part4")]
    [EnumMember(Value = "8859part4")]
    IsoIec8859part4 = 9,

    /// <summary>
    /// ISO/IEC 8859-51, Information technology – 8-bit single-byte coded
    /// graphic character sets – Part 5: Latin/Cyrillic alphabet.
    /// </summary>
    [XmlEnum(Name = "8859part5")]
    [EnumMember(Value = "8859part5")]
    IsoIec8859part5 = 10,

    /// <summary>
    /// ISO/IEC 8859-6, Information technology – 8-bit single-byte coded
    /// graphic character sets – Part 6: Latin/Arabic alphabet.
    /// </summary>
    [XmlEnum(Name = "8859part6")]
    [EnumMember(Value = "8859part6")]
    IsoIec8859part6 = 11,

    /// <summary>
    /// ISO/IEC 8859-7, Information technology – 8-bit single-byte coded
    /// graphic character sets – Part 7: Latin/Greek alphabet.
    /// </summary>
    [XmlEnum(Name = "8859part7")]
    [EnumMember(Value = "8859part7")]
    IsoIec8859part7 = 12,

    /// <summary>
    /// ISO/IEC 8859-8, Information technology – 8-bit single-byte coded
    /// graphic character sets – Part 8: Latin/Hebrew alphabet.
    /// </summary>
    [XmlEnum(Name = "8859part8")]
    [EnumMember(Value = "8859part8")]
    IsoIec8859part8 = 13,

    /// <summary>
    /// ISO/IEC8859-9, Information technology – 8-bit single-byte coded
    /// graphic character sets – Part 9: Latin alphabet No. 5.
    /// </summary>
    [XmlEnum(Name = "8859part9")]
    [EnumMember(Value = "8859part9")]
    IsoIec8859part9 = 14,

    /// <summary>
    /// ISO/IEC 8859-10, Information technology – 8-bit single-byte coded
    /// graphic character sets – Part 10: Latin alphabet No. 6.
    /// </summary>
    [XmlEnum(Name = "8859part10")]
    [EnumMember(Value = "8859part10")]
    IsoIec8859part10 = 15,

    /// <summary>
    /// ISO/IEC 8859-11, Information technology – 8-bit single-byte coded
    /// graphic character sets – Part 11: Latin/Thai alphabet.
    /// </summary>
    [XmlEnum(Name = "8859part11")]
    [EnumMember(Value = "8859part11")]
    IsoIec8859part11 = 16,

    ///// <summary>
    ///// A future ISO/IEC 8-bit single-byte coded graphic character set
    ///// (e.g. possibly ISO/IEC 8859-12).
    ///// </summary>
    ///// <remarks>
    ///// Reserved for future use.
    ///// </remarks>
    //[XmlEnum("8859part12")]
    //[EnumMember(Value = "8859part12")]
    //IsoIec8859part12,

    /// <summary>
    /// ISO/IEC 8859-13, Information technology – 8-bit single-byte coded
    /// graphic character sets – Part 13: Latin alphabet No. 7.
    /// </summary>
    [XmlEnum(Name = "8859part13")]
    [EnumMember(Value = "8859part13")]
    IsoIec8859part13 = 18,

    /// <summary>
    /// ISO/IEC 8859-14, Information technology – 8-bit single-byte coded
    /// graphic character sets – Part 14: Latin alphabet No. 8 (Celtic).
    /// </summary>
    [XmlEnum(Name = "8859part14")]
    [EnumMember(Value = "8859part14")]
    IsoIec8859part14 = 19,

    /// <summary>
    /// ISO/IEC 8859-15, Information technology – 8-bit single-byte coded
    /// graphic character sets – Part 15: Latin alphabet No. 9.
    /// </summary>
    [XmlEnum(Name = "8859part15")]
    [EnumMember(Value = "8859part15")]
    IsoIec8859part15 = 20,

    /// <summary>
    /// ISO/IEC 8859-16, Information technology – 8-bit single-byte coded
    /// graphic character sets – Part 16: Latin alphabet No. 10.
    /// </summary>
    [XmlEnum(Name = "8859part16")]
    [EnumMember(Value = "8859part16")]
    IsoIec8859part16 = 21,

    /// <summary>
    /// Japanese code set used for electronic transmission.
    /// </summary>
    [XmlEnum(Name = "jis")]
    [EnumMember(Value = "jis")]
    JIS = 22,

    /// <summary>
    /// Japanese code set used on MS-DOS based machines.
    /// </summary>
    [XmlEnum(Name = "shiftJIS")]
    [EnumMember(Value = "shiftJIS")]
    ShiftJIS = 23,

    /// <summary>
    /// Japanese code set used on UNIX based machines.
    /// </summary>
    [XmlEnum(Name = "eucJP")]
    [EnumMember(Value = "eucJP")]
    EucJP = 24,

    /// <summary>
    /// United States ASCII code set (ISO 646 US).
    /// </summary>
    [XmlEnum(Name = "usAscii")]
    [EnumMember(Value = "usAscii")]
    UsAscii = 25,

    /// <summary>
    /// IBM mainframe code set.
    /// </summary>
    [XmlEnum(Name = "ebcdic")]
    [EnumMember(Value = "ebcdic")]
    EBCDIC = 26,

    /// <summary>
    /// Korean code set.
    /// </summary>
    [XmlEnum(Name = "eucKR")]
    [EnumMember(Value = "eucKR")]
    EucKR = 27,

    /// <summary>
    /// Traditional Chinese code set used in Taiwan,
    /// Hong Kong of China and other areas
    /// </summary>
    [XmlEnum(Name = "big5")]
    [EnumMember(Value = "big5")]
    Big5 = 28,

    /// <summary>
    /// Simplified Chinese code set.
    /// </summary>
    [XmlEnum(Name = "gb2312")]
    [EnumMember(Value = "gb2312")]
    GB2312 = 29,

  }

}
