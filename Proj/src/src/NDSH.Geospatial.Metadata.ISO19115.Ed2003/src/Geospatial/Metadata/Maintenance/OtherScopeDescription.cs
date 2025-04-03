
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 05/03/2025, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
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

#endregion

namespace NDSH.Geospatial.Metadata.Maintenance {

  /// <summary>
  /// <see cref="OtherScopeDescription"/> holds the scope description of the class
  /// of information that does not fall into the other categories to which the information applies.
  /// </summary>
  public class OtherScopeDescription : MD_ScopeDescription_Type,
    IComparable<OtherScopeDescription>,
    IEquatable<OtherScopeDescription> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="OtherScopeDescription"/>.
    /// </summary>
    public OtherScopeDescription() {
      _other = default;
    }

    #endregion

    #region Public Properties

    private CharacterString? _other;

    /// <summary>
    /// Class of information that does not fall into the other categories to which the information applies.
    /// </summary>
    // TODO: OBL - C
    // TODO: CAR - 1
    //[XmlElement("other", typeof(CharacterString), Order = 0)]
    [JsonProperty("other", Order = 0)]
    public CharacterString? Other {
      get => _other;
      set => SetProperty(ref _other, value);
    }

    #endregion

    #region IComparable<T> Interface

    /// <summary>
    /// Compares this instance to another <see cref="OtherScopeDescription"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="OtherScopeDescription"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(OtherScopeDescription? other) =>
      (other is null) ? 1 : Other?.CompareTo(other.Other) ?? 1;

    /// <inheritdoc />
    public override int CompareTo(MD_ScopeDescription_Type? other) =>
      CompareTo(other as OtherScopeDescription);

    #endregion

    #region IEquatable<T> Interface

    /// <summary>
    /// Determines whether the <see cref="OtherScopeDescription"/>
    /// is equal to the current <see cref="OtherScopeDescription"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="OtherScopeDescription"/> to compare.</param>
    /// <returns>
    /// <see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.
    /// </returns>
    public bool Equals(OtherScopeDescription? other) =>
      other != null && Equals(Other, other.Other);

    /// <inheritdoc />
    public override bool Equals(MD_ScopeDescription_Type? other) =>
      Equals(other as OtherScopeDescription);

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/>
    /// is equal to the current <see cref="OtherScopeDescription"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns>
    /// <see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.
    /// </returns>
    public override bool Equals(object? obj) =>
      Equals(obj as OtherScopeDescription);

    /// <summary>
    /// Gets the hash code for the <see cref="OtherScopeDescription"/> using <see cref="NdshHashCode"/>. 
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();
      hash.Add(Other);

      return hash.ToHashCode();
    }

    #endregion

  }

}
