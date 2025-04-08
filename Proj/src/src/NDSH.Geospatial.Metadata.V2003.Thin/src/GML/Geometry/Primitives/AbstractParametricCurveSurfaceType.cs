using NDSH.Geospatial.Metadata.V2003.Thin.GML.GmlBase;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Primitives {

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
    public AggregationType aggregationType {
      get {
        return _aggregationType;
      }
      set {
        if (_aggregationType.Equals(value) != true) {
          _aggregationType = value;
          OnPropertyChanged("aggregationType");
        }
      }
    }
  }


}
