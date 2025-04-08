
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

using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Derived.UnitsOfMeasure;
using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Implementation.Records;
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
  [JsonObject("DQ_QuantitativeResult")]
  public class DQ_QuantitativeResult : EntityBase<DQ_QuantitativeResult> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_QuantitativeResult"/>.
    /// </summary>
    public DQ_QuantitativeResult() {
      _value = new List<Record>();
      _valueUnit = new UnitOfMeasure();
      _valueType = new RecordType();
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

    private RecordType _valueType;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "valueType")]
    [JsonProperty("valueType", Order = 0)]
    public RecordType ValueType {
      get {
        return _valueType;
      }
      set {
        if (_valueType == value) {
          return;
        }
        if (_valueType == null || _valueType.Equals(value) != true) {
          _valueType = value;
          OnPropertyChanged();
        }
      }
    }

    private UnitOfMeasure _valueUnit;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "valueUnit")]
    [JsonProperty("valueUnit", Order = 1)]
    public UnitOfMeasure ValueUnit {
      get {
        return _valueUnit;
      }
      set {
        if (_valueUnit == value) {
          return;
        }
        if (_valueUnit == null || _valueUnit.Equals(value) != true) {
          _valueUnit = value;
          OnPropertyChanged();
        }
      }
    }

    private string _errorStatistic;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "errorStatistic")]
    [JsonProperty("errorStatistic", Order = 2)]
    public string ErrorStatistic {
      get {
        return _errorStatistic;
      }
      set {
        if (_errorStatistic == value) {
          return;
        }
        if (_errorStatistic == null || _errorStatistic.Equals(value) != true) {
          _errorStatistic = value;
          OnPropertyChanged();
        }
      }
    }

    private List<Record> _value;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlArrayAttribute(Order = 3)]
    [JsonProperty(Order = 3)]
    public List<Record> Value {
      get {
        return _value;
      }
      set {
        if (_value == value) {
          return;
        }
        if (_value == null || _value.Equals(value) != true) {
          _value = value;
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
