#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 17/02/2025, @gisvlasta
// History           : 03/03/2025, @gisvlasta - Added initializers and provided a new get only CodeSpace implementation.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:element name="LocalName" type="gml:CodeType" substitutionGroup="gco:AbstractGenericName"/>
// <xs:complexType name="LocalName_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gco:LocalName"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.BasicTypes;
using NDSH.Hashing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Common.BasicTypes.Implementation.Names {

  /// <summary>
  /// Represents an unqualified, context-dependent name as defined in ISO 19115.
  /// </summary>
  /// <remarks>
  /// A <see cref="LocalName"/> is a simple identifier that does not include any explicit namespace.
  /// It is used within metadata structures where the namespace is inferred from the surrounding context.
  /// <br></br>
  /// Therefore the <see cref="CodeSpace"/> value of a <see cref="LocalName"/> is always <see langword="null"/>.
  /// <br></br>
  /// This class aligns with the ISO 19103 conceptual schema, where <see cref="LocalName"/> forms the base
  /// of structured naming within geographic metadata.
  /// </remarks>
  //[XmlType("LocalName", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("LocalName")]
  public class LocalName : GenericName, IComparable<LocalName>, IEquatable<LocalName> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LocalName"/>.
    /// </summary>
    public LocalName() {

    }

    /// <summary>
    /// Initializes the <see cref="LocalName"/>.
    /// </summary>
    /// <param name="name">
    /// The name used to set the <see cref="CodeType.Value">Value</see> of the <see cref="LocalName"/>.
    /// </param>
    public LocalName(string name) {
      Value = name;
    }

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets always the <see langword="null"/> value, since the <see cref="LocalName"/> is an unqualified
    /// context-dependent name, (a simple identifier), that does not include any explicit namespace.
    /// </summary>
    public new string? CodeSpace => null;

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="LocalName"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="LocalName"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(LocalName? other) {
      return
        other is null ? 1 :
        Value?.CompareTo(other.Value) ?? 1;
    }

    /// <inheritdoc />
    public override int CompareTo(CodeType? other) {
      return CompareTo(other as LocalName);
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="LocalName"/> is equal to the current <see cref="LocalName"/>.
    /// </summary>
    /// <param name="other">The <see cref="LocalName"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(LocalName? other) {
      return other != null &&
         Equals(Value, other.Value);
    }

    /// <inheritdoc />
    public override bool Equals(CodeType? other) {
      return Equals(other as LocalName);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="LocalName"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as LocalName);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="LocalName"/> using <see cref="NdshHashCode"/>.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      hash.Add(Value);

      return hash.ToHashCode();
    }

    #endregion

  }

}
