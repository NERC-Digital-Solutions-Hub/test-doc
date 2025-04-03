
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 03:23, @gisvlasta.
// Updated by        : 09/01/2023, 18:40, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Derived.UnitsOfMeasure;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Implementation.Records;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.DataQuality {

  // TODO: check out the Summary of this type.

  /// <summary>
  /// Quantitative_conformance_measure from Quality Procedures.  -  - Renamed to remove implied use limitation -  - OCL - -- result is type specified by valueDomain - result.tupleType = valueDomain
  /// </summary>
  [Serializable]
  [XmlType("DQ_QuantitativeResult", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("DQ_QuantitativeResult", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("DQ_QuantitativeResult")]
  public class DQ_QuantitativeResult_Type : AbstractDQ_Result_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_QuantitativeResult_Type"/>.
    /// </summary>
    public DQ_QuantitativeResult_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _valueType  = default; //  new RecordType_PropertyType();
      _valueUnit  = default; //  new UnitOfMeasure_PropertyType();
      _errorStatistic  = default; //  new CharacterString_PropertyType();
      _value  = default; //  new List<Record_PropertyType>();
      
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

    private RecordType_PropertyType _valueType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("valueType", Order = 0)]
    [JsonProperty("valueType", Order = 0)]
    public RecordType_PropertyType ValueType {
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

    private UnitOfMeasure_PropertyType _valueUnit;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("valueUnit", Order = 1)]
    [JsonProperty("valueUnit", Order = 1)]
    public UnitOfMeasure_PropertyType ValueUnit {
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

    private CharacterString _errorStatistic;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("errorStatistic", Order = 2)]
    [JsonProperty("errorStatistic", Order = 2)]
    public CharacterString ErrorStatistic {
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

    private List<Record_PropertyType> _value;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("value", Order = 3)]
    [JsonProperty("value", Order = 3)]
    public List<Record_PropertyType> Value {
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

    #endregion

  }

}