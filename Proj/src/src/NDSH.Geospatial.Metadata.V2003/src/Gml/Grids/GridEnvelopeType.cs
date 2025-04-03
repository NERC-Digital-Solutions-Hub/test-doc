
using NDSH.Apps;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Grids {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GridEnvelopeType")]
  public class GridEnvelopeType : ObservableModel {
    #region Private fields
    private string _low;
    private string _high;
    #endregion

    [XmlElement(Order = 0)]
    [JsonProperty("low", Order = 0)]
    public string Low {
      get {
        return _low;
      }
      set {
        if (_low == value) {
          return;
        }
        if (_low == null || _low.Equals(value) != true) {
          _low = value;
          OnPropertyChanged("Low");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("high", Order = 1)]
    public string High {
      get {
        return _high;
      }
      set {
        if (_high == value) {
          return;
        }
        if (_high == null || _high.Equals(value) != true) {
          _high = value;
          OnPropertyChanged("High");
        }
      }
    }
  }
}
