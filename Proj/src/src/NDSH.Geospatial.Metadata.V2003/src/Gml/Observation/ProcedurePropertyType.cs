
using NDSH.Apps;
using NDSH.Geospatial.Metadata.V2003.Gml.Feature;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;


namespace NDSH.Geospatial.Metadata.V2003.Gml.Observation {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ProcedurePropertyType")]
  public class ProcedurePropertyType : ObservableModel {
    #region Private fields
    private AbstractFeatureType _abstractFeature;
    private bool _owns;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// ProcedurePropertyType class constructor
    /// </summary>
    public ProcedurePropertyType() {
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("AbstractFeature", Order = 0)]
    public AbstractFeatureType AbstractFeature {
      get {
        return _abstractFeature;
      }
      set {
        if (_abstractFeature == value) {
          return;
        }
        if (_abstractFeature == null || _abstractFeature.Equals(value) != true) {
          _abstractFeature = value;
          OnPropertyChanged("AbstractFeature");
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
