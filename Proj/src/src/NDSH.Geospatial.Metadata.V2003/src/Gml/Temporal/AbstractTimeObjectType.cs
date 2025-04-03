using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using NDSH.Geospatial.Metadata.V2003.Gml.Temporal.Topology;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Temporal {

  [XmlInclude(typeof(AbstractTimeComplexType))]
  [XmlInclude(typeof(TimeTopologyComplexType))]
  [XmlInclude(typeof(AbstractTimePrimitiveType))]
  [XmlInclude(typeof(AbstractTimeTopologyPrimitiveType))]
  [XmlInclude(typeof(TimeEdgeType))]
  [XmlInclude(typeof(TimeNodeType))]
  [XmlInclude(typeof(AbstractTimeGeometricPrimitiveType))]
  [XmlInclude(typeof(TimePeriodType))]
  [XmlInclude(typeof(TimeInstantType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractTimeObjectType")]
  public abstract class AbstractTimeObjectType : AbstractGMLType {
  }
}
