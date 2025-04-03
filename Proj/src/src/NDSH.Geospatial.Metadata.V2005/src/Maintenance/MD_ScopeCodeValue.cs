
#region Header
// Title Name        : @@@@
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : The class of information to which the referencing entity applies.
// Created by        : 19/09/2022, 21:01, @gisvlasta
// Updated by        : 18/12/2022, 17:19, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.Maintenance {

  /// <summary>
  /// The class of information to which the referencing entity applies.
  /// </summary>
  [Serializable]
  public enum MD_ScopeCodeValue {

    /// <summary>
    /// Information applies to the attribute value.
    /// </summary>
    [XmlEnum(Name = "attribute")]
    [EnumMember(Value = "attribute")]
    Attribute = 1,

    /// <summary>
    /// Information applies to the characteristic of a feature.
    /// </summary>
    [XmlEnum(Name = "attributeType")]
    [EnumMember(Value = "attributeType")]
    AttributeType = 2,

    /// <summary>
    /// Information applies to the collection hardware class.
    /// </summary>
    [XmlEnum(Name = "collectionhardware")]
    [EnumMember(Value = "collectionhardware")]
    Collectionhardware = 3,

    /// <summary>
    /// Information applies to the collection session.
    /// </summary>
    [XmlEnum(Name = "collectionSession")]
    [EnumMember(Value = "collectionSession")]
    CollectionSession = 4,

    /// <summary>
    /// Information applies to the dataset.
    /// </summary>
    [XmlEnum(Name = "dataset")]
    [EnumMember(Value = "dataset")]
    Dataset = 5,

    /// <summary>
    /// Information applies to the series.
    /// </summary>
    /// <remarks>
    /// Note: “series” applies to any DS_Aggregate.
    /// </remarks>
    [XmlEnum(Name = "series")]
    [EnumMember(Value = "series")]
    Series = 6,

    /// <summary>
    /// Information applies to non-geographic data.
    /// </summary>
    [XmlEnum(Name = "nonGeographicDataset")]
    [EnumMember(Value = "nonGeographicDataset")]
    NonGeographicDataset = 7,

    /// <summary>
    /// Information applies to a dimension group.
    /// </summary>
    [XmlEnum(Name = "dimensionGroup")]
    [EnumMember(Value = "dimensionGroup")]
    DimensionGroup = 8,

    /// <summary>
    /// Information applies to a feature.
    /// </summary>
    [XmlEnum(Name = "feature")]
    [EnumMember(Value = "feature")]
    Feature = 9,

    /// <summary>
    /// Information applies to a feature type.
    /// </summary>
    [XmlEnum(Name = "featureType")]
    [EnumMember(Value = "featureType")]
    FeatureType = 10,

    /// <summary>
    /// Information applies to a property type.
    /// </summary>
    [XmlEnum(Name = "propertyType")]
    [EnumMember(Value = "propertyType")]
    PropertyType = 11,

    /// <summary>
    /// Information applies to a field session.
    /// </summary>
    [XmlEnum(Name = "fieldSession")]
    [EnumMember(Value = "fieldSession")]
    FieldSession = 12,

    /// <summary>
    /// Information applies to a computer program or routine.
    /// </summary>
    [XmlEnum(Name = "software")]
    [EnumMember(Value = "software")]
    Software = 13,

    /// <summary>
    /// Information applies to a capability which a service provider entity makes available to a service
    /// user entity through a set of interfaces that define a behaviour, such as a use case.
    /// </summary>
    [XmlEnum(Name = "service")]
    [EnumMember(Value = "service")]
    Service = 14,

    /// <summary>
    /// Information applies to a copy or imitation of an existing or hypothetical object.
    /// </summary>
    [XmlEnum(Name = "model")]
    [EnumMember(Value = "model")]
    Model = 15,

    /// <summary>
    /// Information applies to a tile, a spatial subset of geographic data.
    /// </summary>
    [XmlEnum(Name = "tile")]
    [EnumMember(Value = "tile")]
    Tile = 16

  }

}
