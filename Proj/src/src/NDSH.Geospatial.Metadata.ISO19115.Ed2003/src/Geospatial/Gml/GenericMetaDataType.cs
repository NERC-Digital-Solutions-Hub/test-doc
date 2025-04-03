
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 03/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : In XML Schema (XSD), when a complex type or complex content has the attribute mixed="true",
//                     it means that:
//                      - The element can contain both text and child elements.
//                      - The text can appear anywhere within the child elements.
//                      - The structure is flexible, allowing arbitrary text before, after, or between child elements.
//                     In the case of GenericMetaDataType this means:
//                      - The GenericMetaDataType can contain both text and XML elements.
//                      - The<any> element allows arbitrary XML content to be included within it.
//                      - The processContents="lax" means the XML elements inside <any> may or may not be validated
//                        against a schema.
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/gmlBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="GenericMetaData" type="gml:GenericMetaDataType" substitutionGroup="gml:AbstractMetaData">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// <complexType name="GenericMetaDataType" mixed="true">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <complexContent mixed="true">
//     <extension base="gml:AbstractMetaDataType">
//       <sequence>
//         <any processContents="lax" minOccurs="0" maxOccurs="unbounded"/>
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
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

#endregion

namespace NDSH.Geospatial.Gml {

  // WARNING: Rename from GenericMetaDataType to GenericMetaData.

  /// <summary>
  ///   <para>
  ///     Represents a <b>generic metadata element</b> in GML.
  ///   </para>
  ///   <para>
  ///     The <see cref="GenericMetaDataType"/> class allows <b>extensible metadata content</b> in GML.
  ///     It supports <b>mixed content</b>, meaning it can hold <b>both text</b> and <b>structured XML elements</b>.
  ///   </para>
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     In the case of GenericMetaDataType the presence of <c>mixed="true"</c> means that:
  ///     <list type="bullet">
  ///       <item>The GenericMetaDataType can contain both text and XML elements.</item>
  ///       <item>The <c>&lt;any&gt;</c> element allows arbitrary XML content to be included within it.</item>
  ///       <item>
  ///         The processContents="lax" means the XML elements inside <c>&lt;any&gt;</c> may or may not
  ///         be validated against a schema.
  ///       </item>
  ///     </list>
  ///   </para>
  ///   <para>Maps to: <c>GenericMetaDataType</c> ( /2005/gml/gmlBase.xsd )</para>
  /// </remarks>
  /// <example>
  ///   Example of XML Output:
  ///   <code>
  ///     &lt;GenericMetaData&gt;
  ///       Some metadata text here.
  ///       &lt;CustomTag&gt;Some more metadata.&lt;/CustomTag&gt;
  ///       &lt;AnotherTag attribute = "value"&gt; More structured content.&lt;/AnotherTag&gt;
  ///       And some more text after elements.
  ///     &lt;/GenericMetaData&gt;
  ///   </code>
  /// </example>
  [Obsolete("Marked 'deprecated' in /gml/gmlBase.xsd")]
  [IsoType("GenericMetaDataType", IsoType = IsoTypes.ComplexType)]
  //[XmlType("GenericMetaDataType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GenericMetaDataType")]
  public class GenericMetaDataType : AbstractMetaDataType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="GenericMetaDataType"/>.
    /// </summary>
    public GenericMetaDataType() {
      _mixedContent = [];
    }

    #endregion

    #region Public Properties

    private ObservableCollection<object> _mixedContent;

    /// <summary>
    /// Gets/Sets the <b>mixed content</b>, which includes <b>text and structured XML elements</b>.
    /// </summary>
    /// <remarks>
    /// This property allows <b>arbitrary XML elements</b> and <b>text segments</b> to be stored as metadata.
    /// The <c>processContents="lax"</c> attribute in the XSD means that these elements 
    /// <b>may or may not be validated</b> against an XML schema.
    /// </remarks>
    [JsonProperty("MixedContent")]
    //[XmlText(typeof(string))] // Supports text content
    //[XmlAnyElement] // Supports arbitrary XML elements
    public ObservableCollection<object> MixedContent {
      get => _mixedContent;
      set => _mixedContent = value;
    }

    #endregion

  }

}
