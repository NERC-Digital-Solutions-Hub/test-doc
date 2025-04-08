
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 09/03/2025, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/gmlBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <simpleType name="AggregationType" final="#all">
//   <restriction base="string">
//     <enumeration value="set"/>
//     <enumeration value="bag"/>
//     <enumeration value="sequence"/>
//     <enumeration value="array"/>
//     <enumeration value="record"/>
//     <enumeration value="table"/>
//   </restriction>
// </simpleType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml {

  // WARNING: Rename from AggregationType to AggregationType or AggregationTypes.

  /// <summary>
  /// Defines the possible types of aggregations for a GML object collection.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>AggregationType</c> ( /2005/gml/gmlBase.xsd )
  /// </remarks>
  [IsoType("AggregationType", IsoType = IsoTypes.SimpleType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  public enum AggregationType {

    /// <summary>
    /// A collection where order is not significant, and duplicates are not allowed.
    /// </summary>
    [EnumMember(Value = "set")]
    [XmlEnum(Name = "set")]
    Set,

    /// <summary>
    /// A collection where order is not significant, and duplicates are allowed.
    /// </summary>
    [EnumMember(Value = "bag")]
    [XmlEnum(Name = "bag")]
    Bag,

    /// <summary>
    /// A collection where order is significant, and duplicates are allowed.
    /// </summary>
    [EnumMember(Value = "sequence")]
    [XmlEnum(Name = "sequence")]
    Sequence,

    /// <summary>
    /// A collection where elements are indexed in a structured array format.
    /// </summary>
    [EnumMember(Value = "array")]
    [XmlEnum(Name = "array")]
    Array,

    /// <summary>
    /// A structured collection that follows a record-based model.
    /// </summary>
    [EnumMember(Value = "record")]
    [XmlEnum(Name = "record")]
    Record,

    /// <summary>
    /// A structured collection formatted as a table with rows and columns.
    /// </summary>
    [EnumMember(Value = "table")]
    [XmlEnum(Name = "table")]
    Table,

  }

}
