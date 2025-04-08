
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
// <element name="dictionaryEntry" type="gml:DictionaryEntryType">
//   <annotation>
//     <documentation>
//       This property element contains or refers to the definitions which are members of a dictionary. 
//       The content model follows the standard GML property pattern, so a gml:dictionaryEntry may either contain or
//       refer to a single gml:Definition. Since gml:Dictionary is substitutable for gml:Definition,
//       the content of an entry may itself be a lower level dictionary.
//       Note that if the value is provided by reference, this definition does not carry a handle (gml:id)
//       in this context, so does not allow external references to this specific definition in this context.
//       When used in this way the referenced definition will usually be in a dictionary in the same XML document.
//     </documentation>
//   </annotation>
// </element>
// 
// <element name="definitionMember" type="gml:DictionaryEntryType" substitutionGroup="gml:dictionaryEntry">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <complexType name="DictionaryEntryType">
//   <complexContent>
//     <extension base="gml:AbstractMemberType">
//       <sequence minOccurs="0">
//         <element ref="gml:Definition"/>
//       </sequence>
//       <attributeGroup ref="gml:AssociationAttributeGroup"/>
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

#endregion

namespace NDSH.Geospatial.Gml.Dictionary {

  // WARNING: Rename from DictionaryEntryType to DictionaryEntry.

  /// <summary>
  /// A <see cref="DictionaryEntryType"/> contains or refers to the definitions which are members of a dictionary.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     The content model follows the standard GML property pattern, so a <see cref="DictionaryEntryType"/>
  ///     may either contain or <see cref="DefinitionType"/> refer to a single <see cref="DefinitionType"/>.
  ///     Since <see cref="DictionaryType"/> is substitutable for <see cref="DefinitionType"/>,
  ///     the content of an entry may itself be a lower level dictionary.
  ///   </para>
  ///   <para>
  ///     Note that if the value is provided by reference, this definition does not carry a handle (gml:id)
  ///      in this context, so does not allow external references to this specific definition in this context.
  ///      When used in this way the referenced definition will usually be in a dictionary in the same XML document.
  ///   </para>
  /// </remarks>
  [IsoType("DictionaryEntryType", IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DictionaryEntryType")]
  public class DictionaryEntryType : AbstractMemberType, IDictionaryEntry, IAssociated {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DictionaryEntryType"/>.
    /// </summary>
    public DictionaryEntryType() {
      _definition = default; // new DefinitionType();
    }

    #endregion

    #region Public Properties

    private DefinitionType? _definition;

    /// <summary>
    /// Gets/Sets the definition associated with this dictionary entry.
    /// </summary>
    /// <remarks>
    /// <para>
    ///   The definition may either be contained within this dictionary entry or referenced externally.
    /// </para>
    /// <para>
    ///   If provided as a reference, this definition does not carry a "gml:id" and
    ///   is typically found within the same XML document.
    /// </para>
    /// </remarks>
    //[XmlElement(Order = 0)]
    [JsonProperty("Definition", Order = 0)]
    public DefinitionType? Definition {
      get => _definition;
      set => SetProperty(ref _definition, value);
    }

    #endregion

    #region IAssociated Interface

    private AssociationEntity? _association;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see>.
    /// </summary>
    public AssociationEntity? Association {
      get => _association;
      set => SetProperty(ref _association, value);
    }

    #endregion

  }

}
