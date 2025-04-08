
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/02/2023, 03:25, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces


using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic0D1D;
using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Grids {

  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(RectifiedGridType))]
  [Serializable]
  [XmlType("GridType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GridType")]
  public class GridType : AbstractGeometryType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="GridType"/>.
    /// </summary>
    public GridType() {
      _limits = new GridLimitsType();
    }

    #endregion

    #region Public Properties

    private GridLimitsType _limits;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("limits", Order = 0)]
    [JsonProperty("limits", Order = 0)]
    public GridLimitsType Limits {
      get {
        return _limits;
      }
      set {
        if (_limits == value) {
          return;
        }
        if (_limits == null || _limits.Equals(value) != true) {
          _limits = value;
          OnPropertyChanged();
        }
      }
    }

    private string[] _axisItems;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("axisLabels", DataType = "NCName", Order = 1)]
    [XmlElement("axisName", Order = 1)]
    [XmlChoiceIdentifier("AxisItemsElementName")]
    public string[] AxisItems {
      get {
        return _axisItems;
      }
      set {
        if (_axisItems == value) {
          return;
        }
        if (_axisItems == null || _axisItems.Equals(value) != true) {
          _axisItems = value;
          OnPropertyChanged();
        }
      }
    }

    private AxisEnumeration[] _axisItemsElementName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AxisItemsElementName", Order = 2)]
    [XmlIgnore]
    public AxisEnumeration[] AxisItemsElementName {
      get {
        return _axisItemsElementName;
      }
      set {
        if (_axisItemsElementName == value) {
          return;
        }
        if (_axisItemsElementName == null || _axisItemsElementName.Equals(value) != true) {
          _axisItemsElementName = value;
          OnPropertyChanged();
        }
      }
    }

    private string _dimension;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("dimension", DataType = "positiveInteger")]
    [JsonProperty("dimension")]
    public string Dimension {
      get {
        return _dimension;
      }
      set {
        if (_dimension == value) {
          return;
        }
        if (_dimension == null || _dimension.Equals(value) != true) {
          _dimension = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
