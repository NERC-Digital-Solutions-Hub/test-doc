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
// <complexType name="CompositeSurfaceType">
//   <complexContent>
//     <extension base="gml:AbstractSurfaceType">
//       <sequence>
//         <element ref="gml:surfaceMember" maxOccurs="unbounded"/>
//       </sequence>
//       <attributeGroup ref="gml:AggregationAttributeGroup"/>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="CompositeSurface" type="gml:CompositeSurfaceType" substitutionGroup="gml:AbstractSurface">
//   <annotation>
//     <documentation>
//       A gml:CompositeSurface is represented by a set of orientable surfaces.
//       It is geometry type with all the geometric properties of a (primitive) surface.
//       Essentially, a composite surface is a collection of surfaces that join in pairs
//       on common boundary curves and which, when considered as a whole, form a single surface.
//       surfaceMember references or contains inline one surface in the composite surface. 
//       The surfaces are contiguous.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion


using NDSH.Geospatial.Gml.Geometry.Basic2D;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Complexes {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CompositeSurfaceType")]
  public class CompositeSurfaceType : AbstractSurfaceType {
    #region Private fields
    private List<SurfacePropertyType> _surfaceMember;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// CompositeSurfaceType class constructor
    /// </summary>
    public CompositeSurfaceType() {
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
