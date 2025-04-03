using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Primitives {

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
  public abstract class AbstractCurveSegmentType : Model {
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
    public string numDerivativesAtStart {
      get {
        return _numDerivativesAtStart;
      }
      set {
        if (_numDerivativesAtStart == value) {
          return;
        }
        if (_numDerivativesAtStart == null || _numDerivativesAtStart.Equals(value) != true) {
          _numDerivativesAtStart = value;
          OnPropertyChanged("numDerivativesAtStart");
        }
      }
    }

    [XmlAttribute(DataType = "integer")]
    [DefaultValue("0")]
    [JsonProperty("numDerivativesAtEnd")]
    public string numDerivativesAtEnd {
      get {
        return _numDerivativesAtEnd;
      }
      set {
        if (_numDerivativesAtEnd == value) {
          return;
        }
        if (_numDerivativesAtEnd == null || _numDerivativesAtEnd.Equals(value) != true) {
          _numDerivativesAtEnd = value;
          OnPropertyChanged("numDerivativesAtEnd");
        }
      }
    }

    [XmlAttribute(DataType = "integer")]
    [DefaultValue("0")]
    [JsonProperty("numDerivativeInterior")]
    public string numDerivativeInterior {
      get {
        return _numDerivativeInterior;
      }
      set {
        if (_numDerivativeInterior == value) {
          return;
        }
        if (_numDerivativeInterior == null || _numDerivativeInterior.Equals(value) != true) {
          _numDerivativeInterior = value;
          OnPropertyChanged("numDerivativeInterior");
        }
      }
    }
  }

}
