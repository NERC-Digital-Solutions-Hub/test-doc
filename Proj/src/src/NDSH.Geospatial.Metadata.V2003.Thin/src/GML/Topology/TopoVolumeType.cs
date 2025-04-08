
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML.GmlBase;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Topology {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TopoVolumeType")]
  public class TopoVolumeType : AbstractTopologyType {
    #region Private fields
    private List<DirectedTopoSolidPropertyType> _directedTopoSolid;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// TopoVolumeType class constructor
    /// </summary>
    public TopoVolumeType() {
      _directedTopoSolid = new List<DirectedTopoSolidPropertyType>();
    }

    [XmlElement("directedTopoSolid", Order = 0)]
    [JsonProperty("directedTopoSolid", Order = 0)]
    public List<DirectedTopoSolidPropertyType> directedTopoSolid {
      get {
        return _directedTopoSolid;
      }
      set {
        if (_directedTopoSolid == value) {
          return;
        }
        if (_directedTopoSolid == null || _directedTopoSolid.Equals(value) != true) {
          _directedTopoSolid = value;
          OnPropertyChanged("directedTopoSolid");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("aggregationType")]
    public AggregationType aggregationType {
      get {
        return _aggregationType;
      }
      set {
        if (_aggregationType.Equals(value) != true) {
          _aggregationType = value;
          OnPropertyChanged("aggregationType");
        }
      }
    }
  }
}