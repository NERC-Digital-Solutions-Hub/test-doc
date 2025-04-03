
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 28/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/referenceSystem.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MD_Identifier_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="authority" type="gmd:CI_Citation_PropertyType" minOccurs="0"/>
//         <xs:element name="code" type="gco:CharacterString_PropertyType"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_Identifier" type="gmd:MD_Identifier_Type"/>
// <xs:complexType name="MD_Identifier_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_Identifier"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;

using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.ReferenceSystem {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  //[XmlInclude(typeof(RS_Identifier_Type))]
  //[XmlType("MD_Identifier", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_Identifier", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_Identifier")]
  public class MD_Identifier_Type : MetadataObject, IComparable<MD_Identifier_Type>, IEquatable<MD_Identifier_Type> {

    // TODO: Continue

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Identifier_Type"/>.
    /// </summary>
    public MD_Identifier_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _authority = default; //  new CI_Citation_Type();
      _code = default; //  new CharacterString();

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private CI_Citation_Type? _authority;

    /// <summary>
    /// Person or party responsible for maintenance of the namespace.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    [XmlElement("authority", Order = 0)]
    [JsonProperty("authority", Order = 0)]
    public CI_Citation_Type? Authority {
      get => _authority;
      set => SetProperty(ref _authority, value);
    }

    private CharacterString? _code;

    /// <summary>
    /// Alphanumeric value identifying an instance in the namespace.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    [XmlElement("code", Order = 1)]
    [JsonProperty("code", Order = 1)]
    public CharacterString? Code {
      get => _code;
      set => SetProperty(ref _code, value);
    }

    #endregion

    #region IComparable Interface

    /// <inheritdoc />
    public virtual int CompareTo(MD_Identifier_Type? other) {
      if (other == null) {
        return 1;
      }

      int result = Authority?.CompareTo(other.Authority) ?? 1;
      if (result != 0) {
        return result;
      }

      return Code?.CompareTo(other.Code) ?? 1;
    }

    #endregion

    /// <summary>
    /// Determines whether the <see cref="MD_Identifier_Type"/> is equal to the current <see cref="MD_Identifier_Type"/>.
    /// </summary>
    /// <param name="other">The <see cref="MD_Identifier_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public virtual bool Equals(MD_Identifier_Type? other) {
      return other != null &&
             Equals(Authority, other.Authority) &&
             Equals(Code, other.Code);
    }

    #region Overrides

    /// <inheritdoc />
    public override bool Equals(object? obj) {
      return Equals(obj as MD_Identifier_Type);

    }

    /// <inheritdoc />
    public override int GetHashCode() {
      HashCode hash = new();
      hash.Add(Authority);
      hash.Add(Code);
      return hash.ToHashCode();
    }

    #endregion

  }

}
