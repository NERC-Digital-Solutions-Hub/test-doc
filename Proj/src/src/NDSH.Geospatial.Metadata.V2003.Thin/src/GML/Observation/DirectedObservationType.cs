
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Direction;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Observation {


  [XmlInclude(typeof(DirectedObservationAtDistanceType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DirectedObservationType")]
  public class DirectedObservationType : ObservationType {
    #region Private fields
    private DirectionPropertyType _direction;
    #endregion

    /// <summary>
    /// DirectedObservationType class constructor
    /// </summary>
    public DirectedObservationType() {
      _direction = new DirectionPropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("direction", Order = 0)]
    public DirectionPropertyType direction {
      get {
        return _direction;
      }
      set {
        if (_direction == value) {
          return;
        }
        if (_direction == null || _direction.Equals(value) != true) {
          _direction = value;
          OnPropertyChanged("direction");
        }
      }
    }
  }
}