using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic2D;
using NDSH.Geospatial.Metadata.V2003.Gml.GmlBase;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Complexes {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CompositeSurfaceType")]
  public class CompositeSurfaceType : AbstractSurfaceType {
    #region Private fields
    private List<SurfacePropertyType> _surfaceMember;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// CompositeSurfaceType class constructor
    /// </summary>
    public CompositeSurfaceType() {
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
