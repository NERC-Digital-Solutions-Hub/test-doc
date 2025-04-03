
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 17/12/2022, 02:54, @fdq09eca - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.Constraint {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("MD_SecurityConstraints", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_SecurityConstraints", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_SecurityConstraints")]
  public class MD_SecurityConstraints : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_SecurityConstraints"/>.
    /// </summary>
    public MD_SecurityConstraints() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _useLimitation = default; // new List<string>();
      _classification = default; // new MD_ClassificationCode();
      _userNote = default;
      _classificationSystem = default;
      _handlingDescription = default;

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

    private List<string> _useLimitation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "useLimitation")]
    [JsonProperty("useLimitation", Order = 0)]
    public List<string> UseLimitation {
      get {
        return _useLimitation;
      }
      set {
        if (_useLimitation == value) {
          return;
        }
        if (_useLimitation == null || _useLimitation.Equals(value) != true) {
          _useLimitation = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_ClassificationCode _classification;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "classification")]
    [JsonProperty("classification", Order = 1)]
    public MD_ClassificationCode Classification {
      get {
        return _classification;
      }
      set {
        if (_classification == value) {
          return;
        }
        if (_classification == null || _classification.Equals(value) != true) {
          _classification = value;
          OnPropertyChanged();
        }
      }
    }

    private string _userNote;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "userNote")]
    [JsonProperty("userNote", Order = 2)]
    public string UserNote {
      get {
        return _userNote;
      }
      set {
        if (_userNote == value) {
          return;
        }
        if (_userNote == null || _userNote.Equals(value) != true) {
          _userNote = value;
          OnPropertyChanged();
        }
      }
    }

    private string _classificationSystem;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3, ElementName = "classificationSystem")]
    [JsonProperty("classificationSystem", Order = 3)]
    public string ClassificationSystem {
      get {
        return _classificationSystem;
      }
      set {
        if (_classificationSystem == value) {
          return;
        }
        if (_classificationSystem == null || _classificationSystem.Equals(value) != true) {
          _classificationSystem = value;
          OnPropertyChanged();
        }
      }
    }

    private string _handlingDescription;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4, ElementName = "handlingDescription")]
    [JsonProperty("handlingDescription", Order = 4)]
    public string HandlingDescription {
      get {
        return _handlingDescription;
      }
      set {
        if (_handlingDescription == value) {
          return;
        }
        if (_handlingDescription == null || _handlingDescription.Equals(value) != true) {
          _handlingDescription = value;
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
