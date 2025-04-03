
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : date, @gisvlasta
// History           : 
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/topology.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="AbstractTopologyType" abstract="true">
//   <annotation>
//     <documentation>
//       This abstract type supplies the root or base type for all topological elements
//       including primitives and complexes. It inherits AbstractGMLType and hence can be
//       identified using the gml:id attribute.
//     </documentation>
//   </annotation>
//   <complexContent>
//     <extension base="gml:AbstractGMLType"/>
//   </complexContent>
// </complexType>
// <element name="AbstractTopology" type="gml:AbstractTopologyType" abstract="true" substitutionGroup="gml:AbstractGML"/>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Topology {

  /// <summary>
  /// This abstract type supplies the root or base type for all topological elements including primitives and complexes.
  /// It inherits AbstractGMLType and hence can be identified using the gml:id attribute.
  /// </summary>
  //[XmlInclude(typeof(TopoComplexType))]
  //[XmlInclude(typeof(TopoVolumeType))]
  //[XmlInclude(typeof(TopoSurfaceType))]
  //[XmlInclude(typeof(TopoCurveType))]
  //[XmlInclude(typeof(TopoPointType))]
  //[XmlInclude(typeof(AbstractTopoPrimitiveType))]
  //[XmlInclude(typeof(TopoSolidType))]
  //[XmlInclude(typeof(NodeType))]
  //[XmlInclude(typeof(EdgeType))]
  //[XmlInclude(typeof(FaceType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractTopologyType")]
  public abstract class AbstractTopologyType : AbstractGMLType {

  }

}
