
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
// <complexType name="AbstractSurfacePatchType" abstract="true"/>
// <element name="AbstractSurfacePatch" type="gml:AbstractSurfacePatchType" abstract="true">
//   <annotation>
//     <documentation>
//       A surface patch defines a homogenuous portion of a surface. 
//       The AbstractSurfacePatch element is the abstract head of the substituition group
//       for all surface patch elements describing a continuous portion of a surface.
//       All surface patches shall have an attribute interpolation (declared in the types
//       derived from gml:AbstractSurfacePatchType) specifying the interpolation mechanism
//       used for the patch using gml:SurfaceInterpolationType.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Apps;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Primitives {


  //[XmlInclude(typeof(AbstractParametricCurveSurfaceType))]
  //[XmlInclude(typeof(AbstractGriddedSurfaceType))]
  //[XmlInclude(typeof(SphereType))]
  //[XmlInclude(typeof(CylinderType))]
  //[XmlInclude(typeof(ConeType))]
  //[XmlInclude(typeof(RectangleType))]
  //[XmlInclude(typeof(TriangleType))]
  //[XmlInclude(typeof(PolygonPatchType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractSurfacePatchType")]
  public abstract class AbstractSurfacePatchType : ObservableModel {

  }

}
