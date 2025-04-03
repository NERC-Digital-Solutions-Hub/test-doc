
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
// <complexType name="RingType">
//   <complexContent>
//     <extension base="gml:AbstractRingType">
//       <sequence>
//         <element ref="gml:curveMember" maxOccurs="unbounded"/>
//       </sequence>
//       <attributeGroup ref="gml:AggregationAttributeGroup"/>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="Ring" type="gml:RingType" substitutionGroup="gml:AbstractRing">
//   <annotation>
//     <documentation>
//       A ring is used to represent a single connected component of a surface boundary as specified in ISO 19107:2003, 6.3.6.
//       Every gml:curveMember references or contains one curve, i.e. any element which is substitutable for gml:AbstractCurve.
//       In the context of a ring, the curves describe the boundary of the surface.
//       The sequence of curves shall be contiguous and connected in a cycle.
//       If provided, the aggregationType attribute shall have the value “sequence”.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="RingPropertyType">
//   <annotation>
//     <documentation>
//       A property with the content model of gml:RingPropertyType encapsulates a ring to represent a
//       component of a surface boundary.
//     </documentation>
//   </annotation>
//   <sequence>
//     <element ref="gml:Ring"/>
//   </sequence>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Apps;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Geometry.Primitives {

  /// <summary>
  /// A property with the content model of gml:RingPropertyType encapsulates a ring to represent a component of a surface boundary.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("RingPropertyType")]
  public class RingPropertyType : ObservableModel {

    #region Private fields
    private RingType _ring;
    #endregion

    /// <summary>
    /// RingPropertyType class constructor
    /// </summary>
    public RingPropertyType() {
      _ring = new RingType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("Ring", Order = 0)]
    public RingType Ring {
      get {
        return _ring;
      }
      set {
        if (_ring == value) {
          return;
        }
        if (_ring == null || _ring.Equals(value) != true) {
          _ring = value;
          OnPropertyChanged("Ring");
        }
      }
    }
  }

}
