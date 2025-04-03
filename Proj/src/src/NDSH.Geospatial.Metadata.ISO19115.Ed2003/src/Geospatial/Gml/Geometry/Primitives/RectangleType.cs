
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
// XSD               : /2005/gml/geometryPrimitives.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="RectangleType">
//   <complexContent>
//     <extension base="gml:AbstractSurfacePatchType">
//       <sequence>
//         <element ref="gml:exterior"/>
//       </sequence>
//       <attribute name="interpolation" type="gml:SurfaceInterpolationType" fixed="planar"/>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="Rectangle" type="gml:RectangleType" substitutionGroup="gml:AbstractSurfacePatch">
//   <annotation>
//     <documentation>
//       gml:Rectangle represents a rectangle as a surface patch with an outer boundary consisting of a linear ring.
//       Note that this is a polygon (subtype) with no inner boundaries. The number of points in the linear ring shall be five.
//       The ring (element exterior) shall be a gml:LinearRing and shall form a rectangle;
//       the first and the last position shall be coincident.
//       interpolation is fixed to "planar", i.e. an interpolation shall return points on a single plane.
//       The boundary of the patch shall be contained within that plane.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Geospatial.Gml.Geometry.Basic0D1D;
using NDSH.Geospatial.Gml.Geometry.Basic2D;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Primitives {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("RectangleType")]
  public class RectangleType : AbstractSurfacePatchType {
    #region Private fields
    private AbstractRingPropertyType _exterior;
    private SurfaceInterpolationType _interpolation;
    #endregion

    /// <summary>
    /// RectangleType class constructor
    /// </summary>
    public RectangleType() {
      _exterior = new AbstractRingPropertyType();
      _interpolation = SurfaceInterpolationType.planar;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("exterior", Order = 0)]
    public AbstractRingPropertyType Exterior {
      get {
        return _exterior;
      }
      set {
        if (_exterior == value) {
          return;
        }
        if (_exterior == null || _exterior.Equals(value) != true) {
          _exterior = value;
          OnPropertyChanged("Exterior");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("interpolation")]
    public SurfaceInterpolationType Interpolation {
      get {
        return _interpolation;
      }
      set {
        if (_interpolation.Equals(value) != true) {
          _interpolation = value;
          OnPropertyChanged("Interpolation");
        }
      }
    }
  }

}
