
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
// <complexType name="PolygonPatchType">
//   <complexContent>
//     <extension base="gml:AbstractSurfacePatchType">
//       <sequence>
//         <element ref="gml:exterior" minOccurs="0"/>
//         <element ref="gml:interior" minOccurs="0" maxOccurs="unbounded"/>
//       </sequence>
//       <attribute name="interpolation" type="gml:SurfaceInterpolationType" fixed="planar"/>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="PolygonPatch" type="gml:PolygonPatchType" substitutionGroup="gml:AbstractSurfacePatch">
//   <annotation>
//     <documentation>
//       A gml:PolygonPatch is a surface patch that is defined by a set of boundary curves
//       and an underlying surface to which these curves adhere. The curves shall be coplanar
//       and the polygon uses planar interpolation in its interior. 
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

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("PolygonPatchType")]
  public class PolygonPatchType : AbstractSurfacePatchType {
    #region Private fields
    private AbstractRingPropertyType _exterior;
    private List<AbstractRingPropertyType> _interior;
    private SurfaceInterpolationType _interpolation;
    #endregion

    /// <summary>
    /// PolygonPatchType class constructor
    /// </summary>
    public PolygonPatchType() {
      _interior = new List<AbstractRingPropertyType>();
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

    [XmlElement("interior", Order = 1)]
    [JsonProperty("interior", Order = 1)]
    public List<AbstractRingPropertyType> Interior {
      get {
        return _interior;
      }
      set {
        if (_interior == value) {
          return;
        }
        if (_interior == null || _interior.Equals(value) != true) {
          _interior = value;
          OnPropertyChanged("Interior");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("interpolation")]
    public SurfaceInterpolationType interpolation {
      get {
        return _interpolation;
      }
      set {
        if (_interpolation.Equals(value) != true) {
          _interpolation = value;
          OnPropertyChanged("interpolation");
        }
      }
    }
  }

}
