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
// <xs:complexType name="MD_Constraints_Type">
//   <xs:annotation>
//     <xs:documentation>Restrictions on the access and use of a dataset or metadata</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="useLimitation" type="gco:CharacterString_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_Constraints" type="gmd:MD_Constraints_Type"/>
// <xs:complexType name="MD_Constraints_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_Constraints"/>
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
  /// Restrictions on the access and use of a dataset or metadata.
  /// </summary>
  //[XmlInclude(typeof(MD_SecurityConstraints_Type))]
  //[XmlInclude(typeof(MD_LegalConstraints_Type))]
  [Serializable]
  //[XmlType("MD_Constraints", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_Constraints", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_Constraints")]
  public class MD_Constraints_Type : MetadataObject, IComparable<MD_Constraints_Type>, IEquatable<MD_Constraints_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Constraints_Type"/>.
    /// </summary>
    public MD_Constraints_Type() {
      _useLimitation = default; //  new List<CharacterString>();
    }

    #endregion

    #region Public Properties

    private ObservableCollection<CharacterString>? _useLimitation;

    /// <summary>
    /// Limitation affecting the fitness for use of the resource or metadata.
    /// </summary>
    /// <example>"not to be used for navigation"</example>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("useLimitation", Order = 0)]
    [JsonProperty("useLimitation", Order = 0)]
    public ObservableCollection<CharacterString>? UseLimitation {
      get => _useLimitation;
      set => SetProperty(ref _useLimitation, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="MD_Constraints_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="MD_Constraints_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public virtual int CompareTo(MD_Constraints_Type? other) {
      return
        (other is null) ? 1 :
        UseLimitation?.Count.CompareTo(other.UseLimitation?.Count ?? 0) ?? 1;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="MD_Constraints_Type"/> is equal to the current <see cref="MD_Constraints_Type"/>.
    /// </summary>
    /// <param name="other">The <see cref="MD_Constraints_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public virtual bool Equals(MD_Constraints_Type? other) {
      return other != null &&
             UseLimitation.SequenceEqualOrdered(other.UseLimitation);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="MD_Constraints_Type"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as MD_Constraints_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="MD_Constraints_Type"/> using <see cref="NdshHashCode"/>.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      foreach (CharacterString useLimitation in UseLimitation.SafeOrderBy()) {
        hash.Add(useLimitation);
      }

      return hash.ToHashCode();
    }

    #endregion

  }

}
