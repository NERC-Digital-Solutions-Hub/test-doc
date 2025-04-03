
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
// <element name="indirectEntry" type="gml:IndirectEntryType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <complexType name="IndirectEntryType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <sequence>
//     <element ref="gml:DefinitionProxy"/>
//   </sequence>
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

namespace NDSH.Geospatial.Gml.Dictionary {

  // WARNING: Rename from IndirectEntryType to IndirectEntry.

  /// <summary>
  /// Represents an indirect entry in a GML dictionary.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     This class is marked <b>deprecated</b> in /2005/gml/dictionary.xsd.
  ///   </para>
  ///   <para>
  ///     A dictionary may contain <see cref="DefinitionType">definitions</see> that are included <b>directly</b>
  ///     (<see cref="DictionaryEntryType"/>) or <b>indirectly</b> via references to other dictionaries.
  ///     The <see cref="IndirectEntryType"/> is used to reference definitions <b>indirectly</b>
  ///     through a <b>proxy</b> (<see cref="DefinitionProxyType"/>).
  ///   </para>
  ///   <para>
  ///     Definition proxies allow definitions to be included in a dictionary by reference
  ///     rather than by value. This is useful for avoiding duplication and ensuring consistency
  ///     when using definitions from external sources.
  ///   </para>
  /// </remarks>
  [Obsolete("Marked 'deprecated' in /2005/gml/dictionary.xsd")]
  [IsoType("IndirectEntryType", IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("IndirectEntryType")]
  public class IndirectEntryType : GmlObject, IDictionaryEntry {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="IndirectEntryType"/>.
    /// </summary>
    public IndirectEntryType() {
      _definitionProxy = default; // new DefinitionProxyType();
    }

    #endregion

    #region Public Properties

    private DefinitionProxyType _definitionProxy;

    /// <summary>
    /// Gets/Sets the <see cref="DefinitionProxyType"/> associated with this <see cref="IndirectEntryType"/>.
    /// </summary>
    /// <remarks>
    ///   <para>
    ///     A <see cref="DefinitionProxyType"/> allows this entry to refer to a <see cref="DefinitionType"/>
    ///     in another <see cref="DictionaryType"/> rather than defining it directly.
    ///   </para>
    ///   <para>
    ///     This mechanism supports <b>modular metadata management</b>,
    ///     ensuring that definitions can be reused without duplication.
    ///   </para>
    /// </remarks>
    //[XmlElement(Order = 0)]
    [JsonProperty("DefinitionProxy", Order = 0)]
    public DefinitionProxyType DefinitionProxy {
      get => _definitionProxy;
      set => SetProperty(ref _definitionProxy, value);
    }

    #endregion

  }

}
