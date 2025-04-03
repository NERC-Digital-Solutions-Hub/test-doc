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
// XSD               : /2005/gml/geometryComplexes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="CompositeSolidType">
//   <complexContent>
//     <extension base="gml:AbstractSolidType">
//       <sequence>
//         <element ref="gml:solidMember" maxOccurs="unbounded"/>
//       </sequence>
//       <attributeGroup ref="gml:AggregationAttributeGroup"/>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="CompositeSolid" type="gml:CompositeSolidType" substitutionGroup="gml:AbstractSolid">
//   <annotation>
//     <documentation>
//       gml:CompositeSolid implements ISO 19107 GM_CompositeSolid
//       (see ISO 19107:2003, 6.6.7) as specified in D.2.3.6. 
//       A gml:CompositeSolid is represented by a set of orientable surfaces.
//       It is a geometry type with all the geometric properties of a (primitive) solid.
//       Essentially, a composite solid is a collection of solids that join in pairs on
//       common boundary surfaces and which, when considered as a whole, form a single solid. 
//       solidMember references or contains one solid in the composite solid. The solids are contiguous.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion


using NDSH.Geospatial.Gml.Geometry.Primitives;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Complexes {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CompositeSolidType")]
  public class CompositeSolidType : AbstractSolidType {
    #region Private fields
    private List<SolidPropertyType> _solidMember;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// CompositeSolidType class constructor
    /// </summary>
    public CompositeSolidType() {
      _solidMember = new List<SolidPropertyType>();
    }

    [XmlElement("solidMember", Order = 0)]
    [JsonProperty("solidMember", Order = 0)]
    public List<SolidPropertyType> SolidMember {
      get {
        return _solidMember;
      }
      set {
        if (_solidMember == value) {
          return;
        }
        if (_solidMember == null || _solidMember.Equals(value) != true) {
          _solidMember = value;
          OnPropertyChanged("SolidMember");
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
