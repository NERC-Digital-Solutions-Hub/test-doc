
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 19/03/2025, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/dictionary.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="definitionRef" type="gml:ReferenceType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <element name="DefinitionProxy" type="gml:DefinitionProxyType" substitutionGroup="gml:Definition">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <complexType name="DefinitionProxyType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <complexContent>
//     <extension base="gml:DefinitionType">
//       <sequence>
//         <element ref="gml:definitionRef"/>
//       </sequence>
//     </extension>
//   </complexContent>
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
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Dictionary {

  // WARNING: Rename from DefinitionProxyType to DefinitionProxy.

  /// <summary>
  /// Represents a proxy definition that refers to an external definition rather than containing its own definition.
  /// </summary>
  /// <remarks>
  /// <para>
  ///   The <see cref="DefinitionProxyType"/> is part of the ISO 19115 metadata framework and is used in
  ///   GML-based metadata applications. It extends <see cref="DefinitionType"/>, meaning it inherits all attributes
  ///   of a standard GML definition, but instead of containing the definition itself,
  ///   it references an external definition.
  /// </para>
  /// <para>
  ///   This construct is useful in metadata catalogs, where multiple datasets or systems
  ///   may share a common definition that is maintained in a centralized dictionary or registry.
  /// </para>
  /// <para>
  ///   The <c>definitionRef</c> element is a mandatory reference to another definition,
  ///   ensuring that definitions can be linked across distributed metadata systems.
  /// </para>
  /// <para>
  ///   <b>Deprecation Notice:</b> This type is marked as <c>deprecated</c> in the GML schema,
  ///   meaning that its use is discouraged in favor of other definition structures in newer versions of GML.
  /// </para>
  /// </remarks>
  [Obsolete("Marked 'deprecated' in /2005/gml/dictionary.xsd")]
  [IsoType("DefinitionProxyType", IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DefinitionProxyType")]
  public class DefinitionProxyType : DefinitionType {

    #region constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DefinitionProxyType"/>.
    /// </summary>
    public DefinitionProxyType() {
      _definitionReference = new ReferenceType();
    }

    #endregion

    #region Public Properties

    private ReferenceType _definitionReference;

    /// <summary>
    /// Gets/Sets the reference to an external definition.
    /// </summary>
    /// <remarks>
    /// <para>
    ///   This property holds a <see cref="ReferenceType"/> that points to an existing definition
    ///   rather than containing the definition itself.
    /// </para>
    /// <para>
    ///   The reference typically uses an identifier, such as a <c>URI</c> or <c>UUID</c>, to ensure that
    ///   the correct definition can be retrieved from an external source or dictionary.
    /// </para>
    /// <para>
    ///   This approach enhances interoperability, allowing systems to reference shared metadata
    ///   definitions without duplicating content.
    /// </para>
    /// </remarks>
    //[XmlElement(Order = 0)]
    [JsonProperty("definitionRef", Order = 0)]
    public ReferenceType DefinitionReference {
      get => _definitionReference;
      set => SetProperty(ref _definitionReference, value);
    }

    #endregion

  }

}
