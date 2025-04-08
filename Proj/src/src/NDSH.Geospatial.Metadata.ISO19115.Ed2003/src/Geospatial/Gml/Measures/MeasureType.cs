
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 21/12/2022, @gisvlasta
// History           : 27/02/2025, @gisvlasta - Changed inheritance, refactored code, and updated the documentation.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="MeasureType">
//   <simpleContent>
//     <extension base="double">
//       <attribute name="uom" type="gml:UomIdentifier" use="required"/>
//     </extension>
//   </simpleContent>
// </complexType>
// <simpleType name="UomIdentifier">
//   <annotation>
//     <documentation>
//       The simple type gml:UomIdentifer defines the syntax and value space of the unit of measure identifier.
//     </documentation>
//   </annotation>
//   <union memberTypes="gml:UomSymbol gml:UomURI"/>
// </simpleType>
// <simpleType name="UomSymbol">
//   <annotation>
//     This type specifies a character string of length at least one, and restricted such that it must not
//     contain any of the following characters: “:” (colon), “ “ (space), (newline), (carriage return), (tab).
//     This allows values corresponding to familiar abbreviations, such as “kg”, “m/s”, etc. 
//     It is recommended that the symbol be an identifier for a unit of measure as specified in the
//     “Unified Code of Units of Measure" (UCUM) (http://aurora.regenstrief.org/UCUM).
//     This provides a set of symbols and a grammar for constructing identifiers for units of measure that are unique,
//     and may be easily entered with a keyboard supporting the limited character set known as 7-bit ASCII.
//     ISO 2955 formerly provided a specification with this scope, but was withdrawn in 2001.
//     UCUM largely follows ISO 2955 with modifications to remove ambiguities and other problems.
//   </annotation>
//   <restriction base="string">
//     <pattern value="[^: \n\r\t]+"/>
//   </restriction>
// </simpleType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Database.Entities;
using NDSH.Hashing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Measures {

  #region XmlIncludes
  //[XmlInclude(typeof(AngleType))]
  //[XmlInclude(typeof(SpeedType))]
  //[XmlInclude(typeof(VolumeType))]
  //[XmlInclude(typeof(AreaType))]
  //[XmlInclude(typeof(GridLengthType))]
  //[XmlInclude(typeof(TimeType))]
  //[XmlInclude(typeof(ScaleType))]
  //[XmlInclude(typeof(LengthType))]
  #endregion

  /// <summary>
  /// Represents the GML <c>MeasureType</c> as defined in 
  /// <see href="http://www.opengis.net/gml">GML</see> specification.
  /// This class stores a numeric <see cref="Value"/> measurement along with a mandatory
  /// <see cref="UnitOfMeasure"/> identifier.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     In the underlying schema (<c>/2005/gml/basicTypes.xsd</c>), <see cref="MeasureType"/>
  ///     is an extension of <see cref="double"/> that requires a <see cref="UnitOfMeasure"/> (<c>uom</c>) attribute.
  ///     By inheriting from <see cref="ObservableDbEntity"/>, any changes to <see cref="UnitOfMeasure"/> or
  ///     <see cref="Value"/> trigger property change notifications, aiding in data binding and persistence.
  ///   </para>
  ///   <para>
  ///     The <see cref="UnitOfMeasure"/> property is recommended to follow the
  ///     <b>Unified Code for Units of Measure (UCUM)</b>, ensuring a standardized
  ///     format (e.g., “kg”, “m/s”) that avoids restricted characters 
  ///     (<c>:</c>, <c>' '</c>, <c>\n</c>, <c>\r</c>, <c>\t</c>).
  ///     The <see cref="Value"/> property holds the numerical quantity,
  ///     in line with the GML <c>double</c> base type.
  ///   </para>
  /// </remarks>
  //[Serializable]
  //[XmlType("MeasureType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("MeasureType")]
  public class MeasureType : ObservableDbEntity, IComparable<MeasureType>, IEquatable<MeasureType> {

    #region Public Properties

    private string _unitOfMeasure;

    /// <summary>
    /// Gets/Sets a character string of length at least one,
    /// and restricted such that it must not contain any of the following characters:
    /// <list type="bullet">
    ///   <item><c>:</c> (colon)</item>
    ///   <item><c>' '</c> (space)</item>
    ///   <item><c>\n</c> (newline)</item>
    ///   <item><c>\r</c> (carriage return)</item>
    ///   <item><c>\t</c> (tab)</item>
    /// </list>
    /// This allows values corresponding to familiar abbreviations, such as 'kg', 'm/s', etc. 
    /// </summary>
    /// <remarks>
    /// It is recommended that the symbol be an identifier for a unit of measure as specified in the
    /// 
    /// <b><see href="http://aurora.regenstrief.org/UCUM">'Unified Code of Units of Measure' (UCUM)</see></b>.
    /// <br></br>
    /// This provides a set of symbols and a grammar for constructing identifiers for units of measure that are unique,
    /// and may be easily entered with a keyboard supporting the limited character set known as <b>7-bit ASCII</b>.
    /// <br></br>
    /// <b>ISO 2955</b> formerly provided a specification with this scope, but was withdrawn in 2001.
    /// <b>UCUM</b> largely follows <b>ISO 2955</b> with modifications to remove ambiguities and other problems.
    /// </remarks>
    //[XmlAttribute("uom")]
    [JsonProperty("uom")]
    // WARNING: This needs to implement the pattern <pattern value="[^: \n\r\t]+"/>
    public string UnitOfMeasure { // TODO: Make sure that UoM is a UoMIdentifier etc.
      get => _unitOfMeasure;
      set => SetProperty(ref _unitOfMeasure, value);
    }

    private double _value;

    /// <summary>
    /// Gets/Sets the value.
    /// </summary>
    //[XmlText(DataType = "double")]
    [JsonProperty("Value")]
    public double Value {
      get => _value;
      set => SetProperty(ref _value, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="MeasureType"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="MeasureType"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(MeasureType? other) {
      int result;

      return
        (other is null) ? 1 :
        (result = Value.CompareTo(other.Value)) != 0 ? result :
        UnitOfMeasure.CompareTo(other.UnitOfMeasure);
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="MeasureType"/> is equal to the current <see cref="MeasureType"/>.
    /// </summary>
    /// <param name="other">The <see cref="MeasureType"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(MeasureType? other) {
      return other != null &&
         Value == other.Value &&
         UnitOfMeasure == other.UnitOfMeasure;
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="MeasureType"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as MeasureType);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="MeasureType"/> using <see cref="NdshHashCode"/>.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();
      hash.Add(Value);
      hash.Add(UnitOfMeasure);
      return hash.ToHashCode();
    }

    #endregion

  }

}
