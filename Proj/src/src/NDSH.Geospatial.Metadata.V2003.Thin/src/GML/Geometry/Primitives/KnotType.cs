using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("KnotType")]
  public class KnotType : Model {
    #region Private fields
    private double _value;
    private string _multiplicity;
    private double _weight;
    #endregion

    [XmlElement(Order = 0)]
    [JsonProperty("value", Order = 0)]
    public double value {
      get {
        return _value;
      }
      set {
        if (_value.Equals(value) != true) {
          _value = value;
          OnPropertyChanged("value");
        }
      }
    }

    [XmlElement(DataType = "nonNegativeInteger", Order = 1)]
    [JsonProperty("multiplicity", Order = 1)]
    public string multiplicity {
      get {
        return _multiplicity;
      }
      set {
        if (_multiplicity == value) {
          return;
        }
        if (_multiplicity == null || _multiplicity.Equals(value) != true) {
          _multiplicity = value;
          OnPropertyChanged("multiplicity");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("weight", Order = 2)]
    public double weight {
      get {
        return _weight;
      }
      set {
        if (_weight.Equals(value) != true) {
          _weight = value;
          OnPropertyChanged("weight");
        }
      }
    }
  }

}
