
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : data, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/feature.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="AbstractFeatureType" abstract="true">
//   <annotation>
//     <documentation>
//       The basic feature model is given by the gml:AbstractFeatureType.
//       The content model for gml:AbstractFeatureType adds two specific properties
//       suitable for geographic features to the content model defined in gml:AbstractGMLType. 
//       The value of the gml:boundedBy property describes an envelope that encloses the
//       entire feature instance, and is primarily useful for supporting rapid searching
//       for features that occur in a particular location. 
//       The value of the gml:location property describes the extent,
//       position or relative location of the feature.
//     </documentation>
//   </annotation>
//   <complexContent>
//     <extension base="gml:AbstractGMLType">
//       <sequence>
//         <element ref="gml:boundedBy" minOccurs="0"/>
//         <element ref="gml:location" minOccurs="0"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="AbstractFeature" type="gml:AbstractFeatureType" abstract="true" substitutionGroup="gml:AbstractGML">
//   <annotation>
//     <documentation>
//       This abstract element serves as the head of a substitution group which may contain any
//       elements whose content model is derived from gml:AbstractFeatureType.
//       This may be used as a variable in the construction of content models.  
//       gml:AbstractFeature may be thought of as “anything that is a GML feature”
//       and may be used to define variables or templates in which the value of a GML
//       property is “any feature”. This occurs in particular in a GML feature collection
//       where the feature member properties contain one or multiple copies of gml:AbstractFeature respectively.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using NDSH.Geospatial.Gml.Coverage;
using NDSH.Geospatial.Gml.Feature.Dynamic;
using NDSH.Geospatial.Gml.Observation;
using Newtonsoft.Json;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Feature {


  /// <summary>
  /// The basic feature model is given by the gml:AbstractFeatureType.
  /// The content model for gml:AbstractFeatureType adds two specific properties suitable for geographic features to the content model defined in gml:AbstractGMLType.
  /// The value of the gml:boundedBy property describes an envelope that encloses the entire feature instance, and is primarily useful for supporting rapid searching for features that occur in a particular location.
  /// The value of the gml:location property describes the extent, position or relative location of the feature.
  /// </summary>
  //[XmlInclude(typeof(ObservationType))]
  //[XmlInclude(typeof(DirectedObservationType))]
  //[XmlInclude(typeof(DirectedObservationAtDistanceType))]
  //[XmlInclude(typeof(AbstractCoverageType))]
  //[XmlInclude(typeof(AbstractContinuousCoverageType))]
  //[XmlInclude(typeof(AbstractDiscreteCoverageType))]
  //[XmlInclude(typeof(RectifiedGridCoverageType))]
  //[XmlInclude(typeof(GridCoverageType))]
  //[XmlInclude(typeof(MultiSolidCoverageType))]
  //[XmlInclude(typeof(MultiSurfaceCoverageType))]
  //[XmlInclude(typeof(MultiCurveCoverageType))]
  //[XmlInclude(typeof(MultiPointCoverageType))]
  //[XmlInclude(typeof(DynamicFeatureType))]
  //[XmlInclude(typeof(DynamicFeatureCollectionType))]
  //[XmlInclude(typeof(AbstractFeatureCollectionType))]
  //[XmlInclude(typeof(FeatureCollectionType))]
  //[XmlInclude(typeof(BoundedFeatureType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
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
