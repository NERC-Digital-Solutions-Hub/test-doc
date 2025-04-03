
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
  [JsonObject("LI_Lineage")]
  public class LI_Lineage : EntityBase<LI_Lineage> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LI_Lineage"/>.
    /// </summary>
    public LI_Lineage() {
      _source = new List<LI_Source>();
      _processStep = new List<LI_ProcessStep>();
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

    private string _statement;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "statement")]
    [JsonProperty("statement", Order = 0)]
    public string Statement {
      get {
        return _statement;
      }
      set {
        if (_statement == value) {
          return;
        }
        if (_statement == null || _statement.Equals(value) != true) {
          _statement = value;
          OnPropertyChanged();
        }
      }
    }

    private List<LI_ProcessStep> _processStep;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("processStep", Order = 1, ElementName = "processStep")]
    [JsonProperty("processStep", Order = 1)]
    public List<LI_ProcessStep> ProcessStep {
      get {
        return _processStep;
      }
      set {
        if (_processStep == value) {
          return;
        }
        if (_processStep == null || _processStep.Equals(value) != true) {
          _processStep = value;
          OnPropertyChanged();
        }
      }
    }

    private List<LI_Source> _source;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("source", Order = 2, ElementName = "source")]
    [JsonProperty("source", Order = 2)]
    public List<LI_Source> Source {
      get {
        return _source;
      }
      set {
        if (_source == value) {
          return;
        }
        if (_source == null || _source.Equals(value) != true) {
          _source = value;
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
