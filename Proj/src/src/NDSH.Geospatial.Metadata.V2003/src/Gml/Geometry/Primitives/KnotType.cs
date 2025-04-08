using NDSH.Apps;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("KnotType")]
  public class KnotType : ObservableModel {
    #region Private fields
    private double _value;
    private string _multiplicity;
    private double _weight;
    #endregion

    [XmlElement(Order = 0)]
    [JsonProperty("value", Order = 0)]
    public double Value {
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

    [XmlElement(DataType = "nonNegativeInteger", Order = 1)]
    [JsonProperty("multiplicity", Order = 1)]
    public string Multiplicity {
      get {
        return _multiplicity;
      }
      set {
        if (_multiplicity == value) {
          return;
        }
        if (_multiplicity == null || _multiplicity.Equals(value) != true) {
          _multiplicity = value;
          OnPropertyChanged("Multiplicity");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("weight", Order = 2)]
    public double Weight {
      get {
        return _weight;
      }
      set {
        if (_weight.Equals(value) != true) {
          _weight = value;
          OnPropertyChanged("Weight");
        }
      }
    }
  }

}
