
#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Gml.GmlBase;
using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Topology {

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
    public List<DirectedTopoSolidPropertyType> DirectedTopoSolid {
      get {
        return _directedTopoSolid;
      }
      set {
        if (_directedTopoSolid == value) {
          return;
        }
        if (_directedTopoSolid == null || _directedTopoSolid.Equals(value) != true) {
          _directedTopoSolid = value;
          OnPropertyChanged("DirectedTopoSolid");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("aggregationType")]
    public AggregationType AggregationType {
      get {
        return _aggregationType;
      }
      set {
        if (_aggregationType.Equals(value) != true) {
          _aggregationType = value;
          OnPropertyChanged("AggregationType");
        }
      }
    }

  }

}
