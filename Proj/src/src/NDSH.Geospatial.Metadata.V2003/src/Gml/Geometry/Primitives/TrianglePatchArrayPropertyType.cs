using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Primitives {

  /// <summary>
  /// gml:TrianglePatchArrayPropertyType provides a container for an array of triangle patches.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TrianglePatchArrayPropertyType")]
  public class TrianglePatchArrayPropertyType : SurfacePatchArrayPropertyType {

  }

}
