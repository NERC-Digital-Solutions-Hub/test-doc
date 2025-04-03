using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic0D1D;
using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Complexes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Primitives {


  /// <summary>
  /// gml:AbstractSolidType is an abstraction of a solid to support the different levels of complexity. The solid may always be viewed as a geometric primitive, i.e. is contiguous.
  /// </summary>
  [XmlInclude(typeof(CompositeSolidType))]
  [XmlInclude(typeof(SolidType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractSolidType")]
  public class AbstractSolidType : AbstractGeometricPrimitiveType {

  }

}
