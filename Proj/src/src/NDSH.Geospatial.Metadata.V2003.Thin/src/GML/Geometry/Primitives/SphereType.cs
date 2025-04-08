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
  [JsonObject("SphereType")]
  public class SphereType : AbstractGriddedSurfaceType {
    #region Private fields
    private CurveInterpolationType _horizontalCurveType;
    private CurveInterpolationType _verticalCurveType;
    #endregion

    /// <summary>
    /// SphereType class constructor
    /// </summary>
    public SphereType() {
      _horizontalCurveType = CurveInterpolationType.circularArc3Points;
      _verticalCurveType = CurveInterpolationType.circularArc3Points;
    }

    [XmlAttribute]
    [JsonProperty("horizontalCurveType")]
    public CurveInterpolationType horizontalCurveType {
      get {
        return _horizontalCurveType;
      }
      set {
        if (_horizontalCurveType.Equals(value) != true) {
          _horizontalCurveType = value;
          OnPropertyChanged("horizontalCurveType");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("verticalCurveType")]
    public CurveInterpolationType verticalCurveType {
      get {
        return _verticalCurveType;
      }
      set {
        if (_verticalCurveType.Equals(value) != true) {
          _verticalCurveType = value;
          OnPropertyChanged("verticalCurveType");
        }
      }
    }
  }

}
