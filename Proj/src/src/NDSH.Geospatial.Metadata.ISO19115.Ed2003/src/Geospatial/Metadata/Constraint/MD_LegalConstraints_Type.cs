#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 24/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/constraints.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MD_LegalConstraints_Type">
//   <xs:annotation>
//     <xs:documentation>Restrictions and legal prerequisites for accessing and using the dataset.</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gmd:MD_Constraints_Type">
//       <xs:sequence>
//         <xs:element name="accessConstraints" type="gmd:MD_RestrictionCode_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="useConstraints" type="gmd:MD_RestrictionCode_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="otherConstraints" type="gco:CharacterString_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_LegalConstraints" type="gmd:MD_LegalConstraints_Type" substitutionGroup="gmd:MD_Constraints"/>
// <xs:complexType name="MD_LegalConstraints_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_LegalConstraints"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
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

namespace NDSH.Geospatial.Metadata.Constraint {

  /// <summary>
  /// Restrictions and legal prerequisites for accessing and using the dataset.
  /// </summary>
  [Serializable]
  //[XmlType("MD_LegalConstraints", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_LegalConstraints", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_LegalConstraints")]
  public class MD_LegalConstraints_Type : MD_Constraints_Type, IComparable<MD_LegalConstraints_Type>, IEquatable<MD_LegalConstraints_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_LegalConstraints_Type"/>.
    /// </summary>
    public MD_LegalConstraints_Type() {
      _accessConstraints = default; //  new List<MD_RestrictionCode_PropertyType>();
      _useConstraints = default; //  new List<MD_RestrictionCode_PropertyType>();
      _otherConstraints = default; //  new List<CharacterString>();
    }

    #endregion

    #region Public Properties

    private ObservableCollection<MD_RestrictionCode_CodeList>? _accessConstraints;

    /// <summary>
    /// Access constraints applied to assure the protection of privacy or intellectual property,
    /// and any special restrictions or limitations on obtaining the resource or metadata.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("accessConstraints", Order = 0)]
    [JsonProperty("accessConstraints", Order = 0)]
    public ObservableCollection<MD_RestrictionCode_CodeList>? AccessConstraints {
      get => _accessConstraints;
      set => SetProperty(ref _accessConstraints, value);
    }

    private ObservableCollection<MD_RestrictionCode_CodeList>? _useConstraints;

    /// <summary>
    /// Constraints applied to assure the protection of privacy or intellectual property,
    /// and any special restrictions or limitations or warnings on using the resource or metadata.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("useConstraints", Order = 1)]
    [JsonProperty("useConstraints", Order = 1)]
    public ObservableCollection<MD_RestrictionCode_CodeList>? UseConstraints {
      get => _useConstraints;
      set => SetProperty(ref _useConstraints, value);
    }

    private ObservableCollection<CharacterString>? _otherConstraints;

    /// <summary>
    /// Other restrictions and legal prerequisites for accessing and using the resource or metadata.
    /// </summary>
    // TODO: OBL - C (accessConstraints or useConstraints equal "otherRestrictions"?)
    // TODO: CAR - N
    //[XmlElement("otherConstraints", Order = 2)]
    [JsonProperty("otherConstraints", Order = 2)]
    public ObservableCollection<CharacterString>? OtherConstraints {
      get {
        return _otherConstraints;
      }
      set => SetProperty(ref _otherConstraints, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="MD_LegalConstraints_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="MD_LegalConstraints_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(MD_LegalConstraints_Type? other) {
      int result;

      return
        (other is null) ? 1 :
        (result = base.CompareTo(other)) != 0 ? result :
        (result = AccessConstraints?.Count.CompareTo(other.AccessConstraints?.Count ?? 0) ?? 1) != 0 ? result :
        (result = UseConstraints?.Count.CompareTo(other.UseConstraints?.Count ?? 0) ?? 1) != 0 ? result :
        OtherConstraints?.Count.CompareTo(other.OtherConstraints?.Count ?? 0) ?? 1;
    }

    /// <inheritdoc />
    public override int CompareTo(MD_Constraints_Type? other) {
      return CompareTo(other as MD_LegalConstraints_Type);
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="MD_LegalConstraints_Type"/> is equal to the current <see cref="MD_LegalConstraints_Type"/>.
    /// </summary>
    /// <param name="other">The <see cref="MD_LegalConstraints_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(MD_LegalConstraints_Type? other) {
      return other != null &&
             base.Equals(other) &&
             AccessConstraints.SequenceEqualOrdered(other.AccessConstraints) &&
             UseConstraints.SequenceEqualOrdered(other.UseConstraints) &&
             OtherConstraints.SequenceEqualOrdered(other.OtherConstraints);
    }

    /// <inheritdoc />
    public override bool Equals(MD_Constraints_Type? other) {
      return Equals(other as MD_LegalConstraints_Type);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="MD_LegalConstraints_Type"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as MD_LegalConstraints_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="MD_LegalConstraints_Type"/> using <see cref="NdshHashCode"/>.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();
      hash.Add(base.GetHashCode());

      foreach (MD_RestrictionCode_CodeList accessConstraint in AccessConstraints.SafeOrderBy()) {
        hash.Add(accessConstraint);
      }

      foreach (MD_RestrictionCode_CodeList useConstraint in UseConstraints.SafeOrderBy()) {
        hash.Add(useConstraint);
      }

      foreach (CharacterString otherConstraint in OtherConstraints.SafeOrderBy()) {
        hash.Add(otherConstraint);
      }

      return hash.ToHashCode();
    }

    #endregion

  }

}
