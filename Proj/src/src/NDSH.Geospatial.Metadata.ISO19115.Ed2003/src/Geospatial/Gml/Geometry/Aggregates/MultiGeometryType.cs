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
// <complexType name="MultiGeometryType">
//   <complexContent>
//     <extension base="gml:AbstractGeometricAggregateType">
//       <sequence>
//         <element ref="gml:geometryMember" minOccurs="0" maxOccurs="unbounded"/>
//         <element ref="gml:geometryMembers" minOccurs="0"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="MultiGeometry" type="gml:MultiGeometryType" substitutionGroup="gml:AbstractGeometricAggregate">
//   <annotation>
//     <documentation>
//       gml:MultiGeometry is a collection of one or more GML geometry objects of arbitrary type. 
//       The members of the geometric aggregate may be specified either using the "standard" property (gml:geometryMember) 
//       or the array property (gml:geometryMembers). It is also valid to use both the "standard" and the array properties 
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
  [JsonObject("MultiGeometryType")]
  public class MultiGeometryType : AbstractGeometricAggregateType {
    #region Private fields
    private List<GeometryPropertyType> _geometryMember;
    private GeometryArrayPropertyType _geometryMembers;
    #endregion

    /// <summary>
    /// MultiGeometryType class constructor
    /// </summary>
    public MultiGeometryType() {
      _geometryMembers = new GeometryArrayPropertyType();
      _geometryMember = new List<GeometryPropertyType>();
    }

    [XmlElement("geometryMember", Order = 0)]
    [JsonProperty("geometryMember", Order = 0)]
    public List<GeometryPropertyType> GeometryMember {
      get {
        return _geometryMember;
      }
      set {
        if (_geometryMember == value) {
          return;
        }
        if (_geometryMember == null || _geometryMember.Equals(value) != true) {
          _geometryMember = value;
          OnPropertyChanged("GeometryMember");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("geometryMembers", Order = 1)]
    public GeometryArrayPropertyType GeometryMembers {
      get {
        return _geometryMembers;
      }
      set {
        if (_geometryMembers == value) {
          return;
        }
        if (_geometryMembers == null || _geometryMembers.Equals(value) != true) {
          _geometryMembers = value;
          OnPropertyChanged("GeometryMembers");
        }
      }
    }
  }
}
