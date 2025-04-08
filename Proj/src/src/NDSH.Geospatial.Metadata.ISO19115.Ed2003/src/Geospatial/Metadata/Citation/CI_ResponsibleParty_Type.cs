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
// <xs:complexType name="CI_ResponsibleParty_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="individualName" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="organisationName" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="positionName" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="contactInfo" type="gmd:CI_Contact_PropertyType" minOccurs="0"/>
//         <xs:element name="role" type="gmd:CI_RoleCode_PropertyType"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="CI_ResponsibleParty" type="gmd:CI_ResponsibleParty_Type"/>
// <xs:complexType name="CI_ResponsibleParty_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:CI_ResponsibleParty"/>
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

#endregion

namespace NDSH.Geospatial.Metadata.Citation {

  /// <summary>
  /// Identification of, and means of communication with, person(s) and organisations associated with the dataset.
  /// </summary>
  [Serializable]
  //[XmlType("CI_ResponsibleParty", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("CI_ResponsibleParty", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("CI_ResponsibleParty")]
  public class CI_ResponsibleParty_Type : MetadataObject, IComparable<CI_ResponsibleParty_Type>, IEquatable<CI_ResponsibleParty_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_ResponsibleParty_Type"/>.
    /// </summary>
    public CI_ResponsibleParty_Type() {
      _individualName = default; //new CharacterString();
      _organisationName = default; //new CharacterString();
      _positionName = default; //new CharacterString();
      _contactInfo = default; //new CI_Contact_Type();
      _role = default; //new CI_RoleCode_PropertyType();
    }

    #endregion

    #region Public Properties

    private CharacterString? _individualName;

    /// <summary>
    /// Name of the responsible person.
    /// </summary>
    /// <remarks>Surname, given name, title separated by a delimiter.</remarks>
    // TODO: OBL - C (organisationName and positionName not documented?)
    // TODO: CAR - 1
    //[XmlElement("individualName", Order = 0)]
    [JsonProperty("individualName", Order = 0)]
    public CharacterString? IndividualName {
      get => _individualName;
      set => SetProperty(ref _individualName, value);
    }

    private CharacterString? _organisationName;

    /// <summary>
    /// Name of the responsible organisation.
    /// </summary>
    // TODO: OBL - C (individualName and positionName not documented?)
    // TODO: CAR - 1
    //[XmlElement("organisationName", Order = 1)]
    [JsonProperty("organisationName", Order = 1)]
    public CharacterString? OrganisationName {
      get => _organisationName;
      set => SetProperty(ref _organisationName, value);
    }

    private CharacterString? _positionName;

    /// <summary>
    /// Role or position of the responsible person.
    /// </summary>
    // TODO: OBL - C (individualName and organisationName not documented?)
    // TODO: CAR - 1
    //[XmlElement("positionName", Order = 2)]
    [JsonProperty("positionName", Order = 2)]
    public CharacterString? PositionName {
      get => _positionName;
      set => SetProperty(ref _positionName, value);
    }

    private CI_Contact_Type? _contactInfo;

    /// <summary>
    /// Address of the responsible party.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("contactInfo", Order = 3)]
    [JsonProperty("contactInfo", Order = 3)]
    public CI_Contact_Type? ContactInfo {
      get => _contactInfo;
      set => SetProperty(ref _contactInfo, value);
    }

    private CI_RoleCode_CodeList _role;

    /// <summary>
    /// Function performed by the responsible party.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("role", Order = 4)]
    [JsonProperty("role", Order = 4)]
    public CI_RoleCode_CodeList Role {
      get => _role;
      set => SetProperty(ref _role, value);
    }

    #endregion

    #region IComparable Interface

    /// <inheritdoc />
    /// <summary>
    /// Compares this instance to another <see cref="CI_ResponsibleParty_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="CI_ResponsibleParty_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(CI_ResponsibleParty_Type? other) {
      if (other == null) {
        return 1;
      }

      int result = IndividualName?.CompareTo(other.IndividualName) ?? 1;
      if (result != 0) {
        return result;
      }

      result = OrganisationName?.CompareTo(other.OrganisationName) ?? 1;
      if (result != 0) {
        return result;
      }

      result = PositionName?.CompareTo(other.PositionName) ?? 1;
      if (result != 0) {
        return result;
      }

      return Role.CompareTo(other.Role);
    }

    #endregion

    #region IEquatable Interface

    /// <inheritdoc />
    /// <summary>
    /// Determines whether the <see cref="CI_ResponsibleParty_Type"/> is equal to the current <see cref="CI_ResponsibleParty_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="CI_ResponsibleParty_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(CI_ResponsibleParty_Type? other) {
      if (other == null) {
        return false;
      }

      return Equals(IndividualName, other.IndividualName) &&
             Equals(OrganisationName, other.OrganisationName) &&
             Equals(PositionName, other.PositionName) &&
             Equals(ContactInfo, other.ContactInfo) &&
             Equals(Role, other.Role);
    }

    #endregion

    #region Overrides

    /// <inheritdoc />
    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="CI_ResponsibleParty_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as CI_ResponsibleParty_Type);
    }

    /// <inheritdoc />
    /// <summary>
    /// Gets the hash code for the <see cref="CI_ResponsibleParty_Type"/> using <see cref="NdshHashCode"/>. This will also order 
    /// collections before hashing them.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();
      hash.Add(IndividualName);
      hash.Add(OrganisationName);
      hash.Add(PositionName);
      hash.Add(ContactInfo);
      hash.Add(Role);
      return hash.ToHashCode();
    }

    #endregion

  }

}
