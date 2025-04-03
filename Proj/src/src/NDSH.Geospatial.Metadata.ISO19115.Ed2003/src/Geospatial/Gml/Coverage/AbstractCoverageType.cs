
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
// XSD               : /2005/coverage/coverage.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="AbstractCoverageType" abstract="true">
//   <annotation>
//     <documentation>
//       The base type for coverages is gml:AbstractCoverageType. The basic elements of a coverage can be seen
//       in this content model: the coverage contains gml:domainSet and gml:rangeSet properties.
//       The gml:domainSet property describes the domain of the coverage and the gml:rangeSet property
//       describes the range of the coverage.
//     </documentation>
//   </annotation>
//   <complexContent>
//     <extension base="gml:AbstractFeatureType">
//       <sequence>
//         <element ref="gml:domainSet"/>
//         <element ref="gml:rangeSet"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// 
// <element name="AbstractCoverage"
//          type="gml:AbstractCoverageType" abstract="true" substitutionGroup="gml:AbstractFeature">
//   <annotation>
//     <documentation>
//       This element serves as the head of a substitution group which may contain any coverage whose type
//       is derived from gml:AbstractCoverageType.  It may act as a variable in the definition of
//       content models where it is required to permit any coverage to be valid.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Feature;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Coverage {

  /// <summary>
  /// The base type for coverages is gml:AbstractCoverageType. The basic elements of a coverage can be seen in this content model: the coverage contains gml:domainSet and gml:rangeSet properties. The gml:domainSet property describes the domain of the coverage and the gml:rangeSet property describes the range of the coverage.
  /// </summary>
  //[XmlInclude(typeof(AbstractContinuousCoverageType))]
  //[XmlInclude(typeof(AbstractDiscreteCoverageType))]
  //[XmlInclude(typeof(RectifiedGridCoverageType))]
  //[XmlInclude(typeof(GridCoverageType))]
  //[XmlInclude(typeof(MultiSolidCoverageType))]
  //[XmlInclude(typeof(MultiSurfaceCoverageType))]
  //[XmlInclude(typeof(MultiCurveCoverageType))]
  //[XmlInclude(typeof(MultiPointCoverageType))]
  [IsoType("AbstractCoverageType", IsAbstract = true, IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractCoverageType")]
  public abstract class AbstractCoverageType : AbstractFeatureType {

    #region Private fields
    private DomainSetType _domainSet;
    private RangeSetType _rangeSet;
    #endregion

    /// <summary>
    /// AbstractCoverageType class constructor
    /// </summary>
    public AbstractCoverageType() {
      _rangeSet = new RangeSetType();
      _domainSet = new DomainSetType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("domainSet", Order = 0)]
    public DomainSetType DomainSet {
      get {
        return _domainSet;
      }
      set {
        if (_domainSet == value) {
          return;
        }
        if (_domainSet == null || _domainSet.Equals(value) != true) {
          _domainSet = value;
          OnPropertyChanged("DomainSet");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("rangeSet", Order = 1)]
    public RangeSetType RangeSet {
      get {
        return _rangeSet;
      }
      set {
        if (_rangeSet == value) {
          return;
        }
        if (_rangeSet == null || _rangeSet.Equals(value) != true) {
          _rangeSet = value;
          OnPropertyChanged("RangeSet");
        }
      }
    }

  }

}
