
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 18:55, @fdq09eca, @gisvlasta - Cleaned Xml Serialization Attributes.
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

namespace NDSH.Geospatial.Metadata.V2005.ReferenceSystem {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("MD_Identifier", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_Identifier", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_Identifier")]
  public class MD_Identifier : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Identifier"/>.
    /// </summary>
    public MD_Identifier() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _authority = default; // new CI_Citation();
      _code = default;

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

    private CI_Citation _authority;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "authority")]
    [JsonProperty("authority", Order = 0)]
    public CI_Citation Authority {
      get {
        return _authority;
      }
      set {
        if (_authority == value) {
          return;
        }
        if (_authority == null || _authority.Equals(value) != true) {
          _authority = value;
          OnPropertyChanged();
        }
      }
    }

    private string _code;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "code")]
    [JsonProperty("code", Order = 1)]
    public string Code {
      get {
        return _code;
      }
      set {
        if (_code == value) {
          return;
        }
        if (_code == null || _code.Equals(value) != true) {
          _code = value;
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
