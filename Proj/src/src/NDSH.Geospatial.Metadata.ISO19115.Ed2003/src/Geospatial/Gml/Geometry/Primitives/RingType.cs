
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
  [JsonObject("RingType")]
  public class RingType : AbstractRingType {
    #region Private fields
    private List<CurvePropertyType> _curveMember;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// RingType class constructor
    /// </summary>
    public RingType() {
      _curveMember = new List<CurvePropertyType>();
    }

    [XmlElement("curveMember", Order = 0)]
    [JsonProperty("curveMember", Order = 0)]
    public List<CurvePropertyType> CurveMember {
      get {
        return _curveMember;
      }
      set {
        if (_curveMember == value) {
          return;
        }
        if (_curveMember == null || _curveMember.Equals(value) != true) {
          _curveMember = value;
          OnPropertyChanged("CurveMember");
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
