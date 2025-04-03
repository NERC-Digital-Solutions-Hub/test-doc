
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/02/2023, 19:29, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Primitives;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Measures;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(CircleByCenterPointType))] // TODO: Check this [XmlInclude !!!
  [Serializable]
  [XmlType("ArcByCenterPointType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ArcByCenterPointType")]
  public class ArcByCenterPointType : AbstractCurveSegmentType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ArcByCenterPointType"/>.
    /// </summary>
    public ArcByCenterPointType() {
      _endAngle = new AngleType();
      _startAngle = new AngleType();
      _radius = new LengthType();
      _interpolation = CurveInterpolationType.circularArcCenterPointWithRadius;
    }

    #endregion

    #region Public Properties

    private object _positionTypeItem;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("coordinates", typeof(CoordinatesType), Order = 0)]
    [XmlElement("pointProperty", typeof(PointPropertyType), Order = 0)]
    [XmlElement("pointRep", typeof(PointPropertyType), Order = 0)]
    [XmlElement("pos", typeof(DirectPositionType), Order = 0)]
    [XmlElement("posList", typeof(DirectPositionListType), Order = 0)]
    [XmlChoiceIdentifier("PositionTypeItemElementName")]
    // TODO: Danger !!! What about a [JsonPropertyAttribute here??? Why is this missing?
    public object PositionTypeItem {
      get {
        return _positionTypeItem;
      }
      set {
        if (_positionTypeItem == value) {
          return;
        }
        if (_positionTypeItem == null || _positionTypeItem.Equals(value) != true) {
          _positionTypeItem = value;
          OnPropertyChanged();
        }
      }
    }

    private PositionType _positionTypeItemElementName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("PositionTypeItemElementName", Order = 1)]
    [XmlIgnore]
    public PositionType PositionTypeItemElementName {
      get {
        return _positionTypeItemElementName;
      }
      set {
        if (_positionTypeItemElementName.Equals(value) != true) {
          _positionTypeItemElementName = value;
          OnPropertyChanged();
        }
      }
    }

    private LengthType _radius;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("radius", Order = 2)]
    [JsonProperty("radius", Order = 2)]
    public LengthType Radius {
      get {
        return _radius;
      }
      set {
        if (_radius == value) {
          return;
        }
        if (_radius == null || _radius.Equals(value) != true) {
          _radius = value;
          OnPropertyChanged();
        }
      }
    }

    private AngleType _startAngle;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("startAngle", Order = 3)]
    [JsonProperty("startAngle", Order = 3)]
    public AngleType StartAngle {
      get {
        return _startAngle;
      }
      set {
        if (_startAngle == value) {
          return;
        }
        if (_startAngle == null || _startAngle.Equals(value) != true) {
          _startAngle = value;
          OnPropertyChanged();
        }
      }
    }

    private AngleType _endAngle;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("endAngle", Order = 4)]
    [JsonProperty("endAngle", Order = 4)]
    public AngleType EndAngle {
      get {
        return _endAngle;
      }
      set {
        if (_endAngle == value) {
          return;
        }
        if (_endAngle == null || _endAngle.Equals(value) != true) {
          _endAngle = value;
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

    private const string _numArc = "1";

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("numArc", DataType = "integer")]
    [JsonProperty("numArc")]
    public string NumArc {
      get {
        return _numArc;
      }
      //set {
      //  if (_numArc == value) {
      //    return;
      //  }
      //  if (_numArc == null || _numArc.Equals(value) != true) {
      //    _numArc = value;
      //    OnPropertyChanged();
      //  }
      //}
    }

    #endregion

  }

}
