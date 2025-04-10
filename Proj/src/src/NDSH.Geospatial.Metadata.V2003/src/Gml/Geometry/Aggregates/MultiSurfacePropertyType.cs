
using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Aggregates {

  /// <summary>
  /// A property that has a collection of surfaces as its value domain may either be an appropriate geometry element encapsulated in an element of this type or an XLink reference to a remote geometry element (where remote includes geometry elements located elsewhere in the same document). Either the reference or the contained element shall be given, but neither both nor none.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("MultiSurfacePropertyType")]
  public class MultiSurfacePropertyType : ObservableModel {
    #region Private fields
    private MultiSurfaceType _multiSurface;
    private string _nilReason;
    private string _remoteSchema;
    private bool _owns;
    #endregion

    /// <summary>
    /// MultiSurfacePropertyType class constructor
    /// </summary>
    public MultiSurfacePropertyType() {
      _multiSurface = new MultiSurfaceType();
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("MultiSurface", Order = 0)]
    public MultiSurfaceType MultiSurface {
      get {
        return _multiSurface;
      }
      set {
        if (_multiSurface == value) {
          return;
        }
        if (_multiSurface == null || _multiSurface.Equals(value) != true) {
          _multiSurface = value;
          OnPropertyChanged("MultiSurface");
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
