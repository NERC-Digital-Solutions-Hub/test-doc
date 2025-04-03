
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
// <element name="Dictionary" type="gml:DictionaryType" substitutionGroup="gml:Definition">
//   <annotation>
//     <documentation>
//       Sets of definitions may be collected into dictionaries or collections.
//       A gml:Dictionary is a non-abstract collection of definitions.
//       The gml:Dictionary content model adds list of gml:dictionaryEntry properties that contain or
//       reference gml:Definition objects.  A database handle (gml:id attribute) is required,
//       in order that this collection may be referred to. The standard gml:identifier, gml:description,
//       gml:descriptionReference and gml:name properties are available to reference or contain more information
//       about this dictionary. The gml:description and gml:descriptionReference property elements may be used for a
//       description of this dictionary. The derived gml:name element may be used for the name(s) of this dictionary.
//       For remote definition references gml:dictionaryEntry shall be used. If a Definition object contained within a
//       Dictionary uses the descriptionReference property to refer to a remote definition,
//       then this enables the inclusion of a remote definition in a local dictionary, giving a handle and
//       identifier in the context of the local dictionary.
//     </documentation>
//   </annotation>
// </element>
// 
// <element name="DefinitionCollection" type="gml:DictionaryType" substitutionGroup="gml:Definition">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <complexType name="DictionaryType">
//   <complexContent>
//     <extension base="gml:DefinitionType">
//       <choice minOccurs="0" maxOccurs="unbounded">
//         <element ref="gml:dictionaryEntry"/>
//         <element ref="gml:indirectEntry"/>
//       </choice>
//       <attributeGroup ref="gml:AggregationAttributeGroup"/>
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

#endregion

namespace NDSH.Geospatial.Gml.Dictionary {

  /// <summary>
  /// Sets of definitions may be collected into dictionaries or collections.
  /// A <see cref="DictionaryType"/> is a non-abstract collection of <see cref="DefinitionType">Definitions</see> .
  /// </summary>
  /// <remarks>
  /// The <see cref="DictionaryType"/> content model adds an <see cref="ObservableCollection{DictionaryEntryType}"/>
  /// properties that contain or reference <see cref="DefinitionType"/> objects.
  /// A database handle (<see cref="AbstractGMLType.Id">Id</see> - gml:id attribute) is required,
  /// in order that this collection may be referred to. The standard
  /// <see cref="DefinitionBaseType.Identifier">Identifier</see>,
  /// <see cref="AbstractGMLType.Description">Description</see>,
  /// <see cref="AbstractGMLType.DescriptionReference">DescriptionReference</see> and
  /// <see cref="AbstractGMLType.Name">Name</see> properties are available to reference or contain more information
  /// about this dictionary.
  /// The <see cref="AbstractGMLType.Description">Description</see> and
  /// <see cref="AbstractGMLType.DescriptionReference">DescriptionReference</see> property elements
  /// may be used for a description of this dictionary. The derived <see cref="AbstractGMLType.Name">Name</see>
  /// element may be used for the name(s) of this dictionary.
  /// For remote definition references <see cref="DictionaryEntryType"/> shall be used.
  /// If a <see cref="DefinitionType"/> object contained within a <see cref="DictionaryType"/> uses the
  /// <see cref="AbstractGMLType.DescriptionReference"/> property to refer to a remote definition,
  /// then this enables the inclusion of a remote <see cref="DefinitionType"/> in a local <see cref="DictionaryType"/>,
  /// giving a handle (<see cref="AbstractGMLType.Id">Id</see> - gml:id attribute) and
  /// <see cref="DefinitionBaseType.Identifier">Identifier</see> in the context
  /// of the local <see cref="DictionaryType"/> dictionary.
  /// </remarks>
  //[XmlInclude(typeof(CodeListDictionary_Type))]
  //[XmlInclude(typeof(ML_CodeListDictionary_Type))]
  [IsoType("DictionaryType", IsoType = IsoTypes.ComplexType)]
  //[XmlType("DictionaryType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DictionaryType")]
  public class DictionaryType : DefinitionType, IAggregation {

    // WARNING: Rename from DictionaryType to Dictionary.

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DictionaryType"/>.
    /// </summary>
    public DictionaryType() {
      _entries = default;
    }

    #endregion

    #region Public Properties

    private ObservableCollection<IDictionaryEntry>? _entries;

    /// <summary>
    /// Gets/Sets the <see cref="ObservableCollection{IDictionaryEntry}">collection of dictionary entries</see>, 
    /// each of which contains or references a <see cref="DefinitionType"/> object.
    /// </summary>
    /// <remarks>
    ///   <para>
    ///     Each entry follows the GML property pattern and can either:
    ///     <list type="bullet">
    ///       <item>Contain a definition directly.</item>
    ///       <item>Reference a remote definition.</item>
    ///     </list>
    ///   </para>
    ///   <para>
    ///     If a <see cref="DefinitionType"/> uses the <see cref="AbstractGMLType.DescriptionReference"/> property
    ///     to reference a remote definition, the local dictionary can include that definition,
    ///     assigning it a <b>handle</b> (<see cref="AbstractGMLType.Id">Id</see>) and
    ///     <b>identifier</b> (<see cref="DefinitionBaseType.Identifier">Identifier</see>).
    ///   </para>
    /// </remarks>
    //[XmlElement("dictionaryEntry", typeof(DictionaryEntryType), Order = 0)]
    //[XmlElement("indirectEntry", typeof(IndirectEntryType), Order = 0)]
    public ObservableCollection<IDictionaryEntry>? Entries {
      get => _entries;
      set => SetProperty(ref _entries, value);
    }

    #endregion

    #region IAggregation Interface

    private AggregationType _aggregationType;

    /// <summary>
    /// Gets/sets the <see cref="AggregationType"/> of this dictionary.
    /// </summary>
    /// <remarks>
    ///   <para>
    ///     The <see cref="AggregationType"/> specifies how the dictionary entries are structured.
    ///     It follows the GML <see cref="IAggregation"/> pattern.
    ///   </para>
    ///   <para>
    ///     Example aggregation types include:
    ///     <list type="bullet">
    ///       <item>set</item>
    ///       <item>bag</item>
    ///       <item>sequence</item>
    ///     </list>
    ///   </para>
    /// </remarks>
    //[XmlAttribute("aggregationType")]
    [JsonProperty("aggregationType")]
    public AggregationType AggregationType {
      get => _aggregationType;
      set => SetProperty(ref _aggregationType, value);
    }

    #endregion

  }

}
