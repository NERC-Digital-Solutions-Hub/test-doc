
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 21/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/gcoBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="CodeListValue_Type">
//   <xs:simpleContent>
//     <xs:extension base="xs:string">
//       <xs:attribute name="codeList" type="xs:anyURI" use="required"/>
//       <xs:attribute name="codeListValue" type="xs:anyURI" use="required"/>
//       <xs:attribute name="codeSpace" type="xs:anyURI"/>
//     </xs:extension>
//   </xs:simpleContent>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Hashing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata {

  /// <summary>
  /// Represents a specific value within a registered code list, ensuring standardized
  /// categorization and reference. This class implements multiple metadata interfaces
  /// to provide comprehensive code list support as per the ISO 19115 metadata standard.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     The <see cref="CodeListValue_Type"/> class allows referencing an external code list value,
  ///     supporting interoperability across metadata systems. It provides attributes to store the
  ///     code list URI, the selected value within the list, and an optional code space.
  ///   </para>
  ///   <para>
  ///     <b>Considerations:</b>
  ///     <list type="bullet">
  ///       <item>
  ///         The <see cref="CodeList"/> and <see cref="CodeListValue"/> properties are required attributes.
  ///       </item>
  ///       <item>
  ///         The <see cref="CodeSpace"/> property is optional but recommended for unambiguous referencing.
  ///       </item>
  ///     </list>
  ///   </para>
  ///   <para>
  ///      Maps to: <c>CodeListValue_Type</c> ( /2005/gco/gcoBase.xsd )
  ///   </para>
  /// </remarks>
  [IsoType("CodeListValue_Type", IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("CodeListValue_Type")]
  public class CodeListValue_Type : CharacterString,
    ICodeList,
    ICodeListValue,
    INullableCodeSpace,
    IComparable<CodeListValue_Type>,
    IEquatable<CodeListValue_Type> {

    #region ICodeList Interface

    private string _codeList = null!;

    /// <summary>
    /// Gets/Sets the URI reference to the external code list.
    /// This property is required and ensures compliance with the metadata schema.
    /// </summary>
    /// <exception cref="ArgumentException">
    /// Thrown when the property is set to <see langword="null"/> or whitespace.
    /// </exception>
    //[XmlAttribute(AttributeName = "codeList", DataType = "anyURI")]
    [JsonProperty("codeList")]
    [Required()] // TODO: Check out the RequiredAttribute and its arguments.
    public required string CodeList {
      get => _codeList;
      // TODO: SetProperty
      set {
        if (string.IsNullOrWhiteSpace(value)) {
          throw new ArgumentException("CodeList cannot be null or whitespace.", nameof(value)); // RESOURCE
        }
        if (_codeList != value) {
          _codeList = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

    #region ICodeListValue Interface

    private string _codeListValue = null!;

    /// <summary>
    /// Gets or sets the URI reference to a specific value in the external code list.
    /// This property is required and must be a valid URI.
    /// </summary>
    /// <exception cref="ArgumentException">
    /// Thrown when the property is set to <see langword="null"/> or whitespace.
    /// </exception>
    //[XmlAttribute(AttributeName = "codeListValue", DataType = "anyURI")]
    [JsonProperty("codeListValue")]
    [Required()] // TODO: Check out the RequiredAttribute and its arguments.
    public required string CodeListValue {
      get => _codeListValue;
      // TODO: SetProperty
      set {
        if (string.IsNullOrWhiteSpace(value)) {
          //throw new ArgumentException("CodeList cannot be null or whitespace.", nameof(value)); // RESOURCE
        }
        if (_codeListValue != value) {
          _codeListValue = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

    #region ICodeSpace Interface

    private string? _codeSpace;

    /// <summary>
    /// Gets or sets the URI reference for the code space, defining the authority for the code list.
    /// This property is optional but recommended for metadata traceability.
    /// </summary>
    //[XmlAttribute(AttributeName = "codeSpace", DataType = "anyURI")]
    [JsonProperty("codeSpace")]
    public string? CodeSpace {
      get => _codeSpace;
      // TODO: SetProperty
      set {
        if (_codeSpace != value) {
          _codeSpace = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="CodeListValue_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="CodeListValue_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(CodeListValue_Type? other) {
      int result;

      return
        other is null ? 1 :
        (result = base.CompareTo(other)) != 0 ? result :
        (result = GetType().Name.CompareTo(other.GetType().Name)) != 0 ? result :
        (result = string.Compare(CodeList, other.CodeList, StringComparison.Ordinal)) != 0 ? result :
        (result = string.Compare(CodeListValue, other.CodeListValue, StringComparison.Ordinal)) != 0 ? result :
        string.Compare(CodeSpace, other.CodeSpace, StringComparison.Ordinal);
    }

    public override int CompareTo(CharacterString? other) => CompareTo(other as CodeListValue_Type);

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="CodeListValue_Type"/>
    /// is equal to the current <see cref="CodeListValue_Type"/>.
    /// </summary>
    /// <param name="other">The <see cref="CodeListValue_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(CodeListValue_Type? other) {
      return other != null &&
             base.Equals(other) &&
             string.Equals(GetType().Name, other.GetType().Name, StringComparison.OrdinalIgnoreCase) &&
             CodeList == other.CodeList &&
             CodeListValue == other.CodeListValue &&
             CodeSpace == other.CodeSpace;
    }

    public override bool Equals(CharacterString? other) => Equals(other as CodeListValue_Type);

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="CodeListValue_Type"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) => Equals(obj as CodeListValue_Type);

    /// <summary>
    /// Gets the hash code for the <see cref="CodeListValue_Type"/> using <see cref="NdshHashCode"/>.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();
      hash.Add(base.GetHashCode());
      hash.Add(GetType().Name);
      hash.Add(CodeList);
      hash.Add(CodeListValue);
      hash.Add(CodeSpace);

      return hash.ToHashCode();
    }

    #endregion

  }

}
