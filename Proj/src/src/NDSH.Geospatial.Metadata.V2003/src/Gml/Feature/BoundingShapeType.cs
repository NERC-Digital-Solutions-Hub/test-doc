
using NDSH.Apps;
using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic0D1D;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Feature {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("BoundingShapeType")]
  public class BoundingShapeType : ObservableModel {
    #region Private fields
    private object _item;
    private string _nilReason;
    #endregion

    [XmlElement("Envelope", typeof(EnvelopeType), Order = 0)]
    [XmlElement("Null", typeof(string), Order = 0)]
    public object Item {
      get {
        return _item;
      }
      set {
        if (_item == value) {
          return;
        }
        if (_item == null || _item.Equals(value) != true) {
          _item = value;
          OnPropertyChanged("Item");
        }
      }
    }

    [XmlAttribute]
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
          OnPropertyChanged("NilReason");
        }
      }
    }
  }
}
