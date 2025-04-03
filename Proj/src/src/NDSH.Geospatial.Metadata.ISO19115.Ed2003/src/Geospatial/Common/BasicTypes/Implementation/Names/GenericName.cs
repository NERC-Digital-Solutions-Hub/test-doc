
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 17/02/2025, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:element name="AbstractGenericName" type="gml:CodeType" abstract="true"/>
// <xs:complexType name="GenericName_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gco:AbstractGenericName"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.BasicTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Common.BasicTypes.Implementation.Names {

  /// <summary>
  ///   <para>
  ///     In the context of ISO 19115, <see cref="GenericName"/> is an abstract class representing
  ///     a structured identifier or name in a namespace. It is a conceptual construct;
  ///     a placeholder for specific name types which represents a textual <c>'name'</c> in geospatial metadata.
  ///     It is commonly used to define hierarchical naming conventions, such as:
  ///     <list type="bullet">
  ///       <item>feature types</item>
  ///       <item>attribute names</item>
  ///       <item>or other domain-specific identifiers</item>
  ///     </list>
  ///   </para>
  ///   <para>
  ///     In GML, a <c>'name'</c> is commonly modeled as a GML <see cref="CodeType"/>,
  ///     which can carry a string and an optional codeSpace attribute.
  ///     The <see cref="GenericName"/> typically ties into this pattern.
  ///   </para>
  /// </summary>
  /// <remarks>
  ///   <list type="bullet">
  ///     <item>
  ///       It is primarily used in metadata elements where names
  ///       need to be structured in a namespace.
  ///     </item>
  ///     <item>
  ///       It serves as a base class for more specific name types.
  ///     </item>
  ///     <item>
  ///       It is widely used in geographic metadata to ensure
  ///       interoperability and consistency in naming conventions.
  ///     </item>
  ///   </list>
  /// </remarks>
  //[XmlType("GenericName", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("GenericName")]
  public abstract class GenericName : CodeType {

  }

}
