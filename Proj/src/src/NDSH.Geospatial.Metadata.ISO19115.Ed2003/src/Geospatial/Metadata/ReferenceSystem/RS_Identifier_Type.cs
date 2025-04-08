
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 27/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/referenceSystem.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="RS_Identifier_Type">
//   <xs:complexContent>
//     <xs:extension base="gmd:MD_Identifier_Type">
//       <xs:sequence>
//         <xs:element name="codeSpace" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="version" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// 
// <xs:element name="RS_Identifier" type="gmd:RS_Identifier_Type" substitutionGroup="gmd:MD_Identifier"/>
// 
// <xs:complexType name="RS_Identifier_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:RS_Identifier"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Hashing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.ReferenceSystem {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("RS_Identifier", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("RS_Identifier", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("RS_Identifier")]
  public class RS_Identifier_Type : MD_Identifier_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="RS_Identifier_Type"/>.
    /// </summary>
    public RS_Identifier_Type() {

      //xmlns = new XmlSerializerNamespaces();
      //xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _codeSpace = default; //  new CharacterString();
      _version = default; //  new CharacterString();

    }

    #endregion

    #region Public Fields

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlNamespaceDeclarations()]
    //public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private CharacterString? _codeSpace;

    /// <summary>
    /// Name or identifier of the person or organization responsible for namespace.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    [XmlElement("codeSpace", Order = 0)]
    [JsonProperty("codeSpace", Order = 0)]
    // WARNING: This seems weired. It could have been an ICodespace if this was a string instead of CharacterString.
    public CharacterString? CodeSpace {
      get => _codeSpace;
      set => SetProperty(ref _codeSpace, value);
    }

    private CharacterString? _version;

    /// <summary>
    /// Version identifier for the namespace.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    [XmlElement("version", Order = 1)]
    [JsonProperty("version", Order = 1)]
    public CharacterString? Version {
      get => _version;
      set => SetProperty(ref _version, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="RS_Identifier_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="RS_Identifier_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(RS_Identifier_Type? other) {
      int result;

      return
          (other is null) ? 1 :
          (result = base.CompareTo(other)) != 0 ? result :
          (result = CodeSpace?.CompareTo(other.CodeSpace) ?? 1) != 0 ? result :
          (result = Version?.CompareTo(other.Version) ?? 1) != 0 ? result : 0;
    }

    /// <inheritdoc />
    public override int CompareTo(MD_Identifier_Type? other) {
      return CompareTo(other as RS_Identifier_Type);
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="RS_Identifier_Type"/> is equal to the current <see cref="RS_Identifier_Type"/>.
    /// </summary>
    /// <param name="other">The <see cref="RS_Identifier_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(RS_Identifier_Type? other) {
      return other != null &&
             base.Equals(other) &&
             Equals(CodeSpace, other.CodeSpace) &&
             Equals(Version, other.Version);
    }

    /// <inheritdoc />
    public override bool Equals(MD_Identifier_Type? other) {
      return Equals(other as RS_Identifier_Type);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="RS_Identifier_Type"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as RS_Identifier_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="RS_Identifier_Type"/> using <see cref="NdshHashCode"/>.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();
      hash.Add(base.GetHashCode());
      hash.Add(CodeSpace);
      hash.Add(Version);
      return hash.ToHashCode();
    }

    #endregion

  }

}
