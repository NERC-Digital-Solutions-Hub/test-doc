
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
//       A gml:CompositeSurface is represented by a set of orientable surfaces. It is geometry type with
//       all the geometric properties of a (primitive) surface. Essentially, a composite surface is a
//       collection of surfaces that join in pairs on common boundary curves and which,
//       when considered as a whole, form a single surface.
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

namespace NDSH.Geospatial.Gml.Geometry.Primitives {

  //[XmlInclude(typeof(TriangulatedSurfaceType))]
  //[XmlInclude(typeof(TinType))]
  //[XmlInclude(typeof(PolyhedralSurfaceType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("SurfaceType")]
  public class SurfaceType : AbstractSurfaceType {
    #region Private fields
    private SurfacePatchArrayPropertyType _patches;
    #endregion

    /// <summary>
    /// SurfaceType class constructor
    /// </summary>
    public SurfaceType() {
      _patches = new SurfacePatchArrayPropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("patches", Order = 0)]
    public SurfacePatchArrayPropertyType Patches {
      get {
        return _patches;
      }
      set {
        if (_patches == value) {
          return;
        }
        if (_patches == null || _patches.Equals(value) != true) {
          _patches = value;
          OnPropertyChanged("Patches");
        }
      }
    }
  }

}
