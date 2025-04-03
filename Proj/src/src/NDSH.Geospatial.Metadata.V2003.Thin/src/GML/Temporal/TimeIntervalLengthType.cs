using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Temporal {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeIntervalLengthType")]
  public class TimeIntervalLengthType : Model {
    #region Private fields
    private string _unit;
    private string _radix;
    private string _factor;
    private decimal _value;
    #endregion

    [XmlAttribute]
    [JsonProperty("unit")]
    public string unit {
      get {
        return _unit;
      }
      set {
        if (_unit == value) {
          return;
        }
        if (_unit == null || _unit.Equals(value) != true) {
          _unit = value;
          OnPropertyChanged("unit");
        }
      }
    }

    [XmlAttribute(DataType = "positiveInteger")]
    [JsonProperty("radix")]
    public string radix {
      get {
        return _radix;
      }
      set {
        if (_radix == value) {
          return;
        }
        if (_radix == null || _radix.Equals(value) != true) {
          _radix = value;
          OnPropertyChanged("radix");
        }
      }
    }

    [XmlAttribute(DataType = "integer")]
    [JsonProperty("factor")]
    public string factor {
      get {
        return _factor;
      }
      set {
        if (_factor == value) {
          return;
        }
        if (_factor == null || _factor.Equals(value) != true) {
          _factor = value;
          OnPropertyChanged("factor");
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
