
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 16/12/2022, 19:10, @gisvlasta - Cleaned Xml Serialization Attributes.
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

namespace NDSH.Geospatial.Metadata.V2005.Common.Citation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("CI_OnlineResource", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("CI_OnlineResource", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("CI_OnlineResource")]
  public class CI_OnlineResource : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_OnlineResource"/>.
    /// </summary>
    public CI_OnlineResource() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _linkage = default;
      _protocol = default;
      _applicationProfile = default;
      _name = default;
      _description = default;
      _function = default;

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

    private string _linkage;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "linkage")]
    [JsonProperty("linkage", Order = 0)]
    public string Linkage {
      get {
        return _linkage;
      }
      set {
        if (_linkage == value) {
          return;
        }
        if (_linkage == null || _linkage.Equals(value) != true) {
          _linkage = value;
          OnPropertyChanged();
        }
      }
    }

    private string _protocol;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "protocol")]
    [JsonProperty("protocol", Order = 1)]
    public string Protocol {
      get {
        return _protocol;
      }
      set {
        if (_protocol == value) {
          return;
        }
        if (_protocol == null || _protocol.Equals(value) != true) {
          _protocol = value;
          OnPropertyChanged();
        }
      }
    }

    private string _applicationProfile;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "applicationProfile")]
    [JsonProperty("applicationProfile", Order = 2)]
    public string ApplicationProfile {
      get {
        return _applicationProfile;
      }
      set {
        if (_applicationProfile == value) {
          return;
        }
        if (_applicationProfile == null || _applicationProfile.Equals(value) != true) {
          _applicationProfile = value;
          OnPropertyChanged();
        }
      }
    }

    private string _name;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3, ElementName = "name")]
    [JsonProperty("name", Order = 3)]
    public string Name {
      get {
        return _name;
      }
      set {
        if (_name == value) {
          return;
        }
        if (_name == null || _name.Equals(value) != true) {
          _name = value;
          OnPropertyChanged();
        }
      }
    }

    private string _description;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4, ElementName = "description")]
    [JsonProperty("description", Order = 4)]
    public string Description {
      get {
        return _description;
      }
      set {
        if (_description == value) {
          return;
        }
        if (_description == null || _description.Equals(value) != true) {
          _description = value;
          OnPropertyChanged();
        }
      }
    }

    private CI_OnLineFunctionCode _function;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5, ElementName = "function")]
    [JsonProperty("function", Order = 5)]
    public CI_OnLineFunctionCode Function {
      get {
        return _function;
      }
      set {
        if (_function == value) {
          return;
        }
        if (_function == null || _function.Equals(value) != true) {
          _function = value;
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
