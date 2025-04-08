
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 03/01/2023, @gisvlasta
// History           : 27/02/2025, @gisvlasta
//                     The class was renamed to DateDbEntity and now inherits from ObservableDbEntity.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:simpleType name="Date_Type">
//   <xs:union memberTypes="xs:date xs:gYearMonth xs:gYear"/>
// </xs:simpleType>
// <xs:element name="Date" type="gco:Date_Type" nillable="true"/>
// <xs:complexType name="Date_PropertyType">
//   <xs:choice minOccurs="0">
//     <xs:element ref="gco:Date"/>
//     <xs:element ref="gco:DateTime"/>
//   </xs:choice>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
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
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

#endregion

namespace NDSH.Geospatial.Common.BasicTypes.Primitive.DateTime {

  /// <summary>
  /// Represents an entity that maps a <see cref="System.DateTime"/> value to a dedicated database table,
  /// aligning with the ISO 19115 <c>Date_PropertyType</c> definition for geospatial metadata.
  /// </summary>
  /// <remarks>
  /// Use the <see cref="System.DateTime"/> alongside the <see cref="DateVariant"/> enumeration to
  /// represent correctly the value stored in the <see cref="System.DateTime"/> when such values are required in a POCO.
  /// If the <see cref="System.DateTime"/> property must be stored in its own table (for example, to satisfy
  /// advanced geospatial metadata requirements), map it to this <see cref="DateDbEntity"/>.
  /// This design helps ensure consistent handling of <see cref="DateDbEntity"/> values according
  /// to the ISO 19115 standard.
  /// </remarks>
  //[Serializable]
  //[XmlType("Date_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Date_PropertyType")]
  public class DateDbEntity : ObservableDbEntity, IComparable<DateDbEntity>, IEquatable<DateDbEntity> {

    #region Public Properties

    private System.DateTime? _dateOrDateTime;

    /// <summary>
    /// Gets/Sets the value of the date or datetime.
    /// </summary>
    //[XmlChoiceIdentifier("DateTimeType")]
    //[XmlElement("Date", typeof(string), IsNullable = true, Order = 0)]
    //[XmlElement("DateTime", typeof(System.DateTime), Order = 0)]
    public System.DateTime? DateOrDateTime {
      get => _dateOrDateTime;
      set => SetProperty(ref _dateOrDateTime, value);
    }

    private DateVariant _dateVariant;

    /// <summary>
    /// Specifies the date/time granularity in alignment with the
    /// ISO 19115 <see cref="DateDbEntity"/> definitions. 
    /// </summary>
    public DateVariant DateVariant {
      get => _dateVariant;
      set => SetProperty(ref _dateVariant, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="DateDbEntity"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="DateDbEntity"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(DateDbEntity? other) {
      if (other == null) {
        return 1;
      }

      int result = DateOrDateTime?.CompareTo(other.DateOrDateTime) ?? 1;
      if (result != 0) {
        return result;
      }

      return DateVariant.CompareTo(other.DateVariant);
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="DateDbEntity"/> is equal to the current <see cref="DateDbEntity"/>.
    /// </summary>
    /// <param name="other">The <see cref="DateDbEntity"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(DateDbEntity? other) {
      return other != null &&
         Equals(DateOrDateTime, other.DateOrDateTime) &&
         Equals(DateVariant, other.DateVariant);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="DateDbEntity"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as DateDbEntity);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="DateDbEntity"/> using <see cref="NdshHashCode"/>.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      hash.Add(DateOrDateTime);
      hash.Add(DateVariant);

      return hash.ToHashCode();
    }

    #endregion

  }

}
