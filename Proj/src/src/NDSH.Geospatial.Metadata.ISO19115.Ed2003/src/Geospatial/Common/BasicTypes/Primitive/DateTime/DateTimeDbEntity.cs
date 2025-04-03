#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 02/01/2023, @gisvlasta
// History           : 27/02/2025, @gisvlasta
//                     The class was renamed to DateTimeDbEntity and now inherits from ObservableDbEntity.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:element name="DateTime" type="xs:dateTime"/>
// <xs:complexType name="DateTime_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gco:DateTime"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Database.Entities;
using NDSH.Hashing;
using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Common.BasicTypes.Primitive.DateTime {

  /// <summary>
  /// Represents an entity that maps a <see cref="DateTime"/> value to a dedicated database table,
  /// aligning with the ISO 19115 <c>DateTime_PropertyType</c> definition for geospatial metadata.
  /// </summary>
  /// <remarks>
  /// Use the <see cref="DateTime"/> type whenever date with time values are required in a POCO.
  /// If the <see cref="DateTime"/> property must be stored in its own table (for example, to satisfy
  /// advanced geospatial metadata requirements) map it to this <see cref="DateTimeDbEntity"/>.
  /// This design helps ensure consistent handling of <see cref="DateTime"/> values according to the ISO 19115 standard.
  /// </remarks>
  //[Serializable]
  //[XmlType("DateTime_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("DateTime_PropertyType")]
  public class DateTimeDbEntity : ObservableDbEntity, IComparable<DateTimeDbEntity>, IEquatable<DateTimeDbEntity> {

    #region Public Properties

    private System.DateTime? _dateTime;

    /// <summary>
    /// Gets/Sets the value.
    /// </summary>
    //[XmlElement("DateTime", Order = 0)]
    [JsonProperty("DateTime", Order = 0)]
    public System.DateTime? DateTime {
      get => _dateTime;
      set => SetProperty(ref _dateTime, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="DateTimeDbEntity"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="DateTimeDbEntity"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(DateTimeDbEntity? other) {
      int result;

      return
        other is null ? 1 :
        DateTime?.CompareTo(other.DateTime) ?? 1;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="DateTimeDbEntity"/> is equal to the current <see cref="DateTimeDbEntity"/>.
    /// </summary>
    /// <param name="other">The <see cref="DateTimeDbEntity"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(DateTimeDbEntity? other) {
      return other != null &&
        Equals(DateTime, other.DateTime);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="DateTimeDbEntity"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as DateTimeDbEntity);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="DateTimeDbEntity"/> using <see cref="NdshHashCode"/>.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      hash.Add(DateTime);

      return hash.ToHashCode();
    }

    #endregion

  }

}
