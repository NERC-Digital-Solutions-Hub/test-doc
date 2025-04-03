
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 16/12/2022, 19:03, @gisvlasta - Cleaned Xml Serialization Attributes.
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
  [XmlRoot("CI_Series", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("CI_Series", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("CI_Series")]
  public class CI_Series : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_Series"/>.
    /// </summary>
    public CI_Series() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _name = default;
      _issueIdentification = default;
      _page = default;

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

    private string _name;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "name")]
    [JsonProperty("name", Order = 0)]
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

    private string _issueIdentification;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "issueIdentification")]
    [JsonProperty("issueIdentification", Order = 1)]
    public string IssueIdentification {
      get {
        return _issueIdentification;
      }
      set {
        if (_issueIdentification == value) {
          return;
        }
        if (_issueIdentification == null || _issueIdentification.Equals(value) != true) {
          _issueIdentification = value;
          OnPropertyChanged();
        }
      }
    }

    private string _page;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "page")]
    [XmlIgnore()]
    [JsonProperty("page", Order = 2)]
    public string Page {
      get {
        return _page;
      }
      set {
        if (_page == value) {
          return;
        }
        if (_page == null || _page.Equals(value) != true) {
          _page = value;
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
