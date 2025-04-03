
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 01/02/2023, 19:31, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Apps;
using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.ValueObjects {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("Count", AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
  [JsonObject("Count")]
  public class Count : ObservableModel {

    #region Public Properties

    private string _nilReason;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("nilReason")]
    [JsonProperty("nilReason")]
    public string NilReason {
      get {
        return _nilReason;
      }
      set {
        if (_nilReason == value) {
          return;
        }
        if (_nilReason == null || _nilReason.Equals(value) != true) {
          _nilReason = value;
          OnPropertyChanged();
        }
      }
    }

    private string _value;

    /// <summary>
    /// 
    /// </summary>
    [XmlText(DataType = "integer")]
    [JsonProperty("Value")]
    public string Value {
      get {
        return _value;
      }
      set {
        if (_value == value) {
          return;
        }
        if (_value == null || _value.Equals(value) != true) {
          _value = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
