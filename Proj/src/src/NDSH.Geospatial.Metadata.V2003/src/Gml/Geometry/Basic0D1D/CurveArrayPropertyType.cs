
using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic0D1D {


  /// <summary>
  /// A container for an array of curves. The elements are always contained in the array property, referencing geometry elements or arrays of geometry elements via XLinks is not supported.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CurveArrayPropertyType")]
  public class CurveArrayPropertyType : ObservableModel {
    #region Private fields
    private List<AbstractCurveType> _abstractCurve;
    private bool _owns;
    #endregion

    /// <summary>
    /// CurveArrayPropertyType class constructor
    /// </summary>
    public CurveArrayPropertyType() {
      _abstractCurve = new List<AbstractCurveType>();
      _owns = false;
    }

    [XmlElement("AbstractCurve", Order = 0)]
    [JsonProperty("AbstractCurve", Order = 0)]
    public List<AbstractCurveType> AbstractCurve {
      get {
        return _abstractCurve;
      }
      set {
        if (_abstractCurve == value) {
          return;
        }
        if (_abstractCurve == null || _abstractCurve.Equals(value) != true) {
          _abstractCurve = value;
          OnPropertyChanged("AbstractCurve");
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
