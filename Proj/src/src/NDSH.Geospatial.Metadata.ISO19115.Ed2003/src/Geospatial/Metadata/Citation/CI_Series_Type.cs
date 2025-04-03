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
// <xs:complexType name="CI_Series_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="name" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="issueIdentification" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="page" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="CI_Series" type="gmd:CI_Series_Type"/>
// <xs:complexType name="CI_Series_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:CI_Series"/>
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

  [Serializable]
  //[XmlType("CI_Series", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("CI_Series", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("CI_Series")]
  public class CI_Series_Type : MetadataObject, IComparable<CI_Series_Type>, IEquatable<CI_Series_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_Series_Type"/>.
    /// </summary>
    public CI_Series_Type() {
      _name = default; //  new CharacterString();
      _issueIdentification = default; //  new CharacterString();
      _page = default; //  new CharacterString();
    }

    #endregion

    #region Public Properties

    private CharacterString? _name;

    /// <summary>
    /// Name of the series, or aggregate dataset, of which the dataset is a part.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("name", Order = 0)]
    [JsonProperty("name", Order = 0)]
    public CharacterString? Name {
      get => _name;
      set => SetProperty(ref _name, value);
    }

    private CharacterString? _issueIdentification;

    /// <summary>
    /// Information identifying the issue of the series.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("issueIdentification", Order = 1)]
    [JsonProperty("issueIdentification", Order = 1)]
    public CharacterString? IssueIdentification {
      get => _issueIdentification;
      set => SetProperty(ref _issueIdentification, value);
    }

    private CharacterString? _page;

    /// <summary>
    /// Details on which pages of the publication the article was published.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("page", Order = 2)]
    [JsonProperty("page", Order = 2)]
    public CharacterString? Page {
      get => _page;
      set => SetProperty(ref _page, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="CI_Series_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="CI_Series_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(CI_Series_Type? other) {
      if (other == null) {
        return 1;
      }

      int result = Name?.CompareTo(other.Name) ?? 1;
      if (result != 0) {
        return result;
      }

      result = IssueIdentification?.CompareTo(other.IssueIdentification) ?? 1;
      if (result != 0) {
        return result;
      }

      return Page?.CompareTo(other.Page) ?? 1;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="CI_Series_Type"/> is equal to the current <see cref="CI_Series_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="CI_Series_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(CI_Series_Type? other) {
      if (other == null) {
        return false;
      }

      return Equals(Name, other.Name) &&
             Equals(IssueIdentification, other.IssueIdentification) &&
             Equals(Page, other.Page);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="CI_Series_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as CI_Series_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="CI_Series_Type"/> using <see cref="NdshHashCode"/>. This will also order 
    /// collections before hashing them.
    /// </summary>
    /// <returns>The hash code for the <see cref="CI_Series_Type"/>.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();
      hash.Add(Name);
      hash.Add(IssueIdentification);
      hash.Add(Page);
      return hash.ToHashCode();
    }

    #endregion

  }

}
