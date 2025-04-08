using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic0D1D {

  /// <summary>
  /// SurfaceInterpolationType is a list of codes that may be used to identify
  /// the interpolation mechanisms specified by an application schema.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  public enum SurfaceInterpolationType {
    none,
    planar,
    spherical,
    elliptical,
    conic,
    tin,
    parametricCurve,
    polynomialSpline,
    rationalSpline,
    triangulatedSpline,
  }

}
