#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 29/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/identification.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MD_Usage_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="specificUsage" type="gco:CharacterString_PropertyType"/>
//         <xs:element name="usageDateTime" type="gco:DateTime_PropertyType" minOccurs="0"/>
//         <xs:element name="userDeterminedLimitations" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="userContactInfo" type="gmd:CI_ResponsibleParty_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_Usage" type="gmd:MD_Usage_Type"/>
// <xs:complexType name="MD_Usage_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_Usage"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.DateTime;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;

using NDSH.Hashing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Identification {

  /// <summary>
  /// Brief description of ways in which the dataset is currently used.
  /// </summary>
  [Serializable]
  //[XmlType("MD_Usage", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_Usage", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_Usage")]
  public class MD_Usage_Type : MetadataObject, IComparable<MD_Usage_Type>, IEquatable<MD_Usage_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Usage_Type"/>.
    /// </summary>
    public MD_Usage_Type() {
      _specificUsage = default; //  new CharacterString();
      _usageDateTime = default; //  new DateTime_PropertyType();
      _userDeterminedLimitations = default; //  new CharacterString();
      _userContactInfo = default; //  new List<CI_ResponsibleParty_Type>();
    }

    #endregion

    #region Public Properties

    private CharacterString _specificUsage;

    /// <summary>
    /// Brief description of the resource and/or resource series usage.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("specificUsage", Order = 0)]
    [JsonProperty("specificUsage", Order = 0)]
    public CharacterString SpecificUsage {
      get => _specificUsage;
      set => SetProperty(ref _specificUsage, value);
    }

    private DateTimeDbEntity? _usageDateTime;

    /// <summary>
    /// Date and time of the first use or range of uses of the resource and/or resource series.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("usageDateTime", Order = 1)]
    [JsonProperty("usageDateTime", Order = 1)]
    public DateTimeDbEntity? UsageDateTime {
      get => _usageDateTime;
      set => SetProperty(ref _usageDateTime, value);
    }

    private CharacterString? _userDeterminedLimitations;

    /// <summary>
    /// Applications, determined by the user for which the resource and/or resource series is not suitable.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("userDeterminedLimitations", Order = 2)]
    [JsonProperty("userDeterminedLimitations", Order = 2)]
    public CharacterString? UserDeterminedLimitations {
      get => _userDeterminedLimitations;
      set => SetProperty(ref _userDeterminedLimitations, value);
    }

    private ObservableCollection<CI_ResponsibleParty_Type> _userContactInfo;

    /// <summary>
    /// Identification of and means of communicating with person(s) and organization(s) using the resource(s).
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - N
    //[XmlElement("userContactInfo", Order = 3)]
    [JsonProperty("userContactInfo", Order = 3)]
    public ObservableCollection<CI_ResponsibleParty_Type> UserContactInfo {
      get => _userContactInfo;
      set => SetProperty(ref _userContactInfo, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="MD_Usage_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="MD_Usage_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(MD_Usage_Type? other) {
      int result;

      return
        (other is null) ? 1 :
        (result = SpecificUsage?.CompareTo(other.SpecificUsage) ?? 1) != 0 ? result :
        (result = UsageDateTime?.CompareTo(other.UsageDateTime) ?? 1) != 0 ? result :
        (result = UserDeterminedLimitations?.CompareTo(other.UserDeterminedLimitations) ?? 1) != 0 ? result :
        UserContactInfo?.Count.CompareTo(other.UserContactInfo?.Count ?? 0) ?? 1;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="MD_Usage_Type"/> is equal to the current <see cref="MD_Usage_Type"/>.
    /// </summary>
    /// <param name="other">The <see cref="MD_Usage_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(MD_Usage_Type? other) {
      return other != null &&
             Equals(SpecificUsage, other.SpecificUsage) &&
             Equals(UsageDateTime, other.UsageDateTime) &&
             Equals(UserDeterminedLimitations, other.UserDeterminedLimitations) &&
             UserContactInfo.SequenceEqualOrdered(other.UserContactInfo);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="MD_Usage_Type"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as MD_Usage_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="MD_Usage_Type"/> using <see cref="NdshHashCode"/>.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      hash.Add(SpecificUsage);
      hash.Add(UsageDateTime);
      hash.Add(UserDeterminedLimitations);

      foreach (CI_ResponsibleParty_Type contactInfo in UserContactInfo.SafeOrderBy()) {
        hash.Add(contactInfo);
      }

      return hash.ToHashCode();
    }

    #endregion

  }

}
