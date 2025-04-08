
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 31/12/2022, 04:23, @gisvlasta.
// Updated by        : 31/01/2023, 12:57, @gisvlasta.
// Version           : 1.1.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : The IObjectReference interface is defined in gco/gcoBase.xsd
//                     as the attributeGroup named 'ObjectReferece' which states
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
//                     explicilty a nilReason attribute of type 'gml:NilReasonType'.
//                     Remedy: This implementation derives derectly from IAssociation
//                     which is an implementation of 'gml:AssociationAttributeGroup'
//                     to allow simplicity in the overall implementation.
//                     That makes IOBjectReference and ObjectReference_PropertyType
//                     inheritance to deviate from their definitions in
//                     gco/gcoBase.xsd which seem incorrect.
// --------------------------------------------------------------------------------
// XSD               : /2005/gco/gcoBase.xsd
//                     /2005/gml/gmlBase.xsd
// --------------------------------------------------------------------------------
// <!--The following attributeGroup 'extends' the GML  gml:AssociationAttributeGroup-->
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
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.GML.Base;
using NDSH.Xml.XLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Common {

  /// <summary>
  /// 
  /// </summary>
  public interface IObjectReference : IAssociation, IUuidRef {

  }

}
