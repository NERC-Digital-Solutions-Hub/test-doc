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
  [JsonObject("CompositeCurveType")]
  public class CompositeCurveType : AbstractCurveType {
    #region Private fields
    private List<CurvePropertyType> _curveMember;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// CompositeCurveType class constructor
    /// </summary>
    public CompositeCurveType() {
      _curveMember = new List<CurvePropertyType>();
    }

    [XmlElement("curveMember", Order = 0)]
    [JsonProperty("curveMember", Order = 0)]
    public List<CurvePropertyType> CurveMember {
      get {
        return _curveMember;
      }
      set {
        if (_curveMember == value) {
          return;
        }
        if (_curveMember == null || _curveMember.Equals(value) != true) {
          _curveMember = value;
          OnPropertyChanged("CurveMember");
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
