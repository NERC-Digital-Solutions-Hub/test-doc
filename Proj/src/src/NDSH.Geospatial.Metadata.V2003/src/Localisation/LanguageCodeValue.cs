
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/01/2022, 00:26, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
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

// TODO: Invastigate if this class needs to be in a different assembly file.

namespace NDSH.Geospatial.Metadata.V2003.Localisation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot(Namespace = "", IsNullable = false, ElementName = "languageCodeValue")] // TODO: Namespace ???
  public enum LanguageCodeValue {

    // TODO: Make sure what are the actual enum values (check spec) (Most probably the enum is ok)

    // TODO: Make sure the ISO 639-1 Language Codes are correct. (Check this web page: https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes)

    /// <summary>
    /// Afar
    /// </summary>
    [XmlEnum(Name = "aa")]
    [EnumMember(Value = "aa")]
    AA,

    /// <summary>
    /// Abkhazian
    /// </summary>
    [XmlEnum(Name = "ab")]
    [EnumMember(Value = "ab")]
    AB,

    /// <summary>
    /// Avestan
    /// </summary>
    [XmlEnum(Name = "ae")]
    [EnumMember(Value = "ae")]
    AE,

    /// <summary>
    /// Afrikaans
    /// </summary>
    [XmlEnum(Name = "af")]
    [EnumMember(Value = "af")]
    AF,

    /// <summary>
    /// Akan
    /// </summary>
    [XmlEnum(Name = "ak")]
    [EnumMember(Value = "ak")]
    AK,

    /// <summary>
    /// Amharic
    /// </summary>
    [XmlEnum(Name = "am")]
    [EnumMember(Value = "am")]
    AM,

    /// <summary>
    /// Aragonese
    /// </summary>
    [XmlEnum(Name = "an")]
    [EnumMember(Value = "an")]
    AN,

    /// <summary>
    /// Arabic
    /// </summary>
    [XmlEnum(Name = "ar")]
    [EnumMember(Value = "ar")]
    AR,

    /// <summary>
    /// Assamese
    /// </summary>
    [XmlEnum(Name = "as")]
    [EnumMember(Value = "as")]
    AS,

    /// <summary>
    /// Avaric
    /// </summary>
    [XmlEnum(Name = "av")]
    [EnumMember(Value = "av")]
    AV,

    /// <summary>
    /// Aymara
    /// </summary>
    [XmlEnum(Name = "ay")]
    [EnumMember(Value = "ay")]
    AY,

    /// <summary>
    /// Azerbaijani
    /// </summary>
    [XmlEnum(Name = "az")]
    [EnumMember(Value = "az")]
    AZ,

    /// <summary>
    /// Bashkir
    /// </summary>
    [XmlEnum(Name = "ba")]
    [EnumMember(Value = "ba")]
    BA,

    /// <summary>
    /// Belarusian
    /// </summary>
    [XmlEnum(Name = "be")]
    [EnumMember(Value = "be")]
    BE,

    /// <summary>
    /// Bulgarian
    /// </summary>
    [XmlEnum(Name = "bg")]
    [EnumMember(Value = "bg")]
    BG,

    /// <summary>
    /// Bislama
    /// </summary>
    [XmlEnum(Name = "bi")]
    [EnumMember(Value = "bi")]
    BI,

    /// <summary>
    /// Bambara
    /// </summary>
    [XmlEnum(Name = "bm")]
    [EnumMember(Value = "bm")]
    BM,

    /// <summary>
    /// Bengali
    /// </summary>
    [XmlEnum(Name = "bn")]
    [EnumMember(Value = "bn")]
    BN,

    /// <summary>
    /// Tibetan
    /// </summary>
    [XmlEnum(Name = "bo")]
    [EnumMember(Value = "bo")]
    BO,

    /// <summary>
    /// Breton
    /// </summary>
    [XmlEnum(Name = "br")]
    [EnumMember(Value = "br")]
    BR,

    /// <summary>
    /// Bosnian
    /// </summary>
    [XmlEnum(Name = "bs")]
    [EnumMember(Value = "bs")]
    BS,

    /// <summary>
    /// Catalan, Valencian
    /// </summary>
    [XmlEnum(Name = "ca")]
    [EnumMember(Value = "ca")]
    CA,

    /// <summary>
    /// Chechen
    /// </summary>
    [XmlEnum(Name = "ce")]
    [EnumMember(Value = "ce")]
    CE,

    /// <summary>
    /// Chamorro
    /// </summary>
    [XmlEnum(Name = "ch")]
    [EnumMember(Value = "ch")]
    CH,

    /// <summary>
    /// Corsican
    /// </summary>
    [XmlEnum(Name = "co")]
    [EnumMember(Value = "co")]
    CO,

    /// <summary>
    /// Cree
    /// </summary>
    [XmlEnum(Name = "cr")]
    [EnumMember(Value = "cr")]
    CR,

    /// <summary>
    /// Czech
    /// </summary>
    [XmlEnum(Name = "cs")]
    [EnumMember(Value = "cs")]
    CS,

    /// <summary>
    /// Church Slavic, Old Slavonic, Church Slavonic, Old Bulgarian, Old Church Slavonic
    /// </summary>
    [XmlEnum(Name = "cu")]
    [EnumMember(Value = "cu")]
    CU,

    /// <summary>
    /// Chuvash
    /// </summary>
    [XmlEnum(Name = "cv")]
    [EnumMember(Value = "cv")]
    CV,

    /// <summary>
    /// Welsh
    /// </summary>
    [XmlEnum(Name = "cy")]
    [EnumMember(Value = "cy")]
    CY,

    /// <summary>
    /// Danish
    /// </summary>
    [XmlEnum(Name = "da")]
    [EnumMember(Value = "da")]
    DA,

    /// <summary>
    /// German
    /// </summary>
    [XmlEnum(Name = "de")]
    [EnumMember(Value = "de")]
    DE,

    /// <summary>
    /// Divehi, Dhivehi, Maldivian
    /// </summary>
    [XmlEnum(Name = "dv")]
    [EnumMember(Value = "dv")]
    DV,

    /// <summary>
    /// Dzongkha
    /// </summary>
    [XmlEnum(Name = "dz")]
    [EnumMember(Value = "dz")]
    DZ,

    /// <summary>
    /// Ewe
    /// </summary>
    [XmlEnum(Name = "ee")]
    [EnumMember(Value = "ee")]
    EE,

    /// <summary>
    /// Greek, (Modern 1453-)
    /// </summary>
    [XmlEnum(Name = "el")]
    [EnumMember(Value = "el")]
    EL,

    /// <summary>
    /// English
    /// </summary>
    [XmlEnum(Name = "en")]
    [EnumMember(Value = "en")]
    EN,

    /// <summary>
    /// Esperanto
    /// </summary>
    [XmlEnum(Name = "eo")]
    [EnumMember(Value = "eo")]
    EO,

    /// <summary>
    /// Spanish, Castilian
    /// </summary>
    [XmlEnum(Name = "es")]
    [EnumMember(Value = "es")]
    ES,

    /// <summary>
    /// Estonian
    /// </summary>
    [XmlEnum(Name = "et")]
    [EnumMember(Value = "et")]
    ET,

    /// <summary>
    /// Basque
    /// </summary>
    [XmlEnum(Name = "eu")]
    [EnumMember(Value = "eu")]
    EU,

    /// <summary>
    /// Persian
    /// </summary>
    [XmlEnum(Name = "fa")]
    [EnumMember(Value = "fa")]
    FA,

    /// <summary>
    /// Fulah
    /// </summary>
    [XmlEnum(Name = "ff")]
    [EnumMember(Value = "ff")]
    FF,

    /// <summary>
    /// Finnish
    /// </summary>
    [XmlEnum(Name = "fi")]
    [EnumMember(Value = "fi")]
    FI,

    /// <summary>
    /// Fijian
    /// </summary>
    [XmlEnum(Name = "fj")]
    [EnumMember(Value = "fj")]
    FJ,

    /// <summary>
    /// Faroese
    /// </summary>
    [XmlEnum(Name = "fo")]
    [EnumMember(Value = "fo")]
    FO,

    /// <summary>
    /// French
    /// </summary>
    [XmlEnum(Name = "fr")]
    [EnumMember(Value = "fr")]
    FR,

    /// <summary>
    /// Western Frisian
    /// </summary>
    [XmlEnum(Name = "fy")]
    [EnumMember(Value = "fy")]
    FY,

    /// <summary>
    /// Irish
    /// </summary>
    [XmlEnum(Name = "ga")]
    [EnumMember(Value = "ga")]
    GA,

    /// <summary>
    /// Gaelic, Scottish Gaelic
    /// </summary>
    [XmlEnum(Name = "gd")]
    [EnumMember(Value = "gd")]
    GD,

    /// <summary>
    /// Galician
    /// </summary>
    [XmlEnum(Name = "gl")]
    [EnumMember(Value = "gl")]
    GL,

    /// <summary>
    /// Guarani
    /// </summary>
    [XmlEnum(Name = "gn")]
    [EnumMember(Value = "gn")]
    GN,

    /// <summary>
    /// Gujarati
    /// </summary>
    [XmlEnum(Name = "gu")]
    [EnumMember(Value = "gu")]
    GU,

    /// <summary>
    /// Manx
    /// </summary>
    [XmlEnum(Name = "gv")]
    [EnumMember(Value = "gv")]
    GV,

    /// <summary>
    /// Hausa
    /// </summary>
    [XmlEnum(Name = "ha")]
    [EnumMember(Value = "ha")]
    HA,

    /// <summary>
    /// Hebrew
    /// </summary>
    [XmlEnum(Name = "he")]
    [EnumMember(Value = "he")]
    HE,

    /// <summary>
    /// Hindi
    /// </summary>
    [XmlEnum(Name = "hi")]
    [EnumMember(Value = "hi")]
    HI,

    /// <summary>
    /// HiriMotu
    /// </summary>
    [XmlEnum(Name = "ho")]
    [EnumMember(Value = "ho")]
    HO,

    /// <summary>
    /// Croatian
    /// </summary>
    [XmlEnum(Name = "hr")]
    [EnumMember(Value = "hr")]
    HR,

    /// <summary>
    /// Haitian, Haitian Creole
    /// </summary>
    [XmlEnum(Name = "ht")]
    [EnumMember(Value = "ht")]
    HT,

    /// <summary>
    /// Hungarian
    /// </summary>
    [XmlEnum(Name = "hu")]
    [EnumMember(Value = "hu")]
    HU,

    /// <summary>
    /// Armenian
    /// </summary>
    [XmlEnum(Name = "hy")]
    [EnumMember(Value = "hy")]
    HY,

    /// <summary>
    /// Herero
    /// </summary>
    [XmlEnum(Name = "hz")]
    [EnumMember(Value = "hz")]
    HZ,

    /// <summary>
    /// Interlingua (International Auxiliary Language Association)
    /// </summary>
    [XmlEnum(Name = "ia")]
    [EnumMember(Value = "ia")]
    IA,

    /// <summary>
    /// Indonesian
    /// </summary>
    [XmlEnum(Name = "id")]
    [EnumMember(Value = "id")]
    ID,

    /// <summary>
    /// Interlingue, Occidental
    /// </summary>
    [XmlEnum(Name = "ie")]
    [EnumMember(Value = "ie")]
    IE,

    /// <summary>
    /// Igbo
    /// </summary>
    [XmlEnum(Name = "ig")]
    [EnumMember(Value = "ig")]
    IG,

    /// <summary>
    /// Sichuan Yi, Nuosu
    /// </summary>
    [XmlEnum(Name = "Yi")]
    [EnumMember(Value = "Yi")]
    II,

    /// <summary>
    /// Inupiaq
    /// </summary>
    [XmlEnum(Name = "ik")]
    [EnumMember(Value = "ik")]
    IK,

    /// <summary>
    /// Ido
    /// </summary>
    [XmlEnum(Name = "io")]
    [EnumMember(Value = "io")]
    IO,

    /// <summary>
    /// Icelandic
    /// </summary>
    [XmlEnum(Name = "is")]
    [EnumMember(Value = "is")]
    IS,

    /// <summary>
    /// Italian
    /// </summary>
    [XmlEnum(Name = "it")]
    [EnumMember(Value = "it")]
    IT,

    /// <summary>
    /// Inuktitut
    /// </summary>
    [XmlEnum(Name = "iu")]
    [EnumMember(Value = "iu")]
    IU,

    /// <summary>
    /// Japanese
    /// </summary>
    [XmlEnum(Name = "ja")]
    [EnumMember(Value = "ja")]
    JA,

    /// <summary>
    /// Javanese
    /// </summary>
    [XmlEnum(Name = "jv")]
    [EnumMember(Value = "jv")]
    JV,

    /// <summary>
    /// Georgian
    /// </summary>
    [XmlEnum(Name = "ka")]
    [EnumMember(Value = "ka")]
    KA,

    /// <summary>
    /// Kongo
    /// </summary>
    [XmlEnum(Name = "kg")]
    [EnumMember(Value = "kg")]
    KG,

    /// <summary>
    /// Kikuyu, Gikuyu
    /// </summary>
    [XmlEnum(Name = "ki")]
    [EnumMember(Value = "ki")]
    KI,

    /// <summary>
    /// Kuanyama, Kwanyama
    /// </summary>
    [XmlEnum(Name = "kj")]
    [EnumMember(Value = "kj")]
    KJ,

    /// <summary>
    /// Kazakh
    /// </summary>
    [XmlEnum(Name = "kk")]
    [EnumMember(Value = "kk")]
    KK,

    /// <summary>
    /// Kalaallisut, Greenlandic
    /// </summary>
    [XmlEnum(Name = "kl")]
    [EnumMember(Value = "kl")]
    KL,

    /// <summary>
    /// Central Khmer
    /// </summary>
    [XmlEnum(Name = "km")]
    [EnumMember(Value = "km")]
    KM,

    /// <summary>
    /// Kannada
    /// </summary>
    [XmlEnum(Name = "kn")]
    [EnumMember(Value = "kn")]
    KN,

    /// <summary>
    /// Korean
    /// </summary>
    [XmlEnum(Name = "ko")]
    [EnumMember(Value = "ko")]
    KO,

    /// <summary>
    /// Kanuri
    /// </summary>
    [XmlEnum(Name = "kr")]
    [EnumMember(Value = "kr")]
    KR,

    /// <summary>
    /// Kashmiri
    /// </summary>
    [XmlEnum(Name = "ks")]
    [EnumMember(Value = "ks")]
    KS,

    /// <summary>
    /// Kurdish
    /// </summary>
    [XmlEnum(Name = "ku")]
    [EnumMember(Value = "ku")]
    KU,

    /// <summary>
    /// Komi
    /// </summary>
    [XmlEnum(Name = "kv")]
    [EnumMember(Value = "kv")]
    KV,

    /// <summary>
    /// Cornish
    /// </summary>
    [XmlEnum(Name = "kw")]
    [EnumMember(Value = "kw")]
    KW,

    /// <summary>
    /// Kirghiz, Kyrgyz
    /// </summary>
    [XmlEnum(Name = "ky")]
    [EnumMember(Value = "ky")]
    KY,

    /// <summary>
    /// Latin
    /// </summary>
    [XmlEnum(Name = "la")]
    [EnumMember(Value = "la")]
    LA,

    /// <summary>
    /// Luxembourgish, Letzeburgesch
    /// </summary>
    [XmlEnum(Name = "lb")]
    [EnumMember(Value = "lb")]
    LB,

    /// <summary>
    /// Ganda
    /// </summary>
    [XmlEnum(Name = "lg")]
    [EnumMember(Value = "lg")]
    LG,

    /// <summary>
    /// Limburgan, Limburger, Limburgish
    /// </summary>
    [XmlEnum(Name = "li")]
    [EnumMember(Value = "li")]
    LI,

    /// <summary>
    /// Lingala
    /// </summary>
    [XmlEnum(Name = "ln")]
    [EnumMember(Value = "ln")]
    LN,

    /// <summary>
    /// Lao
    /// </summary>
    [XmlEnum(Name = "lo")]
    [EnumMember(Value = "lo")]
    LO,

    /// <summary>
    /// Lithuanian
    /// </summary>
    [XmlEnum(Name = "lt")]
    [EnumMember(Value = "lt")]
    LT,

    /// <summary>
    /// LubaKatanga
    /// </summary>
    [XmlEnum(Name = "lu")]
    [EnumMember(Value = "lu")]
    LU,

    /// <summary>
    /// Latvian
    /// </summary>
    [XmlEnum(Name = "lv")]
    [EnumMember(Value = "lv")]
    LV,

    /// <summary>
    /// Malagasy
    /// </summary>
    [XmlEnum(Name = "mg")]
    [EnumMember(Value = "mg")]
    MG,

    /// <summary>
    /// Marshallese
    /// </summary>
    [XmlEnum(Name = "mh")]
    [EnumMember(Value = "mh")]
    MH,

    /// <summary>
    /// Maori
    /// </summary>
    [XmlEnum(Name = "mi")]
    [EnumMember(Value = "mi")]
    MI,

    /// <summary>
    /// Macedonian
    /// </summary>
    [XmlEnum(Name = "mk")]
    [EnumMember(Value = "mk")]
    MK,

    /// <summary>
    /// Malayalam
    /// </summary>
    [XmlEnum(Name = "ml")]
    [EnumMember(Value = "ml")]
    ML,

    /// <summary>
    /// Mongolian
    /// </summary>
    [XmlEnum(Name = "mn")]
    [EnumMember(Value = "mn")]
    MN,

    /// <summary>
    /// Marathi
    /// </summary>
    [XmlEnum(Name = "mr")]
    [EnumMember(Value = "mr")]
    MR,

    /// <summary>
    /// Malay
    /// </summary>
    [XmlEnum(Name = "ms")]
    [EnumMember(Value = "ms")]
    MS,

    /// <summary>
    /// Maltese
    /// </summary>
    [XmlEnum(Name = "mt")]
    [EnumMember(Value = "mt")]
    MT,

    /// <summary>
    /// Burmese
    /// </summary>
    [XmlEnum(Name = "my")]
    [EnumMember(Value = "my")]
    MY,

    /// <summary>
    /// Nauru
    /// </summary>
    [XmlEnum(Name = "na")]
    [EnumMember(Value = "na")]
    NA,

    /// <summary>
    /// Norwegian Bokmal
    /// </summary>
    [XmlEnum(Name = "nb")]
    [EnumMember(Value = "nb")]
    NB,

    /// <summary>
    /// North Ndebele
    /// </summary>
    [XmlEnum(Name = "nd")]
    [EnumMember(Value = "nd")]
    ND,

    /// <summary>
    /// Nepali
    /// </summary>
    [XmlEnum(Name = "ne")]
    [EnumMember(Value = "ne")]
    NE,

    /// <summary>
    /// Ndonga
    /// </summary>
    [XmlEnum(Name = "ng")]
    [EnumMember(Value = "ng")]
    NG,

    /// <summary>
    /// Dutch, Flemish
    /// </summary>
    [XmlEnum(Name = "nl")]
    [EnumMember(Value = "nl")]
    NL,

    /// <summary>
    /// Norwegian
    /// </summary>
    [XmlEnum(Name = "no")]
    [EnumMember(Value = "no")]
    NO,

    /// <summary>
    /// Norwegian Nynorsk
    /// </summary>
    [XmlEnum(Name = "nn")]
    [EnumMember(Value = "nn")]
    NN,

    /// <summary>
    /// South Ndebele
    /// </summary>
    [XmlEnum(Name = "nr")]
    [EnumMember(Value = "nr")]
    NR,

    /// <summary>
    /// Navajo, Navaho
    /// </summary>
    [XmlEnum(Name = "nv")]
    [EnumMember(Value = "nv")]
    NV,

    /// <summary>
    /// Chichewa, Chewa, Nyanja
    /// </summary>
    [XmlEnum(Name = "ny")]
    [EnumMember(Value = "ny")]
    NY,

    /// <summary>
    /// Occitan
    /// </summary>
    [XmlEnum(Name = "oc")]
    [EnumMember(Value = "oc")]
    OC,

    /// <summary>
    /// Ojibwa
    /// </summary>
    [XmlEnum(Name = "oj")]
    [EnumMember(Value = "oj")]
    OJ,

    /// <summary>
    /// Oromo
    /// </summary>
    [XmlEnum(Name = "om")]
    [EnumMember(Value = "om")]
    OM,

    /// <summary>
    /// Oriya
    /// </summary>
    [XmlEnum(Name = "or")]
    [EnumMember(Value = "or")]
    OR,

    /// <summary>
    /// Ossetian, Ossetic
    /// </summary>
    [XmlEnum(Name = "os")]
    [EnumMember(Value = "os")]
    OS,

    /// <summary>
    /// Punjabi, Panjabi
    /// </summary>
    [XmlEnum(Name = "pa")]
    [EnumMember(Value = "pa")]
    PA,

    /// <summary>
    /// Pali
    /// </summary>
    [XmlEnum(Name = "pi")]
    [EnumMember(Value = "pi")]
    PI,

    /// <summary>
    /// Polish
    /// </summary>
    [XmlEnum(Name = "pl")]
    [EnumMember(Value = "pl")]
    PL,

    /// <summary>
    /// Pashto, Pushto
    /// </summary>
    [XmlEnum(Name = "ps")]
    [EnumMember(Value = "ps")]
    PS,

    /// <summary>
    /// Portuguese
    /// </summary>
    [XmlEnum(Name = "pt")]
    [EnumMember(Value = "pt")]
    PT,

    /// <summary>
    /// Quechua
    /// </summary>
    [XmlEnum(Name = "qu")]
    [EnumMember(Value = "qu")]
    QU,

    /// <summary>
    /// Romansh
    /// </summary>
    [XmlEnum(Name = "rm")]
    [EnumMember(Value = "rm")]
    RM,

    /// <summary>
    /// Rundi
    /// </summary>
    [XmlEnum(Name = "rn")]
    [EnumMember(Value = "rn")]
    RN,

    /// <summary>
    /// Romanian, Moldavian, Moldovan
    /// </summary>
    [XmlEnum(Name = "ro")]
    [EnumMember(Value = "ro")]
    RO,

    /// <summary>
    /// Russian
    /// </summary>
    [XmlEnum(Name = "ru")]
    [EnumMember(Value = "ru")]
    RU,

    /// <summary>
    /// Kinyarwanda
    /// </summary>
    [XmlEnum(Name = "rw")]
    [EnumMember(Value = "rw")]
    RW,

    /// <summary>
    /// Sanskrit
    /// </summary>
    [XmlEnum(Name = "sa")]
    [EnumMember(Value = "sa")]
    SA,

    /// <summary>
    /// Sardinian
    /// </summary>
    [XmlEnum(Name = "sc")]
    [EnumMember(Value = "sc")]
    SC,

    /// <summary>
    /// Sindhi
    /// </summary>
    [XmlEnum(Name = "sd")]
    [EnumMember(Value = "sd")]
    SD,

    /// <summary>
    /// Northern Sami
    /// </summary>
    [XmlEnum(Name = "se")]
    [EnumMember(Value = "se")]
    SE,

    /// <summary>
    /// Sango
    /// </summary>
    [XmlEnum(Name = "sg")]
    [EnumMember(Value = "sg")]
    SG,

    /// <summary>
    /// Sinhala, Sinhalese
    /// </summary>
    [XmlEnum(Name = "si")]
    [EnumMember(Value = "si")]
    SI,

    /// <summary>
    /// Slovak
    /// </summary>
    [XmlEnum(Name = "sk")]
    [EnumMember(Value = "sk")]
    SK,

    /// <summary>
    /// Slovenian
    /// </summary>
    [XmlEnum(Name = "sl")]
    [EnumMember(Value = "sl")]
    SL,

    /// <summary>
    /// Samoan
    /// </summary>
    [XmlEnum(Name = "sm")]
    [EnumMember(Value = "sm")]
    SM,

    /// <summary>
    /// Shona
    /// </summary>
    [XmlEnum(Name = "sn")]
    [EnumMember(Value = "sn")]
    SN,

    /// <summary>
    /// Somali
    /// </summary>
    [XmlEnum(Name = "so")]
    [EnumMember(Value = "so")]
    SO,

    /// <summary>
    /// Albanian
    /// </summary>
    [XmlEnum(Name = "sq")]
    [EnumMember(Value = "sq")]
    SQ,

    /// <summary>
    /// Serbian
    /// </summary>
    [XmlEnum(Name = "sr")]
    [EnumMember(Value = "sr")]
    SR,

    /// <summary>
    /// Swati
    /// </summary>
    [XmlEnum(Name = "ss")]
    [EnumMember(Value = "ss")]
    SS,

    /// <summary>
    /// Southern Sotho
    /// </summary>
    [XmlEnum(Name = "st")]
    [EnumMember(Value = "st")]
    ST,

    /// <summary>
    /// Sundanese
    /// </summary>
    [XmlEnum(Name = "su")]
    [EnumMember(Value = "su")]
    SU,

    /// <summary>
    /// Swedish
    /// </summary>
    [XmlEnum(Name = "sv")]
    [EnumMember(Value = "sv")]
    SV,

    /// <summary>
    /// Swahili
    /// </summary>
    [XmlEnum(Name = "sw")]
    [EnumMember(Value = "sw")]
    SW,

    /// <summary>
    /// Tamil
    /// </summary>
    [XmlEnum(Name = "ta")]
    [EnumMember(Value = "ta")]
    TA,

    /// <summary>
    /// Telugu
    /// </summary>
    [XmlEnum(Name = "te")]
    [EnumMember(Value = "te")]
    TE,

    /// <summary>
    /// Tajik
    /// </summary>
    [XmlEnum(Name = "tg")]
    [EnumMember(Value = "tg")]
    TG,

    /// <summary>
    /// Thai
    /// </summary>
    [XmlEnum(Name = "th")]
    [EnumMember(Value = "th")]
    TH,

    /// <summary>
    /// Tigrinya
    /// </summary>
    [XmlEnum(Name = "ti")]
    [EnumMember(Value = "ti")]
    TI,

    /// <summary>
    /// Turkmen
    /// </summary>
    [XmlEnum(Name = "tk")]
    [EnumMember(Value = "tk")]
    TK,

    /// <summary>
    /// Tagalog
    /// </summary>
    [XmlEnum(Name = "tl")]
    [EnumMember(Value = "tl")]
    TL,

    /// <summary>
    /// Tswana
    /// </summary>
    [XmlEnum(Name = "tn")]
    [EnumMember(Value = "tn")]
    TN,

    /// <summary>
    /// Tonga
    /// </summary>
    [XmlEnum(Name = "to")]
    [EnumMember(Value = "to")]
    TO,

    /// <summary>
    /// Turkish
    /// </summary>
    [XmlEnum(Name = "tr")]
    [EnumMember(Value = "tr")]
    TR,

    /// <summary>
    /// Tsonga
    /// </summary>
    [XmlEnum(Name = "ts")]
    [EnumMember(Value = "ts")]
    TS,

    /// <summary>
    /// Tatar
    /// </summary>
    [XmlEnum(Name = "tt")]
    [EnumMember(Value = "tt")]
    TT,

    /// <summary>
    /// Twi
    /// </summary>
    [XmlEnum(Name = "tw")]
    [EnumMember(Value = "tw")]
    TW,

    /// <summary>
    /// Tahitian
    /// </summary>
    [XmlEnum(Name = "ty")]
    [EnumMember(Value = "ty")]
    TY,

    /// <summary>
    /// Uighur, Uyghur
    /// </summary>
    [XmlEnum(Name = "ug")]
    [EnumMember(Value = "ug")]
    UG,

    /// <summary>
    /// Ukrainian
    /// </summary>
    [XmlEnum(Name = "uk")]
    [EnumMember(Value = "uk")]
    UK,

    /// <summary>
    /// Urdu
    /// </summary>
    [XmlEnum(Name = "ur")]
    [EnumMember(Value = "ur")]
    UR,

    /// <summary>
    /// Uzbek
    /// </summary>
    [XmlEnum(Name = "uz")]
    [EnumMember(Value = "uz")]
    UZ,

    /// <summary>
    /// Venda
    /// </summary>
    [XmlEnum(Name = "ve")]
    [EnumMember(Value = "ve")]
    VE,

    /// <summary>
    /// Vietnamese
    /// </summary>
    [XmlEnum(Name = "vi")]
    [EnumMember(Value = "vi")]
    VI,

    /// <summary>
    /// Volapük
    /// </summary>
    [XmlEnum(Name = "vo")]
    [EnumMember(Value = "vo")]
    VO,

    /// <summary>
    /// Walloon
    /// </summary>
    [XmlEnum(Name = "wa")]
    [EnumMember(Value = "wa")]
    WA,

    /// <summary>
    /// Wolof
    /// </summary>
    [XmlEnum(Name = "wo")]
    [EnumMember(Value = "wo")]
    WO,

    /// <summary>
    /// Xhosa
    /// </summary>
    [XmlEnum(Name = "xh")]
    [EnumMember(Value = "xh")]
    XH,

    /// <summary>
    /// Yiddish
    /// </summary>
    [XmlEnum(Name = "yi")]
    [EnumMember(Value = "yi")]
    YI,

    /// <summary>
    /// Yoruba
    /// </summary>
    [XmlEnum(Name = "yo")]
    [EnumMember(Value = "yo")]
    YO,

    /// <summary>
    /// Zhuang, Chuang
    /// </summary>
    [XmlEnum(Name = "za")]
    [EnumMember(Value = "za")]
    ZA,

    /// <summary>
    /// Chinese
    /// </summary>
    [XmlEnum(Name = "zh")]
    [EnumMember(Value = "zh")]
    ZH,

    /// <summary>
    /// Zulu
    /// </summary>
    [XmlEnum(Name = "zu")]
    [EnumMember(Value = "zu")]
    ZU,



    // TODO: The following values are those that were originally generated by the ISO 639-1 schema. They are a subset of the values added above from the wikipedia article (https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes)
    // TODO: Add the [XmlEnum()] Attributes and capitalize the language codes.

    //aa,
    //ab,
    //af,
    //am,
    //ar,
    //@as,
    //ay,
    //az,
    //ba,
    //be,
    //bg,
    //bh,
    //bi,
    //bn,
    //bo,
    //br,
    //ca,
    //co,
    //cs,
    //cy,
    //da,
    //de,
    //dz,
    //el,
    //en,
    //eo,
    //es,
    //et,
    //eu,
    //fa,
    //fi,
    //fj,
    //fo,
    //fr,
    //fy,
    //ga,
    //gd,
    //gl,
    //gn,
    //gu,
    //ha,
    //hi,
    //hr,
    //hu,
    //hy,
    //ia,
    //ie,
    //ik,
    //@in,
    //@is,
    //it,
    //iw,
    //ja,
    //ji,
    //jw,
    //ka,
    //kk,
    //kl,
    //km,
    //kn,
    //ko,
    //ks,
    //ku,
    //ky,
    //la,
    //ln,
    //lo,
    //lt,
    //lv,
    //mg,
    //mi,
    //mk,
    //ml,
    //mn,
    //mo,

    //// TODO: Why is this fr1 ???
    //[XmlEnumAttribute("fr")]
    //[EnumMember(Value = "fr")]
    //fr1,

    //ms,
    //mt,
    //my,
    //na,
    //ne,
    //nl,
    //no,
    //oc,
    //om,
    //or,
    //pa,
    //pl,
    //ps,
    //pt,
    //qu,
    //rm,
    //rn,
    //ro,
    //ru,
    //rw,
    //sa,
    //sd,
    //sg,
    //sh,
    //si,
    //sk,
    //sl,
    //sm,
    //sn,
    //so,
    //sq,
    //sr,
    //ss,
    //st,
    //su,
    //sv,
    //sw,
    //ta,
    //te,
    //tg,
    //th,
    //ti,
    //tk,
    //tl,
    //tn,
    //to,
    //tr,
    //ts,
    //tt,
    //tw,
    //uk,
    //ur,
    //uz,
    //vi,
    //vo,
    //wo,
    //xh,
    //yo,
    //zh,
    //zu,

  }

}
