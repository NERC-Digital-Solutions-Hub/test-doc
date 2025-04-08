using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(GeodesicStringType))]
  [XmlInclude(typeof(GeodesicType))]
  [XmlInclude(typeof(ClothoidType))]
  [XmlInclude(typeof(OffsetCurveType))]
  [XmlInclude(typeof(BSplineType))]
  [XmlInclude(typeof(BezierType))]
  [XmlInclude(typeof(CubicSplineType))]
  [XmlInclude(typeof(ArcByCenterPointType))]
  [XmlInclude(typeof(CircleByCenterPointType))]
  [XmlInclude(typeof(ArcStringByBulgeType))]
  [XmlInclude(typeof(ArcByBulgeType))]
  [XmlInclude(typeof(ArcStringType))]
  [XmlInclude(typeof(ArcType))]
  [XmlInclude(typeof(CircleType))]
  [XmlInclude(typeof(LineStringSegmentType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractCurveSegmentType")]
  public abstract class AbstractCurveSegmentType : ObservableModel {
    #region Private fields
    private string _numDerivativesAtStart;
    private string _numDerivativesAtEnd;
    private string _numDerivativeInterior;
    #endregion

    /// <summary>
    /// AbstractCurveSegmentType class constructor
    /// </summary>
    public AbstractCurveSegmentType() {
      _numDerivativesAtStart = "0";
      _numDerivativesAtEnd = "0";
      _numDerivativeInterior = "0";
    }

    [XmlAttribute(DataType = "integer")]
    [DefaultValue("0")]
    [JsonProperty("numDerivativesAtStart")]
    public string NumDerivativesAtStart {
      get {
        return _numDerivativesAtStart;
      }
      set {
        if (_numDerivativesAtStart == value) {
          return;
        }
        if (_numDerivativesAtStart == null || _numDerivativesAtStart.Equals(value) != true) {
          _numDerivativesAtStart = value;
          OnPropertyChanged("NumDerivativesAtStart");
        }
      }
    }

    [XmlAttribute(DataType = "integer")]
    [DefaultValue("0")]
    [JsonProperty("numDerivativesAtEnd")]
    public string NumDerivativesAtEnd {
      get {
        return _numDerivativesAtEnd;
      }
      set {
        if (_numDerivativesAtEnd == value) {
          return;
        }
        if (_numDerivativesAtEnd == null || _numDerivativesAtEnd.Equals(value) != true) {
          _numDerivativesAtEnd = value;
          OnPropertyChanged("NumDerivativesAtEnd");
        }
      }
    }

    [XmlAttribute(DataType = "integer")]
    [DefaultValue("0")]
    [JsonProperty("numDerivativeInterior")]
    public string NumDerivativeInterior {
      get {
        return _numDerivativeInterior;
      }
      set {
        if (_numDerivativeInterior == value) {
          return;
        }
        if (_numDerivativeInterior == null || _numDerivativeInterior.Equals(value) != true) {
          _numDerivativeInterior = value;
          OnPropertyChanged("NumDerivativeInterior");
        }
      }
    }
  }

}
