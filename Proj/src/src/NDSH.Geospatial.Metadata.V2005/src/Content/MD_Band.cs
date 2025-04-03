
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 02:14, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Derived.UnitsOfMeasure;
using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Implementation.Names;
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
  [XmlRoot("MD_Band", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_Band", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_Band")]
  public class MD_Band : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Band"/>.
    /// </summary>
    public MD_Band() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd"); // TODO: Make sure that the namespace is GMD.

      _sequenceIdentifier = default; //new MemberName();
      _descriptor = default;
      _maxValue = default;
      _minValue = default;
      _units = default; //new UomLength();
      _peakResponse = default;
      _bitsPerValue = default;
      _toneGradation = default;
      _scaleFactor = default;
      _offset = default;

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

    private MemberName _sequenceIdentifier;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "sequenceIdentifier")]
    [JsonProperty("sequenceIdentifier", Order = 0)]
    public MemberName SequenceIdentifier {
      get {
        return _sequenceIdentifier;
      }
      set {
        if (_sequenceIdentifier == value) {
          return;
        }
        if (_sequenceIdentifier == null || _sequenceIdentifier.Equals(value) != true) {
          _sequenceIdentifier = value;
          OnPropertyChanged();
        }
      }
    }

    private string _descriptor;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "descriptor")]
    [JsonProperty("descriptor", Order = 1)]
    public string Descriptor {
      get {
        return _descriptor;
      }
      set {
        if (_descriptor == value) {
          return;
        }
        if (_descriptor == null || _descriptor.Equals(value) != true) {
          _descriptor = value;
          OnPropertyChanged();
        }
      }
    }

    private double _maxValue;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "maxValue")]
    [RequiredAttribute()]
    [JsonProperty("maxValue", Order = 2)]
    public double MaxValue {
      get {
        return _maxValue;
      }
      set {
        if (_maxValue.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "MaxValue";
          Validator.ValidateProperty(value, validatorPropContext);
          _maxValue = value;
          OnPropertyChanged();
        }
      }
    }

    private double _minValue;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3, ElementName = "minValue")]
    [RequiredAttribute()]
    [JsonProperty("minValue", Order = 3)]
    public double MinValue {
      get {
        return _minValue;
      }
      set {
        if (_minValue.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "MinValue";
          Validator.ValidateProperty(value, validatorPropContext);
          _minValue = value;
          OnPropertyChanged();
        }
      }
    }

    private UomLength _units;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4, ElementName = "units")]
    [JsonProperty("units", Order = 4)]
    public UomLength Units {
      get {
        return _units;
      }
      set {
        if (_units == value) {
          return;
        }
        if (_units == null || _units.Equals(value) != true) {
          _units = value;
          OnPropertyChanged();
        }
      }
    }

    private double _peakResponse;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5, ElementName = "peakResponse")]
    [RequiredAttribute()]
    [JsonProperty("peakResponse", Order = 5)]
    public double PeakResponse {
      get {
        return _peakResponse;
      }
      set {
        if (_peakResponse.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "PeakResponse";
          Validator.ValidateProperty(value, validatorPropContext);
          _peakResponse = value;
          OnPropertyChanged();
        }
      }
    }

    private int _bitsPerValue;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6, ElementName = "bitsPerValue")]
    [RequiredAttribute()]
    [JsonProperty("bitsPerValue", Order = 6)]
    public int BitsPerValue {
      get {
        return _bitsPerValue;
      }
      set {
        if (_bitsPerValue.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "BitsPerValue";
          Validator.ValidateProperty(value, validatorPropContext);
          _bitsPerValue = value;
          OnPropertyChanged();
        }
      }
    }

    private int _toneGradation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 7, ElementName = "toneGradation")]
    [RequiredAttribute()]
    [JsonProperty("toneGradation", Order = 7)]
    public int ToneGradation {
      get {
        return _toneGradation;
      }
      set {
        if (_toneGradation.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "ToneGradation";
          Validator.ValidateProperty(value, validatorPropContext);
          _toneGradation = value;
          OnPropertyChanged();
        }
      }
    }

    private double _scaleFactor;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 8, ElementName = "scaleFactor")]
    [RequiredAttribute()]
    [JsonProperty("scaleFactor", Order = 8)]
    public double ScaleFactor {
      get {
        return _scaleFactor;
      }
      set {
        if (_scaleFactor.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "ScaleFactor";
          Validator.ValidateProperty(value, validatorPropContext);
          _scaleFactor = value;
          OnPropertyChanged();
        }
      }
    }

    private double _offset;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 9, ElementName = "offset")]
    [RequiredAttribute()]
    [JsonProperty("offset", Order = 9)]
    public double Offset {
      get {
        return _offset;
      }
      set {
        if (_offset.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "Offset";
          Validator.ValidateProperty(value, validatorPropContext);
          _offset = value;
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
