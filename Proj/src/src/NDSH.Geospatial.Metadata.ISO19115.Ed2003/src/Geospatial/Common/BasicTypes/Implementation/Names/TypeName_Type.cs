
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 21/12/2022, @gisvlasta
// History           : 04/03/2025, @gisvlasta - Updated constructors, and documentation.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="TypeName_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="aName" type="gco:CharacterString_PropertyType"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="TypeName" type="gco:TypeName_Type"/>
// <xs:complexType name="TypeName_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gco:TypeName"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Common.BasicTypes.Implementation.Names {

  // TODO: Check the summary and remarks of this class.

  /// <summary>
  /// Represents a structured type name in ISO 19115. A TypeName is a LocalName
  /// that references either a recordType or object type in some form of schema.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     The <see cref="TypeName_Type"/> is a metadata element that defines
  ///     a named type within a dataset, typically representing a feature type,
  ///     attribute type, dataset type, or other structured entity in geospatial metadata.
  ///     This type contains a single required property, <see cref="Name"/>,
  ///     which holds a <see cref="CharacterString"/> representing the name.
  ///   </para>
  ///   <para>
  ///     For parsing from types (or objects) the parseable name normally uses a "." navigation separator,
  ///     so that it is of the form [class].[member].[memberOfMember]. ...)
  ///   </para>
  ///   <para>
  ///     <b><i>Example uses:</i></b>
  ///     <br></br>
  ///     <list type="number">
  ///       <item>
  ///         <term>Defining a Geospatial Feature Type</term>
  ///         <description>
  ///           <b><i>Used for: </i></b>Referencing a dataset's feature type.
  ///         </description>
  ///         <description>
  ///           <code>
  ///             &lt;gco:TypeName&gt;
  ///               &lt;gco:aName&gt;
  ///                 &lt;gco:CharacterString&gt;GeospatialFeature&lt;/gco:CharacterString&gt;
  ///               &lt;/gco:aName&gt;
  ///             &lt;/gco:TypeName&gt;
  ///           </code>
  ///         </description>
  ///       </item>
  ///       <item>
  ///         <term>Referencing an Attribute Type</term>
  ///         <description>
  ///           <b><i>Used for: </i></b>Representing metadata related to an attribute like elevation.
  ///         </description>
  ///         <description>
  ///           <code>
  ///             &lt;gco:TypeName&gt;
  ///               &lt;gco:aName&gt;
  ///                 &lt;gco:CharacterString&gt;Elevation&lt;/gco:CharacterString&gt;
  ///               &lt;/gco:aName&gt;
  ///             &lt;/gco:TypeName&gt;
  ///           </code>
  ///         </description>
  ///       </item>
  ///       <item>
  ///         <term>Dataset Category Name</term>
  ///         <description>
  ///           <b><i>Used for: </i></b>Indicating the dataset type (raster, vector, etc.).
  ///         </description>
  ///         <description>
  ///           <code>
  ///             &lt;gco:TypeName&gt;
  ///               &lt;gco:aName&gt;
  ///                 &lt;gco:CharacterString&gt;RasterDataset&lt;/gco:CharacterString&gt;
  ///               &lt;/gco:aName&gt;
  ///             &lt;/gco:TypeName&gt;
  ///           </code>
  ///         </description>
  ///       </item>
  ///       <item>
  ///         <term>Defining a Complex Object Type</term>
  ///         <description>
  ///           <b><i>Used for: </i></b>Hierarchical naming (e.g., <c>Geology.RockFormation</c>).
  ///         </description>
  ///         <description>
  ///           <code>
  ///             &lt;gco:TypeName&gt;
  ///               &lt;gco:aName&gt;
  ///                 &lt;gco:CharacterString&gt;Geology.RockFormation&lt;/gco:CharacterString&gt;
  ///               &lt;/gco:aName&gt;
  ///             &lt;/gco:TypeName&gt;
  ///           </code>
  ///         </description>
  ///       </item>
  ///     </list>
  ///   </para>
  /// </remarks>
  [Serializable]
  //[XmlType("TypeName", Namespace = "http://www.isotc211.org/2005/gco")] // TODO: XmlRoot
  [JsonObject("TypeName")]
  public class TypeName_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="TypeName_Type"/>.
    /// </summary>
    public TypeName_Type() {
      _name = default; //  new CharacterString();
    }

    /// <summary>
    /// Initializes the <see cref="TypeName_Type"/>/
    /// </summary>
    /// <param name="name">The name <see cref="string"/> used by the <see cref="TypeName_Type"/>.</param>
    public TypeName_Type(string name) {
      _name = name;
    }

    #endregion

    #region Public Properties

    private CharacterString _name;

    //[XmlElement("aName", Order = 0)]
    [JsonProperty("aName", Order = 0)]
    public CharacterString Name {
      get => _name;
      set => SetProperty(ref _name, value);
    }

    #endregion

  }

}
