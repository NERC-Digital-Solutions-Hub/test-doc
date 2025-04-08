
#region Imported Namespaces

using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Topology {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TopoPointType")]
  public class TopoPointType : AbstractTopologyType {

    #region Private fields
    private DirectedNodePropertyType _directedNode;
    #endregion

    /// <summary>
    /// TopoPointType class constructor
    /// </summary>
    public TopoPointType() {
      _directedNode = new DirectedNodePropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("directedNode", Order = 0)]
    public DirectedNodePropertyType DirectedNode {
      get {
        return _directedNode;
      }
      set {
        if (_directedNode == value) {
          return;
        }
        if (_directedNode == null || _directedNode.Equals(value) != true) {
          _directedNode = value;
          OnPropertyChanged("DirectedNode");
        }
      }
    }

  }

}
