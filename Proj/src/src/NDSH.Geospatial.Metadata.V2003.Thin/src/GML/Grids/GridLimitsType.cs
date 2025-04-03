
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
  [JsonObject("GridLimitsType")]
  public class GridLimitsType : Model {
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