using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic0D1D;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Measures;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Primitives {

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
    public CurvePropertyType offsetBase {
      get {
        return _offsetBase;
      }
      set {
        if (_offsetBase == value) {
          return;
        }
        if (_offsetBase == null || _offsetBase.Equals(value) != true) {
          _offsetBase = value;
          OnPropertyChanged("offsetBase");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("distance", Order = 1)]
    public LengthType distance {
      get {
        return _distance;
      }
      set {
        if (_distance == value) {
          return;
        }
        if (_distance == null || _distance.Equals(value) != true) {
          _distance = value;
          OnPropertyChanged("distance");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("refDirection", Order = 2)]
    public VectorType refDirection {
      get {
        return _refDirection;
      }
      set {
        if (_refDirection == value) {
          return;
        }
        if (_refDirection == null || _refDirection.Equals(value) != true) {
          _refDirection = value;
          OnPropertyChanged("refDirection");
        }
      }
    }
  }

}
