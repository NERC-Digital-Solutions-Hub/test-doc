
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 13/03/2025, @pigeowatcher
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial {

  /// <summary>
  /// Extension methods for <see cref="IEnumerable{T}"/>.
  /// </summary>
  public static class EnumerableExtensions {

    /// <summary>
    /// Compares two sequences by ordering them using <see cref="IComparable{T}"/>,
    /// and then comparing for equality using
    /// <see cref="System.Linq.Enumerable.SequenceEqual{TSource}(IEnumerable{TSource}, IEnumerable{TSource})"/>
    /// <br></br>
    /// If either sequence is null, it is treated as an empty collection.
    /// </summary>
    /// <typeparam name="T">The <see cref="Type"/> of elements in the sequences.</typeparam>
    /// <param name="first">The first sequence to compare.</param>
    /// <param name="second">The second sequence to compare.</param>
    public static bool SequenceEqualOrdered<T>(
      this IEnumerable<T>? first, IEnumerable<T>? second
    ) where T : IComparable<T> {

      IEnumerable<T> firstOrdered = first.SafeOrderBy();
      IEnumerable<T> secondOrdered = second.SafeOrderBy();

      return firstOrdered.SequenceEqual(secondOrdered);

    }

    /// <summary>
    /// Orders the elements of a sequence in ascending order using <see cref="IComparable{T}"/>,
    /// and returns an empty collection if the source is null.
    /// </summary>
    /// <typeparam name="T">The <see cref="Type"/> of the elements in the <see cref="IEnumerable{T}"/>.</typeparam>
    /// <param name="source">The <see cref="IEnumerable{T}"/> to order.</param>
    /// <returns>The ordered <see cref="IEnumerable{T}"/>.</returns>
    public static IEnumerable<T> SafeOrderBy<T>(this IEnumerable<T>? source) where T : IComparable<T> =>
      (source ?? []).OrderBy(x => x);

  }

}
