
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 18:59, @fdq09eca, @gisvlasta - Cleaned Xml Serialization Attributes.
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
  [XmlRoot("MD_ObliqueLinePoint", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_ObliqueLinePoint", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_ObliqueLinePoint")]
  public class MD_ObliqueLinePoint : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_ObliqueLinePoint"/>.
    /// </summary>
    public MD_ObliqueLinePoint() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _obliqueLineLatitude = default;
      _obliqueLineLongitude = default;

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

    private double _obliqueLineLatitude;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "obliqueLineLatitude")]
    [RequiredAttribute()]
    [JsonProperty("obliqueLineLatitude", Order = 0)]
    public double ObliqueLineLatitude {
      get {
        return _obliqueLineLatitude;
      }
      set {
        if (_obliqueLineLatitude.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "ObliqueLineLatitude";
          Validator.ValidateProperty(value, validatorPropContext);
          _obliqueLineLatitude = value;
          OnPropertyChanged();
        }
      }
    }

    private double _obliqueLineLongitude;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "obliqueLineLongitude")]
    [RequiredAttribute()]
    [JsonProperty("obliqueLineLongitude", Order = 1)]
    public double ObliqueLineLongitude {
      get {
        return _obliqueLineLongitude;
      }
      set {
        if (_obliqueLineLongitude.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "ObliqueLineLongitude";
          Validator.ValidateProperty(value, validatorPropContext);
          _obliqueLineLongitude = value;
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
