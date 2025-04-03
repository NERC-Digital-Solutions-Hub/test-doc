
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
// <complexType name="TopoPointType">
//   <complexContent>
//     <extension base="gml:AbstractTopologyType">
//       <sequence>
//         <element ref="gml:directedNode"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="TopoPoint" type="gml:TopoPointType">
//   <annotation>
//     <documentation>
//       The intended use of gml:TopoPoint is to appear within a point feature
//       to express the structural and possibly geometric relationships of this
//       feature to other features via shared node definitions.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="TopoPointPropertyType">
//   <sequence>
//     <element ref="gml:TopoPoint"/>
//   </sequence>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
// <element name="topoPointProperty" type="gml:TopoPointPropertyType">
//   <annotation>
//     <documentation>
//       The gml:topoPointProperty property element may be used in features to
//       express their relationship to the referenced topology node.
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
  [JsonObject("TopoPointType")]
  public class TopoPointType : AbstractTopologyType {

    #region Private fields
    private DirectedNodePropertyType _directedNode;
    #endregion

    /// <summary>
    /// TopoPointType class constructor
    /// </summary>
    public TopoPointType() {
      _directedNode = new DirectedNodePropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("directedNode", Order = 0)]
    public DirectedNodePropertyType DirectedNode {
      get {
        return _directedNode;
      }
      set {
        if (_directedNode == value) {
          return;
        }
        if (_directedNode == null || _directedNode.Equals(value) != true) {
          _directedNode = value;
          OnPropertyChanged("DirectedNode");
        }
      }
    }

  }

}
