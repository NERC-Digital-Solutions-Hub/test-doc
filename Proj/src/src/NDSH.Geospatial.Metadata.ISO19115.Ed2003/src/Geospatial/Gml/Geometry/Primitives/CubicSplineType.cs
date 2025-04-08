
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/02/2023, 19:32, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/geometryPrimitives.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="CubicSplineType">
//   <complexContent>
//     <extension base="gml:AbstractCurveSegmentType">
//       <sequence>
//         <choice>
//           <choice minOccurs="2" maxOccurs="unbounded">
//             <element ref="gml:pos"/>
//             <element ref="gml:pointProperty"/>
//             <element ref="gml:pointRep"/>
//           </choice>
//           <element ref="gml:posList"/>
//           <element ref="gml:coordinates"/>
//         </choice>
//         <element name="vectorAtStart" type="gml:VectorType"/>
//         <element name="vectorAtEnd" type="gml:VectorType"/>
//       </sequence>
//       <attribute name="interpolation" type="gml:CurveInterpolationType" fixed="cubicSpline"/>
//       <attribute name="degree" type="integer" fixed="3"/>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="CubicSpline" type="gml:CubicSplineType" substitutionGroup="gml:AbstractCurveSegment">
//   <annotation>
//     <documentation>
//       The number of control points shall be at least three.
//       vectorAtStart is the unit tangent vector at the start point of the spline.
//       vectorAtEnd is the unit tangent vector at the end point of the spline.
//       Only the direction of the vectors shall be used to determine the shape of the cubic spline, not their length.
//       interpolation is fixed as "cubicSpline".
//       degree shall be the degree of the polynomial used for the interpolation in this spline.
//       Therefore the degree for a cubic spline is fixed to "3".
//       The content model follows the general pattern for the encoding of curve segments.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.BasicTypes;
using NDSH.Geospatial.Gml.Geometry.Basic0D1D;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("CubicSplineType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CubicSplineType")]
  public class CubicSplineType : AbstractCurveSegmentType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CubicSplineType"/>.
    /// </summary>
    public CubicSplineType() {
      _vectorAtEnd = new VectorType();
      _vectorAtStart = new VectorType();
      _interpolation = CurveInterpolationType.cubicSpline;
    }

    #endregion

    #region Public Properties

    private object[] _positionTypeItems;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("coordinates", typeof(CoordinatesType), Order = 0)]
    [XmlElement("pointProperty", typeof(PointPropertyType), Order = 0)]
    [XmlElement("pointRep", typeof(PointPropertyType), Order = 0)]
    [XmlElement("pos", typeof(DirectPositionType), Order = 0)]
    [XmlElement("posList", typeof(DirectPositionListType), Order = 0)]
    [XmlChoiceIdentifier("PositionTypeItemsElementName")]
    // TODO: Danger !!! What about a [JsonPropertyAttribute here??? Why is this missing?
    public object[] PositionTypeItems {
      get {
        return _positionTypeItems;
      }
      set {
        if (_positionTypeItems == value) {
          return;
        }
        if (_positionTypeItems == null || _positionTypeItems.Equals(value) != true) {
          _positionTypeItems = value;
          OnPropertyChanged();
        }
      }
    }

    private PositionType[] _positionTypeItemsElementName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("PositionTypeItemsElementName", Order = 1)]
    [XmlIgnore]
    public PositionType[] PositionTypeItemsElementName {
      get {
        return _positionTypeItemsElementName;
      }
      set {
        if (_positionTypeItemsElementName == value) {
          return;
        }
        if (_positionTypeItemsElementName == null || _positionTypeItemsElementName.Equals(value) != true) {
          _positionTypeItemsElementName = value;
          OnPropertyChanged();
        }
      }
    }

    private VectorType _vectorAtStart;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("vectorAtStart", Order = 2)]
    [JsonProperty("vectorAtStart", Order = 2)]
    public VectorType VectorAtStart {
      get {
        return _vectorAtStart;
      }
      set {
        if (_vectorAtStart == value) {
          return;
        }
        if (_vectorAtStart == null || _vectorAtStart.Equals(value) != true) {
          _vectorAtStart = value;
          OnPropertyChanged();
        }
      }
    }

    private VectorType _vectorAtEnd;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("vectorAtEnd", Order = 3)]
    [JsonProperty("vectorAtEnd", Order = 3)]
    public VectorType VectorAtEnd {
      get {
        return _vectorAtEnd;
      }
      set {
        if (_vectorAtEnd == value) {
          return;
        }
        if (_vectorAtEnd == null || _vectorAtEnd.Equals(value) != true) {
          _vectorAtEnd = value;
          OnPropertyChanged();
        }
      }
    }

    private CurveInterpolationType _interpolation;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("interpolation")]
    [JsonProperty("interpolation")]
    public CurveInterpolationType Interpolation {
      get {
        return _interpolation;
      }
      set {
        if (_interpolation.Equals(value) != true) {
          _interpolation = value;
          OnPropertyChanged();
        }
      }
    }

    private const string _degree = "3";

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("degree", DataType = "integer")]
    [JsonProperty]
    public string Degree {
      get {
        return _degree;
      }
      //set {
      //  if (_degree == value) {
      //    return;
      //  }
      //  if (_degree == null || _degree.Equals(value) != true) {
      //    _degree = value;
      //    OnPropertyChanged();
      //  }
      //}
    }

    #endregion

  }

}
