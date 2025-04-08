
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 17/12/2022, 03:49, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Implementation.Names;
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
  [XmlRoot("SV_Parameter", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [XmlType("SV_Parameter", Namespace = "http://www.isotc211.org/2005/srv")]
  [JsonObject("SV_Parameter")]
  public class SV_Parameter : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_Parameter"/>.
    /// </summary>
    public SV_Parameter() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("srv", "http://www.isotc211.org/2005/srv");

      _name = default; //new MemberName();
      _direction = default; //new SV_ParameterDirection();
      _description = default;
      _optionality = default;
      _repeatability = default; //new Boolean();

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

    private MemberName _name;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "name")]
    [JsonProperty("name", Order = 0)]
    public MemberName Name {
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

    private SV_ParameterDirection _direction;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "direction")]
    [JsonProperty("direction", Order = 1)]
    public SV_ParameterDirection Direction {
      get {
        return _direction;
      }
      set {
        if (_direction == value) {
          return;
        }
        if (_direction == null || _direction.Equals(value) != true) {
          _direction = value;
          OnPropertyChanged();
        }
      }
    }

    private string _description;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "description")]
    [JsonProperty("description", Order = 2)]
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

    private string _optionality;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3, ElementName = "optionality")]
    [JsonProperty("optionality", Order = 3)]
    public string Optionality {
      get {
        return _optionality;
      }
      set {
        if (_optionality == value) {
          return;
        }
        if (_optionality == null || _optionality.Equals(value) != true) {
          _optionality = value;
          OnPropertyChanged();
        }
      }
    }

    private Boolean _repeatability;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4, ElementName = "repeatability")]
    [JsonProperty("repeatability", Order = 4)]
    public Boolean Repeatability { // TODO: Use bool here?
      get {
        return _repeatability;
      }
      set {
        if (_repeatability == value) {
          return;
        }
        if (_repeatability == null || _repeatability.Equals(value) != true) { // TODO: LOGIC ERROR HERE
          _repeatability = value;
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
