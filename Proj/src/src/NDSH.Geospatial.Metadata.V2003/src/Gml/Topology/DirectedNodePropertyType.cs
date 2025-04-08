
#region Imported Namespaces

using NDSH.Apps;
using NDSH.Geospatial.Metadata.V2003.Gml.BasicTypes;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Topology {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DirectedNodePropertyType")]
  public class DirectedNodePropertyType : ObservableModel {

    #region Private fields
    private NodeType _node;
    private SignType _orientation;
    private string _nilReason;
    private string _remoteSchema;
    private bool _owns;
    #endregion

    /// <summary>
    /// DirectedNodePropertyType class constructor
    /// </summary>
    public DirectedNodePropertyType() {
      _node = new NodeType();
      _orientation = SignType.Item1;
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("Node", Order = 0)]
    public NodeType Node {
      get {
        return _node;
      }
      set {
        if (_node == value) {
          return;
        }
        if (_node == null || _node.Equals(value) != true) {
          _node = value;
          OnPropertyChanged("Node");
        }
      }
    }

    [XmlAttribute]
    [DefaultValue(SignType.Item1)]
    [JsonProperty("orientation")]
    public SignType Orientation {
      get {
        return _orientation;
      }
      set {
        if (_orientation.Equals(value) != true) {
          _orientation = value;
          OnPropertyChanged("Orientation");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("nilReason")]
    public string NilReason {
      get {
        return _nilReason;
      }
      set {
        if (_nilReason == value) {
          return;
        }
        if (_nilReason == null || _nilReason.Equals(value) != true) {
          _nilReason = value;
          OnPropertyChanged("NilReason");
        }
      }
    }

    [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
    [JsonProperty("remoteSchema")]
    public string RemoteSchema {
      get {
        return _remoteSchema;
      }
      set {
        if (_remoteSchema == value) {
          return;
        }
        if (_remoteSchema == null || _remoteSchema.Equals(value) != true) {
          _remoteSchema = value;
          OnPropertyChanged("RemoteSchema");
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
