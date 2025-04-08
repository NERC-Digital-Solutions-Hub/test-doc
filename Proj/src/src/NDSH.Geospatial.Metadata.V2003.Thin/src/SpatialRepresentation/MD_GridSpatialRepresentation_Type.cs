
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 03:14, @gisvlasta.
// Updated by        : 09/01/2023, 20:55, @gisvlasta. - 1.0.1: Added xmlns field.
//                   : 08/02/2023, 02:01, @gisvlasta. - 1.0.2: Added [XmlInclude]s.
// Version           : 1.0.2
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Numerics;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Truth;
using NDSH.Geospatial.Metadata.V2003.Thin.Imagery.SpatialRepresentation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.SpatialRepresentation {

  /// <summary>
  /// Types and numbers of raster spatial objects in the dataset.
  /// </summary>
  [XmlInclude(typeof(MI_Georectified_Type))]
  [XmlInclude(typeof(MI_Georeferenceable_Type))]
  [XmlInclude(typeof(MD_Georectified_Type))]
  [XmlInclude(typeof(MD_Georeferenceable_Type))]
  [Serializable]
  [XmlType("MD_GridSpatialRepresentation", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_GridSpatialRepresentation", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_GridSpatialRepresentation")]
  public class MD_GridSpatialRepresentation_Type : AbstractMD_SpatialRepresentation_Type {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_GridSpatialRepresentation_Type"/>.
    /// </summary>
    public MD_GridSpatialRepresentation_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _numberOfDimensions  = default; //  new Integer_PropertyType();
      _axisDimensionProperties  = default; //  new List<MD_Dimension_PropertyType>();
      _cellGeometry  = default; //  new MD_CellGeometryCode_PropertyType();
      _transformationParameterAvailability  = default; //  new Boolean_PropertyType();

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

    private Integer_PropertyType _numberOfDimensions;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("numberOfDimensions", Order = 0)]
    [JsonProperty("numberOfDimensions", Order = 0)]
    public Integer_PropertyType NumberOfDimensions {
      get {
        return _numberOfDimensions;
      }
      set {
        if (_numberOfDimensions == value) {
          return;
        }
        if (_numberOfDimensions == null || _numberOfDimensions.Equals(value) != true) {
          _numberOfDimensions = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_Dimension_PropertyType> _axisDimensionProperties;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("axisDimensionProperties", Order = 1)]
    [JsonProperty("axisDimensionProperties", Order = 1)]
    public List<MD_Dimension_PropertyType> AxisDimensionProperties {
      get {
        return _axisDimensionProperties;
      }
      set {
        if (_axisDimensionProperties == value) {
          return;
        }
        if (_axisDimensionProperties == null || _axisDimensionProperties.Equals(value) != true) {
          _axisDimensionProperties = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_CellGeometryCode_PropertyType _cellGeometry;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("cellGeometry", Order = 2)]
    [JsonProperty("cellGeometry", Order = 2)]
    public MD_CellGeometryCode_PropertyType CellGeometry {
      get {
        return _cellGeometry;
      }
      set {
        if (_cellGeometry == value) {
          return;
        }
        if (_cellGeometry == null || _cellGeometry.Equals(value) != true) {
          _cellGeometry = value;
          OnPropertyChanged();
        }
      }
    }

    private Boolean_PropertyType _transformationParameterAvailability;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("transformationParameterAvailability", Order = 3)]
    [JsonProperty("transformationParameterAvailability", Order = 3)]
    public Boolean_PropertyType TransformationParameterAvailability {
      get {
        return _transformationParameterAvailability;
      }
      set {
        if (_transformationParameterAvailability == value) {
          return;
        }
        if (_transformationParameterAvailability == null || _transformationParameterAvailability.Equals(value) != true) {
          _transformationParameterAvailability = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
