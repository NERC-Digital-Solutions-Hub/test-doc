
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 17/12/2022, 03:26, @gisvlasta - Cleaned Xml Serialization Attributes.
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

namespace NDSH.Geospatial.Metadata.V2005.Service {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("DistinguishedName", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [XmlType("DistinguishedName", Namespace = "http://www.isotc211.org/2005/srv")]
  [JsonObject("DistinguishedName")]
  public class DistinguishedName : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DistinguishedName"/>.
    /// </summary>
    public DistinguishedName() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("srv", "http://www.isotc211.org/2005/srv");

      _name = default;
      _nameSpace = default;

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

    private string _nameSpace;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "nameSpace")]
    [JsonProperty("nameSpace", Order = 1)]
    public string NameSpace {
      get {
        return _nameSpace;
      }
      set {
        if (_nameSpace == value) {
          return;
        }
        if (_nameSpace == null || _nameSpace.Equals(value) != true) {
          _nameSpace = value;
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
