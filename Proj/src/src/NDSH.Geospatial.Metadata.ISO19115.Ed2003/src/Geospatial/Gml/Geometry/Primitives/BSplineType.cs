
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/02/2023, 20:34, @gisvlasta.
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
// <complexType name="BSplineType">
//   <complexContent>
//     <extension base="gml:AbstractCurveSegmentType">
//       <sequence>
//         <choice>
//           <choice minOccurs="0" maxOccurs="unbounded">
//             <element ref="gml:pos"/>
//             <element ref="gml:pointProperty"/>
//             <element ref="gml:pointRep"/>
//           </choice>
//           <element ref="gml:posList"/>
//           <element ref="gml:coordinates"/>
//         </choice>
//         <element name="degree" type="nonNegativeInteger"/>
//         <element name="knot" type="gml:KnotPropertyType" minOccurs="2" maxOccurs="unbounded"/>
//       </sequence>
//       <attribute name="interpolation" type="gml:CurveInterpolationType" default="polynomialSpline"/>
//       <attribute name="isPolynomial" type="boolean"/>
//       <attribute name="knotType" type="gml:KnotTypesType"/>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="BSpline" type="gml:BSplineType" substitutionGroup="gml:AbstractCurveSegment">
//   <annotation>
//     <documentation>
//       A B-Spline is a piecewise parametric polynomial or rational curve described in terms
//       of control points and basis functions as specified in ISO 19107:2003, 6.4.30.
//       Therefore, interpolation may be either "polynomialSpline" or "rationalSpline"
//       depending on the interpolation type; default is "polynomialSpline".
//       degree shall be the degree of the polynomial used for interpolation in this spline.
//       knot shall be the sequence of distinct knots used to define the spline basis functions (see ISO 19107:2003, 6.4.26.2).
//       The attribute isPolynomial shall be set to “true” if this is a polynomial spline (see ISO 19107:2003, 6.4.30.5).
//       The attribute knotType shall provide the type of knot distribution used in defining this spline (see ISO 19107:2003, 6.4.30.4).
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
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  //[XmlInclude(typeof(BezierType))]
  [Serializable]
  //[XmlType("BSplineType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("BSplineType")]
  public class BSplineType : AbstractCurveSegmentType {

    #region Constructors - Destructors 

    /// <summary>
    /// Initializes the <see cref="BSplineType"/>.
    /// </summary>
    public BSplineType() {
      _knot = new List<KnotPropertyType>();
      _interpolation = CurveInterpolationType.polynomialSpline;
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

    private string _degree;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("degree", DataType = "nonNegativeInteger", Order = 2)]
    [JsonProperty("degree", Order = 2)]
    public string Degree {
      get {
        return _degree;
      }
      set {
        if (_degree == value) {
          return;
        }
        if (_degree == null || _degree.Equals(value) != true) {
          _degree = value;
          OnPropertyChanged();
        }
      }
    }

    private List<KnotPropertyType> _knot;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("knot", Order = 3)]
    [JsonProperty("knot", Order = 3)]
    [Required()]
    public List<KnotPropertyType> Knot {
      get {
        return _knot;
      }
      set {
        if (_knot == value) {
          return;
        }
        if (_knot == null || _knot.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "knot";
          Validator.ValidateProperty(value, validatorPropContext);
          _knot = value;
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
    [DefaultValue(CurveInterpolationType.polynomialSpline)]
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

    private bool _isPolynomial;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("isPolynomial")]
    [JsonProperty("isPolynomial")]
    public bool IsPolynomial {
      get {
        return _isPolynomial;
      }
      set {
        if (_isPolynomial.Equals(value) != true) {
          _isPolynomial = value;
          OnPropertyChanged();
        }
      }
    }

    private KnotTypesType _knotType;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("knotType")]
    [JsonProperty("knotType")]
    public KnotTypesType KnotType {
      get {
        return _knotType;
      }
      set {
        if (_knotType.Equals(value) != true) {
          _knotType = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
