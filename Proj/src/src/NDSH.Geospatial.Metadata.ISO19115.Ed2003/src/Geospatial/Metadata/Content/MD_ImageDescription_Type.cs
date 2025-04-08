
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 28/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/content.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MD_ImageDescription_Type">
//   <xs:complexContent>
//     <xs:extension base="gmd:MD_CoverageDescription_Type">
//       <xs:sequence>
//         <xs:element name="illuminationElevationAngle" type="gco:Real_PropertyType" minOccurs="0"/>
//         <xs:element name="illuminationAzimuthAngle" type="gco:Real_PropertyType" minOccurs="0"/>
//         <xs:element name="imagingCondition" type="gmd:MD_ImagingConditionCode_PropertyType" minOccurs="0"/>
//         <xs:element name="imageQualityCode" type="gmd:MD_Identifier_PropertyType" minOccurs="0"/>
//         <xs:element name="cloudCoverPercentage" type="gco:Real_PropertyType" minOccurs="0"/>
//         <xs:element name="processingLevelCode" type="gmd:MD_Identifier_PropertyType" minOccurs="0"/>
//         <xs:element name="compressionGenerationQuantity" type="gco:Integer_PropertyType" minOccurs="0"/>
//         <xs:element name="triangulationIndicator" type="gco:Boolean_PropertyType" minOccurs="0"/>
//         <xs:element name="radiometricCalibrationDataAvailability" type="gco:Boolean_PropertyType" minOccurs="0"/>
//         <xs:element name="cameraCalibrationInformationAvailability" type="gco:Boolean_PropertyType" minOccurs="0"/>
//         <xs:element name="filmDistortionInformationAvailability" type="gco:Boolean_PropertyType" minOccurs="0"/>
//         <xs:element name="lensDistortionInformationAvailability" type="gco:Boolean_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_ImageDescription"
//             type="gmd:MD_ImageDescription_Type" substitutionGroup="gmd:MD_CoverageDescription"/>
// <xs:complexType name="MD_ImageDescription_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_ImageDescription"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.ReferenceSystem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Content {

  /// <summary>
  /// Information about an image's suitability for use.
  /// </summary>
  //[XmlInclude(typeof(MI_ImageDescription_Type))]
  [Serializable]
  //[XmlType("MD_ImageDescription", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_ImageDescription", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_ImageDescription")]
  public class MD_ImageDescription_Type : MD_CoverageDescription_Type {

    // WARNING: Check which value types need to be nullable.

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_ImageDescription_Type"/>.
    /// </summary>
    public MD_ImageDescription_Type() {
      _illuminationElevationAngle = default; //  new Real_PropertyType();
      _illuminationAzimuthAngle = default; //  new Real_PropertyType();
      _imagingCondition = default; //  new MD_ImagingConditionCode_PropertyType();
      _imageQualityCode = default; //  new MD_Identifier_Type();
      _cloudCoverPercentage = default; //  new Real_PropertyType();
      _processingLevelCode = default; //  new MD_Identifier_Type();
      _compressionGenerationQuantity = default; //  new Integer_PropertyType();
      _triangulationIndicator = default; //  new Boolean_PropertyType();
      _radiometricCalibrationDataAvailability = default; //  new Boolean_PropertyType();
      _cameraCalibrationInformationAvailability = default; //  new Boolean_PropertyType();
      _filmDistortionInformationAvailability = default; //  new Boolean_PropertyType();
      _lensDistortionInformationAvailability = default; //  new Boolean_PropertyType();
    }

    #endregion

    #region Public Properties

    private double? _illuminationElevationAngle;

    /// <summary>
    /// Illumination elevation measured in degrees clockwise from the target plane
    /// at intersection of the optical lie of sight with the Earth's surface.
    /// </summary>
    /// <remarks>For images from a scanning device, refer to the centre pixel of the image.</remarks>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("illuminationElevationAngle", Order = 0)]
    [JsonProperty("illuminationElevationAngle", Order = 0)]
    public double? IlluminationElevationAngle {
      get => _illuminationElevationAngle;
      // TODO: SetProperty
      set {
        if (_illuminationElevationAngle == value) {
          return;
        }
        if (/*_illuminationElevationAngle == null || */_illuminationElevationAngle.Equals(value) != true) {
          _illuminationElevationAngle = value;
          OnPropertyChanged();
        }
      }
    }

    private double? _illuminationAzimuthAngle;

    /// <summary>
    /// Illumination azimuth measured in degrees clockwise from true north at the time the image is taken.
    /// </summary>
    /// <remarks>For images from a scanning device, refer to the centre pixel of the image.</remarks>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("illuminationAzimuthAngle", Order = 1)]
    [JsonProperty("illuminationAzimuthAngle", Order = 1)]
    public double? IlluminationAzimuthAngle {
      get => _illuminationAzimuthAngle;
      // TODO: SetProperty
      set {
        if (_illuminationAzimuthAngle == value) {
          return;
        }
        if (/*_illuminationAzimuthAngle == null || */_illuminationAzimuthAngle.Equals(value) != true) {
          _illuminationAzimuthAngle = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_ImagingConditionCode_CodeList? _imagingCondition;

    /// <summary>
    /// Conditions affected the image.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("imagingCondition", Order = 2)]
    [JsonProperty("imagingCondition", Order = 2)]
    public MD_ImagingConditionCode_CodeList? ImagingCondition {
      get => _imagingCondition;
      set => SetProperty(ref _imagingCondition, value);
    }

    private MD_Identifier_Type? _imageQualityCode;

    /// <summary>
    /// Specifies the image quality.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("imageQualityCode", Order = 3)]
    [JsonProperty("imageQualityCode", Order = 3)]
    public MD_Identifier_Type? ImageQualityCode {
      get => _imageQualityCode;
      set => SetProperty(ref _imageQualityCode, value);
    }

    private double? _cloudCoverPercentage;

    /// <summary>
    /// Area of the dataset obscured by clouds, expressed as a percentage of the spatial extent.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("cloudCoverPercentage", Order = 4)]
    [JsonProperty("cloudCoverPercentage", Order = 4)]
    public double? CloudCoverPercentage {
      get => _cloudCoverPercentage;
      // TODO: SetProperty
      set {
        if (_cloudCoverPercentage == value) {
          return;
        }
        if (/*_cloudCoverPercentage == null || */_cloudCoverPercentage.Equals(value) != true) {
          _cloudCoverPercentage = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_Identifier_Type? _processingLevelCode;

    /// <summary>
    /// Image distributor's code that identifies the level of radiometric and
    /// geometric processing that has been applied.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("processingLevelCode", Order = 5)]
    [JsonProperty("processingLevelCode", Order = 5)]
    public MD_Identifier_Type? ProcessingLevelCode {
      get => _processingLevelCode;
      set => SetProperty(ref _processingLevelCode, value);
    }

    private int? _compressionGenerationQuantity;

    /// <summary>
    /// Count of the number of lossy compression cycles performed on the image.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("compressionGenerationQuantity", Order = 6)]
    [JsonProperty("compressionGenerationQuantity", Order = 6)]
    public int? CompressionGenerationQuantity {
      get => _compressionGenerationQuantity;
      // TODO: SetProperty
      set {
        if (_compressionGenerationQuantity == value) {
          return;
        }
        if (/*_compressionGenerationQuantity == null || */_compressionGenerationQuantity.Equals(value) != true) {
          _compressionGenerationQuantity = value;
          OnPropertyChanged();
        }
      }
    }

    private bool? _triangulationIndicator;

    /// <summary>
    /// Indication of whether or not triangulation has been performed on the image.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("triangulationIndicator", Order = 7)]
    [JsonProperty("triangulationIndicator", Order = 7)]
    public bool? TriangulationIndicator {
      get => _triangulationIndicator;
      // TODO: SetProperty
      set {
        if (_triangulationIndicator == value) {
          return;
        }
        if (/*_triangulationIndicator == null || */_triangulationIndicator.Equals(value) != true) {
          _triangulationIndicator = value;
          OnPropertyChanged();
        }
      }
    }

    private bool? _radiometricCalibrationDataAvailability;

    /// <summary>
    /// Indication of whether or not the radiometric calibration information for
    /// generating the radiometrically calibrated standard data product is available.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("radiometricCalibrationDataAvailability", Order = 8)]
    [JsonProperty("radiometricCalibrationDataAvailability", Order = 8)]
    public bool? RadiometricCalibrationDataAvailability {
      get => _radiometricCalibrationDataAvailability;
      // TODO: SetProperty
      set {
        if (_radiometricCalibrationDataAvailability == value) {
          return;
        }
        if (/*_radiometricCalibrationDataAvailability == null || */_radiometricCalibrationDataAvailability.Equals(value) != true) {
          _radiometricCalibrationDataAvailability = value;
          OnPropertyChanged();
        }
      }
    }

    private bool? _cameraCalibrationInformationAvailability;

    /// <summary>
    /// Indication of whether or not constants are available which allow for camera calibration corrections.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("cameraCalibrationInformationAvailability", Order = 9)]
    [JsonProperty("cameraCalibrationInformationAvailability", Order = 9)]
    public bool? CameraCalibrationInformationAvailability {
      get => _cameraCalibrationInformationAvailability;
      // TODO: SetProperty
      set {
        if (_cameraCalibrationInformationAvailability == value) {
          return;
        }
        if (/*_cameraCalibrationInformationAvailability == null || */_cameraCalibrationInformationAvailability.Equals(value) != true) {
          _cameraCalibrationInformationAvailability = value;
          OnPropertyChanged();
        }
      }
    }

    private bool? _filmDistortionInformationAvailability;

    /// <summary>
    /// Indication of whether or not Calibration Reseau information is available.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("filmDistortionInformationAvailability", Order = 10)]
    [JsonProperty("filmDistortionInformationAvailability", Order = 10)]
    public bool? FilmDistortionInformationAvailability {
      get => _filmDistortionInformationAvailability;
      // TODO: SetProperty
      set {
        if (_filmDistortionInformationAvailability == value) {
          return;
        }
        if (/*_filmDistortionInformationAvailability == null || */_filmDistortionInformationAvailability.Equals(value) != true) {
          _filmDistortionInformationAvailability = value;
          OnPropertyChanged();
        }
      }
    }

    private bool? _lensDistortionInformationAvailability;

    /// <summary>
    /// Indication of whether or not lens aberration correction information is available.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("lensDistortionInformationAvailability", Order = 11)]
    [JsonProperty("lensDistortionInformationAvailability", Order = 11)]
    public bool? LensDistortionInformationAvailability {
      get => _lensDistortionInformationAvailability;
      // TODO: SetProperty
      set {
        if (_lensDistortionInformationAvailability == value) {
          return;
        }
        if (/*_lensDistortionInformationAvailability == null || */_lensDistortionInformationAvailability.Equals(value) != true) {
          _lensDistortionInformationAvailability = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
