﻿
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 24/03/2025, @gisvlasta
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
  /// Represents a typed wrapper around a URI <see cref="string"/> to ensure valid and well-formed URIs.
  /// </summary>
  public class UriReference {

    /// <summary>
    /// Initializes the <see cref="UriReference"/>.
    /// </summary>
    /// <param name="uri">The URI as a <see cref="string"/>.</param>
    /// <exception cref="ArgumentNullException">Thrown when the URI is null or whitespace.</exception>
    /// <exception cref="UriFormatException">Thrown when the URI is invalid.</exception>
    public UriReference(string uri) {
      if (string.IsNullOrWhiteSpace(uri)) {
        throw new ArgumentNullException(nameof(uri), "The URI value cannot be null or empty."); // RESOURCE
      }

      if (!Uri.IsWellFormedUriString(uri, UriKind.Absolute)) {
        throw new UriFormatException($"The value '{uri}' is not a well-formed absolute URI."); // RESOURCE
      }

      Value = new Uri(uri, UriKind.Absolute);
    }

    /// <summary>
    /// Gets the strongly-typed <see cref="Uri">URI</see> value.
    /// </summary>
    public Uri Value {
      get;
    }

    /// <summary>
    /// Implicit conversion from <see cref="UriReference"/> to <see cref="string"/>.
    /// </summary>
    public static implicit operator string(UriReference reference) => reference?.Value.ToString() ?? string.Empty;

    /// <summary>
    /// Implicit conversion from <see cref="string"/> to <see cref="UriReference"/>.
    /// </summary>
    public static implicit operator UriReference(string uri) => new(uri);

    /// <summary>
    /// Converts the <see cref="Value"/> of the <see cref="UriReference"/> to a <see cref="string"/>.
    /// </summary>
    /// <returns>A <see cref="string"/> with a valid URI.</returns>
    public override string ToString() => Value.ToString();

  }

}
