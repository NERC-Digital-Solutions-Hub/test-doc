
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 23/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/dataQuality.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="DQ_QuantitativeResult_Type">
//   <xs:annotation>
//     <xs:documentation>
//       Quantitative_conformance_measure from Quality Procedures.
//       -  - Renamed to remove implied use limitation
//       -  - OCL - -- result is type specified by valueDomain - result.tupleType = valueDomain
//     </xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gmd:AbstractDQ_Result_Type">
//       <xs:sequence>
//         <xs:element name="valueType" type="gco:RecordType_PropertyType" minOccurs="0"/>
//         <xs:element name="valueUnit" type="gco:UnitOfMeasure_PropertyType"/>
//         <xs:element name="errorStatistic" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="value" type="gco:Record_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="DQ_QuantitativeResult" type="gmd:DQ_QuantitativeResult_Type" substitutionGroup="gmd:AbstractDQ_Result"/>
// <xs:complexType name="DQ_QuantitativeResult_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:DQ_QuantitativeResult"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Derived.UnitsOfMeasure;
using NDSH.Geospatial.Common.BasicTypes.Implementation.Records;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
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

  // WARNING: check out the Summary of this type.

  /// <summary>
  /// Quantitative_conformance_measure from Quality Procedures.
  /// -  - Renamed to remove implied use limitation -  -
  /// OCL
  /// - -- result is type specified by valueDomain - result.tupleType = valueDomain
  /// </summary>
  [Serializable]
  //[XmlType("DQ_QuantitativeResult", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("DQ_QuantitativeResult", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("DQ_QuantitativeResult")]
  public class DQ_QuantitativeResult_Type : AbstractDQ_Result_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_QuantitativeResult_Type"/>.
    /// </summary>
    public DQ_QuantitativeResult_Type() {
      _valueType = default; //  new RecordType_PropertyType();
      _valueUnit = default; //  new UnitOfMeasure_PropertyType();
      _errorStatistic = default; //  new CharacterString();
      _value = default; //  new List<Record_PropertyType>();
    }

    #endregion

    #region Public Properties

    private RecordType_PropertyType? _valueType;

    /// <summary>
    /// Value type for reporting a data quality result.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("valueType", Order = 0)]
    [JsonProperty("valueType", Order = 0)]
    public RecordType_PropertyType? ValueType {
      get => _valueType;
      set => SetProperty(ref _valueType, value);
    }

    private UnitOfMeasure_PropertyType _valueUnit;

    /// <summary>
    /// Value unit for reporting a data quality result.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("valueUnit", Order = 1)]
    [JsonProperty("valueUnit", Order = 1)]
    public UnitOfMeasure_PropertyType ValueUnit {
      get => _valueUnit;
      set => SetProperty(ref _valueUnit, value);
    }

    private CharacterString? _errorStatistic;

    /// <summary>
    /// Statistical method used to determine the value.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("errorStatistic", Order = 2)]
    [JsonProperty("errorStatistic", Order = 2)]
    public CharacterString? ErrorStatistic {
      get => _errorStatistic;
      set => SetProperty(ref _errorStatistic, value);
    }

    private ObservableCollection<Record_PropertyType> _value;

    /// <summary>
    /// Quantitative value or values, content determined by the evaluation procedure used.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - N
    //[XmlElement("value", Order = 3)]
    [JsonProperty("value", Order = 3)]
    public ObservableCollection<Record_PropertyType> Value {
      get => _value;
      set => SetProperty(ref _value, value);
    }

    #endregion

  }

}
