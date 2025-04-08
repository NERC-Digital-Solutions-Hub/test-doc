
using NDSH.Apps;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Grids {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GridLimitsType")]
  public class GridLimitsType : ObservableModel {
    #region Private fields
    private GridEnvelopeType _gridEnvelope;
    #endregion

    /// <summary>
    /// GridLimitsType class constructor
    /// </summary>
    public GridLimitsType() {
      _gridEnvelope = new GridEnvelopeType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("GridEnvelope", Order = 0)]
    public GridEnvelopeType GridEnvelope {
      get {
        return _gridEnvelope;
      }
      set {
        if (_gridEnvelope == value) {
          return;
        }
        if (_gridEnvelope == null || _gridEnvelope.Equals(value) != true) {
          _gridEnvelope = value;
          OnPropertyChanged("GridEnvelope");
        }
      }
    }
  }
}
