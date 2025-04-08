using NDSH.Apps;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Primitives {

  /// <summary>
  /// gml:KnotPropertyType encapsulates a knot to use it in a geometric type.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("KnotPropertyType")]
  public class KnotPropertyType : ObservableModel {
    #region Private fields
    private KnotType _knot;
    #endregion

    /// <summary>
    /// KnotPropertyType class constructor
    /// </summary>
    public KnotPropertyType() {
      _knot = new KnotType();
    }

    /// <summary>
    /// A knot is a breakpoint on a piecewise spline curve.
    /// value is the value of the parameter at the knot of the spline (see ISO 19107:2003, 6.4.24.2).
    /// multiplicity is the multiplicity of this knot used in the definition of the spline (with the same weight).
    /// weight is the value of the averaging weight used for this knot of the spline.
    /// </summary>
    [XmlElement(Order = 0)]
    [JsonProperty("Knot", Order = 0)]
    public KnotType Knot {
      get {
        return _knot;
      }
      set {
        if (_knot == value) {
          return;
        }
        if (_knot == null || _knot.Equals(value) != true) {
          _knot = value;
          OnPropertyChanged("Knot");
        }
      }
    }
  }


}
