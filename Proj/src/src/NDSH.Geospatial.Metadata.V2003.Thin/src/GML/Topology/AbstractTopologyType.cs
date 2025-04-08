
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Topology {



  /// <summary>
  /// This abstract type supplies the root or base type for all topological elements including primitives and complexes. It inherits AbstractGMLType and hence can be identified using the gml:id attribute.
  /// </summary>
  [XmlInclude(typeof(TopoComplexType))]
  [XmlInclude(typeof(TopoVolumeType))]
  [XmlInclude(typeof(TopoSurfaceType))]
  [XmlInclude(typeof(TopoCurveType))]
  [XmlInclude(typeof(TopoPointType))]
  [XmlInclude(typeof(AbstractTopoPrimitiveType))]
  [XmlInclude(typeof(TopoSolidType))]
  [XmlInclude(typeof(NodeType))]
  [XmlInclude(typeof(EdgeType))]
  [XmlInclude(typeof(FaceType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractTopologyType")]
  public abstract class AbstractTopologyType : AbstractGMLType {
  }
}