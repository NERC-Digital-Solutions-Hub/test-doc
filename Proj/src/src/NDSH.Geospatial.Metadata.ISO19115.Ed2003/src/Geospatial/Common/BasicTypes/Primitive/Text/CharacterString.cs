
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 13/02/2023, @gisvlasta
// History           : 21/03/2025, @gisvlasta - Implemented INliReasoned interface, added IsoTypesAttribute,
//                      used SetProperty() method in the property setters, added comments in the implicit operators
//                      implementation, and added XML comments at the class level.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/basicTypes.xsd
// --------------------------------------------------------------------------------
// <xs:element name="CharacterString" type="xs:string"/>
// 
// <xs:complexType name="CharacterString_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gco:CharacterString"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Database.Entities;
using NDSH.Geospatial.Gml.BasicTypes;
using NDSH.Geospatial.Metadata;
using NDSH.Geospatial.Metadata.EntitySet;
using NDSH.Hashing;
using Newtonsoft.Json;

#endregion

namespace NDSH.Geospatial.Common.BasicTypes.Primitive.Text {

  /// <summary>
  /// The <see cref="CharacterString"/> is wrapper of a <see cref="string"/> which is used to
  /// represent textual information in a <see cref="MD_Metadata_Type"/> hierarchy, or database entity.
  /// The <see cref="CharacterString"/> allows to provide an <see cref="INilReason"/>
  /// if its <see cref="Value"/> is set to <see langword="null"/>.
  /// </summary>
  //[TypeConverter(typeof(CharacterString_PropertyTypeConverter))]
  //[XmlInclude(typeof(LanguageCodeProperty))]
  //[XmlInclude(typeof(LanguageCode_PropertyType))]
  //[XmlInclude(typeof(PT_FreeText_PropertyType))] // TODO: Check this include.
  [IsoType("CharacterString", WrapperName = "CharacterString_PropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlType("CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("CharacterString")]
  public class CharacterString : ObservableDbEntity,
    INullableRefValue<string>,
    INilReasoned,
    IComparable<CharacterString>,
    IEquatable<CharacterString> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CharacterString"/>.
    /// </summary>
    public CharacterString() {

    }

    /// <summary>
    /// Initializes the <see cref="CharacterString"/>.
    /// </summary>
    /// <param name="value">The <see cref="string"/> to set.</param>
    public CharacterString(string? value) {
      Value = value;
    }

    #endregion

    #region Operator Overloading

    /// <summary>
    /// Implicitly converts a <see cref="CharacterString"/> to a <see cref="string"/>.
    /// </summary>
    /// <param name="characterString">The <see cref="CharacterString"/> instance.</param>
    /// <returns>
    /// The <see cref="string"/> value contained within the <see cref="CharacterString"/>,
    /// or <see langword="null"/> if none exists.
    /// </returns>
    public static implicit operator string?(CharacterString characterString) => characterString.Value;

    /// <summary>
    /// Implicitly converts a <see cref="string"/> to a <see cref="CharacterString"/>.
    /// </summary>
    /// <param name="s">The <see cref="string"/> value to be converted.</param>
    /// <returns>
    /// A <see cref="CharacterString"/> instance containing the given <see cref="string"/>.
    /// </returns>
    public static implicit operator CharacterString(string? s) => new(s);

    #endregion

    #region INullableRefValue<T> Interface

    private string? _value;

    /// <summary>
    /// Gets or sets the actual value associated with the metadata entity.
    /// This property is designed for XML and JSON serialization and represents a
    /// standardized textual representation of geospatial metadata values.
    /// </summary>
    //[XmlText(DataType = "string")]
    [JsonProperty("Value")]
    public string? Value {
      get => _value;
      set => SetProperty(ref _value, value);
    }

    #endregion

    #region INilReasoned Interface

    private NilReasonEntity? _nilReasonEntity;

    /// <summary>
    /// Gets/Sets the <see cref="NilReasonEntity"/> that indicates the reason why the
    /// <see cref="Value"/> of this <see cref="CharacterString"/> is <see langword="null"/>.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when attempting to set <see cref="NilReason"/>
    /// while <see cref="Value"/> is not <see langword="null"/>.
    /// This ensures that a reason for <see langword="null"/>
    /// cannot be assigned when an actual <see cref="Value"/> is present.
    /// </exception>
    public NilReasonEntity? NilReason {
      get => _nilReasonEntity;
      set {
        if (this.Value is not null) {
          throw new ArgumentOutOfRangeException(
            nameof(NilReason),
            $"Cannot assign {nameof(NilReason)} when {nameof(Value)} is already set. " +
            $"Ensure {nameof(Value)} is null before specifying a nil reason."
          ); // RESOURCE
        }
        SetProperty(ref _nilReasonEntity, value);
      }
    }


    #endregion

    #region IComparable<T> Interface

    /// <summary>
    /// Compares this instance to another <see cref="CharacterString"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="CharacterString"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>    
    public virtual int CompareTo(CharacterString? other) {
      return other == null
        ? 1
        : string.Compare(Value, other.Value, StringComparison.Ordinal);
    }

    #endregion

    #region IEquatable<T> Interface

    /// <summary>
    /// Determines whether the <see cref="CharacterString"/> is equal to the current <see cref="CharacterString"/>.
    /// </summary>
    /// <param name="other">The <see cref="CharacterString"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public virtual bool Equals(CharacterString? other) {
      return other != null &&
             Value == other.Value;
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="CharacterString"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) => Equals(obj as CharacterString);

    /// <summary>
    /// Gets the hash code for the <see cref="CharacterString"/> using <see cref="NdshHashCode"/>.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();
      hash.Add(Value);

      return hash.ToHashCode();
    }

    #endregion

  }

}
