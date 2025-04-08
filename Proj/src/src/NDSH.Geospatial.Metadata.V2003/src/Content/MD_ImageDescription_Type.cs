
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 20:36, @gisvlasta.
// Updated by        : 09/01/2023, 18:23, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Numerics;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Truth;
using NDSH.Geospatial.Metadata.V2003.Imagery.Content;
using NDSH.Geospatial.Metadata.V2003.ReferenceSystem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Content {
  
  /// <summary>
  /// Information about an image's suitability for use.
  /// </summary>
  [XmlInclude(typeof(MI_ImageDescription_Type))]
  [Serializable]
  [XmlType("MD_ImageDescription", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_ImageDescription", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_ImageDescription")]
  public class MD_ImageDescription_Type : MD_CoverageDescription_Type {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_ImageDescription_Type"/>.
    /// </summary>
    public MD_ImageDescription_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _illuminationElevationAngle  = default; //  new Real_PropertyType();
      _illuminationAzimuthAngle  = default; //  new Real_PropertyType();
      _imagingCondition  = default; //  new MD_ImagingConditionCode_PropertyType();
      _imageQualityCode  = default; //  new MD_Identifier_PropertyType();
      _cloudCoverPercentage  = default; //  new Real_PropertyType();
      _processingLevelCode  = default; //  new MD_Identifier_PropertyType();
      _compressionGenerationQuantity  = default; //  new Integer_PropertyType();
      _triangulationIndicator  = default; //  new Boolean_PropertyType();
      _radiometricCalibrationDataAvailability  = default; //  new Boolean_PropertyType();
      _cameraCalibrationInformationAvailability  = default; //  new Boolean_PropertyType();
      _filmDistortionInformationAvailability  = default; //  new Boolean_PropertyType();
      _lensDistortionInformationAvailability  = default; //  new Boolean_PropertyType();
      
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

    private Real_PropertyType _illuminationElevationAngle;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("illuminationElevationAngle", Order = 0)]
    [JsonProperty("illuminationElevationAngle", Order = 0)]
    public Real_PropertyType IlluminationElevationAngle {
      get {
        return _illuminationElevationAngle;
      }
      set {
        if (_illuminationElevationAngle == value) {
          return;
        }
        if (_illuminationElevationAngle == null || _illuminationElevationAngle.Equals(value) != true) {
          _illuminationElevationAngle = value;
          OnPropertyChanged();
        }
      }
    }

    private Real_PropertyType _illuminationAzimuthAngle;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("illuminationAzimuthAngle", Order = 1)]
    [JsonProperty("illuminationAzimuthAngle", Order = 1)]
    public Real_PropertyType IlluminationAzimuthAngle {
      get {
        return _illuminationAzimuthAngle;
      }
      set {
        if (_illuminationAzimuthAngle == value) {
          return;
        }
        if (_illuminationAzimuthAngle == null || _illuminationAzimuthAngle.Equals(value) != true) {
          _illuminationAzimuthAngle = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_ImagingConditionCode_PropertyType _imagingCondition;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("imagingCondition", Order = 2)]
    [JsonProperty("imagingCondition", Order = 2)]
    public MD_ImagingConditionCode_PropertyType ImagingCondition {
      get {
        return _imagingCondition;
      }
      set {
        if (_imagingCondition == value) {
          return;
        }
        if (_imagingCondition == null || _imagingCondition.Equals(value) != true) {
          _imagingCondition = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_Identifier_PropertyType _imageQualityCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("imageQualityCode", Order = 3)]
    [JsonProperty("imageQualityCode", Order = 3)]
    public MD_Identifier_PropertyType ImageQualityCode {
      get {
        return _imageQualityCode;
      }
      set {
        if (_imageQualityCode == value) {
          return;
        }
        if (_imageQualityCode == null || _imageQualityCode.Equals(value) != true) {
          _imageQualityCode = value;
          OnPropertyChanged();
        }
      }
    }

    private Real_PropertyType _cloudCoverPercentage;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("cloudCoverPercentage", Order = 4)]
    [JsonProperty("cloudCoverPercentage", Order = 4)]
    public Real_PropertyType CloudCoverPercentage {
      get {
        return _cloudCoverPercentage;
      }
      set {
        if (_cloudCoverPercentage == value) {
          return;
        }
        if (_cloudCoverPercentage == null || _cloudCoverPercentage.Equals(value) != true) {
          _cloudCoverPercentage = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_Identifier_PropertyType _processingLevelCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("processingLevelCode", Order = 5)]
    [JsonProperty("processingLevelCode", Order = 5)]
    public MD_Identifier_PropertyType ProcessingLevelCode {
      get {
        return _processingLevelCode;
      }
      set {
        if (_processingLevelCode == value) {
          return;
        }
        if (_processingLevelCode == null || _processingLevelCode.Equals(value) != true) {
          _processingLevelCode = value;
          OnPropertyChanged();
        }
      }
    }

    private Integer_PropertyType _compressionGenerationQuantity;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("compressionGenerationQuantity", Order = 6)]
    [JsonProperty("compressionGenerationQuantity", Order = 6)]
    public Integer_PropertyType CompressionGenerationQuantity {
      get {
        return _compressionGenerationQuantity;
      }
      set {
        if (_compressionGenerationQuantity == value) {
          return;
        }
        if (_compressionGenerationQuantity == null || _compressionGenerationQuantity.Equals(value) != true) {
          _compressionGenerationQuantity = value;
          OnPropertyChanged();
        }
      }
    }

    private Boolean_PropertyType _triangulationIndicator;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("triangulationIndicator", Order = 7)]
    [JsonProperty("triangulationIndicator", Order = 7)]
    public Boolean_PropertyType TriangulationIndicator {
      get {
        return _triangulationIndicator;
      }
      set {
        if (_triangulationIndicator == value) {
          return;
        }
        if (_triangulationIndicator == null || _triangulationIndicator.Equals(value) != true) {
          _triangulationIndicator = value;
          OnPropertyChanged();
        }
      }
    }

    private Boolean_PropertyType _radiometricCalibrationDataAvailability;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("radiometricCalibrationDataAvailability", Order = 8)]
    [JsonProperty("radiometricCalibrationDataAvailability", Order = 8)]
    public Boolean_PropertyType RadiometricCalibrationDataAvailability {
      get {
        return _radiometricCalibrationDataAvailability;
      }
      set {
        if (_radiometricCalibrationDataAvailability == value) {
          return;
        }
        if (_radiometricCalibrationDataAvailability == null || _radiometricCalibrationDataAvailability.Equals(value) != true) {
          _radiometricCalibrationDataAvailability = value;
          OnPropertyChanged();
        }
      }
    }

    private Boolean_PropertyType _cameraCalibrationInformationAvailability;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("cameraCalibrationInformationAvailability", Order = 9)]
    [JsonProperty("cameraCalibrationInformationAvailability", Order = 9)]
    public Boolean_PropertyType CameraCalibrationInformationAvailability {
      get {
        return _cameraCalibrationInformationAvailability;
      }
      set {
        if (_cameraCalibrationInformationAvailability == value) {
          return;
        }
        if (_cameraCalibrationInformationAvailability == null || _cameraCalibrationInformationAvailability.Equals(value) != true) {
          _cameraCalibrationInformationAvailability = value;
          OnPropertyChanged();
        }
      }
    }

    private Boolean_PropertyType _filmDistortionInformationAvailability;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("filmDistortionInformationAvailability", Order = 10)]
    [JsonProperty("filmDistortionInformationAvailability", Order = 10)]
    public Boolean_PropertyType FilmDistortionInformationAvailability {
      get {
        return _filmDistortionInformationAvailability;
      }
      set {
        if (_filmDistortionInformationAvailability == value) {
          return;
        }
        if (_filmDistortionInformationAvailability == null || _filmDistortionInformationAvailability.Equals(value) != true) {
          _filmDistortionInformationAvailability = value;
          OnPropertyChanged();
        }
      }
    }

    private Boolean_PropertyType _lensDistortionInformationAvailability;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("lensDistortionInformationAvailability", Order = 11)]
    [JsonProperty("lensDistortionInformationAvailability", Order = 11)]
    public Boolean_PropertyType LensDistortionInformationAvailability {
      get {
        return _lensDistortionInformationAvailability;
      }
      set {
        if (_lensDistortionInformationAvailability == value) {
          return;
        }
        if (_lensDistortionInformationAvailability == null || _lensDistortionInformationAvailability.Equals(value) != true) {
          _lensDistortionInformationAvailability = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}