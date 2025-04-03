
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 11/03/2025, @gisvlasta
// History           : 14/03/2025, @gisvlasta - Updated inheritance from IValue2 to IValue<T>
//                   : 16/03/2025, @gisvlasta - Added IsoTypeAttribute, and updated documentation.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <simpleType name="UomSymbol">
//   <annotation>
//     <documentation>
//       This type specifies a character string of length at least one, and restricted such that
//       it must not contain any of the following characters:
//       “:” (colon), “ “ (space), (newline), (carriage return), (tab).
//       This allows values corresponding to familiar abbreviations, such as “kg”, “m/s”, etc.
//       It is recommended that the symbol be an identifier for a unit of measure as specified
//       in the “Unified Code of Units of Measure" (UCUM) (http://aurora.regenstrief.org/UCUM).
//       This provides a set of symbols and a grammar for constructing identifiers for units of measure
//       that are unique, and may be easily entered with a keyboard supporting the limited character set
//       known as 7-bit ASCII. ISO 2955 formerly provided a specification with this scope,
//       but was withdrawn in 2001. UCUM largely follows ISO 2955 with modifications to remove
//       ambiguities and other problems.
//     </documentation>
//   </annotation>
//   <restriction base="string">
//     <pattern value="[^: \n\r\t]+"/>
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
using static System.Net.WebRequestMethods;

#endregion

namespace NDSH.Geospatial.Gml.BasicTypes {

  /// <summary>
  /// Represents a <b>Unit of Measure Symbol</b> following the
  /// <see href="https://ucum.org/ucum">"Unified Code of Units of Measure" (UCUM)</see> standard.
  /// </summary>
  /// <remarks>
  /// A <b>valid UOM symbol</b> must:
  /// <list type="bullet">
  ///   <item>Be at least one <see cref="char"/> long.</item>
  ///   <item>Not contain spaces, colons (`:`), newlines, carriage returns, or tabs.</item>
  ///   <item>Follow UCUM conventions (e.g., "kg", "m/s").</item>
  /// </list>
  /// </remarks>
  /// <seealso href="http://aurora.regenstrief.org/UCUM">
  /// Unified Code of Units of Measure (UCUM)
  /// </seealso>
  [IsoType("UomSymbol", IsoType = IsoTypes.SimpleType)]
  [JsonObject("UomSymbol")]
  public partial class UomSymbol : ObservableDbEntity, IValue<string> {

    private static readonly Regex SymbolPattern = UomSymbolRegex();

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="UomSymbol"/>.
    /// </summary>
    public UomSymbol() {

    }

    /// <summary>
    /// Initializes the <see cref="UomSymbol"/>.
    /// </summary>
    /// <param name="value">The <see cref="string"/> UOM Symbol value.</param>
    public UomSymbol(string value) {
      this.Value = value;
    }

    #endregion

    #region IValue<T> Interface

    private string _value;

    /// <summary>
    /// Gets/Sets the <b>Unit of Measure (UOM) Symbol</b>.
    /// </summary>
    /// <remarks>
    /// This property ensures that the value conforms to:<br></br>
    /// <b>The UOM symbol pattern</b> defined in <see cref="UomSymbol"/>
    /// </remarks>
    /// <exception cref="ArgumentException">
    /// Thrown when the value does not match the <b>UOM Symbol</b> format.
    /// </exception>
    public required string Value {
      get => _value;
      set {
        if (string.IsNullOrWhiteSpace(value) || !UomSymbol.IsValid(value)) {
          throw new ArgumentException($"Invalid UOM Symbol: {value}.", nameof(Value)); // RESOURCE
        }
        SetProperty(ref _value, value);
      }
    }

    #endregion

    /// <summary>
    /// Checks whether a <see cref="string"/> is a valid UOM symbol or not.
    /// </summary>
    /// <param name="value">The <see cref="string"/> to validate.</param>
    /// <returns>
    /// A <see cref="bool"/> indicating whether the UOM symbol is valid or not.
    /// </returns>
    public static bool IsValid(string value) => SymbolPattern.IsMatch(value);

    /// <summary>
    /// Provides a pre-compiled <see cref="Regex"/> used to validate
    /// a <see cref="string"/> for <see cref="UomSymbol"/> conformance.
    /// </summary>
    /// <returns>
    /// A <see cref="Regex"/> to validate a <see cref="string"/> for <see cref="UomSymbol"/> conformance.
    /// </returns>
    [GeneratedRegex(@"^[^: \n\r\t]+$", RegexOptions.Compiled)]
    private static partial Regex UomSymbolRegex();

  }

}
