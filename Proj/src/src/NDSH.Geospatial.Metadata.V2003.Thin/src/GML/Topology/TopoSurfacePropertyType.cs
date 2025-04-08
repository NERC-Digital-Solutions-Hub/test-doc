
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
  [JsonObject("TopoSurfacePropertyType")]
  public class TopoSurfacePropertyType : Model {
    #region Private fields
    private TopoSurfaceType _topoSurface;
    private bool _owns;
    #endregion

    /// <summary>
    /// TopoSurfacePropertyType class constructor
    /// </summary>
    public TopoSurfacePropertyType() {
      _topoSurface = new TopoSurfaceType();
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TopoSurface", Order = 0)]
    public TopoSurfaceType TopoSurface {
      get {
        return _topoSurface;
      }
      set {
        if (_topoSurface == value) {
          return;
        }
        if (_topoSurface == null || _topoSurface.Equals(value) != true) {
          _topoSurface = value;
          OnPropertyChanged("TopoSurface");
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