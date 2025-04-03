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
// <xs:complexType name="CI_OnlineResource_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="linkage" type="gmd:URL_PropertyType"/>
//         <xs:element name="protocol" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="applicationProfile" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="name" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="description" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="function" type="gmd:CI_OnLineFunctionCode_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="CI_OnlineResource" type="gmd:CI_OnlineResource_Type"/>
// <xs:complexType name="CI_OnlineResource_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:CI_OnlineResource"/>
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
  /// Information about online sources from which the dataset, specification,
  /// or community profile name and extended metadata elements can be obtained.
  /// </summary>
  [Serializable]
  //[XmlType("CI_OnlineResource", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("CI_OnlineResource", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("CI_OnlineResource")]
  public class CI_OnlineResource_Type : MetadataObject, IComparable<CI_OnlineResource_Type>, IEquatable<CI_OnlineResource_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_OnlineResource_Type"/>.
    /// </summary>
    public CI_OnlineResource_Type() {
      _linkage = default; //  new URL_PropertyType();
      _protocol = default; //  new CharacterString();
      _applicationProfile = default; //  new CharacterString();
      _name = default; //  new CharacterString();
      _description = default; //  new CharacterString();
      _function = default; //  new CI_OnLineFunctionCode_PropertyType();
    }

    #endregion

    #region Public Properties

    private URL_PropertyType _linkage;

    /// <summary>
    /// Location (address) for on-line access using a Uniform Resource Locator address or similar addressing scheme.
    /// </summary>
    /// <example>http://www.statkart.no/isotc211</example>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("linkage", Order = 0)]
    [JsonProperty("linkage", Order = 0)]
    public URL_PropertyType Linkage {
      get => _linkage;
      set => SetProperty(ref _linkage, value);
    }

    private CharacterString? _protocol;

    /// <summary>
    /// Connection protocol to be used.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("protocol", Order = 1)]
    [JsonProperty("protocol", Order = 1)]
    public CharacterString? Protocol {
      get => _protocol;
      set => SetProperty(ref _protocol, value);
    }

    private CharacterString? _applicationProfile;

    /// <summary>
    /// Name of an application profile that can be used with the online resource.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("applicationProfile", Order = 2)]
    [JsonProperty("applicationProfile", Order = 2)]
    public CharacterString? ApplicationProfile {
      get => _applicationProfile;
      set => SetProperty(ref _applicationProfile, value);
    }

    private CharacterString? _name;

    /// <summary>
    /// Name of the online resource.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("name", Order = 3)]
    [JsonProperty("name", Order = 3)]
    public CharacterString? Name {
      get => _name;
      set => SetProperty(ref _name, value);
    }

    private CharacterString? _description;

    /// <summary>
    /// Detailed text description of what the online resource is/does.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("description", Order = 4)]
    [JsonProperty("description", Order = 4)]
    public CharacterString? Description {
      get => _description;
      set => SetProperty(ref _description, value);
    }

    private CI_OnLineFunctionCode_CodeList? _function;

    /// <summary>
    /// Code for function performed by the online resource.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("function", Order = 5)]
    [JsonProperty("function", Order = 5)]
    public CI_OnLineFunctionCode_CodeList? Function {
      get => _function;
      set => SetProperty(ref _function, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="CI_OnlineResource_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="CI_OnlineResource_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(CI_OnlineResource_Type? other) {
      if (other == null) {
        return 1;
      }

      int result = Linkage?.CompareTo(other.Linkage) ?? 1;
      if (result != 0) {
        return result;
      }

      result = Protocol?.CompareTo(other.Protocol) ?? 1;
      if (result != 0) {
        return result;
      }

      result = ApplicationProfile?.CompareTo(other.ApplicationProfile) ?? 1;
      if (result != 0) {
        return result;
      }

      result = Name?.CompareTo(other.Name) ?? 1;
      if (result != 0) {
        return result;
      }

      result = Description?.CompareTo(other.Description) ?? 1;
      if (result != 0) {
        return result;
      }

      return Function?.CompareTo(other.Function) ?? 1;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="CI_OnlineResource_Type"/> is equal to the current <see cref="CI_OnlineResource_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="CI_OnlineResource_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(CI_OnlineResource_Type? other) {
      if (other == null) {
        return false;
      }

      return Equals(Linkage, other.Linkage) &&
             Equals(Protocol, other.Protocol) &&
             Equals(ApplicationProfile, other.ApplicationProfile) &&
             Equals(Name, other.Name) &&
             Equals(Description, other.Description) &&
             Equals(Function, other.Function);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="CI_OnlineResource_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as CI_OnlineResource_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="CI_OnlineResource_Type"/> using <see cref="NdshHashCode"/>. This will also order 
    /// collections before hashing them.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();
      hash.Add(Linkage);
      hash.Add(Protocol);
      hash.Add(ApplicationProfile);
      hash.Add(Name);
      hash.Add(Description);
      hash.Add(Function);
      return hash.ToHashCode();
    }

    #endregion

  }

}
