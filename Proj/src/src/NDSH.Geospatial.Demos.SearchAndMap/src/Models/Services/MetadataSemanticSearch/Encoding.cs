
#region Imported Namespaces

using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Demos.SearchAndMap.Models.Services.MetadataSemanticSearch {

  /// <summary>
  /// The possible metadata semantic search service encodings.
  /// </summary>
  public enum Encoding {

    /// <summary>
    /// ASCII encoding.
    /// </summary>
    [EnumMember(Value = "ASCII")]
    Ascii,

    /// <summary>
    /// Unicode encoding
    /// </summary>
    [EnumMember(Value = "Unicode")]
    Unicode,

    /// <summary>
    /// UTF7 encoding.
    /// </summary>
    [EnumMember(Value = "UTF-7")]
    Utf7,

    /// <summary>
    /// UTF8 encoding.
    /// </summary>
    [EnumMember(Value = "UTF-8")]
    Utf8,

    /// <summary>
    /// UTF32 encoding.
    /// </summary>
    [EnumMember(Value = "UTF-32")]
    Utf32,

  }

}
