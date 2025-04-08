
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.Common.Extent;
using NDSH.Geospatial.Metadata.V2005.Maintenance;
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

namespace NDSH.Geospatial.Metadata.V2005.DataQuality {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [DebuggerStepThrough]
  [XmlRoot(Namespace = "", IsNullable = false)]
  [JsonObject("DQ_Scope")]
  public class DQ_Scope : EntityBase<DQ_Scope> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes <see cref="DQ_Scope"/>.
    /// </summary>
    public DQ_Scope() {
      _levelDescription = new List<MD_ScopeDescription>();
      _extent = new EX_Extent();
      _level = new List<MD_ScopeCode>();
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

    private List<MD_ScopeCode> _level;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("level", Order = 0, ElementName = "level")]
    [JsonProperty("level", Order = 0)]
    public List<MD_ScopeCode> Level {
      get {
        return _level;
      }
      set {
        if (_level == value) {
          return;
        }
        if (_level == null || _level.Equals(value) != true) {
          _level = value;
          OnPropertyChanged();
        }
      }
    }

    private EX_Extent _extent;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "extent")]
    [JsonProperty("extent", Order = 1)]
    public EX_Extent Extent {
      get {
        return _extent;
      }
      set {
        if (_extent == value) {
          return;
        }
        if (_extent == null || _extent.Equals(value) != true) {
          _extent = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_ScopeDescription> _levelDescription;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("levelDescription", Order = 2, ElementName = "levelDescription")]
    [JsonProperty("levelDescription", Order = 2)]
    public List<MD_ScopeDescription> LevelDescription {
      get {
        return _levelDescription;
      }
      set {
        if (_levelDescription == value) {
          return;
        }
        if (_levelDescription == null || _levelDescription.Equals(value) != true) {
          _levelDescription = value;
          OnPropertyChanged();
        }
      }
    }

    private string _id;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(DataType = "ID", AttributeName = "id")]
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
