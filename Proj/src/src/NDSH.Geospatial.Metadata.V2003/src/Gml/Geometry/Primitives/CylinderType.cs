using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CylinderType")]
  public class CylinderType : AbstractGriddedSurfaceType {
    #region Private fields
    private CurveInterpolationType _horizontalCurveType;
    private CurveInterpolationType _verticalCurveType;
    #endregion

    /// <summary>
    /// CylinderType class constructor
    /// </summary>
    public CylinderType() {
      _horizontalCurveType = CurveInterpolationType.circularArc3Points;
      _verticalCurveType = CurveInterpolationType.linear;
    }

    [XmlAttribute]
    [JsonProperty("horizontalCurveType")]
    public CurveInterpolationType HorizontalCurveType {
      get {
        return _horizontalCurveType;
      }
      set {
        if (_horizontalCurveType.Equals(value) != true) {
          _horizontalCurveType = value;
          OnPropertyChanged("HorizontalCurveType");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("verticalCurveType")]
    public CurveInterpolationType VerticalCurveType {
      get {
        return _verticalCurveType;
      }
      set {
        if (_verticalCurveType.Equals(value) != true) {
          _verticalCurveType = value;
          OnPropertyChanged("VerticalCurveType");
        }
      }
    }
  }

}
