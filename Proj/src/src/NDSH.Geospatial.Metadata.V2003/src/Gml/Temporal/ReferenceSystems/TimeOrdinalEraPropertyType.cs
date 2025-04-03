
using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Temporal.ReferenceSystems {


  /// <summary>
  /// gml:TimeOrdinalEraPropertyType provides for associating a gml:TimeOrdinalEra with an object.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeOrdinalEraPropertyType")]
  public class TimeOrdinalEraPropertyType : ObservableModel {
    #region Private fields
    private TimeOrdinalEraType _timeOrdinalEra;
    private bool _owns;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// TimeOrdinalEraPropertyType class constructor
    /// </summary>
    public TimeOrdinalEraPropertyType() {
      _timeOrdinalEra = new TimeOrdinalEraType();
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TimeOrdinalEra", Order = 0)]
    public TimeOrdinalEraType TimeOrdinalEra {
      get {
        return _timeOrdinalEra;
      }
      set {
        if (_timeOrdinalEra == value) {
          return;
        }
        if (_timeOrdinalEra == null || _timeOrdinalEra.Equals(value) != true) {
          _timeOrdinalEra = value;
          OnPropertyChanged("TimeOrdinalEra");
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
  }
}
