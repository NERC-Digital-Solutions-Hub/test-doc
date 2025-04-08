
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 09/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/gmlBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <attributeGroup name="AssociationAttributeGroup">
//   <annotation>
//     <documentation>
//       XLink components are the standard method to support hypertext referencing in XML.
//       An XML Schema attribute group, gml:AssociationAttributeGroup, is provided to support the use of
//       Xlinks as the method for indicating the value of a property by reference in a uniform manner in GML.
//     </documentation>
//   </annotation>
//   <attributeGroup ref="xlink:simpleLink"/>
//   <attribute name="nilReason" type="gml:NilReasonType"/>
//   <attribute ref="gml:remoteSchema"/>
// </attributeGroup>
// <attribute name="remoteSchema" type="anyURI">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </attribute>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.BasicTypes;
using NDSH.Xml.XLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml {

  /// <summary>
  /// Defines a contract for geospatial metadata associations, incorporating linking capabilities,
  /// nil reasons, and optional references to remote schemas. This interface aligns with the
  /// <c>AssociationAttributeGroup</c> definition from the GML schema.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     XLink components are the standard method to support hypertext referencing in XML.
  ///     An XML Schema attribute group, gml:AssociationAttributeGroup, is provided to support the use of
  ///     Xlinks as the method for indicating the value of a property by reference in a uniform manner in GML.
  ///   </para>
  ///   <para>
  ///     The <see cref="IAssociation"/> interface extends multiple metadata-related interfaces to provide
  ///     a standardized structure for geospatial associations. It includes linking mechanisms, support for
  ///     nil reasons, and an optional reference to a remote schema.
  ///   </para>
  ///   <para>
  ///     <b>Key Features:</b>
  ///     <list type="bullet">
  ///       <item>Inherits from <see cref="ISimpleLink"/> to support XLink-based linking.</item>
  ///       <item>Implements <see cref="INilReason"/> to indicate missing or void values.</item>
  ///       <item>Supports referencing external schema definitions via <see cref="IRemoteSchema"/>.</item>
  ///     </list>
  ///   </para>
  ///   <para>
  ///     <b>Considerations:</b>
  ///     <list type="bullet">
  ///       <item>
  ///         The <c>remoteSchema</c> attribute is deprecated as per GML schema specifications.
  ///         </item>
  ///       <item>
  ///         Ensure correct implementation of linking attributes inherited from <see cref="ISimpleLink"/>.
  ///       </item>
  ///       <item>Use <see cref="INilReason"/> to handle null or undefined values appropriately.</item>
  ///     </list>
  ///   </para>
  /// </remarks>
  public interface IAssociation : ISimpleLink, INilReason, IRemoteSchema {

  }

}
