
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

using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Topology {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TopoSurfacePropertyType")]
  public class TopoSurfacePropertyType : ObservableModel {

    #region Private fields
    private TopoSurfaceType _topoSurface;
    private bool _owns;
    #endregion

    /// <summary>
    /// TopoSurfacePropertyType class constructor
    /// </summary>
    public TopoSurfacePropertyType() {
      _topoSurface = default; // new TopoSurfaceType();
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TopoSurface", Order = 0)]
    public TopoSurfaceType TopoSurface {
      get {
        return _topoSurface;
      }
      set {
        if (_topoSurface == value) {
          return;
        }
        if (_topoSurface == null || _topoSurface.Equals(value) != true) {
          _topoSurface = value;
          OnPropertyChanged("TopoSurface");
        }
      }
    }

    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty("owns")]
    public bool Owns {
      get {
        return _owns;
      }
      set {
        if (_owns.Equals(value) != true) {
          _owns = value;
          OnPropertyChanged("Owns");
        }
      }
    }

  }

}
