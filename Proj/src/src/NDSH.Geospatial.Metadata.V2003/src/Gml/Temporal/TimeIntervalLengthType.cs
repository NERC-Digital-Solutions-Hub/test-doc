using NDSH.Apps;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Temporal {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeIntervalLengthType")]
  public class TimeIntervalLengthType : ObservableModel {
    #region Private fields
    private string _unit;
    private string _radix;
    private string _factor;
    private decimal _value;
    #endregion

    [XmlAttribute]
    [JsonProperty("unit")]
    public string Unit {
      get {
        return _unit;
      }
      set {
        if (_unit == value) {
          return;
        }
        if (_unit == null || _unit.Equals(value) != true) {
          _unit = value;
          OnPropertyChanged("Unit");
        }
      }
    }

    [XmlAttribute(DataType = "positiveInteger")]
    [JsonProperty("radix")]
    public string Radix {
      get {
        return _radix;
      }
      set {
        if (_radix == value) {
          return;
        }
        if (_radix == null || _radix.Equals(value) != true) {
          _radix = value;
          OnPropertyChanged("Radix");
        }
      }
    }

    [XmlAttribute(DataType = "integer")]
    [JsonProperty("factor")]
    public string Factor {
      get {
        return _factor;
      }
      set {
        if (_factor == value) {
          return;
        }
        if (_factor == null || _factor.Equals(value) != true) {
          _factor = value;
          OnPropertyChanged("Factor");
        }
      }
    }

    [XmlTextAttribute]
    [JsonProperty("Value")]
    public decimal Value {
      get {
        return _value;
      }
      set {
        if (_value.Equals(value) != true) {
          _value = value;
          OnPropertyChanged("Value");
        }
      }
    }
  }

}
