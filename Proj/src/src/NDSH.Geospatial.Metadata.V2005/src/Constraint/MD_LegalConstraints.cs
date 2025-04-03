
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 17/12/2022, 02:47, @fdq09eca - Cleaned Xml Serialization Attributes.
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
  [XmlRoot("MD_LegalConstraints", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_LegalConstraints", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_LegalConstraints")]
  public class MD_LegalConstraints : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_LegalConstraints"/>.
    /// </summary>
    public MD_LegalConstraints() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _otherConstraints = default; // new List<string>();
      _useConstraints = default; // new List<MD_RestrictionCode>();
      _accessConstraints = default; // new List<MD_RestrictionCode>();
      _useLimitation = default; // new List<string>();

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
    [XmlElement("useLimitation", Order = 0, ElementName = "useLimitation")]
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

    private List<MD_RestrictionCode> _accessConstraints;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("accessConstraints", Order = 1, ElementName = "accessConstraints")]
    [JsonProperty("accessConstraints", Order = 1)]
    public List<MD_RestrictionCode> AccessConstraints {
      get {
        return _accessConstraints;
      }
      set {
        if (_accessConstraints == value) {
          return;
        }
        if (_accessConstraints == null || _accessConstraints.Equals(value) != true) {
          _accessConstraints = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_RestrictionCode> _useConstraints;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("useConstraints", Order = 2, ElementName = "useConstraints")]
    [JsonProperty("useConstraints", Order = 2)]
    public List<MD_RestrictionCode> UseConstraints {
      get {
        return _useConstraints;
      }
      set {
        if (_useConstraints == value) {
          return;
        }
        if (_useConstraints == null || _useConstraints.Equals(value) != true) {
          _useConstraints = value;
          OnPropertyChanged();
        }
      }
    }

    private List<string> _otherConstraints;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("otherConstraints", Order = 3, ElementName = "otherConstraints")]
    [JsonProperty("otherConstraints", Order = 3)]
    public List<string> OtherConstraints {
      get {
        return _otherConstraints;
      }
      set {
        if (_otherConstraints == value) {
          return;
        }
        if (_otherConstraints == null || _otherConstraints.Equals(value) != true) {
          _otherConstraints = value;
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
