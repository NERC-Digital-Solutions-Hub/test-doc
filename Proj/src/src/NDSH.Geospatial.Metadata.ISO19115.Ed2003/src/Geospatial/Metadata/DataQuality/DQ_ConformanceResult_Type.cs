
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
// <xs:complexType name="DQ_ConformanceResult_Type">
//   <xs:annotation>
//     <xs:documentation>quantitative_result from Quality Procedures -  - renamed to remove implied use limitiation.</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gmd:AbstractDQ_Result_Type">
//       <xs:sequence>
//         <xs:element name="specification" type="gmd:CI_Citation_PropertyType"/>
//         <xs:element name="explanation" type="gco:CharacterString_PropertyType"/>
//         <xs:element name="pass" type="gco:Boolean_PropertyType"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="DQ_ConformanceResult" type="gmd:DQ_ConformanceResult_Type" substitutionGroup="gmd:AbstractDQ_Result"/>
// <xs:complexType name="DQ_ConformanceResult_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:DQ_ConformanceResult"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.DataQuality {

  // WARNING: Check the Summary of this type.

  /// <summary>
  /// quantitative_result from Quality Procedures -  - renamed to remove implied use limitation.
  /// </summary>
  [Serializable]
  //[XmlType("DQ_ConformanceResult", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("DQ_ConformanceResult", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("DQ_ConformanceResult")]
  public class DQ_ConformanceResult_Type : AbstractDQ_Result_Type {

    // WARNING: Check which value types need to be nullable.

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_ConformanceResult_Type"/>.
    /// </summary>
    public DQ_ConformanceResult_Type() {
      _specification = default; //  new CI_Citation_Type();
      _explanation = default; //  new CharacterString();
      _pass = default; //  new Boolean_PropertyType();
    }

    #endregion

    #region Public Properties

    private CI_Citation_Type _specification;

    /// <summary>
    /// Citation of product specification or user requirement against which data is being evaluated.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("specification", Order = 0)]
    [JsonProperty("specification", Order = 0)]
    public CI_Citation_Type Specification {
      get => _specification;
      set => SetProperty(ref _specification, value);
    }

    private CharacterString _explanation;

    /// <summary>
    /// Explanation of the meaning of conformance for this result.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("explanation", Order = 1)]
    [JsonProperty("explanation", Order = 1)]
    public CharacterString Explanation {
      get => _explanation;
      set => SetProperty(ref _explanation, value);
    }

    private bool _pass;

    /// <summary>
    /// Indication of the conformance result where 0 = fail and 1 = pass.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("pass", Order = 2)]
    [JsonProperty("pass", Order = 2)]
    public bool Pass {
      get => _pass;
      // TODO: SetProperty
      set {
        if (_pass == value) {
          return;
        }
        if (/*_pass == null || */_pass.Equals(value) != true) {
          _pass = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
