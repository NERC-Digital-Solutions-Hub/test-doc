
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 20/12/2022, @gisvlasta
// History           : 11/03/2025, @gisvlasta - Updated inheritance, modified code and updated documentation.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/gcoBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="StringOrRefType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <simpleContent>
//     <extension base="string">
//       <attributeGroup ref="gml:AssociationAttributeGroup"/>
//     </extension>
//   </simpleContent>
// </complexType>
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

  // WARNING: Rename from StringOrRefType to StringOrRef.

  /// <summary>
  ///   <para>
  ///     Represents a string value or a reference to an external resource in GML.
  ///   </para>
  ///   <para>
  ///     This type allows a property to:
  ///     <list type="bullet">
  ///       <item>Store a <b>simple text string</b>.</item>
  ///       <item>
  ///         Contain an <b>external reference</b> to another resource using <b>XLink attributes</b>.
  ///       </item>
  ///     </list>
  ///     It is commonly used for <b>descriptions</b>, <b>identifiers</b>, and other metadata elements.
  ///   </para>
  /// </summary>
  /// <remarks>
  /// Maps to: <c>StringOrRefType</c> ( /2005/gml/gmlBase.xsd )
  /// </remarks>
  [Obsolete("Marked 'deprecated' in /gml/gmlBase.xsd")]
  [IsoType("StringOrRefType", IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("StringOrRefType")]
  public class StringOrRefType : AssociationEntity {

  }

}
