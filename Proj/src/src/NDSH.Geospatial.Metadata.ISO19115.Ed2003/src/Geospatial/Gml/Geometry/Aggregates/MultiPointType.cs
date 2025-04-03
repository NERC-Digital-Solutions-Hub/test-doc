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
// <complexType name="MultiPointType">
//   <complexContent>
//     <extension base="gml:AbstractGeometricAggregateType">
//       <sequence>
//         <element ref="gml:pointMember" minOccurs="0" maxOccurs="unbounded"/>
//         <element ref="gml:pointMembers" minOccurs="0"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="MultiPoint" type="gml:MultiPointType" substitutionGroup="gml:AbstractGeometricAggregate">
//   <annotation>
//     <documentation>
//       A gml:MultiPoint consists of one or more gml:Points.
//       The members of the geometric aggregate may be specified either using the "standard" property (gml:pointMember) or the array property 
//       (gml:pointMembers). It is also valid to use both the "standard" and the array properties in the same collection.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Geospatial.Gml.Geometry.Basic0D1D;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Aggregates {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("MultiPointType")]
  public class MultiPointType : AbstractGeometricAggregateType {
    #region Private fields
    private List<PointPropertyType> _pointMember;
    private PointArrayPropertyType _pointMembers;
    #endregion

    /// <summary>
    /// MultiPointType class constructor
    /// </summary>
    public MultiPointType() {
      _pointMembers = new PointArrayPropertyType();
      _pointMember = new List<PointPropertyType>();
    }

    [XmlElement("pointMember", Order = 0)]
    [JsonProperty("pointMember", Order = 0)]
    public List<PointPropertyType> PointMember {
      get {
        return _pointMember;
      }
      set {
        if (_pointMember == value) {
          return;
        }
        if (_pointMember == null || _pointMember.Equals(value) != true) {
          _pointMember = value;
          OnPropertyChanged("PointMember");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("pointMembers", Order = 1)]
    public PointArrayPropertyType PointMembers {
      get {
        return _pointMembers;
      }
      set {
        if (_pointMembers == value) {
          return;
        }
        if (_pointMembers == null || _pointMembers.Equals(value) != true) {
          _pointMembers = value;
          OnPropertyChanged("PointMembers");
        }
      }
    }
  }
}
