
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

using NDSH.Apps;

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

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TopoVolumePropertyType")]
  public class TopoVolumePropertyType : ObservableModel {

    #region Private fields
    private TopoVolumeType _topoVolume;
    private bool _owns;
    #endregion

    /// <summary>
    /// TopoVolumePropertyType class constructor
    /// </summary>
    public TopoVolumePropertyType() {
      _topoVolume = default; // new TopoVolumeType();
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TopoVolume", Order = 0)]
    public TopoVolumeType TopoVolume {
      get {
        return _topoVolume;
      }
      set {
        if (_topoVolume == value) {
          return;
        }
        if (_topoVolume == null || _topoVolume.Equals(value) != true) {
          _topoVolume = value;
          OnPropertyChanged("TopoVolume");
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
