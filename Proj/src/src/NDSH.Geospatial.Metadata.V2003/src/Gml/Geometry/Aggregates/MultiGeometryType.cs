using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic0D1D;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Aggregates {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("MultiGeometryType")]
  public class MultiGeometryType : AbstractGeometricAggregateType {
    #region Private fields
    private List<GeometryPropertyType> _geometryMember;
    private GeometryArrayPropertyType _geometryMembers;
    #endregion

    /// <summary>
    /// MultiGeometryType class constructor
    /// </summary>
    public MultiGeometryType() {
      _geometryMembers = new GeometryArrayPropertyType();
      _geometryMember = new List<GeometryPropertyType>();
    }

    [XmlElement("geometryMember", Order = 0)]
    [JsonProperty("geometryMember", Order = 0)]
    public List<GeometryPropertyType> GeometryMember {
      get {
        return _geometryMember;
      }
      set {
        if (_geometryMember == value) {
          return;
        }
        if (_geometryMember == null || _geometryMember.Equals(value) != true) {
          _geometryMember = value;
          OnPropertyChanged("GeometryMember");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("geometryMembers", Order = 1)]
    public GeometryArrayPropertyType GeometryMembers {
      get {
        return _geometryMembers;
      }
      set {
        if (_geometryMembers == value) {
          return;
        }
        if (_geometryMembers == null || _geometryMembers.Equals(value) != true) {
          _geometryMembers = value;
          OnPropertyChanged("GeometryMembers");
        }
      }
    }
  }
}
