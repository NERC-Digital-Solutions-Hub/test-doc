
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
    public DirectedNodePropertyType directedNode {
      get {
        return _directedNode;
      }
      set {
        if (_directedNode == value) {
          return;
        }
        if (_directedNode == null || _directedNode.Equals(value) != true) {
          _directedNode = value;
          OnPropertyChanged("directedNode");
        }
      }
    }
  }
}