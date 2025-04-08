using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Primitives {

  /// <summary>
  /// gml:CurveInterpolationType is a list of codes that may be used to identify the interpolation mechanisms specified by an application schema.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  public enum CurveInterpolationType {
    linear,
    geodesic,
    circularArc3Points,
    circularArc2PointWithBulge,
    circularArcCenterPointWithRadius,
    elliptical,
    clothoid,
    conic,
    polynomialSpline,
    cubicSpline,
    rationalSpline,
  }

}
