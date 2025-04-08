
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 04:42, @gisvlasta.
// Updated by        : 09/01/2023, 20:58, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Derived.UnitsOfMeasure;
using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Numerics;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.SpatialRepresentation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_Dimension", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_Dimension", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_Dimension")]
  public class MD_Dimension_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Dimension_Type"/>.
    /// </summary>
    public MD_Dimension_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _dimensionName  = default; //  new MD_DimensionNameTypeCode_PropertyType();
      _dimensionSize  = default; //  new Integer_PropertyType();
      _resolution  = default; //  new Measure_PropertyType();

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private MD_DimensionNameTypeCode_PropertyType _dimensionName;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("dimensionName", Order = 0)]
    [JsonProperty("dimensionName", Order = 0)]
    public MD_DimensionNameTypeCode_PropertyType DimensionName {
      get {
        return _dimensionName;
      }
      set {
        if (_dimensionName == value) {
          return;
        }
        if (_dimensionName == null || _dimensionName.Equals(value) != true) {
          _dimensionName = value;
          OnPropertyChanged();
        }
      }
    }

    private Integer_PropertyType _dimensionSize;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("dimensionSize", Order = 1)]
    [JsonProperty("dimensionSize", Order = 1)]
    public Integer_PropertyType DimensionSize {
      get {
        return _dimensionSize;
      }
      set {
        if (_dimensionSize == value) {
          return;
        }
        if (_dimensionSize == null || _dimensionSize.Equals(value) != true) {
          _dimensionSize = value;
          OnPropertyChanged();
        }
      }
    }

    private Measure_PropertyType _resolution;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("resolution", Order = 2)]
    [JsonProperty("resolution", Order = 2)]
    public Measure_PropertyType Resolution {
      get {
        return _resolution;
      }
      set {
        if (_resolution == value) {
          return;
        }
        if (_resolution == null || _resolution.Equals(value) != true) {
          _resolution = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
