using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Primitives {

  /// <summary>
  /// gml:CurveSegmentArrayPropertyType is a container for an array of curve segments.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CurveSegmentArrayPropertyType")]
  public class CurveSegmentArrayPropertyType : Model {
    #region Private fields
    private List<AbstractCurveSegmentType> _abstractCurveSegment;
    #endregion

    /// <summary>
    /// CurveSegmentArrayPropertyType class constructor
    /// </summary>
    public CurveSegmentArrayPropertyType() {
      _abstractCurveSegment = new List<AbstractCurveSegmentType>();
    }

    [XmlElement("AbstractCurveSegment", Order = 0)]
    [JsonProperty("AbstractCurveSegment", Order = 0)]
    public List<AbstractCurveSegmentType> AbstractCurveSegment {
      get {
        return _abstractCurveSegment;
      }
      set {
        if (_abstractCurveSegment == value) {
          return;
        }
        if (_abstractCurveSegment == null || _abstractCurveSegment.Equals(value) != true) {
          _abstractCurveSegment = value;
          OnPropertyChanged("AbstractCurveSegment");
        }
      }
    }
  }

}
