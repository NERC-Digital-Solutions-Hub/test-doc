
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 16/12/2022, 15:16, @EttoreM - Cleaned Xml Serialization Attributes.
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

namespace NDSH.Geospatial.Metadata.V2005.SpatialRepresentation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("MD_Dimension", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_Dimension", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_Dimension")]
  public class MD_Dimension : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Dimension"/>.
    /// </summary>
    public MD_Dimension() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _dimensionName = default;
      _dimensionSize = default;
      _resolution = default;

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

    private MD_DimensionNameTypeCode _dimensionName;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "dimensionName")]
    [JsonProperty("dimensionName", Order = 0)]
    public MD_DimensionNameTypeCode DimensionName {
      get {
        return _dimensionName;
      }
      set {
        if (_dimensionName == value) {
          return;
        }
        if (_dimensionName == null || _dimensionName.Equals(value) != true) {
          _dimensionName = value;
          OnPropertyChanged();
        }
      }
    }

    private int _dimensionSize;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "dimensionSize")]
    [RequiredAttribute()]
    [JsonProperty("dimensionSize", Order = 1)]
    public int DimensionSize {
      get {
        return _dimensionSize;
      }
      set {
        if (_dimensionSize.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "DimensionSize";
          Validator.ValidateProperty(value, validatorPropContext);
          _dimensionSize = value;
          OnPropertyChanged();
        }
      }
    }

    private Measure _resolution;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "resolution")]
    [JsonProperty("resolution", Order = 2)]
    public Measure Resolution {
      get {
        return _resolution;
      }
      set {
        if (_resolution == value) {
          return;
        }
        if (_resolution == null || _resolution.Equals(value) != true) {
          _resolution = value;
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
