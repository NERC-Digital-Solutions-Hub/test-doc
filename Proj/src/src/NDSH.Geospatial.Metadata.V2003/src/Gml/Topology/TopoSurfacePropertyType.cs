
#region Imported Namespaces

using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Topology {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TopoSurfacePropertyType")]
  public class TopoSurfacePropertyType : ObservableModel {

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
    public bool Owns {
      get {
        return _owns;
      }
      set {
        if (_owns.Equals(value) != true) {
          _owns = value;
          OnPropertyChanged("Owns");
        }
      }
    }

  }

}
