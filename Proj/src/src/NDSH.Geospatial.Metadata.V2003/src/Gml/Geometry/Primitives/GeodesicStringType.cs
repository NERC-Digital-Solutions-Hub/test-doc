
using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic0D1D;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Primitives {

  [XmlInclude(typeof(GeodesicType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GeodesicStringType")]
  public class GeodesicStringType : AbstractCurveSegmentType {
    #region Private fields
    private object _item;
    private CurveInterpolationType _interpolation;
    #endregion

    /// <summary>
    /// GeodesicStringType class constructor
    /// </summary>
    public GeodesicStringType() {
      _interpolation = CurveInterpolationType.geodesic;
    }

    [XmlElement("pointProperty", typeof(PointPropertyType), Order = 0)]
    [XmlElement("pos", typeof(DirectPositionType), Order = 0)]
    [XmlElement("posList", typeof(DirectPositionListType), Order = 0)]
    public object Item {
      get {
        return _item;
      }
      set {
        if (_item == value) {
          return;
        }
        if (_item == null || _item.Equals(value) != true) {
          _item = value;
          OnPropertyChanged("Item");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("interpolation")]
    public CurveInterpolationType Interpolation {
      get {
        return _interpolation;
      }
      set {
        if (_interpolation.Equals(value) != true) {
          _interpolation = value;
          OnPropertyChanged("Interpolation");
        }
      }
    }
  }

}
