
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 11/03/2025, @gisvlasta
// History           : 16/03/2025, @gisvlasta - Added IsoTypeAttribute, and updated documentation.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <simpleType name="UomURI">
//   <annotation>
//     <documentation>
//       This type specifies a URI, restricted such that it must start with one of the following sequences:
//       “#”, “./”, “../”, or a string of characters followed by a “:”.
//       These patterns ensure that the most common URI forms are supported, including absolute and relative URIs
//       and URIs that are simple fragment identifiers, but prohibits certain forms of relative URI
//       that could be mistaken for unit of measure symbol.
//       NOTE  It is possible to re-write such a relative URI to conform to the restriction (e.g. “./m/s”).
//       In an instance document, on elements of type gml:MeasureType the mandatory uom attribute
//       shall carry a value corresponding to either
//         - a conventional unit of measure symbol,
//         - a link to a definition of a unit of measure that does not have a conventional symbol,
//           or when it is desired to indicate a precise or variant definition.
//     </documentation>
//   </annotation>
//   <restriction base="anyURI">
//     <pattern value="([a-zA-Z][a-zA-Z0-9\-\+\.]*:|\.\./|\./|#).*"/>
//   </restriction>
// </simpleType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Database.Entities;
using NDSH.Geospatial.Metadata;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.BasicTypes {

  /// <summary>
  /// Represents a <b>URI-based Unit of Measure Identifier</b>.
  /// </summary>
  /// <remarks>
  /// A <b>valid UOM URI</b> must start with one of the following:
  /// <list type="bullet">
  ///   <item><term><c>"#"</c></term><description> (fragment identifier).</description></item>
  ///   <item><term><c>"./"</c> or <c>"../"</c></term><description> (relative path).</description></item>
  ///   <item>A <b>scheme name</b> followed by <c>":"</c> (e.g., "http:", "urn:", "ftp:").</item>
  /// </list>
  /// This ensures compatibility with <b>absolute and relative URIs</b>.
  /// </remarks>
  [IsoType("UomURI", IsoType = IsoTypes.SimpleType)]
  [JsonObject("UomURI")]
  public partial class UomUri : ObservableDbEntity, IValue<string> {

    private static readonly Regex UriPattern = UomUriRegex();

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="UomUri"/>.
    /// </summary>
    public UomUri() {

    }

    /// <summary>
    /// Initializes the <see cref="UomUri"/>.
    /// </summary>
    /// <param name="value">The <see cref="string"/> UOM URI value.</param>
    public UomUri(string value) {
      this.Value = value;
    }

    #endregion

    #region IValue<T> Interface

    private string _value;

    /// <summary>
    /// Gets/Sets the <b>Unit of Measure (UOM) URI</b>.
    /// </summary>
    /// <remarks>
    /// This property ensures that the value conforms to:<br></br>
    /// <b>The UOM URI pattern</b> defined in <see cref="UomUri"/>
    /// </remarks>
    /// <exception cref="ArgumentException">
    /// Thrown when the value does not match the <b>UOM URI</b> format.
    /// </exception>
    public required string Value {
      get => _value;
      set {
        if (string.IsNullOrWhiteSpace(value) || !UomUri.IsValid(value)) {
          throw new ArgumentException($"Invalid UOM URI: {value}.", nameof(Value)); // RESOURCE
        }
        SetProperty(ref _value, value);
      }
    }

    #endregion

    /// <summary>
    /// Checks whether a <see cref="string"/> is a valid UOM URI or not.
    /// </summary>
    /// <param name="value">The <see cref="string"/> to validate.</param>
    /// <returns>
    /// A <see cref="bool"/> indicating whether the UOM URI is valid or not.
    /// </returns>
    public static bool IsValid(string value) => UriPattern.IsMatch(value);

    /// <summary>
    /// Provides a pre-compiled <see cref="Regex"/> used to validate
    /// a <see cref="string"/> for <see cref="UomUri"/> conformance.
    /// </summary>
    /// <returns>
    /// A <see cref="Regex"/> to validate a <see cref="string"/> for <see cref="UomUri"/> conformance.
    /// </returns>
    [GeneratedRegex(@"^([a-zA-Z][a-zA-Z0-9\-\+\.]*:|\.\./|\./|#).*", RegexOptions.Compiled)]
    private static partial Regex UomUriRegex();

  }

}
