
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 03/01/2023, @gisvlasta
// History           : 12/03/2025, @gisvlasta - Updated code, documentation, and header.
//                   : 15/03/2025, @gisvlasta - Added Uri validation and the IsoTypeAttribute.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="CodeType">
//   <annotation>
//     <documentation>
//       gml:CodeType is a generalized type to be used for a term, keyword or name.
//       It adds a XML attribute codeSpace to a term, where the value of the codeSpace attribute (if present)
//       shall indicate a dictionary, thesaurus, classification scheme, authority, or pattern for the term.
//     </documentation>
//   </annotation>
//   <simpleContent>
//     <extension base="string">
//       <attribute name="codeSpace" type="anyURI"/>
//     </extension>
//   </simpleContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Database.Entities;
using NDSH.Geospatial.Metadata;
using NDSH.Hashing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.BasicTypes {

  // WARNING: Rename from CodeType to Code.

  /// <summary>
  /// The <see cref="CodeType"/> is a generalized type to be used for a term, keyword or name.
  /// It adds a XML attribute codeSpace to a term, where the value of the codeSpace
  /// attribute (if present) shall indicate a dictionary, thesaurus, classification scheme,
  /// authority, or pattern for the term.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>CodeType</c> ( /2005/gml/gmlBase.xsd )
  /// </remarks>
  //[XmlInclude(typeof(CodeWithAuthorityType))]
  [IsoType("CodeType", IsoType = IsoTypes.ComplexType)]
  //[XmlType("CodeType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CodeType")]
  public class CodeType : ObservableDbEntity,
    INullableCodeSpace,
    INullableRefValue<string>,
    IComparable<CodeType>,
    IEquatable<CodeType> {

    #region ICodeSpace Interface

    private string? _codeSpace;

    /// <summary>
    /// Gets or sets the URI reference to the code space authority.
    /// This property is required and must be a valid URI,
    /// ensuring compliance with metadata schema definitions.
    /// </summary>
    //[XmlAttribute(AttributeName = "codeSpace", DataType = "anyURI")]
    // WARNING: This property performs the validation in the setter; however, it may need to use a validation library. (Attribute or Fluent based)
    [JsonProperty("codeSpace")]
    public string? CodeSpace {
      get => _codeSpace;
      set {
        if (!Uri.IsWellFormedUriString(value, UriKind.RelativeOrAbsolute)) {
          throw new UriFormatException($"The provided '{nameof(CodeSpace)}' value is not a valid URI."); // RESOURCE
        }
        SetProperty(ref _codeSpace, value);
      }
    }

    #endregion

    #region INullableRefValue<T> Interface

    private string? _value;

    /// <summary>
    /// Gets or sets the value associated with a metadata entity.
    /// This property is designed for XML and JSON serialization and represents
    /// a standardized textual representation of geospatial metadata values.
    /// </summary>
    //[XmlText]
    [JsonProperty("Value")]
    public string? Value {
      get => _value;
      set => SetProperty(ref _value, value);
    }

    #endregion

    #region IComparable<T> Interface

    /// <summary>
    /// Compares this instance to another <see cref="CodeType"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="CodeType"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public virtual int CompareTo(CodeType? other) {
      int result;

      return
        (other is null) ? 1 :
        (result = CodeSpace?.CompareTo(other.CodeSpace) ?? 1) != 0 ? result :
        Value?.CompareTo(other.Value) ?? 1;
    }

    #endregion

    #region IEquatable<T> Interface

    /// <summary>
    /// Determines whether the <see cref="CodeType"/> is equal to the current <see cref="CodeType"/>.
    /// </summary>
    /// <param name="other">The <see cref="CodeType"/> to compare.</param>
    /// <returns>
    /// <see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.
    /// </returns>
    public virtual bool Equals(CodeType? other) {
      return other != null &&
        Equals(CodeSpace, other.CodeSpace) &&
        Equals(Value, other.Value);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="CodeType"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns>
    /// <see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.
    /// </returns>
    public override bool Equals(object? obj) => Equals(obj as CodeType);

    /// <summary>
    /// Gets the hash code for the <see cref="CodeType"/> using <see cref="NdshHashCode"/>.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      hash.Add(CodeSpace);
      hash.Add(Value);

      return hash.ToHashCode();
    }

    #endregion

  }

}
