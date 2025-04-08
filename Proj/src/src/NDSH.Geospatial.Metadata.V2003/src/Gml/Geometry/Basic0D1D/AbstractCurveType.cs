
using NDSH.Geospatial.Metadata.V2003.Gml.Base;
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
  /// gml:AbstractCurveType is an abstraction of a curve to support the different levels of complexity. The curve may always be viewed as a geometric primitive, i.e. is continuous.
  /// </summary>
  [XmlInclude(typeof(CompositeCurveType))]
  [XmlInclude(typeof(OrientableCurveType))]
  [XmlInclude(typeof(CurveType))]
  [XmlInclude(typeof(LineStringType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractCurveType")]
  public abstract class AbstractCurveType : AbstractGeometricPrimitiveType {

  }

}
