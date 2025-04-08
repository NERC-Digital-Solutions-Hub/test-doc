using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic2D;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Aggregates {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("MultiSurfaceType")]
  public class MultiSurfaceType : AbstractGeometricAggregateType {
    #region Private fields
    private List<SurfacePropertyType> _surfaceMember;
    private SurfaceArrayPropertyType _surfaceMembers;
    #endregion

    /// <summary>
    /// MultiSurfaceType class constructor
    /// </summary>
    public MultiSurfaceType() {
      _surfaceMembers = new SurfaceArrayPropertyType();
      _surfaceMember = new List<SurfacePropertyType>();
    }

    [XmlElement("surfaceMember", Order = 0)]
    [JsonProperty("surfaceMember", Order = 0)]
    public List<SurfacePropertyType> SurfaceMember {
      get {
        return _surfaceMember;
      }
      set {
        if (_surfaceMember == value) {
          return;
        }
        if (_surfaceMember == null || _surfaceMember.Equals(value) != true) {
          _surfaceMember = value;
          OnPropertyChanged("SurfaceMember");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("surfaceMembers", Order = 1)]
    public SurfaceArrayPropertyType SurfaceMembers {
      get {
        return _surfaceMembers;
      }
      set {
        if (_surfaceMembers == value) {
          return;
        }
        if (_surfaceMembers == null || _surfaceMembers.Equals(value) != true) {
          _surfaceMembers = value;
          OnPropertyChanged("SurfaceMembers");
        }
      }
    }
  }
}
