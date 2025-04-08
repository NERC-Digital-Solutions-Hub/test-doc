
#region Imported Namespaces

using NDSH.Apps;
using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic0D1D;
using NDSH.Geospatial.Metadata.V2003.Gml.Temporal;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.ValueObjects {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ValuePropertyType")]
  public class ValuePropertyType : ObservableModel {

    #region Private fields
    private object _abstractValue;
    private AbstractGeometryType _abstractGeometry;
    private AbstractTimeObjectType _abstractTimeObject;
    private string _null;
    private string _nilReason;
    private string _remoteSchema;
    private bool _owns;
    #endregion

    /// <summary>
    /// ValuePropertyType class constructor
    /// </summary>
    public ValuePropertyType() {
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("AbstractValue", Order = 0)]
    public object AbstractValue {
      get {
        return _abstractValue;
      }
      set {
        if (_abstractValue == value) {
          return;
        }
        if (_abstractValue == null || _abstractValue.Equals(value) != true) {
          _abstractValue = value;
          OnPropertyChanged("AbstractValue");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("AbstractGeometry", Order = 1)]
    public AbstractGeometryType AbstractGeometry {
      get {
        return _abstractGeometry;
      }
      set {
        if (_abstractGeometry == value) {
          return;
        }
        if (_abstractGeometry == null || _abstractGeometry.Equals(value) != true) {
          _abstractGeometry = value;
          OnPropertyChanged("AbstractGeometry");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("AbstractTimeObject", Order = 2)]
    public AbstractTimeObjectType AbstractTimeObject {
      get {
        return _abstractTimeObject;
      }
      set {
        if (_abstractTimeObject == value) {
          return;
        }
        if (_abstractTimeObject == null || _abstractTimeObject.Equals(value) != true) {
          _abstractTimeObject = value;
          OnPropertyChanged("AbstractTimeObject");
        }
      }
    }

    [XmlElement(Order = 3)]
    [JsonProperty("Null", Order = 3)]
    public string Null {
      get {
        return _null;
      }
      set {
        if (_null == value) {
          return;
        }
        if (_null == null || _null.Equals(value) != true) {
          _null = value;
          OnPropertyChanged("Null");
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
