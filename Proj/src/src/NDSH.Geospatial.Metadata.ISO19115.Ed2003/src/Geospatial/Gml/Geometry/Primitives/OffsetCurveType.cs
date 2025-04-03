
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
// <complexType name="OffsetCurveType">
//   <complexContent>
//     <extension base="gml:AbstractCurveSegmentType">
//       <sequence>
//         <element name="offsetBase" type="gml:CurvePropertyType"/>
//         <element name="distance" type="gml:LengthType"/>
//         <element name="refDirection" type="gml:VectorType" minOccurs="0"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="OffsetCurve" type="gml:OffsetCurveType" substitutionGroup="gml:AbstractCurveSegment">
//   <annotation>
//     <documentation>
//       An offset curve is a curve at a constant distance from the basis curve.
//       offsetBase is the base curve from which this curve is defined as an offset.
//       distance and refDirection have the same meaning as specified in ISO 19107:2003, 6.4.23.
//       The content model follows the general pattern for the encoding of curve segments.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Geospatial.Gml.Geometry.Basic0D1D;
using NDSH.Geospatial.Gml.Measures;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("OffsetCurveType")]
  public class OffsetCurveType : AbstractCurveSegmentType {
    #region Private fields
    private CurvePropertyType _offsetBase;
    private LengthType _distance;
    private VectorType _refDirection;
    #endregion

    /// <summary>
    /// OffsetCurveType class constructor
    /// </summary>
    public OffsetCurveType() {
      _refDirection = new VectorType();
      _distance = new LengthType();
      _offsetBase = new CurvePropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("offsetBase", Order = 0)]
    public CurvePropertyType OffsetBase {
      get {
        return _offsetBase;
      }
      set {
        if (_offsetBase == value) {
          return;
        }
        if (_offsetBase == null || _offsetBase.Equals(value) != true) {
          _offsetBase = value;
          OnPropertyChanged("OffsetBase");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("distance", Order = 1)]
    public LengthType Distance {
      get {
        return _distance;
      }
      set {
        if (_distance == value) {
          return;
        }
        if (_distance == null || _distance.Equals(value) != true) {
          _distance = value;
          OnPropertyChanged("Distance");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("refDirection", Order = 2)]
    public VectorType RefDirection {
      get {
        return _refDirection;
      }
      set {
        if (_refDirection == value) {
          return;
        }
        if (_refDirection == null || _refDirection.Equals(value) != true) {
          _refDirection = value;
          OnPropertyChanged("RefDirection");
        }
      }
    }
  }

}
