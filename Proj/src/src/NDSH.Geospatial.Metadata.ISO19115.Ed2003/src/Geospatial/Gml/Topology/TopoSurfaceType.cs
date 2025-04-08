
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
// <complexType name="TopoSurfaceType">
//   <complexContent>
//     <extension base="gml:AbstractTopologyType">
//       <sequence>
//         <element ref="gml:directedFace" maxOccurs="unbounded"/>
//       </sequence>
//       <attributeGroup ref="gml:AggregationAttributeGroup"/>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="TopoSurface" type="gml:TopoSurfaceType">
//   <annotation>
//     <documentation>
//       gml:TopoSurface represents a homogeneous topological expression,
//       a set of directed faces, which if realised are isomorphic to a
//       geometric surface primitive. The intended use of gml:TopoSurface
//       is to appear within a surface feature to express the structural
//       and possibly geometric relationships of this surface feature to
//       other features via the shared face definitions.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="TopoSurfacePropertyType">
//   <sequence>
//     <element ref="gml:TopoSurface"/>
//   </sequence>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
// <element name="topoSurfaceProperty" type="gml:TopoSurfacePropertyType">
//   <annotation>
//     <documentation>
//       The gml:topoSurfaceProperty property element may be used in features
//       to express their relationship to the referenced topology faces.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Topology {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TopoSurfaceType")]
  public class TopoSurfaceType : AbstractTopologyType {

    #region Private fields
    private List<DirectedFacePropertyType> _directedFace;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// TopoSurfaceType class constructor
    /// </summary>
    public TopoSurfaceType() {
      _directedFace = new List<DirectedFacePropertyType>();
    }

    [XmlElement("directedFace", Order = 0)]
    [JsonProperty("directedFace", Order = 0)]
    public List<DirectedFacePropertyType> DirectedFace {
      get {
        return _directedFace;
      }
      set {
        if (_directedFace == value) {
          return;
        }
        if (_directedFace == null || _directedFace.Equals(value) != true) {
          _directedFace = value;
          OnPropertyChanged("DirectedFace");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("aggregationType")]
    public AggregationType AggregationType {
      get {
        return _aggregationType;
      }
      set {
        if (_aggregationType.Equals(value) != true) {
          _aggregationType = value;
          OnPropertyChanged("AggregationType");
        }
      }
    }

  }

}
