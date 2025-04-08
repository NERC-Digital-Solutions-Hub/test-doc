
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 01:55, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Implementation.Records;
using NDSH.Geospatial.Metadata.V2005.ReferenceSystem;
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

namespace NDSH.Geospatial.Metadata.V2005.Content {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("MD_ImageDescription", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_ImageDescription", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_ImageDescription")]
  public class MD_ImageDescription : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_ImageDescription"/>.
    /// </summary>
    public MD_ImageDescription() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd"); // TODO: Make sure that the namespace is GMD.

      _attributeDescription = default; // new RecordType();
      _contentType = default; // new MD_CoverageContentTypeCode();
      _dimension = default; // new List<Parent_MD_RangeDimension>();
      _illuminationElevationAngle = default;
      _illuminationAzimuthAngle = default;
      _imagingCondition = default; // new MD_ImagingConditionCode();
      _imageQualityCode = default; // new Parent_MD_Identifier();
      _cloudCoverPercentage = default;
      _processingLevelCode = default; // new Parent_MD_Identifier();
      _compressionGenerationQuantity = default;
      _triangulationIndicator = default; // new Boolean();
      _radiometricCalibrationDataAvailability = default; // new Boolean();
      _cameraCalibrationInformationAvailability = default; // new Boolean();
      _filmDistortionInformationAvailability = default; // new Boolean();
      _lensDistortionInformationAvailability = default; // new Boolean();

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

    private RecordType _attributeDescription;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "attributeDescription")]
    [JsonProperty("attributeDescription", Order = 0)]
    public RecordType AttributeDescription {
      get {
        return _attributeDescription;
      }
      set {
        if (_attributeDescription == value) {
          return;
        }
        if (_attributeDescription == null || _attributeDescription.Equals(value) != true) {
          _attributeDescription = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_CoverageContentTypeCode _contentType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "contentType")]
    [JsonProperty("contentType", Order = 1)]
    public MD_CoverageContentTypeCode ContentType {
      get {
        return _contentType;
      }
      set {
        if (_contentType == value) {
          return;
        }
        if (_contentType == null || _contentType.Equals(value) != true) {
          _contentType = value;
          OnPropertyChanged();
        }
      }
    }

    private List<Parent_MD_RangeDimension> _dimension;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("dimension", Order = 2, ElementName = "dimension")]
    [JsonProperty("dimension", Order = 2)]
    public List<Parent_MD_RangeDimension> Dimension {
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

    private double _illuminationElevationAngle;
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3, ElementName = "illuminationElevationAngle")]
    [RequiredAttribute()]
    [JsonProperty("illuminationElevationAngle", Order = 3)]
    public double IlluminationElevationAngle {
      get {
        return _illuminationElevationAngle;
      }
      set {
        if (_illuminationElevationAngle.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "IlluminationElevationAngle";
          Validator.ValidateProperty(value, validatorPropContext);
          _illuminationElevationAngle = value;
          OnPropertyChanged();
        }
      }
    }

    private double _illuminationAzimuthAngle;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4, ElementName = "illuminationAzimuthAngle")]
    [RequiredAttribute()]
    [JsonProperty("illuminationAzimuthAngle", Order = 4)]
    public double IlluminationAzimuthAngle {
      get {
        return _illuminationAzimuthAngle;
      }
      set {
        if (_illuminationAzimuthAngle.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "IlluminationAzimuthAngle";
          Validator.ValidateProperty(value, validatorPropContext);
          _illuminationAzimuthAngle = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_ImagingConditionCode _imagingCondition;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5, ElementName = "imagingCondition")]
    [JsonProperty("imagingCondition", Order = 5)]
    public MD_ImagingConditionCode ImagingCondition {
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

    private Parent_MD_Identifier _imageQualityCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6, ElementName = "imageQualityCode")]
    [JsonProperty("imageQualityCode", Order = 6)]
    public Parent_MD_Identifier ImageQualityCode {
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

    private double _cloudCoverPercentage;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 7, ElementName = "cloudCoverPercentage")]
    [RequiredAttribute()]
    [JsonProperty("cloudCoverPercentage", Order = 7)]
    public double CloudCoverPercentage {
      get {
        return _cloudCoverPercentage;
      }
      set {
        if (_cloudCoverPercentage.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "CloudCoverPercentage";
          Validator.ValidateProperty(value, validatorPropContext);
          _cloudCoverPercentage = value;
          OnPropertyChanged();
        }
      }
    }

    private Parent_MD_Identifier _processingLevelCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 8, ElementName = "processingLevelCode")]
    [JsonProperty("processingLevelCode", Order = 8)]
    public Parent_MD_Identifier ProcessingLevelCode {
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

    private int _compressionGenerationQuantity;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 9, ElementName = "compressionGenerationQuantity")]
    [RequiredAttribute()]
    [JsonProperty("compressionGenerationQuantity", Order = 9)]
    public int CompressionGenerationQuantity {
      get {
        return _compressionGenerationQuantity;
      }
      set {
        if (_compressionGenerationQuantity.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "CompressionGenerationQuantity";
          Validator.ValidateProperty(value, validatorPropContext);
          _compressionGenerationQuantity = value;
          OnPropertyChanged();
        }
      }
    }

    private Boolean _triangulationIndicator;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 10, ElementName = "triangulationIndicator")]
    [JsonProperty("triangulationIndicator", Order = 10)]
    public Boolean TriangulationIndicator {
      get {
        return _triangulationIndicator;
      }
      set {
        if (_triangulationIndicator == value) {
          return;
        }
        if (_triangulationIndicator == null || _triangulationIndicator.Equals(value) != true) { // TODO: Check out the problem with Boolean
          _triangulationIndicator = value;
          OnPropertyChanged();
        }
      }
    }

    private Boolean _radiometricCalibrationDataAvailability;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 11, ElementName = "radiometricCalibrationDataAvailability")]
    [JsonProperty("radiometricCalibrationDataAvailability", Order = 11)]
    public Boolean RadiometricCalibrationDataAvailability {
      get {
        return _radiometricCalibrationDataAvailability;
      }
      set {
        if (_radiometricCalibrationDataAvailability == value) {
          return;
        }
        if (_radiometricCalibrationDataAvailability == null || _radiometricCalibrationDataAvailability.Equals(value) != true) {  // TODO: Check out the problem with Boolean
          _radiometricCalibrationDataAvailability = value;
          OnPropertyChanged();
        }
      }
    }

    private Boolean _cameraCalibrationInformationAvailability;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 12, ElementName = "cameraCalibrationInformationAvailability")]
    [JsonProperty("cameraCalibrationInformationAvailability", Order = 12)]
    public Boolean CameraCalibrationInformationAvailability {
      get {
        return _cameraCalibrationInformationAvailability;
      }
      set {
        if (_cameraCalibrationInformationAvailability == value) {
          return;
        }
        if (_cameraCalibrationInformationAvailability == null || _cameraCalibrationInformationAvailability.Equals(value) != true) {  // TODO: Check out the problem with Boolean
          _cameraCalibrationInformationAvailability = value;
          OnPropertyChanged();
        }
      }
    }

    private Boolean _filmDistortionInformationAvailability;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 13, ElementName = "filmDistortionInformationAvailability")]
    [JsonProperty("filmDistortionInformationAvailability", Order = 13)]
    public Boolean FilmDistortionInformationAvailability {
      get {
        return _filmDistortionInformationAvailability;
      }
      set {
        if (_filmDistortionInformationAvailability == value) {
          return;
        }
        if (_filmDistortionInformationAvailability == null || _filmDistortionInformationAvailability.Equals(value) != true) { // TODO: Check out the problem with Boolean
          _filmDistortionInformationAvailability = value;
          OnPropertyChanged();
        }
      }
    }

    private Boolean _lensDistortionInformationAvailability;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 14, ElementName = "lensDistortionInformationAvailability")]
    [JsonProperty("lensDistortionInformationAvailability", Order = 14)]
    public Boolean LensDistortionInformationAvailability {
      get {
        return _lensDistortionInformationAvailability;
      }
      set {
        if (_lensDistortionInformationAvailability == value) {
          return;
        }
        if (_lensDistortionInformationAvailability == null || _lensDistortionInformationAvailability.Equals(value) != true) { // TODO: Check out the problem with Boolean
          _lensDistortionInformationAvailability = value;
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
