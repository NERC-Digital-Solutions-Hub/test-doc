
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
// <complexType name="AbstractDiscreteCoverageType" abstract="true">
//   <complexContent>
//     <extension base="gml:AbstractCoverageType">
//       <sequence>
//         <element ref="gml:coverageFunction" minOccurs="0"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// 
// <element name="AbstractDiscreteCoverage"
//          type="gml:AbstractDiscreteCoverageType" abstract="true" substitutionGroup="gml:AbstractCoverage">
//   <annotation>
//     <documentation>
//       A discrete coverage consists of a domain set, range set and optionally a coverage function.
//       The domain set consists of either spatial or temporal geometry objects, finite in number.
//       The range set is comprised of a finite number of attribute values each of which is associated to
//       every direct position within any single spatio-temporal object in the domain. In other words,
//       the range values are constant on each spatio-temporal object in the domain.
//       This coverage function maps each element from the coverage domain to an element in its range.
//       The coverageFunction element describes the mapping function.
//       This element serves as the head of a substitution group which may contain any discrete coverage
//       whose type is derived from gml:AbstractDiscreteCoverageType.
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

  #region XmlInclude
  //[XmlInclude(typeof(RectifiedGridCoverageType))]
  //[XmlInclude(typeof(GridCoverageType))]
  //[XmlInclude(typeof(MultiSolidCoverageType))]
  //[XmlInclude(typeof(MultiSurfaceCoverageType))]
  //[XmlInclude(typeof(MultiCurveCoverageType))]
  //[XmlInclude(typeof(MultiPointCoverageType))]
  #endregion

  [IsoType("AbstractDiscreteCoverageType", IsAbstract = true, IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractDiscreteCoverageType")]
  public abstract class AbstractDiscreteCoverageType : AbstractCoverageType {

    #region Private fields
    private CoverageFunctionType _coverageFunction;
    #endregion

    /// <summary>
    /// AbstractDiscreteCoverageType class constructor
    /// </summary>
    public AbstractDiscreteCoverageType() {
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
