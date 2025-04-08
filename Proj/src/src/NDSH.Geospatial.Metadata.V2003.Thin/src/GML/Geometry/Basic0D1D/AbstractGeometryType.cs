
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 31/01/2023, 00:26, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.GML.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Grids;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Primitives;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Complexes;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic2D;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Aggregates;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic0D1D {

  /// <summary>
  /// <para>
  /// All geometry elements are derived directly or indirectly from this abstract supertype.
  /// A geometry element may have an identifying attribute (gml:id), one or more names
  /// (elements identifier and name) and a description (elements description and
  /// descriptionReference) . It may be associated with a spatial reference system
  /// (attribute group gml:SRSReferenceGroup).
  /// </para>
  /// <para>
  /// The following rules shall be adhered to: <br></br>
  /// <list type="bullet">
  /// <item>Every geometry type shall derive from this abstract type.</item>
  /// <item>
  /// Every geometry element (i.e. an element of a geometry type) shall be
  /// directly or indirectly in the substitution group of AbstractGeometry.
  /// </item>
  /// </list>
  /// </para>
  /// </summary>
  [XmlInclude(typeof(GridType))]
  [XmlInclude(typeof(RectifiedGridType))]
  [XmlInclude(typeof(GeometricComplexType))]
  [XmlInclude(typeof(AbstractGeometricAggregateType))]
  [XmlInclude(typeof(MultiSolidType))]
  [XmlInclude(typeof(MultiSurfaceType))]
  [XmlInclude(typeof(MultiCurveType))]
  [XmlInclude(typeof(MultiPointType))]
  [XmlInclude(typeof(MultiGeometryType))]
  [XmlInclude(typeof(AbstractGeometricPrimitiveType))]
  [XmlInclude(typeof(AbstractSolidType))]
  [XmlInclude(typeof(CompositeSolidType))]
  [XmlInclude(typeof(SolidType))]
  [XmlInclude(typeof(AbstractSurfaceType))]
  [XmlInclude(typeof(CompositeSurfaceType))]
  [XmlInclude(typeof(OrientableSurfaceType))]
  [XmlInclude(typeof(SurfaceType))]
  [XmlInclude(typeof(TriangulatedSurfaceType))]
  [XmlInclude(typeof(TinType))]
  [XmlInclude(typeof(PolyhedralSurfaceType))]
  [XmlInclude(typeof(PolygonType))]
  [XmlInclude(typeof(AbstractCurveType))]
  [XmlInclude(typeof(CompositeCurveType))]
  [XmlInclude(typeof(OrientableCurveType))]
  [XmlInclude(typeof(CurveType))]
  [XmlInclude(typeof(LineStringType))]
  [XmlInclude(typeof(PointType))]
  [Serializable]
  [XmlType("AbstractGeometryType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractGeometryType")]
  public abstract class AbstractGeometryType : AbstractGMLType, ISrsReference {

    #region ISrsReference Interface

    private string _srsName;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("srsName", DataType = "anyURI")]
    [JsonProperty("srsName")]
    public string SrsName {
      get {
        return _srsName;
      }
      set {
        if (_srsName == value) {
          return;
        }
        if (_srsName == null || _srsName.Equals(value) != true) {
          _srsName = value;
          OnPropertyChanged();
        }
      }
    }

    private string _srsDimension;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("srsDimension", DataType = "positiveInteger")]
    [JsonProperty("srsDimension")]
    public string SrsDimension {
      get {
        return _srsDimension;
      }
      set {
        if (_srsDimension == value) {
          return;
        }
        if (_srsDimension == null || _srsDimension.Equals(value) != true) {
          _srsDimension = value;
          OnPropertyChanged();
        }
      }
    }

    // How to implement NCName:
    // https://stackoverflow.com/questions/1631396/what-is-an-xsncname-type-and-when-should-it-be-used

    private List<string> _axisLabel;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("axisLabel")]
    [JsonProperty("axisLabel")]
    // TODO: IMPORTANT!!! - This is a List of NCName(s)
    // TODO: Check List Serialization here!
    public List<string> AxisLabel {
      get {
        return _axisLabel;
      }
      set {
        if (_axisLabel == value) {
          return;
        }
        if (_axisLabel == null || _axisLabel.Equals(value) != true) {
          _axisLabel = value;
          OnPropertyChanged();
        }
      }
    }

    private List<string> _uomLabels;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("uomLabels")]
    [JsonProperty("uomLabels")]
    // TODO: IMPORTANT!!! - This is a List of NCName(s)
    // TODO: Check List Serialization here!
    public List<string> UomLabels {
      get {
        return _uomLabels;
      }
      set {
        if (_uomLabels == value) {
          return;
        }
        if (_uomLabels == null || _uomLabels.Equals(value) != true) {
          _uomLabels = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
