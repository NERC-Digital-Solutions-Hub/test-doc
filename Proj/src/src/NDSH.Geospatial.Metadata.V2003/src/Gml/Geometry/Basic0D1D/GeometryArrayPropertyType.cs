
using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic0D1D {

  /// <summary>
  /// If a feature has a property which takes an array of geometry elements as its value, this is called a geometry array property. A generic type for such a geometry property is GeometryArrayPropertyType.
  /// The elements are always contained inline in the array property, referencing geometry elements or arrays of geometry elements via XLinks is not supported.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GeometryArrayPropertyType")]
  public class GeometryArrayPropertyType : ObservableModel {
    #region Private fields
    private List<AbstractGeometryType> _abstractGeometry;
    private bool _owns;
    #endregion

    /// <summary>
    /// GeometryArrayPropertyType class constructor
    /// </summary>
    public GeometryArrayPropertyType() {
      _abstractGeometry = new List<AbstractGeometryType>();
      _owns = false;
    }

    [XmlElement("AbstractGeometry", Order = 0)]
    [JsonProperty("AbstractGeometry", Order = 0)]
    public List<AbstractGeometryType> AbstractGeometry {
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
