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
// <element name="exterior" type="gml:AbstractRingPropertyType">
//   <annotation>
//     <documentation>
//       A boundary of a surface consists of a number of rings. In the normal 2D case, one of these rings is distinguished as 
//       being the exterior boundary. In a general manifold this is not always possible, in which case all boundaries shall be listed as 
//       interior boundaries, and the exterior will be empty.
//     </documentation>
//   </annotation>
// </element>
// <element name="interior" type="gml:AbstractRingPropertyType">
//   <annotation>
//     <documentation>
//       A boundary of a surface consists of a number of rings. The "interior" rings separate the surface / surface patch from 
//       the area enclosed by the rings.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="AbstractRingPropertyType">
//   <annotation>
//     <documentation>A property with the content model of gml:AbstractRingPropertyType encapsulates a ring to represent the 
//       surface boundary property of a surface.
//     </documentation>
//   </annotation>
//   <sequence>
//     <element ref="gml:AbstractRing"/>
//   </sequence>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Apps;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Basic2D {

  /// <summary>
  /// A property with the content model of gml:AbstractRingPropertyType encapsulates a ring to represent the surface boundary property of a surface.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractRingPropertyType")]
  public class AbstractRingPropertyType : ObservableModel {
    #region Private fields
    private AbstractRingType _abstractRing;
    #endregion

    [XmlElement(Order = 0)]
    [JsonProperty("AbstractRing", Order = 0)]
    public AbstractRingType AbstractRing {
      get {
        return _abstractRing;
      }
      set {
        if (_abstractRing == value) {
          return;
        }
        if (_abstractRing == null || _abstractRing.Equals(value) != true) {
          _abstractRing = value;
          OnPropertyChanged("AbstractRing");
        }
      }
    }
  }
}
