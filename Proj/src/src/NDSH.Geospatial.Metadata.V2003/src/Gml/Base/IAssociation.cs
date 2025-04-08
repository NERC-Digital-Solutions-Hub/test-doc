
#region Header
// --------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gml/gmlBase.xsd
// --------------------------------------------------------------------------------
// <attributeGroup name="AssociationAttributeGroup">
//   <attributeGroup ref="xlink:simpleLink"/>
//   <attribute name="nilReason" type="gml:NilReasonType"/>
//   <attribute ref="gml:remoteSchema"/>
// </attributeGroup>
// <attribute name="remoteSchema" type="anyURI">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </attribute>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Xml.XLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Base {

  /// <summary>
  /// Defines a contract for geospatial metadata associations, incorporating linking capabilities,
  /// nil reasons, and optional references to remote schemas. This interface aligns with the
  /// <c>AssociationAttributeGroup</c> definition from the GML schema.
  /// </summary>
  /// <remarks>
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
