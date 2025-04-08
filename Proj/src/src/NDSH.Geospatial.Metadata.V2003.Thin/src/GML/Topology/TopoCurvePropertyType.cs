
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Topology {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TopoCurvePropertyType")]
  public class TopoCurvePropertyType : Model {
    #region Private fields
    private TopoCurveType _topoCurve;
    private bool _owns;
    #endregion

    /// <summary>
    /// TopoCurvePropertyType class constructor
    /// </summary>
    public TopoCurvePropertyType() {
      _topoCurve = new TopoCurveType();
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TopoCurve", Order = 0)]
    public TopoCurveType TopoCurve {
      get {
        return _topoCurve;
      }
      set {
        if (_topoCurve == value) {
          return;
        }
        if (_topoCurve == null || _topoCurve.Equals(value) != true) {
          _topoCurve = value;
          OnPropertyChanged("TopoCurve");
        }
      }
    }

    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty("owns")]
    public bool owns {
      get {
        return _owns;
      }
      set {
        if (_owns.Equals(value) != true) {
          _owns = value;
          OnPropertyChanged("owns");
        }
      }
    }
  }
}