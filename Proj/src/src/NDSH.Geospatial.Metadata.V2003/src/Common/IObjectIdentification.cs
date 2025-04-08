
#region Header
// --------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 30/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
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

namespace NDSH.Geospatial.Metadata.V2003.Common {

  /// <summary>
  /// Provides a standardized interface for identifying metadata objects with both
  /// a unique local identifier and a globally unique UUID, ensuring interoperability
  /// across different datasets and systems.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     This interface extends both <see cref="IId"/> and <see cref="IUuid"/>, integrating
  ///     both a locally unique XML identifier and a universally unique identifier (UUID)
  ///     for metadata objects following the ISO 19115 standard.
  ///   </para>
  ///   <para>
  ///     <b>Key Features:</b>
  ///     <list type="bullet">
  ///       <item>Combines local XML ID uniqueness with a globally unique UUID.</item>
  ///       <item>Facilitates interoperability across metadata repositories.</item>
  ///       <item>Ensures compliance with the gcoBase XSD schema.</item>
  ///     </list>
  ///   </para>
  ///   <para>
  ///     <b>Considerations:</b>
  ///     <list type="bullet">
  ///       <item>
  ///         Implementing classes must provide valid values for both
  ///         <see cref="IId.Id"/> and <see cref="IUuid.Uuid"/>.
  ///       </item>
  ///       <item>
  ///         The <c>id</c> attribute must be unique within an XML document,
  ///         while <c>uuid</c> should be globally unique.
  ///       </item>
  ///     </list>
  ///   </para>
  /// </remarks>
  public interface IObjectIdentification : IId, IUuid {

  }

}
