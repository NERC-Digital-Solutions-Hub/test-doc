using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Temporal.Topology {


  /// <summary>
  /// gml:TimeTopologyComplexPropertyType provides for associating a gml:TimeTopologyComplex with an object.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeTopologyComplexPropertyType")]
  public class TimeTopologyComplexPropertyType : ObservableModel {
    #region Private fields
    private TimeTopologyComplexType _timeTopologyComplex;
    private string _nilReason;
    private string _remoteSchema;
    private bool _owns;
    #endregion

    /// <summary>
    /// TimeTopologyComplexPropertyType class constructor
    /// </summary>
    public TimeTopologyComplexPropertyType() {
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TimeTopologyComplex", Order = 0)]
    public TimeTopologyComplexType TimeTopologyComplex {
      get {
        return _timeTopologyComplex;
      }
      set {
        if (_timeTopologyComplex == value) {
          return;
        }
        if (_timeTopologyComplex == null || _timeTopologyComplex.Equals(value) != true) {
          _timeTopologyComplex = value;
          OnPropertyChanged("TimeTopologyComplex");
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
