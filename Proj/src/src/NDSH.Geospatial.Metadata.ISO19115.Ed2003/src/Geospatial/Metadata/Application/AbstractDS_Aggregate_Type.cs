
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 29/12/2022, @gisvlasta
// History           : 16/03/2025, @gisvlasta - Updated properties nullability, updated code and documentation.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/metadataApplication.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="AbstractDS_Aggregate_Type" abstract="true">
//   <xs:annotation>
//     <xs:documentation>Identifiable collection of datasets</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="composedOf" type="gmd:DS_DataSet_PropertyType" maxOccurs="unbounded"/>
//         <xs:element name="seriesMetadata" type="gmd:MD_Metadata_PropertyType" maxOccurs="unbounded"/>
//         <xs:element name="subset" type="gmd:DS_Aggregate_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="superset" type="gmd:DS_Aggregate_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="AbstractDS_Aggregate" type="gmd:AbstractDS_Aggregate_Type" abstract="true"/>
// <xs:complexType name="DS_Aggregate_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:AbstractDS_Aggregate"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.EntitySet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Application {

  // WARNING: Rename from AbstractDS_Aggregate_Type to Aggregate or DatasetAggregate.

  #region XmlIncludes
  //[XmlInclude(typeof(DS_Initiative_Type))]
  //[XmlInclude(typeof(DS_Series_Type))]
  //[XmlInclude(typeof(DS_ProductionSeries_Type))]
  //[XmlInclude(typeof(DS_Sensor_Type))]
  //[XmlInclude(typeof(DS_Platform_Type))]
  //[XmlInclude(typeof(DS_OtherAggregate_Type))]
  //[XmlInclude(typeof(DS_StereoMate_Type))]
  //[XmlInclude(typeof(MX_Aggregate_Type))]
  #endregion

  /// <summary>
  /// Represents an identifiable collection of datasets in the ISO 19115 metadata standard.
  /// This abstract class serves as a base type for various dataset aggregations.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>AbstractDS_Aggregate_Type</c> ( /2005/gmd/metadataApplication.xsd )
  /// </remarks>
  [IsoType("AbstractDS_Aggregate_Type", IsoType = IsoTypes.ComplexType)]
  //[XmlType("AbstractDS_Aggregate", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("AbstractDS_Aggregate", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("AbstractDS_Aggregate")]
  public abstract class AbstractDS_Aggregate_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractDS_Aggregate_Type"/>.
    /// </summary>
    public AbstractDS_Aggregate_Type() {
      _composedOf = [];
      _seriesMetadata = [];
      _subset = default; //  new List<AbstractDS_Aggregate_Type>();
      _superset = default; //  new List<AbstractDS_Aggregate_Type>();
    }

    #endregion

    #region Public Properties

    private ObservableCollection<DS_DataSet_Type> _composedOf;

    /// <summary>
    /// Gets/Sets the datasets that compose this aggregate.
    /// </summary>
    /// <remarks>
    /// This property represents a <b>required</b> collection of datasets within this aggregate.
    /// </remarks>
    /// <value>
    /// An <see cref="ObservableCollection{DS_DataSet_Type}"/>.
    /// </value>
    [Required()]
    [JsonRequired()]
    //[XmlElement("composedOf", Order = 0)]
    [JsonProperty("composedOf", Order = 0)]
    public ObservableCollection<DS_DataSet_Type> ComposedOf {
      get => _composedOf;
      set => SetProperty(ref _composedOf, value);
    }

    private ObservableCollection<MD_Metadata_Type> _seriesMetadata;

    /// <summary>
    /// Gets/Sets the metadata series associated with this dataset aggregation.
    /// </summary>
    /// <remarks>
    /// This property is <b>required</b> and contains metadata describing the dataset series.
    /// </remarks>
    /// <value>
    /// An <see cref="ObservableCollection{MD_Metadata_Type}"/>.
    /// </value>
    [Required()]
    [JsonRequired()]
    //[XmlElement("seriesMetadata", Order = 1)]
    [JsonProperty("seriesMetadata", Order = 1)]
    public ObservableCollection<MD_Metadata_Type> SeriesMetadata {
      get => _seriesMetadata;
      set => SetProperty(ref _seriesMetadata, value);
    }

    private ObservableCollection<AbstractDS_Aggregate_Type>? _subset;

    /// <summary>
    /// Gets/Sets subsets of this dataset aggregation.
    /// </summary>
    /// <remarks>
    /// This property is <b>optional</b> and represents aggregations that are part of this dataset.
    /// </remarks>
    /// <value>
    /// An <see cref="ObservableCollection{AbstractDS_Aggregate_Type}"/> or <see langword="null"/>.
    /// </value>
    [Required()]
    [JsonRequired()]
    //[XmlElement("subset", Order = 2)]
    [JsonProperty("subset", Order = 2, NullValueHandling = NullValueHandling.Ignore)]
    public ObservableCollection<AbstractDS_Aggregate_Type>? Subset {
      get => _subset;
      set => SetProperty(ref _subset, value);
    }

    private ObservableCollection<AbstractDS_Aggregate_Type>? _superset;

    /// <summary>
    /// Gets/Sets supersets that include this dataset aggregation.
    /// </summary>
    /// <remarks>
    /// This property is <b>optional</b> and represents dataset aggregations that contain this one.
    /// </remarks>
    /// <value>
    /// An <see cref="ObservableCollection{AbstractDS_Aggregate_Type}"/> or <see langword="null"/>.
    /// </value>
    [Required()]
    [JsonRequired()]
    //[XmlElement("superset", Order = 3)]
    [JsonProperty("superset", Order = 3, NullValueHandling = NullValueHandling.Ignore)]
    public ObservableCollection<AbstractDS_Aggregate_Type>? Superset {
      get => _superset;
      set => SetProperty(ref _superset, value);
    }

    #endregion

  }

}
