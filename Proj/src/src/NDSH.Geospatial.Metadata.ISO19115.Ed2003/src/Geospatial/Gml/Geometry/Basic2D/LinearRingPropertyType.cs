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
// XSD               : /2005/gml/geometryBasic2d.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="LinearRingType">
//   <complexContent>
//     <extension base="gml:AbstractRingType">
//       <sequence>
//         <choice>
//           <choice minOccurs="4" maxOccurs="unbounded">
//             <element ref="gml:pos"/>
//             <element ref="gml:pointProperty"/>
//             <element ref="gml:pointRep"/>
//           </choice>
//           <element ref="gml:posList"/>
//           <element ref="gml:coordinates"/>
//         </choice>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="LinearRing" type="gml:LinearRingType" substitutionGroup="gml:AbstractRing">
//   <annotation>
//     <documentation>
//       A LinearRing is defined by four or more coordinate tuples, with linear interpolation
//       between them; the first and last coordinates shall be coincident. The number of direct
//       positions in the list shall be at least four.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="LinearRingPropertyType">
//   <annotation>
//     <documentation>
//       A property with the content model of gml:LinearRingPropertyType encapsulates a linear
//       ring to represent a component of a surface boundary.
//     </documentation>
//   </annotation>
//   <sequence>
//     <element ref="gml:LinearRing"/>
//   </sequence>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Apps;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Basic2D {

  /// <summary>
  /// A property with the content model of gml:LinearRingPropertyType encapsulates a linear ring to represent a component of a surface boundary.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("LinearRingPropertyType")]
  public class LinearRingPropertyType : ObservableModel {
    #region Private fields
    private LinearRingType _linearRing;
    #endregion

    /// <summary>
    /// LinearRingPropertyType class constructor
    /// </summary>
    public LinearRingPropertyType() {
      _linearRing = new LinearRingType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("LinearRing", Order = 0)]
    public LinearRingType LinearRing {
      get {
        return _linearRing;
      }
      set {
        if (_linearRing == value) {
          return;
        }
        if (_linearRing == null || _linearRing.Equals(value) != true) {
          _linearRing = value;
          OnPropertyChanged("LinearRing");
        }
      }
    }
  }
}
