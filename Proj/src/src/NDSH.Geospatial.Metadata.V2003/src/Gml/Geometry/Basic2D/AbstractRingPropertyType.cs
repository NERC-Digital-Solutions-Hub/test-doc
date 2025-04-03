
using NDSH.Apps;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic2D {

  /// <summary>
  /// A property with the content model of gml:AbstractRingPropertyType encapsulates a ring to represent the surface boundary property of a surface.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractRingPropertyType")]
  public class AbstractRingPropertyType : ObservableModel {
    #region Private fields
    private AbstractRingType _abstractRing;
    #endregion

    [XmlElement(Order = 0)]
    [JsonProperty("AbstractRing", Order = 0)]
    public AbstractRingType AbstractRing {
      get {
        return _abstractRing;
      }
      set {
        if (_abstractRing == value) {
          return;
        }
        if (_abstractRing == null || _abstractRing.Equals(value) != true) {
          _abstractRing = value;
          OnPropertyChanged("AbstractRing");
        }
      }
    }
  }
}
