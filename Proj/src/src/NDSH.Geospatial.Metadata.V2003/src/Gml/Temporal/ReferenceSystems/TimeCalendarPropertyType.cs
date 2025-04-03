
using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Temporal.ReferenceSystems {


  /// <summary>
  /// gml:TimeCalendarPropertyType provides for associating a gml:TimeCalendar with an object.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeCalendarPropertyType")]
  public class TimeCalendarPropertyType : ObservableModel {
    #region Private fields
    private TimeCalendarType _timeCalendar;
    private bool _owns;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// TimeCalendarPropertyType class constructor
    /// </summary>
    public TimeCalendarPropertyType() {
      _timeCalendar = new TimeCalendarType();
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TimeCalendar", Order = 0)]
    public TimeCalendarType TimeCalendar {
      get {
        return _timeCalendar;
      }
      set {
        if (_timeCalendar == value) {
          return;
        }
        if (_timeCalendar == null || _timeCalendar.Equals(value) != true) {
          _timeCalendar = value;
          OnPropertyChanged("TimeCalendar");
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
