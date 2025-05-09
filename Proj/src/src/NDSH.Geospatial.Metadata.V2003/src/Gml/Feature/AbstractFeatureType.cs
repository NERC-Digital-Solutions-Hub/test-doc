
using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using NDSH.Geospatial.Metadata.V2003.Gml.Coverage;
using NDSH.Geospatial.Metadata.V2003.Gml.Feature.Dynamic;
using NDSH.Geospatial.Metadata.V2003.Gml.Observation;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Feature {


  /// <summary>
  /// The basic feature model is given by the gml:AbstractFeatureType.
  /// The content model for gml:AbstractFeatureType adds two specific properties suitable for geographic features to the content model defined in gml:AbstractGMLType.
  /// The value of the gml:boundedBy property describes an envelope that encloses the entire feature instance, and is primarily useful for supporting rapid searching for features that occur in a particular location.
  /// The value of the gml:location property describes the extent, position or relative location of the feature.
  /// </summary>
  [XmlInclude(typeof(ObservationType))]
  [XmlInclude(typeof(DirectedObservationType))]
  [XmlInclude(typeof(DirectedObservationAtDistanceType))]
  [XmlInclude(typeof(AbstractCoverageType))]
  [XmlInclude(typeof(AbstractContinuousCoverageType))]
  [XmlInclude(typeof(AbstractDiscreteCoverageType))]
  [XmlInclude(typeof(RectifiedGridCoverageType))]
  [XmlInclude(typeof(GridCoverageType))]
  [XmlInclude(typeof(MultiSolidCoverageType))]
  [XmlInclude(typeof(MultiSurfaceCoverageType))]
  [XmlInclude(typeof(MultiCurveCoverageType))]
  [XmlInclude(typeof(MultiPointCoverageType))]
  [XmlInclude(typeof(DynamicFeatureType))]
  [XmlInclude(typeof(DynamicFeatureCollectionType))]
  [XmlInclude(typeof(AbstractFeatureCollectionType))]
  [XmlInclude(typeof(FeatureCollectionType))]
  [XmlInclude(typeof(BoundedFeatureType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractFeatureType")]
  public abstract class AbstractFeatureType : AbstractGMLType {
    #region Private fields
    private BoundingShapeType _boundedBy;
    private LocationPropertyType _location;
    #endregion

    /// <summary>
    /// AbstractFeatureType class constructor
    /// </summary>
    public AbstractFeatureType() {
      _location = new LocationPropertyType();
      _boundedBy = new BoundingShapeType();
    }

    [XmlElement(IsNullable = true, Order = 0)]
    [JsonProperty("boundedBy", Order = 0)]
    public BoundingShapeType BoundedBy {
      get {
        return _boundedBy;
      }
      set {
        if (_boundedBy == value) {
          return;
        }
        if (_boundedBy == null || _boundedBy.Equals(value) != true) {
          _boundedBy = value;
          OnPropertyChanged("BoundedBy");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("location", Order = 1)]
    public LocationPropertyType Location {
      get {
        return _location;
      }
      set {
        if (_location == value) {
          return;
        }
        if (_location == null || _location.Equals(value) != true) {
          _location = value;
          OnPropertyChanged("Location");
        }
      }
    }
  }
}
