
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
// <complexType name="TopoCurveType">
//   <complexContent>
//     <extension base="gml:AbstractTopologyType">
//       <sequence>
//         <element ref="gml:directedEdge" maxOccurs="unbounded"/>
//       </sequence>
//       <attributeGroup ref="gml:AggregationAttributeGroup"/>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="TopoCurve" type="gml:TopoCurveType">
//   <annotation>
//     <documentation>
//       gml:TopoCurve represents a homogeneous topological expression, a sequence of directed edges,
//       which if realised are isomorphic to a geometric curve primitive. The intended use of gml:TopoCurve
//       is to appear within a line feature to express the structural and geometric relationships of this
//       feature to other features via the shared edge definitions.
//       If provided, the aggregationType attribute shall have the value “sequence”.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="TopoCurvePropertyType">
//   <sequence>
//     <element ref="gml:TopoCurve"/>
//   </sequence>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
// <element name="topoCurveProperty" type="gml:TopoCurvePropertyType">
//   <annotation>
//     <documentation>
//       The gml:topoCurveProperty property element may be used in features to
//       express their relationship to the referenced topology edges.
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
  [JsonObject("TopoCurvePropertyType")]
  public class TopoCurvePropertyType : ObservableModel {

    #region Private fields
    private TopoCurveType _topoCurve;
    private bool _owns;
    #endregion

    /// <summary>
    /// TopoCurvePropertyType class constructor
    /// </summary>
    public TopoCurvePropertyType() {
      _topoCurve = default; // new TopoCurveType();
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TopoCurve", Order = 0)]
    public TopoCurveType TopoCurve {
      get {
        return _topoCurve;
      }
      set {
        if (_topoCurve == value) {
          return;
        }
        if (_topoCurve == null || _topoCurve.Equals(value) != true) {
          _topoCurve = value;
          OnPropertyChanged("TopoCurve");
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
