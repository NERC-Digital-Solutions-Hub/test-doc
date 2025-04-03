
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 17/12/2022, 00:11, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005;
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

namespace NDSH.Geospatial.Metadata.V2005.Common.Extent {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("EX_VerticalExtent", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("EX_VerticalExtent", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("EX_VerticalExtent")]
  public class EX_VerticalExtent : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_VerticalExtent"/>.
    /// </summary>
    public EX_VerticalExtent() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _minimumValue = default;
      _maximumValue = default;
      _unitOfMeasure = default; //new UomLength();
      _verticalDatum = default; //new SC_VerticalDatum();

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

    private double _minimumValue;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "minimumValue")]
    [RequiredAttribute()]
    [JsonProperty("minimumValue", Order = 0)]
    public double MinimumValue {
      get {
        return _minimumValue;
      }
      set {
        if (_minimumValue.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "MinimumValue";
          Validator.ValidateProperty(value, validatorPropContext);
          _minimumValue = value;
          OnPropertyChanged();
        }
      }
    }

    private double _maximumValue;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "maximumValue")]
    [RequiredAttribute()]
    [JsonProperty("maximumValue", Order = 1)]
    public double MaximumValue {
      get {
        return _maximumValue;
      }
      set {
        if (_maximumValue.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "MaximumValue";
          Validator.ValidateProperty(value, validatorPropContext);
          _maximumValue = value;
          OnPropertyChanged();
        }
      }
    }
    private UomLength _unitOfMeasure;


    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "unitOfMeasure")]
    [JsonProperty("unitOfMeasure", Order = 2)]
    public UomLength UnitOfMeasure {
      get {
        return _unitOfMeasure;
      }
      set {
        if (_unitOfMeasure == value) {
          return;
        }
        if (_unitOfMeasure == null || _unitOfMeasure.Equals(value) != true) {
          _unitOfMeasure = value;
          OnPropertyChanged();
        }
      }
    }
    private SC_VerticalDatum _verticalDatum;


    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3, ElementName = "verticalDatum")]
    [JsonProperty("verticalDatum", Order = 3)]
    public SC_VerticalDatum VerticalDatum {
      get {
        return _verticalDatum;
      }
      set {
        if (_verticalDatum == value) {
          return;
        }
        if (_verticalDatum == null || _verticalDatum.Equals(value) != true) {
          _verticalDatum = value;
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
