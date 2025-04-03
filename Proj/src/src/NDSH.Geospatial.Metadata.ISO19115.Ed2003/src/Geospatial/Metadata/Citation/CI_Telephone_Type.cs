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
// <xs:complexType name="CI_Telephone_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="voice" type="gco:CharacterString_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="facsimile" type="gco:CharacterString_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="CI_Telephone" type="gmd:CI_Telephone_Type"/>
// <xs:complexType name="CI_Telephone_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:CI_Telephone"/>
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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.Citation {

  /// <summary>
  /// Telephone numbers for contacting the responsible individual or organisation.
  /// </summary>
  [Serializable]
  //[XmlType("CI_Telephone", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("CI_Telephone", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("CI_Telephone")]
  public class CI_Telephone_Type : MetadataObject, IComparable<CI_Telephone_Type>, IEquatable<CI_Telephone_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_Telephone_Type"/>.
    /// </summary>
    public CI_Telephone_Type() {
      _voice = default; //  new List<CharacterString>();
      _facsimile = default; //  new List<CharacterString>();
    }

    #endregion

    #region Public Properties

    private ObservableCollection<CharacterString>? _voice;

    /// <summary>
    /// Telephone number by which individuals can speak to the responsible organization or individual.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("voice", Order = 0)]
    [JsonProperty("voice", Order = 0)]
    public ObservableCollection<CharacterString>? Voice {
      get => _voice;
      set => SetProperty(ref _voice, value);
    }

    private ObservableCollection<CharacterString>? _facsimile;

    /// <summary>
    /// Telephone number of a facsimile machine for the responsible organization or individual.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("facsimile", Order = 1)]
    [JsonProperty("facsimile", Order = 1)]
    public ObservableCollection<CharacterString>? Facsimile {
      get => _facsimile;
      set => SetProperty(ref _facsimile, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="CI_Telephone_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="CI_Telephone_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(CI_Telephone_Type? other) {
      if (other == null) {
        return 1;
      }

      int result = Voice?.Count.CompareTo(other.Voice?.Count ?? 0) ?? 1;
      if (result != 0) {
        return result;
      }

      return Facsimile?.Count.CompareTo(other.Facsimile?.Count ?? 0) ?? 1;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="CI_Telephone_Type"/> is equal to the current <see cref="CI_Telephone_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="CI_Telephone_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(CI_Telephone_Type? other) {
      if (other == null) {
        return false;
      }

      return Voice.SequenceEqualOrdered(other.Voice) &&
                Facsimile.SequenceEqualOrdered(other.Facsimile);
    }

    #endregion

    #region Overrides


    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="CI_Telephone_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as CI_Telephone_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="CI_Telephone_Type"/> using <see cref="NdshHashCode"/>. This will also order 
    /// collections before hashing them.
    /// </summary>
    /// <returns>The hash code for the <see cref="CI_Telephone_Type"/>.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      foreach (CharacterString characterString in Voice.SafeOrderBy()) {
        hash.Add(characterString);
      }

      foreach (CharacterString characterString in Facsimile.SafeOrderBy()) {
        hash.Add(characterString);
      }
      return hash.ToHashCode();
    }

    #endregion

  }

}
