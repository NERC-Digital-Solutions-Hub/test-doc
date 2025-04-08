
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 10/03/2025, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/gmlBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <attributeGroup name="AggregationAttributeGroup">
//   <annotation>
//     <documentation>
//       A GML Object Collection is any GML Object with a property element in its content model
//       whose content model is derived by extension from gml:AbstractMemberType. In addition,
//       the complex type describing the content model of the GML Object Collection may also
//       include a reference to the attribute group gml:AggregationAttributeGroup to provide
//       additional information about the semantics of the object collection.  This information
//       may be used by applications to group GML objects, and optionally to order and index them.
//       The allowed values for the aggregationType attribute are defined by gml:AggregationType.
//       See 8.4 of ISO/IEC 11404:1996 for the meaning of the values in the enumeration.
//   </documentation>
//   </annotation>
//   <attribute name="aggregationType" type="gml:AggregationType"/>
// </attributeGroup>
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

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml {

  /// <summary>
  /// Defines attributes for a GML Object Collection to provide information about grouping and indexing.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>AggregationAttributeGroup</c> ( /2005/gml/gmlBase.xsd )
  /// </remarks>
  public interface IAggregation {

    /// <summary>
    /// Gets or sets the aggregation type, specifying how the collection is structured.
    /// </summary>
    /// <remarks>
    /// The aggregation type follows the values defined in
    /// <see cref="Gml.AggregationType">AggregationType</see>.
    /// </remarks>
    //[XmlAttribute("aggregationType")]
    [JsonProperty("aggregationType")]
    AggregationType AggregationType {
      get;
      set;
    }

  }

}
