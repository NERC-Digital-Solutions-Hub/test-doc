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
// <complexType name="MultiSurfaceType">
//   <complexContent>
//     <extension base="gml:AbstractGeometricAggregateType">
//       <sequence>
//         <element ref="gml:surfaceMember" minOccurs="0" maxOccurs="unbounded"/>
//         <element ref="gml:surfaceMembers" minOccurs="0"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="MultiSurface" type="gml:MultiSurfaceType" substitutionGroup="gml:AbstractGeometricAggregate">
//   <annotation>
//     <documentation>
//       A gml:MultiSurface is defined by one or more gml:AbstractSurfaces.
//       The members of the geometric aggregate may be specified either using the "standard" property (gml:surfaceMember) or 
//       the array property (gml:surfaceMembers). It is also valid to use both the "standard" and the array properties in 
//       the same collection.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Geospatial.Gml.Geometry.Basic2D;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Aggregates {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("MultiSurfaceType")]
  public class MultiSurfaceType : AbstractGeometricAggregateType {
    #region Private fields
    private List<SurfacePropertyType> _surfaceMember;
    private SurfaceArrayPropertyType _surfaceMembers;
    #endregion

    /// <summary>
    /// MultiSurfaceType class constructor
    /// </summary>
    public MultiSurfaceType() {
      _surfaceMembers = new SurfaceArrayPropertyType();
      _surfaceMember = new List<SurfacePropertyType>();
    }

    [XmlElement("surfaceMember", Order = 0)]
    [JsonProperty("surfaceMember", Order = 0)]
    public List<SurfacePropertyType> SurfaceMember {
      get {
        return _surfaceMember;
      }
      set {
        if (_surfaceMember == value) {
          return;
        }
        if (_surfaceMember == null || _surfaceMember.Equals(value) != true) {
          _surfaceMember = value;
          OnPropertyChanged("SurfaceMember");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("surfaceMembers", Order = 1)]
    public SurfaceArrayPropertyType SurfaceMembers {
      get {
        return _surfaceMembers;
      }
      set {
        if (_surfaceMembers == value) {
          return;
        }
        if (_surfaceMembers == null || _surfaceMembers.Equals(value) != true) {
          _surfaceMembers = value;
          OnPropertyChanged("SurfaceMembers");
        }
      }
    }
  }
}
