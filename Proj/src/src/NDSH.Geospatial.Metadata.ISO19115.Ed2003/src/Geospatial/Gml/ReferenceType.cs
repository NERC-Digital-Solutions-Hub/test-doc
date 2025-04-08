
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 07/03/2025, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : Although the class AbstractReference exists in the project, the ReferenceType does not
//                     inherit from it. Instead ReferenceType inherits from AssociationAndOwnership. This is
//                     because the class has properties from OwnershipAttributeGroup and AssociationAttributeGroup
//                     and it is better to avoid implement the interfaces since they are implemented by the
//                     abstract class AssociationAndOwnership, and abstractReference is not necessary to be used;
//                     it is explicitly stated in the XSD definition's documentation that it 'may be used'.
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/gmlBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="abstractReference" type="gml:ReferenceType" abstract="true">
//   <annotation>
//     <documentation>
//       gml:abstractReference may be used as the head of a substitution group
//       of more specific elements providing a value by-reference.
//     </documentation>
//   </annotation>
// </element>
//
// <complexType name="ReferenceType">
//   <annotation>
//     <documentation>
//       gml:ReferenceType is intended to be used in application schemas directly,
//       if a property element shall use a “by-reference only” encoding.
//     </documentation>
//   </annotation>
//   <sequence/>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml {

  // WARNING: Rename from ReferenceType to Reference

  /// <summary>
  /// <see cref="ReferenceType"/> is intended to be used in application schemas directly,
  /// if a property element shall use a <b>'by-reference only'</b> encoding.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>ReferenceType</c> ( /2005/gml/gmlBase.xsd )
  /// </remarks>
  [IsoType("ReferenceType", IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ReferenceType")]
  public class ReferenceType : AssociationAndOwnership {

  }

}
