
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : date, @gisvlasta
// History           : 
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/coverage.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="AbstractContinuousCoverageType" abstract="true">
//   <complexContent>
//     <extension base="gml:AbstractCoverageType">
//       <sequence>
//         <element ref="gml:coverageFunction" minOccurs="0"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// 
// <element name="AbstractContinuousCoverage"
//          type="gml:AbstractContinuousCoverageType" abstract="true" substitutionGroup="gml:AbstractFeature">
//   <annotation>
//     <documentation>
//       A continuous coverage as defined in ISO 19123 is a coverage that can return different values
//       for the same feature attribute at different direct positions within a single spatio-temporal object
//       in its spatio-temporal domain. The base type for continuous coverages is AbstractContinuousCoverageType.
//       The coverageFunction element describes the mapping function. 
//       The abstract element gml:AbstractContinuousCoverage serves as the head of a substitution group
//       which may contain any continuous coverage whose type is derived from gml:AbstractContinuousCoverageType.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Coverage {

  [IsoType("AbstractContinuousCoverageType", IsAbstract = true, IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractContinuousCoverageType")]
  public abstract class AbstractContinuousCoverageType : AbstractCoverageType {

    #region Private fields
    private CoverageFunctionType _coverageFunction;
    #endregion

    /// <summary>
    /// AbstractContinuousCoverageType class constructor
    /// </summary>
    public AbstractContinuousCoverageType() {
      _coverageFunction = new CoverageFunctionType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("coverageFunction", Order = 0)]
    public CoverageFunctionType CoverageFunction {
      get {
        return _coverageFunction;
      }
      set {
        if (_coverageFunction == value) {
          return;
        }
        if (_coverageFunction == null || _coverageFunction.Equals(value) != true) {
          _coverageFunction = value;
          OnPropertyChanged("CoverageFunction");
        }
      }
    }

  }

}
