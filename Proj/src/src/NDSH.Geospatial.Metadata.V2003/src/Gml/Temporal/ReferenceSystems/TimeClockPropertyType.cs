
using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Temporal.ReferenceSystems {


  /// <summary>
  /// gml:TimeClockPropertyType provides for associating a gml:TimeClock with an object.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeClockPropertyType")]
  public class TimeClockPropertyType : ObservableModel {
    #region Private fields
    private TimeClockType _timeClock;
    private bool _owns;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// TimeClockPropertyType class constructor
    /// </summary>
    public TimeClockPropertyType() {
      _timeClock = new TimeClockType();
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TimeClock", Order = 0)]
    public TimeClockType TimeClock {
      get {
        return _timeClock;
      }
      set {
        if (_timeClock == value) {
          return;
        }
        if (_timeClock == null || _timeClock.Equals(value) != true) {
          _timeClock = value;
          OnPropertyChanged("TimeClock");
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
