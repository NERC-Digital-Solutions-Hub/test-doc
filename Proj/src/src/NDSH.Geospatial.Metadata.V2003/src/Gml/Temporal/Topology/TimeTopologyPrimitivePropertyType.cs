using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Temporal.Topology {


  /// <summary>
  /// gml:TimeTopologyPrimitivePropertyType provides for associating a gml:AbstractTimeTopologyPrimitive with an object.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeTopologyPrimitivePropertyType")]
  public class TimeTopologyPrimitivePropertyType : ObservableModel {
    #region Private fields
    private AbstractTimeTopologyPrimitiveType _abstractTimeTopologyPrimitive;
    private string _nilReason;
    private string _remoteSchema;
    private bool _owns;
    #endregion

    /// <summary>
    /// TimeTopologyPrimitivePropertyType class constructor
    /// </summary>
    public TimeTopologyPrimitivePropertyType() {
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("AbstractTimeTopologyPrimitive", Order = 0)]
    public AbstractTimeTopologyPrimitiveType AbstractTimeTopologyPrimitive {
      get {
        return _abstractTimeTopologyPrimitive;
      }
      set {
        if (_abstractTimeTopologyPrimitive == value) {
          return;
        }
        if (_abstractTimeTopologyPrimitive == null || _abstractTimeTopologyPrimitive.Equals(value) != true) {
          _abstractTimeTopologyPrimitive = value;
          OnPropertyChanged("AbstractTimeTopologyPrimitive");
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
