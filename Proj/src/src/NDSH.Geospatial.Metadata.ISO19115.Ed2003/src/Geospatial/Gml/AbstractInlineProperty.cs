
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 11/03/2025, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/gmlBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="abstractInlineProperty" type="gml:InlinePropertyType" abstract="true">
//   <annotation>
//     <documentation>
//       gml:abstractInlineProperty may be used as the head of a substitution group
//       of more specific elements providing a value in-line.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="InlinePropertyType">
//   <sequence>
//     <element ref="gml:AbstractObject"/>
//   </sequence>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
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

  // WARNING: Rename from AbstractInlineProperty to InlinePropertyBase.

  /// <summary>
  ///   <para>
  ///     Represents an <b>abstract in-line property</b> within a GML object.
  ///   </para>
  ///   <para>
  ///     The <see cref="AbstractInlineProperty"/> class serves as the <b>head of a substitution group</b>
  ///     for <b>more specific elements</b> that provide an in-line value.
  ///   </para>
  /// </summary>
  /// <remarks>
  /// Maps to: <c>AbstractInlineProperty</c> ( /2005/gml/gmlBase.xsd )
  /// <br></br>
  /// Implementing classes must define how <b>in-line values</b> are handled within the GML schema.
  /// </remarks>
  [IsoType("abstractInlineProperty", IsAbstract = true, IsoType = IsoTypes.Element)]
  //[XmlType("AbstractInlineProperty", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractInlineProperty")]
  public abstract class AbstractInlineProperty : AbstractMemberType {

  }

}
