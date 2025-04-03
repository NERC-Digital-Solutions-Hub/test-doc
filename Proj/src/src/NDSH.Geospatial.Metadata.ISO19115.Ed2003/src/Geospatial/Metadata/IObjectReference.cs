
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 31/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : The IObjectReference interface is defined in gco/gcoBase.xsd
//                     as the attributeGroup named 'ObjectReference' which states
//                     that it 'extends the 'gml:AssociationAttributeGroup' in
//                     gml/gmlBase.xsd. The AssociationAttributeGroup clearly includes
//                     the attribute nilReason of type 'gml:NilReasonType' which is
//                     defined in gml/basicTypes.xsd. The NilReasonType has been
//                     implemented in INilReasonType. However, no NilReasonType is
//                     included in attributeGroup 'ObjectReference' which makes the
//                     situation unclear and complicated because clearly the
//                     'ObjectReferece' attributeGroup, does not extend the
//                     'AssociationAttributeGroup' since does not include
//                     'nilReason' of type 'gml:NilReasonType'.
//                     The complexType 'ObjectReference_PropertyType' includes
//                     explicitly a nilReason attribute of type 'gml:NilReasonType'.
//                     Remedy: This implementation derives directly from IAssociation
//                     which is an implementation of 'gml:AssociationAttributeGroup'
//                     to allow simplicity in the overall implementation.
//                     That makes IObjectReference and ObjectReference_PropertyType
//                     inheritance to deviate from their definitions in
//                     gco/gcoBase.xsd which seem incorrect.
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/gcoBase.xsd
//                     /2005/gml/gmlBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <!--The following attributeGroup 'extends' the GML gml:AssociationAttributeGroup-->
// <xs:attributeGroup name="ObjectReference">
//   <xs:attributeGroup ref="xlink:simpleLink"/>
//   <xs:attribute name="uuidref" type="xs:string"/>
// </xs:attributeGroup>
// <!--================== NULL ==================== -->
// <xs:attribute name = "nilReason" type="gml:NilReasonType"/>
//
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
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata {

  /// <summary>
  /// Defines a contract for referencing objects within geospatial metadata,
  /// incorporating linking capabilities and UUID-based references.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     The <see cref="IObjectReference"/> interface extends
  ///     <see cref="IAssociation"/> and <see cref="INullableUuidRef"/>,
  ///     integrating metadata linking mechanisms and UUID-based identification.
  ///   </para>
  ///   <para>
  ///     <b>Key Features:</b>
  ///     <list type="bullet">
  ///       <item>Supports linking via <see cref="IAssociation"/> to reference remote resources.</item>
  ///       <item>Provides a UUID reference mechanism via <see cref="INullableUuidRef"/>.</item>
  ///       <item>Ensures compliance with GML and ISO 19115 metadata standards.</item>
  ///     </list>
  ///   </para>
  ///   <para>
  ///     <b>Considerations:</b>
  ///     <list type="bullet">
  ///       <item>
  ///         The implementation derives from <see cref="IAssociation"/> for simplicity,
  ///         ensuring alignment with <c>AssociationAttributeGroup</c>.
  ///       </item>
  ///       <item>Designed for referencing objects within geospatial metadata structures.</item>
  ///     </list>
  ///   </para>
  /// </remarks>
  // WARNING: Most probably this is an obsolete interface. We can make sure it is deleted, since ReferencedObject inherits from Association and implements INullableUuidRef.
  public interface IObjectReference : IAssociation, INullableUuidRef {

  }

}
