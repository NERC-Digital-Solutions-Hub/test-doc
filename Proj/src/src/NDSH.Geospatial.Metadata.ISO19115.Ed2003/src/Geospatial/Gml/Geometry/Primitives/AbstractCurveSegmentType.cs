
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
// <complexType name="AbstractCurveSegmentType" abstract="true">
//   <attribute name="numDerivativesAtStart" type="integer" default="0"/>
//   <attribute name="numDerivativesAtEnd" type="integer" default="0"/>
//   <attribute name="numDerivativeInterior" type="integer" default="0"/>
// </complexType>
// <element name="AbstractCurveSegment" type="gml:AbstractCurveSegmentType" abstract="true" substitutionGroup="gml:AbstractObject">
//   <annotation>
//     <documentation>
//       A curve segment defines a homogeneous segment of a curve.
//       The attributes numDerivativesAtStart, numDerivativesAtEnd and numDerivativesInterior
//       specify the type of continuity as specified in ISO 19107:2003, 6.4.9.3.
//       The AbstractCurveSegment element is the abstract head of the substituition group for
//       all curve segment elements, i.e. continuous segments of the same interpolation mechanism.
//       All curve segments shall have an attribute interpolation with type gml:CurveInterpolationType
//       specifying the curve interpolation mechanism used for this segment. This mechanism uses the
//       control points and control parameters to determine the position of this curve segment.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  //[XmlInclude(typeof(GeodesicStringType))]
  //[XmlInclude(typeof(GeodesicType))]
  //[XmlInclude(typeof(ClothoidType))]
  //[XmlInclude(typeof(OffsetCurveType))]
  //[XmlInclude(typeof(BSplineType))]
  //[XmlInclude(typeof(BezierType))]
  //[XmlInclude(typeof(CubicSplineType))]
  //[XmlInclude(typeof(ArcByCenterPointType))]
  //[XmlInclude(typeof(CircleByCenterPointType))]
  //[XmlInclude(typeof(ArcStringByBulgeType))]
  //[XmlInclude(typeof(ArcByBulgeType))]
  //[XmlInclude(typeof(ArcStringType))]
  //[XmlInclude(typeof(ArcType))]
  //[XmlInclude(typeof(CircleType))]
  //[XmlInclude(typeof(LineStringSegmentType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractCurveSegmentType")]
  public abstract class AbstractCurveSegmentType : ObservableModel {
    #region Private fields
    private string _numDerivativesAtStart;
    private string _numDerivativesAtEnd;
    private string _numDerivativeInterior;
    #endregion

    /// <summary>
    /// AbstractCurveSegmentType class constructor
    /// </summary>
    public AbstractCurveSegmentType() {
      _numDerivativesAtStart = "0";
      _numDerivativesAtEnd = "0";
      _numDerivativeInterior = "0";
    }

    [XmlAttribute(DataType = "integer")]
    [DefaultValue("0")]
    [JsonProperty("numDerivativesAtStart")]
    public string NumDerivativesAtStart {
      get {
        return _numDerivativesAtStart;
      }
      set {
        if (_numDerivativesAtStart == value) {
          return;
        }
        if (_numDerivativesAtStart == null || _numDerivativesAtStart.Equals(value) != true) {
          _numDerivativesAtStart = value;
          OnPropertyChanged("NumDerivativesAtStart");
        }
      }
    }

    [XmlAttribute(DataType = "integer")]
    [DefaultValue("0")]
    [JsonProperty("numDerivativesAtEnd")]
    public string NumDerivativesAtEnd {
      get {
        return _numDerivativesAtEnd;
      }
      set {
        if (_numDerivativesAtEnd == value) {
          return;
        }
        if (_numDerivativesAtEnd == null || _numDerivativesAtEnd.Equals(value) != true) {
          _numDerivativesAtEnd = value;
          OnPropertyChanged("NumDerivativesAtEnd");
        }
      }
    }

    [XmlAttribute(DataType = "integer")]
    [DefaultValue("0")]
    [JsonProperty("numDerivativeInterior")]
    public string NumDerivativeInterior {
      get {
        return _numDerivativeInterior;
      }
      set {
        if (_numDerivativeInterior == value) {
          return;
        }
        if (_numDerivativeInterior == null || _numDerivativeInterior.Equals(value) != true) {
          _numDerivativeInterior = value;
          OnPropertyChanged("NumDerivativeInterior");
        }
      }
    }
  }

}
