
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 18:27, @gisvlasta.
// Updated by        : 09/01/2023, 18:23, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Derived.UnitsOfMeasure;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Numerics;
using NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Content;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Content {
  
  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(MI_Band_Type))]
  [Serializable]
  [XmlType("MD_Band", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_Band", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_Band")]
  public class MD_Band_Type : MD_RangeDimension_Type {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Band_Type"/>.
    /// </summary>
    public MD_Band_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _maxValue  = default; //  new Real_PropertyType();
      _minValue  = default; //  new Real_PropertyType();
      _units  = default; //  new UomLength_PropertyType();
      _peakResponse  = default; //  new Real_PropertyType();
      _bitsPerValue  = default; //  new Integer_PropertyType();
      _toneGradation  = default; //  new Integer_PropertyType();
      _scaleFactor  = default; //  new Real_PropertyType();
      _offset  = default; //  new Real_PropertyType();
      
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

    private Real_PropertyType _maxValue;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("maxValue", Order = 0)]
    [JsonProperty("maxValue", Order = 0)]
    public Real_PropertyType MaxValue {
      get {
        return _maxValue;
      }
      set {
        if (_maxValue == value) {
          return;
        }
        if (_maxValue == null || _maxValue.Equals(value) != true) {
          _maxValue = value;
          OnPropertyChanged();
        }
      }
    }

    private Real_PropertyType _minValue;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("minValue", Order = 1)]
    [JsonProperty("minValue", Order = 1)]
    public Real_PropertyType MinValue {
      get {
        return _minValue;
      }
      set {
        if (_minValue == value) {
          return;
        }
        if (_minValue == null || _minValue.Equals(value) != true) {
          _minValue = value;
          OnPropertyChanged();
        }
      }
    }

    private UomLength_PropertyType _units;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("units", Order = 2)]
    [JsonProperty("units", Order = 2)]
    public UomLength_PropertyType Units {
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

    private Real_PropertyType _peakResponse;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("peakResponse", Order = 3)]
    [JsonProperty("peakResponse", Order = 3)]
    public Real_PropertyType PeakResponse {
      get {
        return _peakResponse;
      }
      set {
        if (_peakResponse == value) {
          return;
        }
        if (_peakResponse == null || _peakResponse.Equals(value) != true) {
          _peakResponse = value;
          OnPropertyChanged();
        }
      }
    }

    private Integer_PropertyType _bitsPerValue;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("bitsPerValue", Order = 4)]
    [JsonProperty("bitsPerValue", Order = 4)]
    public Integer_PropertyType BitsPerValue {
      get {
        return _bitsPerValue;
      }
      set {
        if (_bitsPerValue == value) {
          return;
        }
        if (_bitsPerValue == null || _bitsPerValue.Equals(value) != true) {
          _bitsPerValue = value;
          OnPropertyChanged();
        }
      }
    }

    private Integer_PropertyType _toneGradation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("toneGradation", Order = 5)]
    [JsonProperty("toneGradation", Order = 5)]
    public Integer_PropertyType ToneGradation {
      get {
        return _toneGradation;
      }
      set {
        if (_toneGradation == value) {
          return;
        }
        if (_toneGradation == null || _toneGradation.Equals(value) != true) {
          _toneGradation = value;
          OnPropertyChanged();
        }
      }
    }

    private Real_PropertyType _scaleFactor;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("scaleFactor", Order = 6)]
    [JsonProperty("scaleFactor", Order = 6)]
    public Real_PropertyType ScaleFactor {
      get {
        return _scaleFactor;
      }
      set {
        if (_scaleFactor == value) {
          return;
        }
        if (_scaleFactor == null || _scaleFactor.Equals(value) != true) {
          _scaleFactor = value;
          OnPropertyChanged();
        }
      }
    }

    private Real_PropertyType _offset;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("offset", Order = 7)]
    [JsonProperty("offset", Order = 7)]
    public Real_PropertyType Offset {
      get {
        return _offset;
      }
      set {
        if (_offset == value) {
          return;
        }
        if (_offset == null || _offset.Equals(value) != true) {
          _offset = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}