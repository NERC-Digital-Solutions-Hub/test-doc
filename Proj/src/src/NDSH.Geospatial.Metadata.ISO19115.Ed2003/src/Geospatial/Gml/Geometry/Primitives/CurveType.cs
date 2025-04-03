
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
// <complexType name="CurveType">
//   <complexContent>
//     <extension base="gml:AbstractCurveType">
//       <sequence>
//         <element ref="gml:segments"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="Curve" type="gml:CurveType" substitutionGroup="gml:AbstractCurve">
//   <annotation>
//     <documentation>
//       A curve is a 1-dimensional primitive. Curves are continuous, connected,
//       and have a measurable length in terms of the coordinate system. 
//       A curve is composed of one or more curve segments. Each curve segment
//       within a curve may be defined using a different interpolation method.
//       The curve segments are connected to one another, with the end point of
//       each segment except the last being the start point of the next segment in the segment list.
//       The orientation of the curve is positive.
//       The element segments encapsulates the segments of the curve.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Geospatial.Gml.Geometry.Basic0D1D;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CurveType")]
  public class CurveType : AbstractCurveType {
    #region Private fields
    private CurveSegmentArrayPropertyType _segments;
    #endregion

    /// <summary>
    /// CurveType class constructor
    /// </summary>
    public CurveType() {
      _segments = new CurveSegmentArrayPropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("segments", Order = 0)]
    public CurveSegmentArrayPropertyType Segments {
      get {
        return _segments;
      }
      set {
        if (_segments == value) {
          return;
        }
        if (_segments == null || _segments.Equals(value) != true) {
          _segments = value;
          OnPropertyChanged("Segments");
        }
      }
    }
  }

}
