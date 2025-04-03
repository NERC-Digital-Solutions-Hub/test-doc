
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
// <complexType name="TopoComplexType">
//   <complexContent>
//     <extension base="gml:AbstractTopologyType">
//       <sequence>
//         <element ref="gml:maximalComplex"/>
//         <element ref="gml:superComplex" minOccurs="0" maxOccurs="unbounded"/>
//         <element ref="gml:subComplex" minOccurs="0" maxOccurs="unbounded"/>
//         <element ref="gml:topoPrimitiveMember" minOccurs="0" maxOccurs="unbounded"/>
//         <element ref="gml:topoPrimitiveMembers" minOccurs="0"/>
//       </sequence>
//       <attribute name="isMaximal" type="boolean" default="false"/>
//       <attributeGroup ref="gml:AggregationAttributeGroup"/>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="TopoComplex" type="gml:TopoComplexType" substitutionGroup="gml:AbstractTopology">
//   <annotation>
//     <documentation>
//       gml:TopoComplex is a collection of topological primitives.
//       Each complex holds a reference to its maximal complex (gml:maximalComplex)
//       and optionally to sub- or super-complexes (gml:subComplex, gml:superComplex). 
//       A topology complex contains its primitive and sub-complex members.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Topology {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TopoComplexType")]
  public class TopoComplexType : AbstractTopologyType {

    #region Private fields
    private TopoComplexMemberType _maximalComplex;
    private List<TopoComplexMemberType> _superComplex;
    private List<TopoComplexMemberType> _subComplex;
    private List<TopoPrimitiveMemberType> _topoPrimitiveMember;
    private TopoPrimitiveArrayAssociationType _topoPrimitiveMembers;
    private bool _isMaximal;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// TopoComplexType class constructor
    /// </summary>
    public TopoComplexType() {
      _topoPrimitiveMembers = new TopoPrimitiveArrayAssociationType();
      _topoPrimitiveMember = new List<TopoPrimitiveMemberType>();
      _subComplex = new List<TopoComplexMemberType>();
      _superComplex = new List<TopoComplexMemberType>();
      _maximalComplex = new TopoComplexMemberType();
      _isMaximal = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("maximalComplex", Order = 0)]
    public TopoComplexMemberType MaximalComplex {
      get {
        return _maximalComplex;
      }
      set {
        if (_maximalComplex == value) {
          return;
        }
        if (_maximalComplex == null || _maximalComplex.Equals(value) != true) {
          _maximalComplex = value;
          OnPropertyChanged("MaximalComplex");
        }
      }
    }

    [XmlElement("superComplex", Order = 1)]
    [JsonProperty("superComplex", Order = 1)]
    public List<TopoComplexMemberType> SuperComplex {
      get {
        return _superComplex;
      }
      set {
        if (_superComplex == value) {
          return;
        }
        if (_superComplex == null || _superComplex.Equals(value) != true) {
          _superComplex = value;
          OnPropertyChanged("SuperComplex");
        }
      }
    }

    [XmlElement("subComplex", Order = 2)]
    [JsonProperty("subComplex", Order = 2)]
    public List<TopoComplexMemberType> SubComplex {
      get {
        return _subComplex;
      }
      set {
        if (_subComplex == value) {
          return;
        }
        if (_subComplex == null || _subComplex.Equals(value) != true) {
          _subComplex = value;
          OnPropertyChanged("SubComplex");
        }
      }
    }

    [XmlElement("topoPrimitiveMember", Order = 3)]
    [JsonProperty("topoPrimitiveMember", Order = 3)]
    public List<TopoPrimitiveMemberType> TopoPrimitiveMember {
      get {
        return _topoPrimitiveMember;
      }
      set {
        if (_topoPrimitiveMember == value) {
          return;
        }
        if (_topoPrimitiveMember == null || _topoPrimitiveMember.Equals(value) != true) {
          _topoPrimitiveMember = value;
          OnPropertyChanged("TopoPrimitiveMember");
        }
      }
    }

    [XmlElement(Order = 4)]
    [JsonProperty("topoPrimitiveMembers", Order = 4)]
    public TopoPrimitiveArrayAssociationType TopoPrimitiveMembers {
      get {
        return _topoPrimitiveMembers;
      }
      set {
        if (_topoPrimitiveMembers == value) {
          return;
        }
        if (_topoPrimitiveMembers == null || _topoPrimitiveMembers.Equals(value) != true) {
          _topoPrimitiveMembers = value;
          OnPropertyChanged("TopoPrimitiveMembers");
        }
      }
    }

    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty("isMaximal")]
    public bool IsMaximal {
      get {
        return _isMaximal;
      }
      set {
        if (_isMaximal.Equals(value) != true) {
          _isMaximal = value;
          OnPropertyChanged("IsMaximal");
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
