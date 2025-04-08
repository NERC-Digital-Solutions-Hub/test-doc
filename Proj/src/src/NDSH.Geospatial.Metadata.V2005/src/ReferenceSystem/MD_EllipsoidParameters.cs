
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 18:54, @fdq09eca - Cleaned Xml Serialization Attributes.
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
  [XmlRoot("MD_EllipsoidParameters", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_EllipsoidParameters", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_EllipsoidParameters")]
  public class MD_EllipsoidParameters : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_EllipsoidParameters"/>.
    /// </summary>
    public MD_EllipsoidParameters() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _semiMajorAxis = default;
      _axisUnits = default; //  new UomLength();
      _denominatorOfFlatteningRatio = default;

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

    private double _semiMajorAxis;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "semiMajorAxis")]
    [RequiredAttribute()]
    [JsonProperty("semiMajorAxis", Order = 0)]
    public double SemiMajorAxis {
      get {
        return _semiMajorAxis;
      }
      set {
        if (_semiMajorAxis.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "SemiMajorAxis";
          Validator.ValidateProperty(value, validatorPropContext);
          _semiMajorAxis = value;
          OnPropertyChanged();
        }
      }
    }

    private UomLength _axisUnits;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "axisUnits")]
    [JsonProperty("axisUnits", Order = 1)]
    public UomLength AxisUnits {
      get {
        return _axisUnits;
      }
      set {
        if (_axisUnits == value) {
          return;
        }
        if (_axisUnits == null || _axisUnits.Equals(value) != true) {
          _axisUnits = value;
          OnPropertyChanged();
        }
      }
    }

    private double _denominatorOfFlatteningRatio;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "denominatorOfFlatteningRatio")]
    [RequiredAttribute()]
    [JsonProperty("denominatorOfFlatteningRatio", Order = 2)]
    public double DenominatorOfFlatteningRatio {
      get {
        return _denominatorOfFlatteningRatio;
      }
      set {
        if (_denominatorOfFlatteningRatio.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "DenominatorOfFlatteningRatio";
          Validator.ValidateProperty(value, validatorPropContext);
          _denominatorOfFlatteningRatio = value;
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
