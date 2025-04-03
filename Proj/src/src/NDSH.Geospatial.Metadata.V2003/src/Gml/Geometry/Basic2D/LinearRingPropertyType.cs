
using NDSH.Apps;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic2D {

  /// <summary>
  /// A property with the content model of gml:LinearRingPropertyType encapsulates a linear ring to represent a component of a surface boundary.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("LinearRingPropertyType")]
  public class LinearRingPropertyType : ObservableModel {
    #region Private fields
    private LinearRingType _linearRing;
    #endregion

    /// <summary>
    /// LinearRingPropertyType class constructor
    /// </summary>
    public LinearRingPropertyType() {
      _linearRing = new LinearRingType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("LinearRing", Order = 0)]
    public LinearRingType LinearRing {
      get {
        return _linearRing;
      }
      set {
        if (_linearRing == value) {
          return;
        }
        if (_linearRing == null || _linearRing.Equals(value) != true) {
          _linearRing = value;
          OnPropertyChanged("LinearRing");
        }
      }
    }
  }
}
