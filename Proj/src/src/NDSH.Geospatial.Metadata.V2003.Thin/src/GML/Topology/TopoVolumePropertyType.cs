
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
  [JsonObject("TopoVolumePropertyType")]
  public class TopoVolumePropertyType : Model {
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