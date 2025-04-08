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
// <complexType name="AbstractRingType" abstract="true">
//   <sequence/>
// </complexType>
// <element name="AbstractRing" type="gml:AbstractRingType" abstract="true" substitutionGroup="gml:AbstractObject">
//   <annotation>
//     <documentation>
//       An abstraction of a ring to support surface boundaries of different complexity.
//       The AbstractRing element is the abstract head of the substituition group for all closed boundaries of a surface patch.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Apps;
using NDSH.Geospatial.Gml.Geometry.Primitives;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Basic2D {

  /// <summary>
  /// 
  /// </summary>
  //[XmlInclude(typeof(RingType))]
  //[XmlInclude(typeof(LinearRingType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractRingType")]
  public abstract class AbstractRingType : ObservableModel {

  }

}
