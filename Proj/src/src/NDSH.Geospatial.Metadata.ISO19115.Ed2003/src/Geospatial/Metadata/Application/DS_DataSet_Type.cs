
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 29/12/2022, @gisvlasta
// History           : 16/03/2025, @gisvlasta - Corrected the properties nullability, updated code,
//                                               added IsoTypeAttribute, and updated documentation.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/metadataApplication.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="DS_DataSet_Type">
//   <xs:annotation>
//     <xs:documentation>Identifiable collection of data</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="has" type="gmd:MD_Metadata_PropertyType" maxOccurs="unbounded"/>
//         <xs:element name="partOf" type="gmd:DS_Aggregate_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="DS_DataSet" type="gmd:DS_DataSet_Type"/>
// <xs:complexType name="DS_DataSet_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:DS_DataSet"/>
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

  /// <summary>
  /// Represents an identifiable collection of data.
  /// This class models a dataset that may contain multiple metadata records (<see cref="Has">Has</see>)
  /// and may be part of one or more dataset aggregates (<see cref="PartOf">PartOf</see>).
  /// </summary>
  /// <remarks>
  /// Maps to: <c>DS_DataSet_Type</c> ( /2005/gmd/metadataApplication.xsd ).
  /// </remarks>
  //[XmlInclude(typeof(MX_DataSet_Type))]
  [IsoType("DS_DataSet_Type", IsoType = IsoTypes.ComplexType)]
  //[XmlType("DS_DataSet", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("DS_DataSet", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("DS_DataSet")]
  public class DS_DataSet_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DS_DataSet_Type"/>.
    /// </summary>
    public DS_DataSet_Type() {
      _has = [];
      _partOf = default; //  new List<AbstractDS_Aggregate_Type>();
    }

    #endregion

    #region Public Properties

    private ObservableCollection<MD_Metadata_Type> _has;

    /// <summary>
    /// Gets/Sets the metadata records associated with this dataset.
    /// </summary>
    /// <remarks>
    ///   <list type="bullet">
    ///     <item>This property is <b>required</b>.</item>
    ///     <item>It contains <b>one or more</b> metadata records that describe this dataset.</item>
    ///   </list>
    /// </remarks>
    /// <value>
    /// A non <see langword="null"/> <see cref="ObservableCollection{MD_Metadata_Type}"/>.
    /// </value>
    [Required()]
    [JsonRequired()]
    //[XmlElement("has", Order = 0)]
    [JsonProperty("has", Order = 0)]
    public ObservableCollection<MD_Metadata_Type> Has {
      get => _has;
      set => SetProperty(ref _has, value);
    }

    private ObservableCollection<AbstractDS_Aggregate_Type>? _partOf;

    /// <summary>
    /// Gets/Sets the dataset aggregations that this dataset is part of.
    /// </summary>
    /// <remarks>
    ///   <list type="bullet">
    ///     <item>This property is <b>optional</b>.</item>
    ///     <item>If set, it represents one or more dataset aggregates that include this dataset.</item>
    ///   </list>
    /// </remarks>
    /// <value>
    /// A nullable <see cref="ObservableCollection{AbstractDS_Aggregate_Type}"/>.
    /// </value>
    //[XmlElement("partOf", Order = 1)]
    [JsonProperty("partOf", Order = 1)]
    public ObservableCollection<AbstractDS_Aggregate_Type>? PartOf {
      get => _partOf;
      set => SetProperty(ref _partOf, value);
    }

    #endregion

  }

}
