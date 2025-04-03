
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
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Gml.BasicTypes;
using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic0D1D;
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

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(BezierType))]
  [Serializable]
  [XmlType("BSplineType", Namespace = "http://www.opengis.net/gml")]
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
