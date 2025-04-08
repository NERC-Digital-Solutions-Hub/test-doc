
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Measures;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Observation {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DirectedObservationAtDistanceType")]
  public class DirectedObservationAtDistanceType : DirectedObservationType {
    #region Private fields
    private MeasureType _distance;
    #endregion

    /// <summary>
    /// DirectedObservationAtDistanceType class constructor
    /// </summary>
    public DirectedObservationAtDistanceType() {
      _distance = new MeasureType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("distance", Order = 0)]
    public MeasureType distance {
      get {
        return _distance;
      }
      set {
        if (_distance == value) {
          return;
        }
        if (_distance == null || _distance.Equals(value) != true) {
          _distance = value;
          OnPropertyChanged("distance");
        }
      }
    }
  }
}