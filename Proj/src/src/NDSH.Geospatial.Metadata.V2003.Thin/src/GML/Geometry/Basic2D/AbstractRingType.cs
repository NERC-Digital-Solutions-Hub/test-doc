
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Primitives;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic2D {

  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(RingType))]
  [XmlInclude(typeof(LinearRingType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractRingType")]
  public abstract class AbstractRingType : Model {

  }

}
