﻿using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("SolidType")]
  public class SolidType : AbstractSolidType {
    #region Private fields
    private ShellPropertyType _exterior;
    private List<ShellPropertyType> _interior;
    #endregion

    /// <summary>
    /// SolidType class constructor
    /// </summary>
    public SolidType() {
      _interior = new List<ShellPropertyType>();
      _exterior = new ShellPropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("exterior", Order = 0)]
    public ShellPropertyType Exterior {
      get {
        return _exterior;
      }
      set {
        if (_exterior == value) {
          return;
        }
        if (_exterior == null || _exterior.Equals(value) != true) {
          _exterior = value;
          OnPropertyChanged("Exterior");
        }
      }
    }

    [XmlElement("interior", Order = 1)]
    [JsonProperty("interior", Order = 1)]
    public List<ShellPropertyType> Interior {
      get {
        return _interior;
      }
      set {
        if (_interior == value) {
          return;
        }
        if (_interior == null || _interior.Equals(value) != true) {
          _interior = value;
          OnPropertyChanged("Interior");
        }
      }
    }
  }

}
