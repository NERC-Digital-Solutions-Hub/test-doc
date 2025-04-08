
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 03/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/gmlBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <attributeGroup name="OwnershipAttributeGroup">
//   <attribute name="owns" type="boolean" default="false"/>
// </attributeGroup>
// 
// <complexType name="AbstractMetadataPropertyType" abstract="true">
//   <sequence/>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
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
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml {

  /// <summary>
  ///   <para>
  ///     To associate metadata described by any XML Schema with a GML object, a property element
  ///     shall be defined whose content model is derived by extension from <see cref="AbstractMetadataPropertyType"/>.
  ///     The value of such a property shall be metadata. The content model of such a property type,
  ///     i.e. the metadata application schema shall be specified by the GML Application Schema.
  ///     By default, this abstract property type does not imply any ownership of the metadata.
  ///     The <see cref="AssociationAndOwnership.Owns">Owns</see> property (<c>owns</c> attribute) of
  ///     the <see cref="IOwnership"/> (<c>gml:OwnershipAttributeGroup</c>) may be used on a
  ///     metadata property element instance to assert ownership of the metadata.
  ///   </para>
  ///   <para>
  ///     If metadata following the conceptual model of ISO 19115 is to be encoded in a GML document,
  ///     the corresponding Implementation Specification specified in ISO/TS 19139 shall be used
  ///     to encode the metadata information.
  ///   </para>
  /// </summary>
  /// <remarks>
  /// Maps to: <c>AbstractMetadataPropertyType</c> ( /2005/gml/gmlBase.xsd )
  /// </remarks>
  [IsoType("AbstractMetadataPropertyType", IsAbstract = true, IsoType = IsoTypes.ComplexType)]
  //[XmlType("AbstractMetadataPropertyType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractMetadataPropertyType")]
  public abstract class AbstractMetadataPropertyType : AbstractMemberType {

  }

}
