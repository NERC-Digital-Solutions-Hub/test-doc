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
  [Serializable]
  [XmlType("ArcByBulgeType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ArcByBulgeType")]
  public class ArcByBulgeType : ArcStringByBulgeType {

  }

}
