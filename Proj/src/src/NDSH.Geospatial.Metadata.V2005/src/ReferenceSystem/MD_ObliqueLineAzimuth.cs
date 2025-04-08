
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 18:56, @fdq09eca, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005;
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
  [XmlRoot("MD_ObliqueLineAzimuth", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_ObliqueLineAzimuth", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_ObliqueLineAzimuth")]
  public class MD_ObliqueLineAzimuth : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_ObliqueLineAzimuth"/>.
    /// </summary>
    public MD_ObliqueLineAzimuth() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _azimuthAngle = default;
      _azimuthMeasurePointLongitude = default;

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

    private double _azimuthAngle;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "azimuthAngle")]
    [RequiredAttribute()]
    [JsonProperty("azimuthAngle", Order = 0)]
    public double AzimuthAngle {
      get {
        return _azimuthAngle;
      }
      set {
        if (_azimuthAngle.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "AzimuthAngle";
          Validator.ValidateProperty(value, validatorPropContext);
          _azimuthAngle = value;
          OnPropertyChanged();
        }
      }
    }

    private double _azimuthMeasurePointLongitude;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "azimuthMeasurePointLongitude")]
    [RequiredAttribute()]
    [JsonProperty("azimuthMeasurePointLongitude", Order = 1)]
    public double AzimuthMeasurePointLongitude {
      get {
        return _azimuthMeasurePointLongitude;
      }
      set {
        if (_azimuthMeasurePointLongitude.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "AzimuthMeasurePointLongitude";
          Validator.ValidateProperty(value, validatorPropContext);
          _azimuthMeasurePointLongitude = value;
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
