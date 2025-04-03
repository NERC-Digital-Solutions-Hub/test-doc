
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
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.Maintenance {

  /// <summary>
  /// <see cref="DatasetScopeDescription"/> holds the scope description of
  /// the dataset to which the information applies.
  /// </summary>
  public class DatasetScopeDescription : MD_ScopeDescription_Type,
    IComparable<DatasetScopeDescription>,
    IEquatable<DatasetScopeDescription> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DatasetScopeDescription"/>.
    /// </summary>
    public DatasetScopeDescription() {
      _dataset = default;
    }

    #endregion

    #region Public Properties

    private CharacterString? _dataset;

    /// <summary>
    /// Dataset to which the information applies.
    /// </summary>
    // TODO: OBL - C
    // TODO: CAR - 1
    //[XmlElement("dataset", typeof(CharacterString), Order = 0)]
    [JsonProperty("dataset", Order = 0)]
    public CharacterString? Dataset {
      get => _dataset;
      set => SetProperty(ref _dataset, value);
    }

    #endregion

    #region IComparable<T> Interface

    /// <summary>
    /// Compares this instance to another <see cref="DatasetScopeDescription"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="DatasetScopeDescription"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(DatasetScopeDescription? other) =>
      (other is null) ? 1 : Dataset?.CompareTo(other.Dataset) ?? 1;

    /// <inheritdoc />
    public override int CompareTo(MD_ScopeDescription_Type? other) =>
      CompareTo(other as DatasetScopeDescription);

    #endregion

    #region IEquatable<T> Interface

    /// <summary>
    /// Determines whether the <see cref="DatasetScopeDescription"/>
    /// is equal to the current <see cref="DatasetScopeDescription"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="DatasetScopeDescription"/> to compare.</param>
    /// <returns>
    /// <see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.
    /// </returns>
    public bool Equals(DatasetScopeDescription? other) =>
      other != null && Equals(Dataset, other.Dataset);

    /// <inheritdoc />
    public override bool Equals(MD_ScopeDescription_Type? other) =>
      Equals(other as DatasetScopeDescription);

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="DatasetScopeDescription"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as DatasetScopeDescription);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="DatasetScopeDescription"/> using <see cref="NdshHashCode"/>. 
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();
      hash.Add(Dataset);
      return hash.ToHashCode();
    }

    #endregion

  }

}
