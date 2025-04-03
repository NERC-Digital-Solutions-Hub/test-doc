
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
// <complexType name="AbstractParametricCurveSurfaceType" abstract="true">
//   <complexContent>
//     <extension base="gml:AbstractSurfacePatchType">
//       <attributeGroup ref="gml:AggregationAttributeGroup"/>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="AbstractParametricCurveSurface" type="gml:AbstractParametricCurveSurfaceType" abstract="true" substitutionGroup="gml:AbstractSurfacePatch">
//   <annotation>
//     <documentation>
//       The element provides a substitution group head for the surface patches based on parametric curves.
//       All properties are specified in the derived subtypes. All derived subtypes shall conform to
//       the constraints specified in ISO 19107:2003, 6.4.40.
//       If provided, the aggregationType attribute shall have the value “set”.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion


using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  //[XmlInclude(typeof(AbstractGriddedSurfaceType))]
  //[XmlInclude(typeof(SphereType))]
  //[XmlInclude(typeof(CylinderType))]
  //[XmlInclude(typeof(ConeType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractParametricCurveSurfaceType")]
  public abstract class AbstractParametricCurveSurfaceType : AbstractSurfacePatchType {
    #region Private fields
    private AggregationType _aggregationType;
    #endregion

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
