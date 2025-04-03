
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 01:22, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.Common.Citation;
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

namespace NDSH.Geospatial.Metadata.V2005.Identification {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("MD_Keywords", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_Keywords", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_Keywords")]
  public class MD_Keywords : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Keywords"/>.
    /// </summary>
    public MD_Keywords() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _keyword = default; // new List<string>();
      _type = default; // new MD_KeywordTypeCode();
      _thesaurusName = default; // new CI_Citation();

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
    
    private List<string> _keyword;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("keyword", Order = 0, ElementName = "keyword")]
    [JsonProperty("keyword", Order = 0)]
    public List<string> Keyword {
      get {
        return _keyword;
      }
      set {
        if (_keyword == value) {
          return;
        }
        if (_keyword == null || _keyword.Equals(value) != true) {
          _keyword = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_KeywordTypeCode _type;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "type")]
    [JsonProperty("type", Order = 1)]
    public MD_KeywordTypeCode Type {
      get {
        return _type;
      }
      set {
        if (_type == value) {
          return;
        }
        if (_type == null || _type.Equals(value) != true) {
          _type = value;
          OnPropertyChanged();
        }
      }
    }

    private CI_Citation _thesaurusName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "thesaurusName")]
    [JsonProperty("thesaurusName", Order = 2)]
    public CI_Citation ThesaurusName {
      get {
        return _thesaurusName;
      }
      set {
        if (_thesaurusName == value) {
          return;
        }
        if (_thesaurusName == null || _thesaurusName.Equals(value) != true) {
          _thesaurusName = value;
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
