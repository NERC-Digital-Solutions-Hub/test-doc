using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Primitives {
  /// <summary>
  /// This enumeration type specifies values for the knots� type (see ISO 19107:2003, 6.4.25).
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  public enum KnotTypesType {
    uniform,
    quasiUniform,
    piecewiseBezier,
  }
}
