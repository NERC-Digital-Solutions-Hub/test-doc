
using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic2D;
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

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic0D1D {


  /// <summary>
  /// gml:AbstractGeometricPrimitiveType is the abstract root type of the geometric primitives. A geometric primitive is a geometric object that is not decomposed further into other primitives in the system. All primitives are oriented in the direction implied by the sequence of their coordinate tuples.
  /// </summary>
  [XmlInclude(typeof(AbstractSolidType))]
  [XmlInclude(typeof(CompositeSolidType))]
  [XmlInclude(typeof(SolidType))]
  [XmlInclude(typeof(AbstractSurfaceType))]
  [XmlInclude(typeof(CompositeSurfaceType))]
  [XmlInclude(typeof(OrientableSurfaceType))]
  [XmlInclude(typeof(SurfaceType))]
  [XmlInclude(typeof(TriangulatedSurfaceType))]
  [XmlInclude(typeof(TinType))]
  [XmlInclude(typeof(PolyhedralSurfaceType))]
  [XmlInclude(typeof(PolygonType))]
  [XmlInclude(typeof(AbstractCurveType))]
  [XmlInclude(typeof(CompositeCurveType))]
  [XmlInclude(typeof(OrientableCurveType))]
  [XmlInclude(typeof(CurveType))]
  [XmlInclude(typeof(LineStringType))]
  [XmlInclude(typeof(PointType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractGeometricPrimitiveType")]
  public abstract class AbstractGeometricPrimitiveType : AbstractGeometryType {

  }

}
