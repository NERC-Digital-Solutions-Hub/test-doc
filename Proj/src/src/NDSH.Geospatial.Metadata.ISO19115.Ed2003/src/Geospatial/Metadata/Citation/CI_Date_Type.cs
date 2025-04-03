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
// XSD               : /2005/gmd/citation.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="CI_Date_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="date" type="gco:Date_PropertyType"/>
//         <xs:element name="dateType" type="gmd:CI_DateTypeCode_PropertyType"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="CI_Date" type="gmd:CI_Date_Type"/>
// <xs:complexType name="CI_Date_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:CI_Date"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.DateTime;

using NDSH.Hashing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.Citation {

  [Serializable]
  //[XmlType("CI_Date", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("CI_Date", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("CI_Date")]
  public class CI_Date_Type : MetadataObject, IComparable<CI_Date_Type>, IEquatable<CI_Date_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_Date_Type"/>.
    /// </summary>
    public CI_Date_Type() {
      _date = default; //  new Date_PropertyType();
      _dateType = default; //  new CI_DateTypeCode_PropertyType();
    }

    #endregion

    #region Public Properties

    private DateDbEntity _date;

    /// <summary>
    /// Reference date for the cited resource.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("date", Order = 0)]
    [JsonProperty("date", Order = 0)]
    public DateDbEntity Date {
      get => _date;
      set => SetProperty(ref _date, value);
    }

    private CI_DateTypeCode_CodeList _dateType;

    /// <summary>
    /// Event used for reference date.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("dateType", Order = 1)]
    [JsonProperty("dateType", Order = 1)]
    public CI_DateTypeCode_CodeList DateType {
      get => _dateType;
      set => SetProperty(ref _dateType, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="CI_Date_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="CI_Date_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(CI_Date_Type? other) {
      if (other == null) {
        return 1;
      }

      int result = Date.CompareTo(other.Date);
      if (result != 0) {
        return result;
      }

      return DateType.CompareTo(other.DateType);
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="CI_Date_Type"/> is equal to the current <see cref="CI_Date_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="CI_Date_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(CI_Date_Type? other) {
      if (other == null) {
        return false;
      }

      return Equals(Date, other.Date) &&
             Equals(DateType, other.DateType);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="CI_Date_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as CI_Date_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="CI_Date_Type"/> using <see cref="NdshHashCode"/>. This will also order 
    /// collections before hashing them.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();
      hash.Add(Date);
      hash.Add(DateType);
      return hash.ToHashCode();
    }

    #endregion

  }

}
