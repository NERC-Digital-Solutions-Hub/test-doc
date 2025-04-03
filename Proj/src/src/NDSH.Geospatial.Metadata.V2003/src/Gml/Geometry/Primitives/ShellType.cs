using NDSH.Apps;
using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic2D;
using NDSH.Geospatial.Metadata.V2003.Gml.GmlBase;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Primitives {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ShellType")]
  public class ShellType : ObservableModel {
    #region Private fields
    private List<SurfacePropertyType> _surfaceMember;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// ShellType class constructor
    /// </summary>
    public ShellType() {
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
