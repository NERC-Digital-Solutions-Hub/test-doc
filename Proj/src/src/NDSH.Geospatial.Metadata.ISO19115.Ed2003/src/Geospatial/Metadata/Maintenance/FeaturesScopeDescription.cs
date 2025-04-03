
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
  /// <see cref="FeaturesScopeDescription"/> holds the scope description of
  /// the instances of feature types to which the information applies.
  /// </summary>
  public class FeaturesScopeDescription : MD_ScopeDescription_Type,
    IComparable<FeaturesScopeDescription>,
    IEquatable<FeaturesScopeDescription> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="FeatureInstancesScopeDescription"/>.
    /// </summary>
    public FeaturesScopeDescription() {
      _features = default;
    }

    #endregion

    #region Public Properties

    private HashSet<GF_FeatureType>? _features;

    /// <summary>
    /// Instances of feature types to which the information applies.
    /// </summary>
    // TODO: OBL - C
    // TODO: CAR - 1
    //[XmlElement("features", typeof(ReferencedObject), Order = 0)]
    [JsonProperty("features", Order = 0)]
    public HashSet<GF_FeatureType>? Features {
      get => _features;
      set => SetProperty(ref _features, value);
    }

    #endregion

    #region IComparable<T> Interface

    /// <summary>
    /// Compares this instance to another <see cref="FeaturesScopeDescription"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="FeaturesScopeDescription"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(FeaturesScopeDescription? other) =>
      (other is null) ? 1 : 1; //Features?.SetEquals(other.Features) ?? 1;

    /// <inheritdoc />
    public override int CompareTo(MD_ScopeDescription_Type? other) =>
      CompareTo(other as FeaturesScopeDescription);

    #endregion

    #region IEquatable<T> Interface

    /// <summary>
    /// Determines whether the <see cref="FeaturesScopeDescription"/>
    /// is equal to the current <see cref="FeaturesScopeDescription"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="FeaturesScopeDescription"/> to compare.</param>
    /// <returns>
    /// <see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.
    /// </returns>
    public bool Equals(FeaturesScopeDescription? other) =>
      other != null && Equals(Features, other.Features);

    /// <inheritdoc />
    public override bool Equals(MD_ScopeDescription_Type? other) =>
      Equals(other as FeaturesScopeDescription);

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/>
    /// is equal to the current <see cref="FeaturesScopeDescription"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns>
    /// <see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.
    /// </returns>
    public override bool Equals(object? obj) =>
      Equals(obj as FeaturesScopeDescription);

    /// <summary>
    /// Gets the hash code for the <see cref="FeaturesScopeDescription"/> using <see cref="NdshHashCode"/>. 
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();
      //hash.Add(Features);

      return hash.ToHashCode();
    }

    #endregion

  }

}
