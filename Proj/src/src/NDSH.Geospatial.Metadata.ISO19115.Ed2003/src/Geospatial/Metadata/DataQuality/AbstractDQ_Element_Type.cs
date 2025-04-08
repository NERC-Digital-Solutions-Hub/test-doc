#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 22/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/dataQuality.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="AbstractDQ_Element_Type" abstract="true">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="nameOfMeasure" type="gco:CharacterString_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="measureIdentification" type="gmd:MD_Identifier_PropertyType" minOccurs="0"/>
//         <xs:element name="measureDescription" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="evaluationMethodType" type="gmd:DQ_EvaluationMethodTypeCode_PropertyType" minOccurs="0"/>
//         <xs:element name="evaluationMethodDescription" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="evaluationProcedure" type="gmd:CI_Citation_PropertyType" minOccurs="0"/>
//         <xs:element name="dateTime" type="gco:DateTime_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="result" type="gmd:DQ_Result_PropertyType" maxOccurs="2"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="AbstractDQ_Element" type="gmd:AbstractDQ_Element_Type" abstract="true"/>
// <xs:complexType name="DQ_Element_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:AbstractDQ_Element"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.DateTime;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;
using NDSH.Geospatial.Metadata.ReferenceSystem;
using NDSH.Hashing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.DataQuality {

  #region XmlIncludes
  //[XmlInclude(typeof(QE_Usability_Type))]
  //[XmlInclude(typeof(AbstractDQ_Completeness_Type))]
  //[XmlInclude(typeof(DQ_CompletenessCommission_Type))]
  //[XmlInclude(typeof(DQ_CompletenessOmission_Type))]
  //[XmlInclude(typeof(AbstractDQ_LogicalConsistency_Type))]
  //[XmlInclude(typeof(DQ_ConceptualConsistency_Type))]
  //[XmlInclude(typeof(DQ_DomainConsistency_Type))]
  //[XmlInclude(typeof(DQ_FormatConsistency_Type))]
  //[XmlInclude(typeof(DQ_TopologicalConsistency_Type))]
  //[XmlInclude(typeof(AbstractDQ_PositionalAccuracy_Type))]
  //[XmlInclude(typeof(DQ_AbsoluteExternalPositionalAccuracy_Type))]
  //[XmlInclude(typeof(DQ_GriddedDataPositionalAccuracy_Type))]
  //[XmlInclude(typeof(DQ_RelativeInternalPositionalAccuracy_Type))]
  //[XmlInclude(typeof(AbstractDQ_ThematicAccuracy_Type))]
  //[XmlInclude(typeof(DQ_ThematicClassificationCorrectness_Type))]
  //[XmlInclude(typeof(DQ_NonQuantitativeAttributeAccuracy_Type))]
  //[XmlInclude(typeof(DQ_QuantitativeAttributeAccuracy_Type))]
  //[XmlInclude(typeof(AbstractDQ_TemporalAccuracy_Type))]
  //[XmlInclude(typeof(DQ_AccuracyOfATimeMeasurement_Type))]
  //[XmlInclude(typeof(DQ_TemporalConsistency_Type))]
  //[XmlInclude(typeof(DQ_TemporalValidity_Type))]
  #endregion

  [Serializable]
  //[XmlType("AbstractDQ_Element", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("AbstractDQ_Element", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("AbstractDQ_Element")]
  public abstract class AbstractDQ_Element_Type : MetadataObject, IComparable<AbstractDQ_Element_Type>, IEquatable<AbstractDQ_Element_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractDQ_Element_Type"/>.
    /// </summary>
    public AbstractDQ_Element_Type() {
      _nameOfMeasure = default; //  new List<CharacterString>();
      _measureIdentification = default; //  new MD_Identifier_Type();
      _measureDescription = default; //  new CharacterString();
      _evaluationMethodType = default; //  new DQ_EvaluationMethodTypeCode_PropertyType();
      _evaluationMethodDescription = default; //  new CharacterString();
      _evaluationProcedure = default; //  new CI_Citation_Type();
      _dateTime = default; //  new List<DateTime_PropertyType>();
      _result = default; //  new List<DQ_Result_PropertyType>();
    }

    #endregion

    #region Public Properties

    private ObservableCollection<CharacterString>? _nameOfMeasure;

    /// <summary>
    /// Name of the test applied to the data.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("nameOfMeasure", Order = 0)]
    [JsonProperty("nameOfMeasure", Order = 0)]
    public ObservableCollection<CharacterString>? NameOfMeasure {
      get => _nameOfMeasure;
      set => SetProperty(ref _nameOfMeasure, value);
    }

    private MD_Identifier_Type? _measureIdentification;

    /// <summary>
    /// Code identifying a registered standard procedure.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("measureIdentification", Order = 1)]
    [JsonProperty("measureIdentification", Order = 1)]
    public MD_Identifier_Type? MeasureIdentification {
      get => _measureIdentification;
      set => SetProperty(ref _measureIdentification, value);
    }

    private CharacterString? _measureDescription;

    /// <summary>
    /// Description of the measure.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("measureDescription", Order = 2)]
    [JsonProperty("measureDescription", Order = 2)]
    public CharacterString? MeasureDescription {
      get => _measureDescription;
      set => SetProperty(ref _measureDescription, value);
    }

    private DQ_EvaluationMethodTypeCode_CodeList? _evaluationMethodType;

    /// <summary>
    /// Type of the method used to evaluate quality of the dataset.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("evaluationMethodType", Order = 3)]
    [JsonProperty("evaluationMethodType", Order = 3)]
    public DQ_EvaluationMethodTypeCode_CodeList? EvaluationMethodType {
      get => _evaluationMethodType;
      set => SetProperty(ref _evaluationMethodType, value);
    }

    private CharacterString? _evaluationMethodDescription;

    /// <summary>
    /// Description of the evaluation method.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("evaluationMethodDescription", Order = 4)]
    [JsonProperty("evaluationMethodDescription", Order = 4)]
    public CharacterString? EvaluationMethodDescription {
      get => _evaluationMethodDescription;
      set => SetProperty(ref _evaluationMethodDescription, value);
    }

    private CI_Citation_Type? _evaluationProcedure;

    /// <summary>
    /// Reference to the procedure information.
    /// </summary>
    // TODO: OBL - 0
    // TODO: CAR - 1
    //[XmlElement("evaluationProcedure", Order = 5)]
    [JsonProperty("evaluationProcedure", Order = 5)]
    public CI_Citation_Type? EvaluationProcedure {
      get => _evaluationProcedure;
      set => SetProperty(ref _evaluationProcedure, value);
    }

    private ObservableCollection<DateTimeDbEntity>? _dateTime;

    /// <summary>
    /// Date or range of dates no which a data quality measure was applied.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("dateTime", Order = 6)]
    [JsonProperty("dateTime", Order = 6)]
    public ObservableCollection<DateTimeDbEntity>? DateTime {
      get => _dateTime;
      set => SetProperty(ref _dateTime, value);
    }

    private ObservableCollection<AbstractDQ_Result_Type> _result;

    /// <summary>
    /// Value (or set of values) obtained from applying a data quality measure or the outcome of evaluation
    /// the obtained value (or set of values) against a specified acceptable conformance quality level.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 2
    //[XmlElement("result", Order = 7)]
    [JsonProperty("result", Order = 7)]
    public ObservableCollection<AbstractDQ_Result_Type> Result {
      get => _result;
      set => SetProperty(ref _result, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="AbstractDQ_Element_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="AbstractDQ_Element_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public virtual int CompareTo(AbstractDQ_Element_Type? other) {
      int result;

      return
          (other is null) ? 1 :
          (result = NameOfMeasure?.Count.CompareTo(other.NameOfMeasure?.Count ?? 0) ?? 1) != 0 ? result :
          (result = MeasureIdentification?.CompareTo(other.MeasureIdentification) ?? 1) != 0 ? result :
          (result = MeasureDescription?.CompareTo(other.MeasureDescription) ?? 1) != 0 ? result :
          (result = EvaluationMethodType?.CompareTo(other.EvaluationMethodType) ?? 1) != 0 ? result :
          (result = EvaluationMethodDescription?.CompareTo(other.EvaluationMethodDescription) ?? 1) != 0 ? result :
          (result = EvaluationProcedure?.CompareTo(other.EvaluationProcedure) ?? 1) != 0 ? result :
          (result = DateTime?.Count.CompareTo(other.DateTime?.Count ?? 0) ?? 1) != 0 ? result :
          (result = Result?.Count.CompareTo(other.Result?.Count ?? 0) ?? 1) != 0 ? result : 0;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="AbstractDQ_Element_Type"/> is equal to the current <see cref="AbstractDQ_Element_Type"/>.
    /// </summary>
    /// <param name="other">The <see cref="AbstractDQ_Element_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public virtual bool Equals(AbstractDQ_Element_Type? other) {
      return other != null &&
             NameOfMeasure.SequenceEqualOrdered(other.NameOfMeasure) &&
             Equals(MeasureIdentification, other.MeasureIdentification) &&
             Equals(MeasureDescription, other.MeasureDescription) &&
             Equals(EvaluationMethodType, other.EvaluationMethodType) &&
             Equals(EvaluationMethodDescription, other.EvaluationMethodDescription) &&
             Equals(EvaluationProcedure, other.EvaluationProcedure) &&
             DateTime.SequenceEqualOrdered(other.DateTime) &&
             Result.SequenceEqualOrdered(other.Result);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="AbstractDQ_Element_Type"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as AbstractDQ_Element_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="AbstractDQ_Element_Type"/> using <see cref="NdshHashCode"/>.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();
      foreach (CharacterString measure in NameOfMeasure.SafeOrderBy()) {
        hash.Add(measure);
      }
      hash.Add(MeasureIdentification);
      hash.Add(MeasureDescription);
      hash.Add(EvaluationMethodType);
      hash.Add(EvaluationMethodDescription);
      hash.Add(EvaluationProcedure);
      foreach (DateTimeDbEntity dateTime in DateTime.SafeOrderBy()) {
        hash.Add(dateTime);
      }
      foreach (AbstractDQ_Result_Type result in Result.SafeOrderBy()) {
        hash.Add(result);
      }
      return hash.ToHashCode();
    }

    #endregion

  }

}
