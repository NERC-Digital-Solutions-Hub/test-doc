
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/02/2023, 20:45, @gisvlasta.
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
  [XmlInclude(typeof(ArcByBulgeType))]
  [Serializable]
  [XmlType("ArcStringByBulgeType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ArcStringByBulgeType")]
  public class ArcStringByBulgeType : AbstractCurveSegmentType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ArcStringByBulgeType"/>.
    /// </summary>
    public ArcStringByBulgeType() {
      _normal = new List<VectorType>();
      _bulge = new List<double>();
      _interpolation = CurveInterpolationType.circularArc2PointWithBulge;
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

    private List<double> _bulge;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("bulge", Order = 2)]
    [JsonProperty("bulge", Order = 2)]
    public List<double> Bulge {
      get {
        return _bulge;
      }
      set {
        if (_bulge == value) {
          return;
        }
        if (_bulge == null || _bulge.Equals(value) != true) {
          _bulge = value;
          OnPropertyChanged();
        }
      }
    }

    private List<VectorType> _normal;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("normal", Order = 3)]
    [JsonProperty("normal", Order = 3)]
    public List<VectorType> Normal {
      get {
        return _normal;
      }
      set {
        if (_normal == value) {
          return;
        }
        if (_normal == null || _normal.Equals(value) != true) {
          _normal = value;
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

    private string _numArc;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("numArc", DataType = "integer")]
    [JsonProperty("numArc")]
    public string NumArc {
      get {
        return _numArc;
      }
      set {
        if (_numArc == value) {
          return;
        }
        if (_numArc == null || _numArc.Equals(value) != true) {
          _numArc = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
