
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 22/12/2022, 20:46, @gisvlasta.
// Updated by        : 09/01/2023, 18:43, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common.Citation;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using NDSH.Geospatial.Metadata.V2003.ReferenceSystem;
using NDSH.Geospatial.Metadata.V2003.DataQuality.Completeness;
using NDSH.Geospatial.Metadata.V2003.DataQuality.LogicalConsistency;
using NDSH.Geospatial.Metadata.V2003.DataQuality.PositionalAccuracy;
using NDSH.Geospatial.Metadata.V2003.DataQuality.TemporalAccuracy;
using NDSH.Geospatial.Metadata.V2003.DataQuality.ThematicAccuracy;
using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.DateTime;
using NDSH.Geospatial.Metadata.V2003.Imagery.DataQuality;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.DataQuality {

  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(QE_Usability_Type))]
  [XmlInclude(typeof(AbstractDQ_Completeness_Type))]
  [XmlInclude(typeof(DQ_CompletenessCommission_Type))]
  [XmlInclude(typeof(DQ_CompletenessOmission_Type))]
  [XmlInclude(typeof(AbstractDQ_LogicalConsistency_Type))]
  [XmlInclude(typeof(DQ_ConceptualConsistency_Type))]
  [XmlInclude(typeof(DQ_DomainConsistency_Type))]
  [XmlInclude(typeof(DQ_FormatConsistency_Type))]
  [XmlInclude(typeof(DQ_TopologicalConsistency_Type))]
  [XmlInclude(typeof(AbstractDQ_PositionalAccuracy_Type))]
  [XmlInclude(typeof(DQ_AbsoluteExternalPositionalAccuracy_Type))]
  [XmlInclude(typeof(DQ_GriddedDataPositionalAccuracy_Type))]
  [XmlInclude(typeof(DQ_RelativeInternalPositionalAccuracy_Type))]
  [XmlInclude(typeof(AbstractDQ_ThematicAccuracy_Type))]
  [XmlInclude(typeof(DQ_ThematicClassificationCorrectness_Type))]
  [XmlInclude(typeof(DQ_NonQuantitativeAttributeAccuracy_Type))]
  [XmlInclude(typeof(DQ_QuantitativeAttributeAccuracy_Type))]
  [XmlInclude(typeof(AbstractDQ_TemporalAccuracy_Type))]
  [XmlInclude(typeof(DQ_AccuracyOfATimeMeasurement_Type))]
  [XmlInclude(typeof(DQ_TemporalConsistency_Type))]
  [XmlInclude(typeof(DQ_TemporalValidity_Type))]
  [Serializable]
  [XmlType("AbstractDQ_Element", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("AbstractDQ_Element", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("AbstractDQ_Element")]
  public abstract class AbstractDQ_Element_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractDQ_Element_Type"/>.
    /// </summary>
    public AbstractDQ_Element_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _nameOfMeasure  = default; //  new List<CharacterString_PropertyType>();
      _measureIdentification  = default; //  new MD_Identifier_PropertyType();
      _measureDescription  = default; //  new CharacterString_PropertyType();
      _evaluationMethodType  = default; //  new DQ_EvaluationMethodTypeCode_PropertyType();
      _evaluationMethodDescription  = default; //  new CharacterString_PropertyType();
      _evaluationProcedure  = default; //  new CI_Citation_PropertyType();
      _dateTime  = default; //  new List<DateTime_PropertyType>();
      _result  = default; //  new List<DQ_Result_PropertyType>();
      
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

    private List<CharacterString_PropertyType> _nameOfMeasure;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("nameOfMeasure", Order = 0)]
    [JsonProperty("nameOfMeasure", Order = 0)]
    public List<CharacterString_PropertyType> NameOfMeasure {
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

    private MD_Identifier_PropertyType _measureIdentification;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("measureIdentification", Order = 1)]
    [JsonProperty("measureIdentification", Order = 1)]
    public MD_Identifier_PropertyType MeasureIdentification {
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

    private CharacterString_PropertyType _measureDescription;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("measureDescription", Order = 2)]
    [JsonProperty("measureDescription", Order = 2)]
    public CharacterString_PropertyType MeasureDescription {
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

    private DQ_EvaluationMethodTypeCode_PropertyType _evaluationMethodType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("evaluationMethodType", Order = 3)]
    [JsonProperty("evaluationMethodType", Order = 3)]
    public DQ_EvaluationMethodTypeCode_PropertyType EvaluationMethodType {
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

    private CharacterString_PropertyType _evaluationMethodDescription;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("evaluationMethodDescription", Order = 4)]
    [JsonProperty("evaluationMethodDescription", Order = 4)]
    public CharacterString_PropertyType EvaluationMethodDescription {
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

    private CI_Citation_PropertyType _evaluationProcedure;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("evaluationProcedure", Order = 5)]
    [JsonProperty("evaluationProcedure", Order = 5)]
    public CI_Citation_PropertyType EvaluationProcedure {
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

    private List<DateTime_PropertyType> _dateTime;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("dateTime", Order = 6)]
    [JsonProperty("dateTime", Order = 6)]
    public List<DateTime_PropertyType> DateTime {
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

    private List<DQ_Result_PropertyType> _result;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("result", Order = 7)]
    [JsonProperty("result", Order = 7)]
    public List<DQ_Result_PropertyType> Result {
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

    #endregion

  }

}