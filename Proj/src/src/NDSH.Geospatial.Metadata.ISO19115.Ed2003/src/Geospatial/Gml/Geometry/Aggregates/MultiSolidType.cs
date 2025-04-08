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
// <complexType name="MultiSolidType">
//   <complexContent>
//     <extension base="gml:AbstractGeometricAggregateType">
//       <sequence>
//         <element ref="gml:solidMember" minOccurs="0" maxOccurs="unbounded"/>
//         <element ref="gml:solidMembers" minOccurs="0"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="MultiSolid" type="gml:MultiSolidType" substitutionGroup="gml:AbstractGeometricAggregate">
//   <annotation>
//     <documentation>
//       A gml:MultiSolid is defined by one or more gml:AbstractSolids.
//       The members of the geometric aggregate may be specified either using the "standard" property (gml:solidMember) or the array 
//       property (gml:solidMembers). It is also valid to use both the "standard" and the array properties in the same collection.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Geospatial.Gml.Geometry.Primitives;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Aggregates {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("MultiSolidType")]
  public class MultiSolidType : AbstractGeometricAggregateType {
    #region Private fields
    private List<SolidPropertyType> _solidMember;
    private SolidArrayPropertyType _solidMembers;
    #endregion

    /// <summary>
    /// MultiSolidType class constructor
    /// </summary>
    public MultiSolidType() {
      _solidMembers = new SolidArrayPropertyType();
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

    [XmlElement(Order = 1)]
    [JsonProperty("solidMembers", Order = 1)]
    public SolidArrayPropertyType SolidMembers {
      get {
        return _solidMembers;
      }
      set {
        if (_solidMembers == value) {
          return;
        }
        if (_solidMembers == null || _solidMembers.Equals(value) != true) {
          _solidMembers = value;
          OnPropertyChanged("SolidMembers");
        }
      }
    }
  }
}
