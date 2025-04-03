
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
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.GML.BasicTypes;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic0D1D;
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Primitives {

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
