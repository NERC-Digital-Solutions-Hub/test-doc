using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic0D1D;
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
  [JsonObject("CurveType")]
  public class CurveType : AbstractCurveType {
    #region Private fields
    private CurveSegmentArrayPropertyType _segments;
    #endregion

    /// <summary>
    /// CurveType class constructor
    /// </summary>
    public CurveType() {
      _segments = new CurveSegmentArrayPropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("segments", Order = 0)]
    public CurveSegmentArrayPropertyType segments {
      get {
        return _segments;
      }
      set {
        if (_segments == value) {
          return;
        }
        if (_segments == null || _segments.Equals(value) != true) {
          _segments = value;
          OnPropertyChanged("segments");
        }
      }
    }
  }

}
