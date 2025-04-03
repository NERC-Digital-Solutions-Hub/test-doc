
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
// <complexType name="TopoVolumeType">
//   <complexContent>
//     <extension base="gml:AbstractTopologyType">
//       <sequence>
//         <element ref="gml:directedTopoSolid" maxOccurs="unbounded"/>
//       </sequence>
//       <attributeGroup ref="gml:AggregationAttributeGroup"/>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="TopoVolume" type="gml:TopoVolumeType">
//   <annotation>
//     <documentation>
//       gml:TopoVolume represents a homogeneous topological expression,
//       a set of directed topologic solids, which if realised are isomorphic
//       to a geometric solid primitive. The intended use of gml:TopoVolume is
//       to appear within a solid feature to express the structural and geometric
//       relationships of this solid feature to other features via the shared solid definitions.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="TopoVolumePropertyType">
//   <sequence>
//     <element ref="gml:TopoVolume"/>
//   </sequence>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
// <element name="topoVolumeProperty" type="gml:TopoVolumePropertyType">
//   <annotation>
//     <documentation>
//       The gml:topoVolumeProperty element may be used in features to
//       express their relationship to the referenced topology volume.
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
  [JsonObject("TopoVolumeType")]
  public class TopoVolumeType : AbstractTopologyType {

    #region Private fields
    private List<DirectedTopoSolidPropertyType> _directedTopoSolid;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// TopoVolumeType class constructor
    /// </summary>
    public TopoVolumeType() {
      _directedTopoSolid = new List<DirectedTopoSolidPropertyType>();
    }

    [XmlElement("directedTopoSolid", Order = 0)]
    [JsonProperty("directedTopoSolid", Order = 0)]
    public List<DirectedTopoSolidPropertyType> DirectedTopoSolid {
      get {
        return _directedTopoSolid;
      }
      set {
        if (_directedTopoSolid == value) {
          return;
        }
        if (_directedTopoSolid == null || _directedTopoSolid.Equals(value) != true) {
          _directedTopoSolid = value;
          OnPropertyChanged("DirectedTopoSolid");
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
