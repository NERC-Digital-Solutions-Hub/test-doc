
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

using NDSH.Geospatial.Metadata.V2005.Common.Citation;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
  [JsonObject("LI_ProcessStep")]
  public class LI_ProcessStep : EntityBase<LI_ProcessStep> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LI_ProcessStep"/>.
    /// </summary>
    public LI_ProcessStep() {
      _source = new List<LI_Source>();
      _processor = new List<CI_ResponsibleParty>();
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

    private string _description;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "description")]
    [JsonProperty("description", Order = 0)]
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

    private string _rationale;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "rationale")]
    [JsonProperty("rationale", Order = 1)]
    public string Rationale {
      get {
        return _rationale;
      }
      set {
        if (_rationale == value) {
          return;
        }
        if (_rationale == null || _rationale.Equals(value) != true) {
          _rationale = value;
          OnPropertyChanged();
        }
      }
    }

    private System.DateTime _dateTime;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "dateTime")]
    [RequiredAttribute()]
    [JsonProperty("dateTime", Order = 2)]
    public System.DateTime DateTime {
      get {
        return _dateTime;
      }
      set {
        if (_dateTime.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "DateTime";
          Validator.ValidateProperty(value, validatorPropContext);
          _dateTime = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CI_ResponsibleParty> _processor;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("processor", Order = 3, ElementName = "processor")]
    [JsonProperty("processor", Order = 3)]
    public List<CI_ResponsibleParty> Processor {
      get {
        return _processor;
      }
      set {
        if (_processor == value) {
          return;
        }
        if (_processor == null || _processor.Equals(value) != true) {
          _processor = value;
          OnPropertyChanged();
        }
      }
    }

    private List<LI_Source> _source;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("source", Order = 4, ElementName = "source")]
    [JsonProperty("source", Order = 4)]
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
