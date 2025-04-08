
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 03:29, @gisvlasta.
// Updated by        : 09/01/2023, 20:56, @gisvlasta. - 1.0.1: Added xmlns field.
//                   : 08/02/2023, 01:54, @gisvlasta. - 1.0.2: Added [XmlInclude]s.
// Version           : 1.0.2
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common.SpatialSchema;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
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
  /// 
  /// </summary>
  [XmlInclude(typeof(MI_Georectified_Type))]
  [Serializable]
  [XmlType("MD_Georectified", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_Georectified", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_Georectified")]
  public class MD_Georectified_Type : MD_GridSpatialRepresentation_Type {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Georectified_Type"/>.
    /// </summary>
    public MD_Georectified_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _checkPointAvailability  = default; //  new Boolean_PropertyType();
      _checkPointDescription  = default; //  new CharacterString_PropertyType();
      _cornerPoints  = default; //  new List<GM_Point_PropertyType>();
      _centerPoint  = default; //  new GM_Point_PropertyType();
      _pointInPixel  = default; //  new MD_PixelOrientationCode_PropertyType();
      _transformationDimensionDescription  = default; //  new CharacterString_PropertyType();
      _transformationDimensionMapping  = default; //  new List<CharacterString_PropertyType>();

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

    private Boolean_PropertyType _checkPointAvailability;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("checkPointAvailability", Order = 0)]
    [JsonProperty("checkPointAvailability", Order = 0)]
    public Boolean_PropertyType CheckPointAvailability {
      get {
        return _checkPointAvailability;
      }
      set {
        if (_checkPointAvailability == value) {
          return;
        }
        if (_checkPointAvailability == null || _checkPointAvailability.Equals(value) != true) {
          _checkPointAvailability = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _checkPointDescription;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("checkPointDescription", Order = 1)]
    [JsonProperty("checkPointDescription", Order = 1)]
    public CharacterString CheckPointDescription {
      get {
        return _checkPointDescription;
      }
      set {
        if (_checkPointDescription == value) {
          return;
        }
        if (_checkPointDescription == null || _checkPointDescription.Equals(value) != true) {
          _checkPointDescription = value;
          OnPropertyChanged();
        }
      }
    }

    private List<GM_Point_PropertyType> _cornerPoints;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("cornerPoints", Order = 2)]
    [JsonProperty("cornerPoints", Order = 2)]
    public List<GM_Point_PropertyType> CornerPoints {
      get {
        return _cornerPoints;
      }
      set {
        if (_cornerPoints == value) {
          return;
        }
        if (_cornerPoints == null || _cornerPoints.Equals(value) != true) {
          _cornerPoints = value;
          OnPropertyChanged();
        }
      }
    }

    private GM_Point_PropertyType _centerPoint;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("centerPoint", Order = 3)]
    [JsonProperty("centerPoint", Order = 3)]
    public GM_Point_PropertyType CenterPoint {
      get {
        return _centerPoint;
      }
      set {
        if (_centerPoint == value) {
          return;
        }
        if (_centerPoint == null || _centerPoint.Equals(value) != true) {
          _centerPoint = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_PixelOrientationCode_PropertyType _pointInPixel;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("pointInPixel", Order = 4)]
    [JsonProperty("pointInPixel", Order = 4)]
    public MD_PixelOrientationCode_PropertyType PointInPixel {
      get {
        return _pointInPixel;
      }
      set {
        if (_pointInPixel == value) {
          return;
        }
        if (_pointInPixel == null || _pointInPixel.Equals(value) != true) {
          _pointInPixel = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _transformationDimensionDescription;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("transformationDimensionDescription", Order = 5)]
    [JsonProperty("transformationDimensionDescription", Order = 5)]
    public CharacterString TransformationDimensionDescription {
      get {
        return _transformationDimensionDescription;
      }
      set {
        if (_transformationDimensionDescription == value) {
          return;
        }
        if (_transformationDimensionDescription == null || _transformationDimensionDescription.Equals(value) != true) {
          _transformationDimensionDescription = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CharacterString> _transformationDimensionMapping;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("transformationDimensionMapping", Order = 6)]
    [JsonProperty("transformationDimensionMapping", Order = 6)]
    public List<CharacterString> TransformationDimensionMapping {
      get {
        return _transformationDimensionMapping;
      }
      set {
        if (_transformationDimensionMapping == value) {
          return;
        }
        if (_transformationDimensionMapping == null || _transformationDimensionMapping.Equals(value) != true) {
          _transformationDimensionMapping = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
