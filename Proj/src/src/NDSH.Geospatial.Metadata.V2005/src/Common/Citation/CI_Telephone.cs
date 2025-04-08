
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : Telephone numbers for contacting the responsible individual or organization.
// Created by        : 21/10/2022, 00:36, @gisvlasta.
// Updated by        : 16/12/2022, 19:02, @gisvlasta - Cleaned Xml Serialization Attributes.
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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.Common.Citation {

  /// <summary>
  /// Telephone numbers for contacting the responsible individual or organization.
  /// </summary>
  [Serializable]
  [XmlRoot("CI_Telephone", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("CI_Telephone", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("CI_Telephone")]
  public class CI_Telephone : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_Telephone"/>.
    /// </summary>
    public CI_Telephone() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _voice = default;
      _facsimile = default;
      
    }

    #endregion

    #region Public Fields

    /// <summary>
    /// The <see cref="XmlSerializerNamespaces"/>.
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private List<string> _voice;

    /// <summary>
    /// Telephone number by which individuals can speak
    /// to the responsible organization or individual.
    /// </summary>
    [XmlElement(Order = 0, ElementName = "voice")]
    [JsonProperty("voice", Order = 0)]
    public List<string> Voice {
      get {
        return _voice;
      }
      set {
        if (_voice == value) {
          return;
        }
        if (_voice == null || _voice.Equals(value) != true) {
          _voice = value;
          OnPropertyChanged();
        }
      }
    }

    private List<string> _facsimile;

    /// <summary>
    /// Telephone number of a facsimile machine for the
    /// responsible rganization or individual.
    /// </summary>
    [XmlElement(Order = 1, ElementName = "voice")]
    [JsonProperty("facsimile", Order = 1)]
    public List<string> Facsimile {
      get {
        return _facsimile;
      }
      set {
        if (_facsimile == value) {
          return;
        }
        if (_facsimile == null || _facsimile.Equals(value) != true) {
          _facsimile = value;
          OnPropertyChanged();
        }
      }
    }

    private string _id;

    /// <summary>
    /// The identifier of the object.
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
    /// The universally unique identifier of the object.
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
