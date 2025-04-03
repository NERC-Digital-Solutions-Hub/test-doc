
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 29/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : This class is an exception to the rule. It does not inherit from `IdentifiableObject`
//                      (xsd: `AbstractObject_Type`). Classes whose properties are of this type
//                      are not decorated with property metadata instances of type `ReferencedObject`;
//                      instead they are decorated with instances of `NilReasonEntity`.
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/citation.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:element name="URL" type="xs:anyURI"/>
// <xs:complexType name="URL_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:URL"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Database.Entities;
using NDSH.Geospatial.Gml.BasicTypes;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.Citation {

  // WARNING: The URL_PropertyType may need to be wrapped so that it provides a robust URL validation.

  /// <summary>
  /// Represents a URL type.
  /// </summary>
  /// <remarks>
  /// This class does not inherit from <see cref="MetadataObject"/> (xsd: AbstractObject_Type).
  /// Classes whose properties are of this type are not decorated with property metadata instances of type
  /// <see cref="ReferenceEntity"/>; instead they are decorated with instances of <see cref="NilReasonEntity"/>.
  /// </remarks>
  [Serializable]
  //[XmlType("URL_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("URL_PropertyType")]
  public class URL_PropertyType : ObservableDbEntity, IComparable<URL_PropertyType> {

    #region Public Properties

    private string? _url;

    /// <summary>
    /// Gets/Sets the URL value.
    /// </summary>
    //[XmlElement("URL", DataType = "anyURI", Order = 0)]
    [JsonProperty("URL", Order = 0)]
    public string? Url {
      get => _url;
      set => SetProperty(ref _url, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this object with another <see cref="URL_PropertyType"/> object.
    /// </summary>
    /// <param name="other">The <see cref="URL_PropertyType">other</see> object to compare.</param>
    /// <returns>
    ///   An <see cref="int"/> with the following possible values, indicating the position of this
    ///   object in relation to the <paramref name="other"/> object.
    ///   <list type="bullet">
    ///     <item><c>-1 (minus one)</c> - if this object precedes <paramref name="other"/></item>
    ///     <item><c>0 (zero)</c> - if they are equal</item>
    ///     <item><c>1 (one)</c> - if it follows</item>
    ///   </list>
    /// </returns>
    public int CompareTo(URL_PropertyType? other) {

      // WARNING: Is this implementation better?

      if (other is null) {
        return 1; // This instance is greater.
      }
      if (Url is null && other.Url is null) {
        return 0; // Both are null, considered equal.
      }
      if (Url is null) {
        return -1; // Null URL should be considered "lesser".
      }
      if (other.Url is null) {
        return 1;
      }

      return string.Compare(Url, other.Url);

      //  return other is null
      //      ? 1
      //      : Url?.CompareTo(other.Url) ?? 0;

    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to this object.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare with this object.</param>
    /// <returns>
    /// A <see cref="bool"/> value indicating whether the two objects are equal or not.
    /// </returns>
    public override bool Equals(object? obj) =>
      obj is URL_PropertyType url && Equals(Url, url.Url);

    /// <summary>
    /// Returns a hash code for this object.
    /// </summary>
    /// <returns>An <see cref="int"/> hash code for this object.</returns>
    public override int GetHashCode() {
      HashCode hash = new();

      hash.Add(Url);

      return hash.ToHashCode();
    }

    #endregion

  }

}
