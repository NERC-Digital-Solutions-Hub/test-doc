using NDSH.Geospatial.Metadata.V2003.Gml.Temporal.Topology;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Temporal {

  [XmlInclude(typeof(TimeTopologyComplexType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractTimeComplexType")]
  public abstract class AbstractTimeComplexType : AbstractTimeObjectType {
  }

}
