
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
  [JsonObject("TopoPointPropertyType")]
  public class TopoPointPropertyType : Model {
    #region Private fields
    private TopoPointType _topoPoint;
    private bool _owns;
    #endregion

    /// <summary>
    /// TopoPointPropertyType class constructor
    /// </summary>
    public TopoPointPropertyType() {
      _topoPoint = new TopoPointType();
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TopoPoint", Order = 0)]
    public TopoPointType TopoPoint {
      get {
        return _topoPoint;
      }
      set {
        if (_topoPoint == value) {
          return;
        }
        if (_topoPoint == null || _topoPoint.Equals(value) != true) {
          _topoPoint = value;
          OnPropertyChanged("TopoPoint");
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