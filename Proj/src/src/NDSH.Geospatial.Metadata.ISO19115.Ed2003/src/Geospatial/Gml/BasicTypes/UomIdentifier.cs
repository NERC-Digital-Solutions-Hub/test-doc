
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
// <simpleType name="UomIdentifier">
//   <annotation>
//     <documentation>
//       The simple type gml:UomIdentifer defines the syntax and value space of the unit of measure identifier.
//     </documentation>
//   </annotation>
//   <union memberTypes="gml:UomSymbol gml:UomURI"/>
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
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.BasicTypes {

  /// <summary>
  /// The <see cref="UomIdentifier"/> defines the syntax and value space of the unit of measure identifier.
  /// Represents a <b>Unit of Measure (UOM) Identifier</b> in GML.
  /// </summary>
  /// <remarks>
  /// The <see cref="UomIdentifier"/> class defines a <b>union</b> of two possible representations:
  /// <list type="bullet">
  ///   <item>
  ///     A <b>conventional unit symbol</b> (e.g., "kg", "m/s") following the
  ///     <see href="https://ucum.org/ucum">"The Unified Code for Units of Measure" (UCUM)</see> standard.
  ///   </item>
  ///   <item>A <b>URI reference</b> to a unit of measure definition.</item>
  /// </list>
  /// This allows either a <b>symbolic representation</b> or a <b>reference-based representation</b>>.
  /// </remarks>
  [IsoType("UomIdentifier")]
  [JsonObject("UomIdentifier")]
  public class UomIdentifier : ObservableDbEntity, IValue<string> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="UomIdentifier"/>.
    /// </summary>
    public UomIdentifier() {

    }

    /// <summary>
    /// Initializes the <see cref="UomIdentifier"/>.
    /// </summary>
    /// <param name="value">A valid UOM symbol or URI.</param>
    public UomIdentifier(string value) {
      Value = value;
    }

    /// <summary>
    /// Initializes the <see cref="UomIdentifier"/>.
    /// </summary>
    /// <param name="uomSymbol">
    /// The <see cref="UomSymbol"/> used to create the <see cref="UomIdentifier"/>.
    /// </param>
#pragma warning disable CS8601
    public UomIdentifier(UomSymbol uomSymbol) {
      _ = SetProperty(ref _value, uomSymbol.Value, nameof(Value));
    }
#pragma warning restore

    /// <summary>
    /// Initializes the <see cref="UomIdentifier"/>.
    /// </summary>
    /// <param name="uomUri">
    /// The <see cref="UomUri"/> used to create the <see cref="UomIdentifier"/>.
    /// </param>
#pragma warning disable CS8601
    public UomIdentifier(UomUri uomUri) {
      _ = SetProperty(ref _value, uomUri.Value, nameof(Value));
    }
#pragma warning restore

    #endregion

    #region IValue<T> Interface

    private string _value;

    /// <summary>
    /// Gets/Sets the <b>Unit of Measure (UOM) identifier</b>, which can be either:
    /// <list type="bullet">
    ///   <item>A <b>UOM symbol</b> (e.g., "kg", "m/s").</item>
    ///   <item>A <b>UOM URI reference</b> (e.g., "http://example.com/unit").</item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// This property ensures that the value conforms to either:
    /// <list type="bullet">
    ///   <item><b>The UOM Symbol pattern</b> defined in <see cref="UomSymbol"/>.</item>
    ///   <item><b>The URI pattern</b> defined in <see cref="UomUri"/>.</item>
    /// </list>
    /// </remarks>
    [JsonProperty("value")]
    public required string Value {
      get => _value;
      set => SetValue(value);
    }

    #endregion

    #region Private Methods

    /// <summary>
    /// Sets the <b>Unit of Measure (UOM) identifier</b>, which can be either:
    /// <list type="bullet">
    ///   <item>A <b>UOM symbol</b> (e.g., "kg", "m/s").</item>
    ///   <item>A <b>UOM URI reference</b> (e.g., "http://example.com/unit").</item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// The method ensures that the value conforms to either:
    /// <list type="bullet">
    ///   <item><b>The UOM Symbol pattern</b> defined in <see cref="UomSymbol"/>.</item>
    ///   <item><b>The URI pattern</b> defined in <see cref="UomUri"/>.</item>
    /// </list>
    /// </remarks>
    /// <exception cref="ArgumentException">
    /// Thrown when the value does not match either the <b>UOM Symbol</b> or <b>UOM URI</b> format.
    /// </exception>
    private void SetValue(string value) {
      if (string.IsNullOrWhiteSpace(value) || (!UomSymbol.IsValid(value) && !UomUri.IsValid(value))) {
        throw new ArgumentException(
          $"Invalid UOM Identifier: {value}. Must be a valid UOM symbol or URI.", nameof(value)
        ); // RESOURCE
      }
      SetProperty(ref _value, value);
    }

    #endregion

  }

}
