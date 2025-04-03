
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Grids {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GridEnvelopeType")]
  public class GridEnvelopeType : Model {
    #region Private fields
    private string _low;
    private string _high;
    #endregion

    [XmlElement(Order = 0)]
    [JsonProperty("low", Order = 0)]
    public string low {
      get {
        return _low;
      }
      set {
        if (_low == value) {
          return;
        }
        if (_low == null || _low.Equals(value) != true) {
          _low = value;
          OnPropertyChanged("low");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("high", Order = 1)]
    public string high {
      get {
        return _high;
      }
      set {
        if (_high == value) {
          return;
        }
        if (_high == null || _high.Equals(value) != true) {
          _high = value;
          OnPropertyChanged("high");
        }
      }
    }
  }
}