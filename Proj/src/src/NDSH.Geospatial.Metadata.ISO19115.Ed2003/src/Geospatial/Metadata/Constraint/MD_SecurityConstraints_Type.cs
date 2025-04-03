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
// <xs:complexType name="MD_SecurityConstraints_Type">
//   <xs:annotation>
//     <xs:documentation>Handling restrictions imposed on the dataset because of national security, privacy, or other concerns</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gmd:MD_Constraints_Type">
//       <xs:sequence>
//         <xs:element name="classification" type="gmd:MD_ClassificationCode_PropertyType"/>
//         <xs:element name="userNote" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="classificationSystem" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="handlingDescription" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_SecurityConstraints" type="gmd:MD_SecurityConstraints_Type" substitutionGroup="gmd:MD_Constraints"/>
// <xs:complexType name="MD_SecurityConstraints_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_SecurityConstraints"/>
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Constraint {

  /// <summary>
  /// Handling restrictions imposed on the dataset because of national security, privacy, or other concerns.
  /// </summary>
  [Serializable]
  //[XmlType("MD_SecurityConstraints", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_SecurityConstraints", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_SecurityConstraints")]
  public class MD_SecurityConstraints_Type : MD_Constraints_Type, IComparable<MD_SecurityConstraints_Type>, IEquatable<MD_SecurityConstraints_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_SecurityConstraints_Type"/>.
    /// </summary>
    public MD_SecurityConstraints_Type() {
      _classification = default; //  new MD_ClassificationCode_PropertyType();
      _userNote = default; //  new CharacterString();
      _classificationSystem = default; //  new CharacterString();
      _handlingDescription = default; //  new CharacterString();
    }

    #endregion

    #region Public Properties

    private MD_ClassificationCode_CodeList _classification;

    /// <summary>
    /// Name of the handling restrictions on the resource or metadata.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("classification", Order = 0)]
    [JsonProperty("classification", Order = 0)]
    public MD_ClassificationCode_CodeList Classification {
      get => _classification;
      set => SetProperty(ref _classification, value);
    }

    private CharacterString? _userNote;

    /// <summary>
    /// Explanation of the application of the legal constraints or other restrictions and legal prerequisites for obtaining and using the resource or metadata.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("userNote", Order = 1)]
    [JsonProperty("userNote", Order = 1)]
    public CharacterString? UserNote {
      get => _userNote;
      set => SetProperty(ref _userNote, value);
    }

    private CharacterString? _classificationSystem;

    /// <summary>
    /// Name of the classification system.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("classificationSystem", Order = 2)]
    [JsonProperty("classificationSystem", Order = 2)]
    public CharacterString? ClassificationSystem {
      get => _classificationSystem;
      set => SetProperty(ref _classificationSystem, value);
    }

    private CharacterString? _handlingDescription;

    /// <summary>
    /// Additional information about the restrictions on handling the resource or metadata.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("handlingDescription", Order = 3)]
    [JsonProperty("handlingDescription", Order = 3)]
    public CharacterString? HandlingDescription {
      get => _handlingDescription;
      set => SetProperty(ref _handlingDescription, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="MD_SecurityConstraints_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="MD_SecurityConstraints_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(MD_SecurityConstraints_Type? other) {
      int result;

      return
        (other is null) ? 1 :
        (result = base.CompareTo(other)) != 0 ? result :
        (result = Classification?.CompareTo(other.Classification) ?? 1) != 0 ? result :
        (result = UserNote?.CompareTo(other.UserNote) ?? 1) != 0 ? result :
        (result = ClassificationSystem?.CompareTo(other.ClassificationSystem) ?? 1) != 0 ? result :
        HandlingDescription?.CompareTo(other.HandlingDescription) ?? 1;
    }

    /// <inheritdoc />
    public override int CompareTo(MD_Constraints_Type? other) {
      return CompareTo(other as MD_SecurityConstraints_Type);
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="MD_SecurityConstraints_Type"/> is equal to the current <see cref="MD_SecurityConstraints_Type"/>.
    /// </summary>
    /// <param name="other">The <see cref="MD_SecurityConstraints_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(MD_SecurityConstraints_Type? other) {
      return other != null &&
             base.Equals(other) &&
             Equals(Classification, other.Classification) &&
             Equals(UserNote, other.UserNote) &&
             Equals(ClassificationSystem, other.ClassificationSystem) &&
             Equals(HandlingDescription, other.HandlingDescription);
    }

    /// <inheritdoc />
    public override bool Equals(MD_Constraints_Type? other) {
      return Equals(other as MD_SecurityConstraints_Type);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="MD_SecurityConstraints_Type"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as MD_SecurityConstraints_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="MD_SecurityConstraints_Type"/> using <see cref="NdshHashCode"/>.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      hash.Add(base.GetHashCode());
      hash.Add(Classification);
      hash.Add(UserNote);
      hash.Add(ClassificationSystem);
      hash.Add(HandlingDescription);

      return hash.ToHashCode();
    }

    #endregion

  }

}
