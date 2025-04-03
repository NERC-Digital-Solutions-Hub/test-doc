
using NDSH.Apps;
using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Primitives;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic2D {

  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(RingType))]
  [XmlInclude(typeof(LinearRingType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractRingType")]
  public abstract class AbstractRingType : ObservableModel {

  }

}
