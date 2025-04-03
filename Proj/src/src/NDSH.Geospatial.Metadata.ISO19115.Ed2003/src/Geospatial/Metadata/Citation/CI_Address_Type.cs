
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
// <xs:complexType name="CI_Address_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="deliveryPoint"
//                     type="gco:CharacterString_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="city"
//                     type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="administrativeArea"
//                     type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="postalCode"
//                     type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="country"
//                     type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="electronicMailAddress"
//                     type="gco:CharacterString_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="CI_Address" type="gmd:CI_Address_Type"/>
// <xs:complexType name="CI_Address_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:CI_Address"/>
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
  /// Location of the responsible individual or organisation.
  /// </summary>
  [Serializable]
  //[XmlType("CI_Address", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("CI_Address", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("CI_Address")] // TODO: The JsonObject attribute is different than XmlType and XmlRoot. Is this correct?
  public class CI_Address_Type : MetadataObject, IComparable<CI_Address_Type>, IEquatable<CI_Address_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_Address_Type"/>
    /// </summary>
    public CI_Address_Type() {
      _deliveryPoint = default; // new List<CharacterString>();
      _city = default; // new CharacterString();
      _administrativeArea = default; // new CharacterString();
      _postalCode = default; // new CharacterString();
      _country = default; // new CharacterString();
      _electronicMailAddress = default; // new List<CharacterString>();
    }

    #endregion

    #region Public Properties

    private ObservableCollection<CharacterString>? _deliveryPoint;

    /// <summary>
    /// Address line for the location.
    /// </summary>
    /// <remarks>As described in ISO 11180, Annex A.</remarks>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("deliveryPoint", Order = 0)]
    [JsonProperty("deliveryPoint", Order = 0)]
    public ObservableCollection<CharacterString>? DeliveryPoint {
      get => _deliveryPoint;
      set => SetProperty(ref _deliveryPoint, value);
    }

    private CharacterString? _city;

    /// <summary>
    /// City of the location.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("city", Order = 1)]
    [JsonProperty("city", Order = 1)]
    public CharacterString? City {
      get => _city;
      set => SetProperty(ref _city, value);
    }

    private CharacterString? _administrativeArea;

    /// <summary>
    /// State, province of the location.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("administrativeArea", Order = 2)]
    [JsonProperty("administrativeArea", Order = 2)]
    public CharacterString? AdministrativeArea {
      get => _administrativeArea;
      set => SetProperty(ref _administrativeArea, value);
    }

    private CharacterString? _postalCode;

    /// <summary>
    /// ZIP or other postal code.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("postalCode", Order = 3)]
    [JsonProperty("postalCode", Order = 3)]
    public CharacterString? PostalCode {
      get => _postalCode;
      set => SetProperty(ref _postalCode, value);
    }

    private CharacterString? _country;

    /// <summary>
    /// Country of the physical address.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("country", Order = 4)]
    [JsonProperty("country", Order = 4)]
    public CharacterString? Country {
      get => _country;
      set => SetProperty(ref _country, value);
    }

    private ObservableCollection<CharacterString>? _electronicMailAddress;

    /// <summary>
    /// Address of the electronic mailbox of the responsible organization or individual.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("electronicMailAddress", Order = 5)]
    [JsonProperty("electronicMailAddress", Order = 5)]
    public ObservableCollection<CharacterString>? ElectronicMailAddress {
      get => _electronicMailAddress;
      set => SetProperty(ref _electronicMailAddress, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="CI_Address_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="CI_Address_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(CI_Address_Type? other) {

      int result;

      return
        other is null ? 1 :
        (result = DeliveryPoint?.Count.CompareTo(other.DeliveryPoint?.Count ?? 0) ?? 1) != 0 ? result :
        (result = City?.CompareTo(other.City) ?? 1) != 0 ? result :
        (result = AdministrativeArea?.CompareTo(other.AdministrativeArea) ?? 1) != 0 ? result :
        (result = PostalCode?.CompareTo(other.PostalCode) ?? 1) != 0 ? result :
        (result = Country?.CompareTo(other.Country) ?? 1) != 0 ? result :
        ElectronicMailAddress?.Count.CompareTo(other.ElectronicMailAddress?.Count ?? 0) ?? 1;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="CI_Address_Type"/> is equal to the current <see cref="CI_Address_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="CI_Address_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(CI_Address_Type? other) {
      return other != null &&
         DeliveryPoint.SequenceEqualOrdered(other.DeliveryPoint) &&
         Equals(City, other.City) &&
         Equals(AdministrativeArea, other.AdministrativeArea) &&
         Equals(PostalCode, other.PostalCode) &&
         Equals(Country, other.Country) &&
         ElectronicMailAddress.SequenceEqualOrdered(other.ElectronicMailAddress);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="CI_Address_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as CI_Address_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="CI_Address_Type"/> using <see cref="NdshHashCode"/>. This will also order 
    /// collections before hashing them.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      foreach (CharacterString characterString in DeliveryPoint.SafeOrderBy()) {
        hash.Add(characterString);
      }

      hash.Add(City);
      hash.Add(AdministrativeArea);
      hash.Add(PostalCode);
      hash.Add(Country);

      foreach (CharacterString characterString in ElectronicMailAddress.SafeOrderBy()) {
        hash.Add(characterString);
      }

      return hash.ToHashCode();
    }

    #endregion

  }

}
