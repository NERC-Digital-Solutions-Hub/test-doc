
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 16/12/2022, 15:12, @EttoreM - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.Common.SpatialSchema;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.SpatialRepresentation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("MD_Georectified", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_Georectified", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_Georectified")]
  public class MD_Georectified : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Georectified"/>.
    /// </summary>
    public MD_Georectified() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _numberOfDimensions = default;
      _axisDimensionProperties = default;
      _cellGeometry = default;
      _transformationParameterAvailability = default;
      _checkPointAvailability = default;
      _checkPointDescription = default;
      _cornerPoints = default;
      _centerPoint = default;
      _pointInPixel = default;
      _transformationDimensionDescription = default;
      _transformationDimensionMapping = default;

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

    private int _numberOfDimensions;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "numberOfDimensions")]
    [RequiredAttribute()]
    [JsonProperty("numberOfDimensions", Order = 0)]
    public int NumberOfDimensions {
      get {
        return _numberOfDimensions;
      }
      set {
        if (_numberOfDimensions.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "NumberOfDimensions";
          Validator.ValidateProperty(value, validatorPropContext);
          _numberOfDimensions = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_Dimension _axisDimensionProperties;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "axisDimensionProperties")]
    [JsonProperty("axisDimensionProperties", Order = 1)]
    public MD_Dimension AxisDimensionProperties {
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

    private MD_CellGeometryCode _cellGeometry;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "cellGeometry")]
    [JsonProperty("cellGeometry", Order = 2)]
    public MD_CellGeometryCode CellGeometry {
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

    private Boolean _transformationParameterAvailability;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3, ElementName = "transformationParameterAvailability")]
    [JsonProperty("transformationParameterAvailability", Order = 3)]
    public Boolean TransformationParameterAvailability {
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

    private Boolean _checkPointAvailability;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4, ElementName = "checkPointAvailability")]
    [JsonProperty("checkPointAvailability", Order = 4)]
    public Boolean CheckPointAvailability {
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

    private string _checkPointDescription;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5, ElementName = "checkPointDescription")]
    [JsonProperty("checkPointDescription", Order = 5)]
    public string CheckPointDescription {
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

    private GM_Point _cornerPoints;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6, ElementName = "cornerPoints")]
    [JsonProperty("cornerPoints", Order = 6)]
    public GM_Point CornerPoints {
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

    private GM_Point _centerPoint;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 7, ElementName = "centerPoint")]
    [JsonProperty("centerPoint", Order = 7)]
    public GM_Point CenterPoint {
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

    private MD_PixelOrientationCode _pointInPixel;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 8, ElementName = "pointInPixel")]
    [JsonProperty("pointInPixel", Order = 8)]
    public MD_PixelOrientationCode PointInPixel {
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

    private string _transformationDimensionDescription;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 9, ElementName = "transformationDimensionDescription")]
    [JsonProperty("transformationDimensionDescription", Order = 9)]
    public string TransformationDimensionDescription {
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

    private List<string> _transformationDimensionMapping;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("transformationDimensionMapping", Order = 10, ElementName = "transformationDimensionMapping")]
    [JsonProperty("transformationDimensionMapping", Order = 10)]
    public List<string> TransformationDimensionMapping {
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

    private string _id;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(DataType = "ID", AttributeName = "id")]
    [XmlIgnore()]
    [JsonProperty("id")]
    public string Id {
      get {
        return _id;
      }
      set {
        if (_id == value) {
          return;
        }
        if (_id == null || _id.Equals(value) != true) {
          _id = value;
          OnPropertyChanged();
        }
      }
    }

    private string _uuid;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "uuid")]
    [XmlIgnore()]
    [JsonProperty("uuid")]
    public string Uuid {
      get {
        return _uuid;
      }
      set {
        if (_uuid == value) {
          return;
        }
        if (_uuid == null || _uuid.Equals(value) != true) {
          _uuid = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
