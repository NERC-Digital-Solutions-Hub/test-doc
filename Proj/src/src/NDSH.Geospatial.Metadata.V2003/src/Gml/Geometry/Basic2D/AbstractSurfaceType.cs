
using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic0D1D;
using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Complexes;
using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Primitives;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic2D {


  /// <summary>
  /// gml:AbstractSurfaceType is an abstraction of a surface to support the different levels of complexity. A surface is always a continuous region of a plane.
  /// </summary>
  [XmlInclude(typeof(CompositeSurfaceType))]
  [XmlInclude(typeof(OrientableSurfaceType))]
  [XmlInclude(typeof(SurfaceType))]
  [XmlInclude(typeof(TriangulatedSurfaceType))]
  [XmlInclude(typeof(TinType))]
  [XmlInclude(typeof(PolyhedralSurfaceType))]
  [XmlInclude(typeof(PolygonType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractSurfaceType")]
  public abstract class AbstractSurfaceType : AbstractGeometricPrimitiveType {

  }

}
