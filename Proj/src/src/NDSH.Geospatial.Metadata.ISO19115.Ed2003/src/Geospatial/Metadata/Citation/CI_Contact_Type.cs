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
// <xs:complexType name="CI_Contact_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="phone" type="gmd:CI_Telephone_PropertyType" minOccurs="0"/>
//         <xs:element name="address" type="gmd:CI_Address_PropertyType" minOccurs="0"/>
//         <xs:element name="onlineResource" type="gmd:CI_OnlineResource_PropertyType" minOccurs="0"/>
//         <xs:element name="hoursOfService" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="contactInstructions" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="CI_Contact" type="gmd:CI_Contact_Type"/>
// <xs:complexType name="CI_Contact_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:CI_Contact"/>
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
  /// Information required enabling contact with the responsible person and/or organisation.
  /// </summary>
  [Serializable]
  //[XmlType("CI_Contact", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("CI_Contact", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("CI_Contact")]
  public class CI_Contact_Type : MetadataObject, IComparable<CI_Contact_Type>, IEquatable<CI_Contact_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_Contact_Type"/>.
    /// </summary>
    public CI_Contact_Type() {
      _phone = default; //  new CI_Telephone_Type();
      _address = default; //  new CI_Address_Type();
      _onlineResource = default; //  new CI_OnlineResource_Type();
      _hoursOfService = default; //  new CharacterString();
      _contactInstructions = default; //  new CharacterString();
    }

    #endregion

    #region Public Properties

    private CI_Telephone_Type? _phone;

    /// <summary>
    /// Telephone numbers at which the organization or individual may be contacted.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("phone", Order = 0)]
    [JsonProperty("phone", Order = 0)]
    public CI_Telephone_Type? Phone {
      get => _phone;
      set => SetProperty(ref _phone, value);
    }

    private CI_Address_Type? _address;

    /// <summary>
    /// Physical and email address at which the organization or individual may be contacted.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("address", Order = 1)]
    [JsonProperty("address", Order = 1)]
    public CI_Address_Type? Address {
      get => _address;
      set => SetProperty(ref _address, value);
    }

    private CI_OnlineResource_Type? _onlineResource;

    /// <summary>
    /// On-line information that can be used to contact the individual or organization.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("onlineResource", Order = 2)]
    [JsonProperty("onlineResource", Order = 2)]
    public CI_OnlineResource_Type? OnlineResource {
      get => _onlineResource;
      set => SetProperty(ref _onlineResource, value);
    }

    private CharacterString? _hoursOfService;

    /// <summary>
    /// Time period (including time zone) when individuals can contact the organization or individual.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("hoursOfService", Order = 3)]
    [JsonProperty("hoursOfService", Order = 3)]
    public CharacterString? HoursOfService {
      get => _hoursOfService;
      set => SetProperty(ref _hoursOfService, value);
    }

    private CharacterString? _contactInstructions;

    /// <summary>
    /// Supplemental instructions on how or when to contact the individual or organization.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("contactInstructions", Order = 4)]
    [JsonProperty("contactInstructions", Order = 4)]
    public CharacterString? ContactInstructions {
      get => _contactInstructions;
      set => SetProperty(ref _contactInstructions, value);
    }


    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="CI_Contact_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="CI_Contact_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(CI_Contact_Type? other) {
      if (other == null) {
        return 1;
      }

      int result = Phone?.CompareTo(other.Phone) ?? 1;
      if (result != 0) {
        return result;
      }

      result = Address?.CompareTo(other.Address) ?? 1;
      if (result != 0) {
        return result;
      }

      result = OnlineResource?.CompareTo(other.OnlineResource) ?? 1;
      if (result != 0) {
        return result;
      }

      result = HoursOfService?.CompareTo(other.HoursOfService) ?? 1;
      if (result != 0) {
        return result;
      }

      return ContactInstructions?.CompareTo(other.ContactInstructions) ?? 1;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="CI_Contact_Type"/> is equal to the current <see cref="CI_Contact_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="CI_Contact_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(CI_Contact_Type? other) {
      if (other == null) {
        return false;
      }

      return Equals(Phone, other.Phone) &&
             Equals(Address, other.Address) &&
             Equals(OnlineResource, other.OnlineResource) &&
             Equals(HoursOfService, other.HoursOfService) &&
             Equals(ContactInstructions, other.ContactInstructions);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="CI_Contact_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as CI_Contact_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="CI_Contact_Type"/> using <see cref="NdshHashCode"/>. 
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();
      hash.Add(Phone);
      hash.Add(Address);
      hash.Add(OnlineResource);
      hash.Add(HoursOfService);
      hash.Add(ContactInstructions);
      return hash.ToHashCode();
    }

    #endregion

  }

}
