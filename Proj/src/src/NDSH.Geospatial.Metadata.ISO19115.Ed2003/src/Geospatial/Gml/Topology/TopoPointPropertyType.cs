
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

using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Topology {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TopoPointPropertyType")]
  public class TopoPointPropertyType : ObservableModel {

    #region Private fields
    private TopoPointType _topoPoint;
    private bool _owns;
    #endregion

    /// <summary>
    /// TopoPointPropertyType class constructor
    /// </summary>
    public TopoPointPropertyType() {
      _topoPoint = default; // new TopoPointType();
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TopoPoint", Order = 0)]
    public TopoPointType TopoPoint {
      get {
        return _topoPoint;
      }
      set {
        if (_topoPoint == value) {
          return;
        }
        if (_topoPoint == null || _topoPoint.Equals(value) != true) {
          _topoPoint = value;
          OnPropertyChanged("TopoPoint");
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
