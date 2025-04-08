using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic0D1D;
using NDSH.Geospatial.Metadata.V2003.Gml.GmlBase;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Complexes {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GeometricComplexType")]
  public class GeometricComplexType : AbstractGeometryType {
    #region Private fields
    private List<GeometricPrimitivePropertyType> _element;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// GeometricComplexType class constructor
    /// </summary>
    public GeometricComplexType() {
      _element = new List<GeometricPrimitivePropertyType>();
    }

    [XmlElement("element", Order = 0)]
    [JsonProperty("element", Order = 0)]
    public List<GeometricPrimitivePropertyType> Element {
      get {
        return _element;
      }
      set {
        if (_element == value) {
          return;
        }
        if (_element == null || _element.Equals(value) != true) {
          _element = value;
          OnPropertyChanged("Element");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("aggregationType")]
    public AggregationType AggregationType {
      get {
        return _aggregationType;
      }
      set {
        if (_aggregationType.Equals(value) != true) {
          _aggregationType = value;
          OnPropertyChanged("AggregationType");
        }
      }
    }
  }
}
