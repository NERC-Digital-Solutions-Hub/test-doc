
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
  /// <see cref="FeatureInstancesScopeDescription"/> holds the scope description of
  /// the feature instances to which the information applies.
  /// </summary>
  public class FeatureInstancesScopeDescription : MD_ScopeDescription_Type,
    IComparable<FeatureInstancesScopeDescription>,
    IEquatable<FeatureInstancesScopeDescription> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="FeatureInstancesScopeDescription"/>.
    /// </summary>
    public FeatureInstancesScopeDescription() {
      _featureInstances = default;
    }

    #endregion

    #region Public Properties

    private HashSet<GF_FeatureType>? _featureInstances;

    /// <summary>
    /// Feature instances to which the information applies.
    /// </summary>
    // TODO: OBL - C
    // TODO: CAR - 1
    //[XmlElement("featureInstances", typeof(ReferencedObject), Order = 0)]
    [JsonProperty("featureInstances", Order = 0)]
    public HashSet<GF_FeatureType>? FeatureInstances {
      get => _featureInstances;
      set => SetProperty(ref _featureInstances, value);
    }

    #endregion

    #region IComparable<T> Interface

    /// <summary>
    /// Compares this instance to another <see cref="FeatureInstancesScopeDescription"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="FeatureInstancesScopeDescription"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(FeatureInstancesScopeDescription? other) =>
      (other is null) ? 1 : 1; //FeatureInstances?.SetEquals(other.FeatureInstances) ?? 1;

    /// <inheritdoc />
    public override int CompareTo(MD_ScopeDescription_Type? other) =>
      CompareTo(other as FeatureInstancesScopeDescription);

    #endregion

    #region IEquatable<T> Interface

    /// <summary>
    /// Determines whether the <see cref="FeatureInstancesScopeDescription"/>
    /// is equal to the current <see cref="FeatureInstancesScopeDescription"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="FeatureInstancesScopeDescription"/> to compare.</param>
    /// <returns>
    /// <see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.
    /// </returns>
    public bool Equals(FeatureInstancesScopeDescription? other) =>
      other != null && Equals(FeatureInstances, other.FeatureInstances);

    /// <inheritdoc />
    public override bool Equals(MD_ScopeDescription_Type? other) =>
      Equals(other as FeatureInstancesScopeDescription);

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="FeatureInstancesScopeDescription"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as FeatureInstancesScopeDescription);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="FeatureInstancesScopeDescription"/> using <see cref="NdshHashCode"/>. 
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();
      //hash.Add(FeatureInstances);
      return hash.ToHashCode();
    }

    #endregion

  }

}
