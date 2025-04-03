
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
// <xs:complexType name="MemberName_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="aName" type="gco:CharacterString_PropertyType"/>
//         <xs:element name="attributeType" type="gco:TypeName_PropertyType"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MemberName" type="gco:MemberName_Type"/>
// <xs:complexType name="MemberName_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gco:MemberName"/>
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

  /// <summary>
  /// Represents a structured metadata element. A MemberName is a LocalName
  /// that references either an attribute slot in a record, or recordType,
  /// or an attribute, operation, or association role in an object instance,
  /// or  type description in some form of schema. This metadata structure is used
  /// in ISO 19115 to describe attributes in datasets, schemas, and metadata models.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     The <see cref="MemberName_Type"/> is used to define the name of a member
  ///     (attribute, property, or element) within a structured data type. It consists of:
  ///     <list type="bullet">
  ///       <item>
  ///         <see cref="Name">Name</see>: A character string representing the name of the member.
  ///       </item>
  ///       <item>
  ///         <see cref="AttributeType">AttributeType</see>: A reference to a <see cref="TypeName_Type"/>
  ///         that describes the type of this member.
  ///       </item>
  ///     </list>
  ///   </para>
  ///   <para>
  ///     <b><i>Example of usage in metadata:</i></b>
  ///     <code>
  ///       MemberName memberName = new MemberName("Elevation", new TypeName("Real"));
  ///       Console.WriteLine(memberName.Name); // Output: Elevation
  ///       Console.WriteLine(memberName.AttributeType.AName); // Output: Real
  ///     </code>
  ///   </para>
  ///   <para>
  ///     <b><i>Example XML Representation:</i></b>
  ///     <code>
  ///       &lt;gco:MemberName&gt;
  ///         &lt;gco:aName&gt;
  ///           &lt;gco:CharacterString&gt;Elevation&lt;/gco:CharacterString&gt;
  ///         &lt;/gco:aName&gt;
  ///         &lt;gco:attributeType&gt;
  ///           &lt;gco:TypeName&gt;
  ///             &lt;gco:aName&gt;
  ///               &lt;gco:CharacterString&gt;Real&lt;/gco:CharacterString&gt;
  ///             &lt;/gco:aName&gt;
  ///           &lt;/gco:TypeName&gt;
  ///         &lt;/gco:attributeType&gt;
  ///       &lt;/gco:MemberName&gt;
  ///     </code>
  ///   </para>
  /// </remarks>
  [Serializable]
  //[XmlType("MemberName", Namespace = "http://www.isotc211.org/2005/gco")] // TODO: XmlRoot???
  [JsonObject("MemberName")]
  public class MemberName_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MemberName_Type"/>.
    /// </summary>
    public MemberName_Type() {
      _name = default; //  new CharacterString();
      _attributeType = default; //  new TypeName_Type();
    }

    /// <summary>
    /// Initializes the <see cref="MemberName_Type"/>.
    /// </summary>
    /// <param name="name">The name of the attribute.</param>
    /// <param name="attributeType">The type of the attribute.</param>
    public MemberName_Type(string name, TypeName_Type attributeType) {
      _name = name;
      _attributeType = attributeType;
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

    private TypeName_Type _attributeType;

    //[XmlElement("attributeType", Order = 1)]
    [JsonProperty("attributeType", Order = 1)]
    public TypeName_Type AttributeType {
      get => _attributeType;
      set {
        if (_attributeType == value) {
          return;
        }
        if (_attributeType == null || !_attributeType.Equals(value)) {
          _attributeType = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
