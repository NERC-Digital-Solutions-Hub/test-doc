using NDSH.Geospatial.Metadata.V2003.Gml.GmlBase;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(AbstractGriddedSurfaceType))]
  [XmlInclude(typeof(SphereType))]
  [XmlInclude(typeof(CylinderType))]
  [XmlInclude(typeof(ConeType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractParametricCurveSurfaceType")]
  public abstract class AbstractParametricCurveSurfaceType : AbstractSurfacePatchType {
    #region Private fields
    private AggregationType _aggregationType;
    #endregion

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
