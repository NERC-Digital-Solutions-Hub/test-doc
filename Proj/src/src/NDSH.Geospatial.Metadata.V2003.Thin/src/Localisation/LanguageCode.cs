
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/01/2023, 00:26, @gisvlasta.
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
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

// TODO: Investigate if this class needs to be in a different assembly file.

namespace NDSH.Geospatial.Metadata.V2003.Thin.Localisation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("LanguageCode", Namespace = "", IsNullable = false)] // TODO: Namespace ???
  [JsonObject("LanguageCode")]
  public class LanguageCode : Model {

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private LanguageCodeValue _value;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("value")]
    [JsonProperty("value")]
    [JsonConverter(typeof(StringEnumConverter))]
    public LanguageCodeValue Value {
      get {
        return _value;
      }
      set {
        if (_value != value) {
          _value = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
