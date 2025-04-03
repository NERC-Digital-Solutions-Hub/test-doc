using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Temporal.Topology {

  /// <summary>
  /// gml:TimeEdgePropertyType provides for associating a gml:TimeEdge with an object.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeEdgePropertyType")]
  public class TimeEdgePropertyType : ObservableModel {
    #region Private fields
    private TimeEdgeType _timeEdge;
    private string _nilReason;
    private string _remoteSchema;
    private bool _owns;
    #endregion

    /// <summary>
    /// TimeEdgePropertyType class constructor
    /// </summary>
    public TimeEdgePropertyType() {
      _timeEdge = new TimeEdgeType();
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TimeEdge", Order = 0)]
    public TimeEdgeType TimeEdge {
      get {
        return _timeEdge;
      }
      set {
        if (_timeEdge == value) {
          return;
        }
        if (_timeEdge == null || _timeEdge.Equals(value) != true) {
          _timeEdge = value;
          OnPropertyChanged("TimeEdge");
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
