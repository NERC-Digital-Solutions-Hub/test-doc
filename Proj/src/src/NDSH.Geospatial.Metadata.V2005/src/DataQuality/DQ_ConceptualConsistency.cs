
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
using NDSH.Geospatial.Metadata.V2005.ReferenceSystem;
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
  [JsonObject("DQ_ConceptualConsistency")]
  public class DQ_ConceptualConsistency : EntityBase<DQ_ConceptualConsistency> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_ConceptualConsistency"/>.
    /// </summary>
    public DQ_ConceptualConsistency() {
      _result = new List<DQ_Result>();
      _dateTime = new List<System.DateTime>();
      _evaluationProcedure = new CI_Citation();
      _evaluationMethodType = new DQ_EvaluationMethodTypeCode();
      _measureIdentification = new Parent_MD_Identifier();
      _nameOfMeasure = new List<string>();
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

    private List<string> _nameOfMeasure;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("nameOfMeasure", Order = 0, ElementName = "nameOfMeasure")]
    [JsonProperty("nameOfMeasure", Order = 0)]
    public List<string> NameOfMeasure {
      get {
        return _nameOfMeasure;
      }
      set {
        if (_nameOfMeasure == value) {
          return;
        }
        if (_nameOfMeasure == null || _nameOfMeasure.Equals(value) != true) {
          _nameOfMeasure = value;
          OnPropertyChanged();
        }
      }
    }

    private Parent_MD_Identifier _measureIdentification;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "measureIdentification")]
    [JsonProperty("measureIdentification", Order = 1)]
    public Parent_MD_Identifier MeasureIdentification {
      get {
        return _measureIdentification;
      }
      set {
        if (_measureIdentification == value) {
          return;
        }
        if (_measureIdentification == null || _measureIdentification.Equals(value) != true) {
          _measureIdentification = value;
          OnPropertyChanged();
        }
      }
    }

    private string _measureDescription;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "measureDescription")]
    [JsonProperty("measureDescription", Order = 2)]
    public string MeasureDescription {
      get {
        return _measureDescription;
      }
      set {
        if (_measureDescription == value) {
          return;
        }
        if (_measureDescription == null || _measureDescription.Equals(value) != true) {
          _measureDescription = value;
          OnPropertyChanged();
        }
      }
    }

    private DQ_EvaluationMethodTypeCode _evaluationMethodType;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3, ElementName = "evaluationMethodType")]
    [JsonProperty("evaluationMethodType", Order = 3)]
    public DQ_EvaluationMethodTypeCode EvaluationMethodType {
      get {
        return _evaluationMethodType;
      }
      set {
        if (_evaluationMethodType == value) {
          return;
        }
        if (_evaluationMethodType == null || _evaluationMethodType.Equals(value) != true) {
          _evaluationMethodType = value;
          OnPropertyChanged();
        }
      }
    }

    private string _evaluationMethodDescription;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4, ElementName = "evaluationMethodDescription")]
    [JsonProperty("evaluationMethodDescription", Order = 4)]
    public string EvaluationMethodDescription {
      get {
        return _evaluationMethodDescription;
      }
      set {
        if (_evaluationMethodDescription == value) {
          return;
        }
        if (_evaluationMethodDescription == null || _evaluationMethodDescription.Equals(value) != true) {
          _evaluationMethodDescription = value;
          OnPropertyChanged();
        }
      }
    }

    private CI_Citation _evaluationProcedure;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5, ElementName = "evaluationProcedure")]
    [JsonProperty("evaluationProcedure", Order = 5)]
    public CI_Citation EvaluationProcedure {
      get {
        return _evaluationProcedure;
      }
      set {
        if (_evaluationProcedure == value) {
          return;
        }
        if (_evaluationProcedure == null || _evaluationProcedure.Equals(value) != true) {
          _evaluationProcedure = value;
          OnPropertyChanged();
        }
      }
    }

    private List<System.DateTime> _dateTime;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("dateTime", Order = 6, ElementName = "dateTime")]
    [JsonProperty("dateTime", Order = 6)]
    public List<System.DateTime> DateTime {
      get {
        return _dateTime;
      }
      set {
        if (_dateTime == value) {
          return;
        }
        if (_dateTime == null || _dateTime.Equals(value) != true) {
          _dateTime = value;
          OnPropertyChanged();
        }
      }
    }

    private List<DQ_Result> _result;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("result", Order = 7, ElementName = "result")]
    [JsonProperty("result", Order = 7)]
    public List<DQ_Result> Result {
      get {
        return _result;
      }
      set {
        if (_result == value) {
          return;
        }
        if (_result == null || _result.Equals(value) != true) {
          _result = value;
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
