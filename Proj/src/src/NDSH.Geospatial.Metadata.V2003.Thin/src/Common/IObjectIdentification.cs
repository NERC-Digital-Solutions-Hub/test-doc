#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/12/2022, 04:47, @gisvlasta.
// Updated by        : 30/12/2002, 22:00, @gisvlasta.
//                     1.0.1 - Extracted IId and IUuid interfaces.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gco/gcoBase.xsd
// --------------------------------------------------------------------------------
// <xs:attributeGroup name="ObjectIdentification">
//   <xs:attribute name="id" type="xs:ID"/>
//   <xs:attribute name="uuid" type="xs:string"/>
// </xs:attributeGroup>
// --------------------------------------------------------------------------------
#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Common {

  /// <summary>
  /// Identification of a resource.
  /// </summary>
  public interface IObjectIdentification : IId, IUuid {

  }

}
