using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Primitives {


  [XmlInclude(typeof(AbstractParametricCurveSurfaceType))]
  [XmlInclude(typeof(AbstractGriddedSurfaceType))]
  [XmlInclude(typeof(SphereType))]
  [XmlInclude(typeof(CylinderType))]
  [XmlInclude(typeof(ConeType))]
  [XmlInclude(typeof(RectangleType))]
  [XmlInclude(typeof(TriangleType))]
  [XmlInclude(typeof(PolygonPatchType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractSurfacePatchType")]
  public abstract class AbstractSurfacePatchType : Model {

  }

}
