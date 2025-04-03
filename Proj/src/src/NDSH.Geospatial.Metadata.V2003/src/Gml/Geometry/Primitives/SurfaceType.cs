using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic2D;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Primitives {

  [XmlInclude(typeof(TriangulatedSurfaceType))]
  [XmlInclude(typeof(TinType))]
  [XmlInclude(typeof(PolyhedralSurfaceType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("SurfaceType")]
  public class SurfaceType : AbstractSurfaceType {
    #region Private fields
    private SurfacePatchArrayPropertyType _patches;
    #endregion

    /// <summary>
    /// SurfaceType class constructor
    /// </summary>
    public SurfaceType() {
      _patches = new SurfacePatchArrayPropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("patches", Order = 0)]
    public SurfacePatchArrayPropertyType Patches {
      get {
        return _patches;
      }
      set {
        if (_patches == value) {
          return;
        }
        if (_patches == null || _patches.Equals(value) != true) {
          _patches = value;
          OnPropertyChanged("Patches");
        }
      }
    }
  }

}
