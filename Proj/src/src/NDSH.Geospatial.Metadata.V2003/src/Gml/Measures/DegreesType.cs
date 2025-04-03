
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 31/01/2023, 20:56, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Gml.Measures {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DegreesType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DegreesType")]
  public class DegreesType : ObservableModel {

    #region Public Properties

    private DegreesTypeDirection _direction;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("direction")]
    public DegreesTypeDirection Direction {
      get {
        return _direction;
      }
      set {
        if (_direction.Equals(value) != true) {
          _direction = value;
          OnPropertyChanged();
        }
      }
    }

    private string _value;

    /// <summary>
    /// 
    /// </summary>
    [XmlText(DataType = "nonNegativeInteger")]
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
