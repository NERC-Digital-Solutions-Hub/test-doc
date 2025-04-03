
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
  [JsonObject("DQ_DataQuality")]
  public class DQ_DataQuality : EntityBase<DQ_DataQuality> {

    #region Constructors - Destructors

    /// <summary>
    /// Initialzies the <see cref="DQ_DataQuality"/>.
    /// </summary>
    public DQ_DataQuality() {
      _lineage = new LI_Lineage();
      _report = new List<Parent_DQ_Element>();
      _scope = new DQ_Scope();
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

    private DQ_Scope _scope;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "scope")]
    [JsonProperty("scope", Order = 0)]
    public DQ_Scope Scope {
      get {
        return _scope;
      }
      set {
        if (_scope == value) {
          return;
        }
        if (_scope == null || _scope.Equals(value) != true) {
          _scope = value;
          OnPropertyChanged();
        }
      }
    }

    private List<Parent_DQ_Element> _report;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("report", Order = 1, ElementName = "report")]
    [JsonProperty("report", Order = 1)]
    public List<Parent_DQ_Element> Report {
      get {
        return _report;
      }
      set {
        if (_report == value) {
          return;
        }
        if (_report == null || _report.Equals(value) != true) {
          _report = value;
          OnPropertyChanged();
        }
      }
    }

    private LI_Lineage _lineage;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "lineage")]
    [JsonProperty("lineage", Order = 2)]
    public LI_Lineage Lineage {
      get {
        return _lineage;
      }
      set {
        if (_lineage == value) {
          return;
        }
        if (_lineage == null || _lineage.Equals(value) != true) {
          _lineage = value;
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
