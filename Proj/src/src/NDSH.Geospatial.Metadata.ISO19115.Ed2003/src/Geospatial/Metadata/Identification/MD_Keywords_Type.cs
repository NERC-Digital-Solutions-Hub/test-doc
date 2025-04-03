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
// <xs:complexType name="MD_Keywords_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="keyword" type="gco:CharacterString_PropertyType" maxOccurs="unbounded"/>
//         <xs:element name="type" type="gmd:MD_KeywordTypeCode_PropertyType" minOccurs="0"/>
//         <xs:element name="thesaurusName" type="gmd:CI_Citation_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_Keywords" type="gmd:MD_Keywords_Type"/>
// <xs:complexType name="MD_Keywords_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_Keywords"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------

#endregion

#region Imported Namespaces

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
  /// Keywords, their type and reference source.
  /// </summary>
  [Serializable]
  //[XmlType("MD_Keywords", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_Keywords", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_Keywords")]
  public class MD_Keywords_Type : MetadataObject, IComparable<MD_Keywords_Type>, IEquatable<MD_Keywords_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Keywords_Type"/>.
    /// </summary>
    public MD_Keywords_Type() {
      _keyword = default; //  new List<CharacterString>();
      _type = default; //  new MD_KeywordTypeCode_PropertyType();
      _thesaurusName = default; //  new CI_Citation_Type();
    }

    #endregion

    #region Public Properties

    private ObservableCollection<CharacterString> _keyword; // TODO: LIST

    /// <summary>
    /// Commonly used word(s) or formalised word(s) or phrase(s) used to describe the subject.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - N
    //[XmlElement("keyword", Order = 0)]
    [JsonProperty("keyword", Order = 0)]
    public ObservableCollection<CharacterString> Keyword {
      get => _keyword;
      set => SetProperty(ref _keyword, value);
    }

    private MD_KeywordTypeCode_CodeList? _type;

    /// <summary>
    /// Subject matter used to group similar keywords.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("type", Order = 1)]
    [JsonProperty("type", Order = 1)]
    public MD_KeywordTypeCode_CodeList? Type {
      get => _type;
      set => SetProperty(ref _type, value);
    }

    private CI_Citation_Type? _thesaurusName;

    /// <summary>
    /// Name of the formally registered thesaurus or a similar authoritative source of keywords.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("thesaurusName", Order = 2)]
    [JsonProperty("thesaurusName", Order = 2)]
    public CI_Citation_Type? ThesaurusName {
      get => _thesaurusName;
      set => SetProperty(ref _thesaurusName, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="MD_Keywords_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="MD_Keywords_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(MD_Keywords_Type? other) {
      int result;

      return
        (other is null) ? 1 :
        (result = Keyword?.Count.CompareTo(other.Keyword?.Count ?? 0) ?? 1) != 0 ? result :
        (result = Type?.CompareTo(other.Type) ?? 1) != 0 ? result :
        ThesaurusName?.CompareTo(other.ThesaurusName) ?? 1;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="MD_Keywords_Type"/> is equal to the current <see cref="MD_Keywords_Type"/>.
    /// </summary>
    /// <param name="other">The <see cref="MD_Keywords_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(MD_Keywords_Type? other) {
      return other != null &&
             Keyword.SequenceEqualOrdered(other.Keyword) &&
             Equals(Type, other.Type) &&
             Equals(ThesaurusName, other.ThesaurusName);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="MD_Keywords_Type"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as MD_Keywords_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="MD_Keywords_Type"/> using <see cref="NdshHashCode"/>.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      foreach (CharacterString keyword in Keyword.SafeOrderBy()) {
        hash.Add(keyword);
      }

      hash.Add(Type);
      hash.Add(ThesaurusName);

      return hash.ToHashCode();
    }

    #endregion

  }

}
