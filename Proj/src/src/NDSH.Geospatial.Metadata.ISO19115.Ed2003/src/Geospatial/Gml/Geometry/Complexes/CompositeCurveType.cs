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
// <complexType name="CompositeCurveType">
//   <complexContent>
//     <extension base="gml:AbstractCurveType">
//       <sequence>
//         <element ref="gml:curveMember" maxOccurs="unbounded"/>
//       </sequence>
//       <attributeGroup ref="gml:AggregationAttributeGroup"/>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="CompositeCurve" type="gml:CompositeCurveType" substitutionGroup="gml:AbstractCurve">
//   <annotation>
//     <documentation>
//       A gml:CompositeCurve is represented by a sequence of (orientable) curves such
//       that each curve in the sequence terminates at the start point of the subsequent curve in the list. 
//       curveMember references or contains inline one curve in the composite curve. 
//       The curves are contiguous, the collection of curves is ordered. Therefore, if provided,
//       the aggregationType attribute shall have the value “sequence”.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion


using NDSH.Geospatial.Gml.Geometry.Basic0D1D;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Complexes {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CompositeCurveType")]
  public class CompositeCurveType : AbstractCurveType {
    #region Private fields
    private List<CurvePropertyType> _curveMember;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// CompositeCurveType class constructor
    /// </summary>
    public CompositeCurveType() {
      _curveMember = new List<CurvePropertyType>();
    }

    [XmlElement("curveMember", Order = 0)]
    [JsonProperty("curveMember", Order = 0)]
    public List<CurvePropertyType> CurveMember {
      get {
        return _curveMember;
      }
      set {
        if (_curveMember == value) {
          return;
        }
        if (_curveMember == null || _curveMember.Equals(value) != true) {
          _curveMember = value;
          OnPropertyChanged("CurveMember");
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
