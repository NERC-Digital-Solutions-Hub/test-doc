
#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Gml.GmlBase;
using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Topology {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TopoSurfaceType")]
  public class TopoSurfaceType : AbstractTopologyType {

    #region Private fields
    private List<DirectedFacePropertyType> _directedFace;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// TopoSurfaceType class constructor
    /// </summary>
    public TopoSurfaceType() {
      _directedFace = new List<DirectedFacePropertyType>();
    }

    [XmlElement("directedFace", Order = 0)]
    [JsonProperty("directedFace", Order = 0)]
    public List<DirectedFacePropertyType> DirectedFace {
      get {
        return _directedFace;
      }
      set {
        if (_directedFace == value) {
          return;
        }
        if (_directedFace == null || _directedFace.Equals(value) != true) {
          _directedFace = value;
          OnPropertyChanged("DirectedFace");
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
