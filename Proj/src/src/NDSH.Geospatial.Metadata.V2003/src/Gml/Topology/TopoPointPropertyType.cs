
#region Imported Namespaces

using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Topology {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TopoPointPropertyType")]
  public class TopoPointPropertyType : ObservableModel {

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
