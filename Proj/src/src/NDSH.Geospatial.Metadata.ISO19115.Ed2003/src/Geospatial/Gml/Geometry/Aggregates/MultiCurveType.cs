
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
// XSD               : /2005/gml/geometryAggregates.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="MultiCurveType">
//   <complexContent>
//     <extension base="gml:AbstractGeometricAggregateType">
//       <sequence>
//         <element ref="gml:curveMember" minOccurs="0" maxOccurs="unbounded"/>
//         <element ref="gml:curveMembers" minOccurs="0"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="MultiCurve" type="gml:MultiCurveType" substitutionGroup="gml:AbstractGeometricAggregate">
//   <annotation>
//     <documentation>
//       A gml:MultiCurve is defined by one or more gml:AbstractCurves.
//       The members of the geometric aggregate may be specified either using the "standard" property (gml:curveMember) 
//       or the array property (gml:curveMembers). It is also valid to use both the "standard" and the array properties 
//       in the same collection.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Geospatial.Gml.Geometry.Basic0D1D;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Aggregates {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("MultiCurveType")]
  public class MultiCurveType : AbstractGeometricAggregateType {
    #region Private fields
    private List<CurvePropertyType> _curveMember;
    private CurveArrayPropertyType _curveMembers;
    #endregion

    /// <summary>
    /// MultiCurveType class constructor
    /// </summary>
    public MultiCurveType() {
      _curveMembers = new CurveArrayPropertyType();
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

    [XmlElement(Order = 1)]
    [JsonProperty("curveMembers", Order = 1)]
    public CurveArrayPropertyType CurveMembers {
      get {
        return _curveMembers;
      }
      set {
        if (_curveMembers == value) {
          return;
        }
        if (_curveMembers == null || _curveMembers.Equals(value) != true) {
          _curveMembers = value;
          OnPropertyChanged("CurveMembers");
        }
      }
    }
  }
}
