
#region Imported Namespaces

using NDSH.Apps;
using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Topology {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TopoVolumePropertyType")]
  public class TopoVolumePropertyType : ObservableModel {

    #region Private fields
    private TopoVolumeType _topoVolume;
    private bool _owns;
    #endregion

    /// <summary>
    /// TopoVolumePropertyType class constructor
    /// </summary>
    public TopoVolumePropertyType() {
      _topoVolume = new TopoVolumeType();
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TopoVolume", Order = 0)]
    public TopoVolumeType TopoVolume {
      get {
        return _topoVolume;
      }
      set {
        if (_topoVolume == value) {
          return;
        }
        if (_topoVolume == null || _topoVolume.Equals(value) != true) {
          _topoVolume = value;
          OnPropertyChanged("TopoVolume");
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
