
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

using NDSH.Geospatial.Metadata.Features.Model;
using NDSH.Hashing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.Maintenance {

  /// <summary>
  /// <see cref="AttributeInstancesScopeDescription"/> holds the scope description of
  /// attribute instances to which the information applies.
  /// </summary>
  public class AttributeInstancesScopeDescription : MD_ScopeDescription_Type,
    IComparable<AttributeInstancesScopeDescription>,
    IEquatable<AttributeInstancesScopeDescription> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AttributeInstancesScopeDescription"/>.
    /// </summary>
    public AttributeInstancesScopeDescription() {
      _attributeInstances = default;
    }

    #endregion

    #region Public Properties

    private HashSet<GF_AttributeType>? _attributeInstances;

    /// <summary>
    /// Attribute instances to which the information applies.
    /// </summary>
    // TODO: OBL - C
    // TODO: CAR - 1
    //[XmlElement("attributeInstances", typeof(ReferencedObject), Order = 0)]
    [JsonProperty("attributeInstances", Order = 0)]
    public HashSet<GF_AttributeType>? AttributeInstances {
      get => _attributeInstances;
      set => SetProperty(ref _attributeInstances, value);
    }

    #endregion

    #region IComparable<T> Interface

    /// <summary>
    /// Compares this instance to another <see cref="AttributeInstancesScopeDescription"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="AttributeInstancesScopeDescription"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(AttributeInstancesScopeDescription? other) => (other is null) ? 1 : 1;

    /// <inheritdoc />
    public override int CompareTo(MD_ScopeDescription_Type? other) =>
      CompareTo(other as AttributeInstancesScopeDescription);

    #endregion

    #region IEquatable<T> Interface

    /// <summary>
    /// Determines whether the <see cref="AttributeInstancesScopeDescription"/>
    /// is equal to the current <see cref="AttributeInstancesScopeDescription"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="AttributeInstancesScopeDescription"/> to compare.</param>
    /// <returns>
    /// <see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.
    /// </returns>
    public bool Equals(AttributeInstancesScopeDescription? other) =>
      other != null && Equals(AttributeInstances, other.AttributeInstances);

    /// <inheritdoc />
    public override bool Equals(MD_ScopeDescription_Type? other) =>
      Equals(other as AttributeInstancesScopeDescription);

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current
    /// <see cref="AttributeInstancesScopeDescription"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns>
    /// <see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.
    /// </returns>
    public override bool Equals(object? obj) {
      return Equals(obj as AttributeInstancesScopeDescription);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="AttributeInstancesScopeDescription"/> using <see cref="NdshHashCode"/>. 
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();
      //foreach (GF_AttributeType attribute in AttributeInstances.SafeOrderBy()) {
      //  hash.Add(attribute);
      //}
      return hash.ToHashCode();
    }

    #endregion

  }

}
