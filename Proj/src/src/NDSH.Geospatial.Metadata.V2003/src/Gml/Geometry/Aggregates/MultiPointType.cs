using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic0D1D;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Aggregates {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("MultiPointType")]
  public class MultiPointType : AbstractGeometricAggregateType {
    #region Private fields
    private List<PointPropertyType> _pointMember;
    private PointArrayPropertyType _pointMembers;
    #endregion

    /// <summary>
    /// MultiPointType class constructor
    /// </summary>
    public MultiPointType() {
      _pointMembers = new PointArrayPropertyType();
      _pointMember = new List<PointPropertyType>();
    }

    [XmlElement("pointMember", Order = 0)]
    [JsonProperty("pointMember", Order = 0)]
    public List<PointPropertyType> PointMember {
      get {
        return _pointMember;
      }
      set {
        if (_pointMember == value) {
          return;
        }
        if (_pointMember == null || _pointMember.Equals(value) != true) {
          _pointMember = value;
          OnPropertyChanged("PointMember");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("pointMembers", Order = 1)]
    public PointArrayPropertyType PointMembers {
      get {
        return _pointMembers;
      }
      set {
        if (_pointMembers == value) {
          return;
        }
        if (_pointMembers == null || _pointMembers.Equals(value) != true) {
          _pointMembers = value;
          OnPropertyChanged("PointMembers");
        }
      }
    }
  }
}
