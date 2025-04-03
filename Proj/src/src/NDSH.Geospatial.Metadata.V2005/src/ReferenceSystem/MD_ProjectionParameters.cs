
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 19:04, @fdq09eca, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Derived.UnitsOfMeasure;
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

namespace NDSH.Geospatial.Metadata.V2005.ReferenceSystem {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("MD_ProjectionParameters", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_ProjectionParameters", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_ProjectionParameters")]
  public class MD_ProjectionParameters : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_ProjectionParameters"/>.
    /// </summary>
    public MD_ProjectionParameters() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _zoneNumber = default;
      _standardParallel = default; //  new List<double>();
      _longitudeOfCentralMeridian = default;
      _latitudeOfProjectionOrigin = default;
      _falseEasting = default;
      _falseNorthing = default;
      _falseEastingNorthingUnits = default; // new UomLength();
      _scaleFactorAtEquator = default;
      _heightOfProspectivePointAboveSurface = default;
      _longitudeOfProjectionCenter = default;
      _latitudeOfProjectionCenter = default;
      _scaleFactorAtCenterLine = default;
      _straightVertialLongitudeFromPole = default;
      _scaleFactorAtProjectionOrigin = default;
      _obliqueLineAzimuthParameter = default; // new MD_ObliqueLineAzimuth();
      _obliqueLinePointParameter = default; // new List<MD_ObliqueLinePoint>();

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

    private int _zoneNumber;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "zoneNumber")]
    [RequiredAttribute()]
    [JsonProperty("zoneNumber", Order = 0)]
    public int ZoneNumber {
      get {
        return _zoneNumber;
      }
      set {
        if (_zoneNumber.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "ZoneNumber";
          Validator.ValidateProperty(value, validatorPropContext);
          _zoneNumber = value;
          OnPropertyChanged();
        }
      }
    }

    private List<double> _standardParallel;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("standardParallel", Order = 1, ElementName = "standardParallel")]
    [JsonProperty("standardParallel", Order = 1)]
    public List<double> StandardParallel {
      get {
        return _standardParallel;
      }
      set {
        if (_standardParallel == value) {
          return;
        }
        if (_standardParallel == null || _standardParallel.Equals(value) != true) {
          _standardParallel = value;
          OnPropertyChanged();
        }
      }
    }

    private double _longitudeOfCentralMeridian;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "longitudeOfCentralMeridian")]
    [RequiredAttribute()]
    [JsonProperty("longitudeOfCentralMeridian", Order = 2)]
    public double LongitudeOfCentralMeridian {
      get {
        return _longitudeOfCentralMeridian;
      }
      set {
        if (_longitudeOfCentralMeridian.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "LongitudeOfCentralMeridian";
          Validator.ValidateProperty(value, validatorPropContext);
          _longitudeOfCentralMeridian = value;
          OnPropertyChanged();
        }
      }
    }

    private double _latitudeOfProjectionOrigin;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3, ElementName = "latitudeOfProjectionOrigin")]
    [RequiredAttribute()]
    [JsonProperty("latitudeOfProjectionOrigin", Order = 3)]
    public double LatitudeOfProjectionOrigin {
      get {
        return _latitudeOfProjectionOrigin;
      }
      set {
        if (_latitudeOfProjectionOrigin.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "LatitudeOfProjectionOrigin";
          Validator.ValidateProperty(value, validatorPropContext);
          _latitudeOfProjectionOrigin = value;
          OnPropertyChanged();
        }
      }
    }

    private double _falseEasting;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4, ElementName = "falseEasting")]
    [RequiredAttribute()]
    [JsonProperty("falseEasting", Order = 4)]
    public double FalseEasting {
      get {
        return _falseEasting;
      }
      set {
        if (_falseEasting.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "FalseEasting";
          Validator.ValidateProperty(value, validatorPropContext);
          _falseEasting = value;
          OnPropertyChanged();
        }
      }
    }

    private double _falseNorthing;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5, ElementName = "falseNorthing")]
    [RequiredAttribute()]
    [JsonProperty("falseNorthing", Order = 5)]
    public double FalseNorthing {
      get {
        return _falseNorthing;
      }
      set {
        if (_falseNorthing.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "FalseNorthing";
          Validator.ValidateProperty(value, validatorPropContext);
          _falseNorthing = value;
          OnPropertyChanged();
        }
      }
    }

    private UomLength _falseEastingNorthingUnits;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6, ElementName = "falseEastingNorthingUnits")]
    [JsonProperty("falseEastingNorthingUnits", Order = 6)]
    public UomLength FalseEastingNorthingUnits {
      get {
        return _falseEastingNorthingUnits;
      }
      set {
        if (_falseEastingNorthingUnits == value) {
          return;
        }
        if (_falseEastingNorthingUnits == null || _falseEastingNorthingUnits.Equals(value) != true) {
          _falseEastingNorthingUnits = value;
          OnPropertyChanged();
        }
      }
    }

    private double _scaleFactorAtEquator;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 7, ElementName = "scaleFactorAtEquator")]
    [RequiredAttribute()]
    [JsonProperty("scaleFactorAtEquator", Order = 7)]
    public double ScaleFactorAtEquator {
      get {
        return _scaleFactorAtEquator;
      }
      set {
        if (_scaleFactorAtEquator.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "ScaleFactorAtEquator";
          Validator.ValidateProperty(value, validatorPropContext);
          _scaleFactorAtEquator = value;
          OnPropertyChanged();
        }
      }
    }

    private double _heightOfProspectivePointAboveSurface;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 8, ElementName = "heightOfProspectivePointAboveSurface")]
    [RequiredAttribute()]
    [JsonProperty("heightOfProspectivePointAboveSurface", Order = 8)]
    public double HeightOfProspectivePointAboveSurface {
      get {
        return _heightOfProspectivePointAboveSurface;
      }
      set {
        if (_heightOfProspectivePointAboveSurface.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "HeightOfProspectivePointAboveSurface";
          Validator.ValidateProperty(value, validatorPropContext);
          _heightOfProspectivePointAboveSurface = value;
          OnPropertyChanged();
        }
      }
    }

    private double _longitudeOfProjectionCenter;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 9, ElementName = "longitudeOfProjectionCenter")]
    [RequiredAttribute()]
    [JsonProperty("longitudeOfProjectionCenter", Order = 9)]
    public double LongitudeOfProjectionCenter {
      get {
        return _longitudeOfProjectionCenter;
      }
      set {
        if (_longitudeOfProjectionCenter.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "LongitudeOfProjectionCenter";
          Validator.ValidateProperty(value, validatorPropContext);
          _longitudeOfProjectionCenter = value;
          OnPropertyChanged();
        }
      }
    }

    private double _latitudeOfProjectionCenter;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 10, ElementName = "latitudeOfProjectionCenter")]
    [RequiredAttribute()]
    [JsonProperty("latitudeOfProjectionCenter", Order = 10)]
    public double LatitudeOfProjectionCenter {
      get {
        return _latitudeOfProjectionCenter;
      }
      set {
        if (_latitudeOfProjectionCenter.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "LatitudeOfProjectionCenter";
          Validator.ValidateProperty(value, validatorPropContext);
          _latitudeOfProjectionCenter = value;
          OnPropertyChanged();
        }
      }
    }

    private double _scaleFactorAtCenterLine;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 11, ElementName = "scaleFactorAtCenterLine")]
    [RequiredAttribute()]
    [JsonProperty("scaleFactorAtCenterLine", Order = 11)]
    public double ScaleFactorAtCenterLine {
      get {
        return _scaleFactorAtCenterLine;
      }
      set {
        if (_scaleFactorAtCenterLine.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "ScaleFactorAtCenterLine";
          Validator.ValidateProperty(value, validatorPropContext);
          _scaleFactorAtCenterLine = value;
          OnPropertyChanged();
        }
      }
    }

    private double _straightVertialLongitudeFromPole;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 12, ElementName = "straightVertialLongitudeFromPole")]
    [RequiredAttribute()]
    [JsonProperty("straightVertialLongitudeFromPole", Order = 12)]
    public double StraightVertialLongitudeFromPole {
      get {
        return _straightVertialLongitudeFromPole;
      }
      set {
        if (_straightVertialLongitudeFromPole.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "StraightVertialLongitudeFromPole";
          Validator.ValidateProperty(value, validatorPropContext);
          _straightVertialLongitudeFromPole = value;
          OnPropertyChanged();
        }
      }
    }

    private double _scaleFactorAtProjectionOrigin;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 13, ElementName = "scaleFactorAtProjectionOrigin")]
    [RequiredAttribute()]
    [JsonProperty("scaleFactorAtProjectionOrigin", Order = 13)]
    public double ScaleFactorAtProjectionOrigin {
      get {
        return _scaleFactorAtProjectionOrigin;
      }
      set {
        if (_scaleFactorAtProjectionOrigin.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "ScaleFactorAtProjectionOrigin";
          Validator.ValidateProperty(value, validatorPropContext);
          _scaleFactorAtProjectionOrigin = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_ObliqueLineAzimuth _obliqueLineAzimuthParameter;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 14, ElementName = "obliqueLineAzimuthParameter")]
    [JsonProperty("obliqueLineAzimuthParameter", Order = 14)]
    public MD_ObliqueLineAzimuth ObliqueLineAzimuthParameter {
      get {
        return _obliqueLineAzimuthParameter;
      }
      set {
        if (_obliqueLineAzimuthParameter == value) {
          return;
        }
        if (_obliqueLineAzimuthParameter == null || _obliqueLineAzimuthParameter.Equals(value) != true) {
          _obliqueLineAzimuthParameter = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_ObliqueLinePoint> _obliqueLinePointParameter;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("obliqueLinePointParameter", Order = 15, ElementName = "obliqueLinePointParameter")]
    [JsonProperty("obliqueLinePointParameter", Order = 15)]
    public List<MD_ObliqueLinePoint> ObliqueLinePointParameter {
      get {
        return _obliqueLinePointParameter;
      }
      set {
        if (_obliqueLinePointParameter == value) {
          return;
        }
        if (_obliqueLinePointParameter == null || _obliqueLinePointParameter.Equals(value) != true) {
          _obliqueLinePointParameter = value;
          OnPropertyChanged();
        }
      }
    }

    private string _id;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(DataType = "ID", AttributeName = "id")]
    [XmlIgnore]
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
    [XmlIgnore]
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
