using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic0D1D;
using NDSH.Geospatial.Metadata.V2003.Gml.Measures;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("OffsetCurveType")]
  public class OffsetCurveType : AbstractCurveSegmentType {
    #region Private fields
    private CurvePropertyType _offsetBase;
    private LengthType _distance;
    private VectorType _refDirection;
    #endregion

    /// <summary>
    /// OffsetCurveType class constructor
    /// </summary>
    public OffsetCurveType() {
      _refDirection = new VectorType();
      _distance = new LengthType();
      _offsetBase = new CurvePropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("offsetBase", Order = 0)]
    public CurvePropertyType OffsetBase {
      get {
        return _offsetBase;
      }
      set {
        if (_offsetBase == value) {
          return;
        }
        if (_offsetBase == null || _offsetBase.Equals(value) != true) {
          _offsetBase = value;
          OnPropertyChanged("OffsetBase");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("distance", Order = 1)]
    public LengthType Distance {
      get {
        return _distance;
      }
      set {
        if (_distance == value) {
          return;
        }
        if (_distance == null || _distance.Equals(value) != true) {
          _distance = value;
          OnPropertyChanged("Distance");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("refDirection", Order = 2)]
    public VectorType RefDirection {
      get {
        return _refDirection;
      }
      set {
        if (_refDirection == value) {
          return;
        }
        if (_refDirection == null || _refDirection.Equals(value) != true) {
          _refDirection = value;
          OnPropertyChanged("RefDirection");
        }
      }
    }
  }

}
