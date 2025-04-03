
#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using NDSH.Geospatial.Metadata.V2003.Gml.Feature;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Coverage {

  /// <summary>
  /// The base type for coverages is gml:AbstractCoverageType. The basic elements of a coverage can be seen in this content model: the coverage contains gml:domainSet and gml:rangeSet properties. The gml:domainSet property describes the domain of the coverage and the gml:rangeSet property describes the range of the coverage.
  /// </summary>
  [XmlInclude(typeof(AbstractContinuousCoverageType))]
  [XmlInclude(typeof(AbstractDiscreteCoverageType))]
  [XmlInclude(typeof(RectifiedGridCoverageType))]
  [XmlInclude(typeof(GridCoverageType))]
  [XmlInclude(typeof(MultiSolidCoverageType))]
  [XmlInclude(typeof(MultiSurfaceCoverageType))]
  [XmlInclude(typeof(MultiCurveCoverageType))]
  [XmlInclude(typeof(MultiPointCoverageType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
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
