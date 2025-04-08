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
// XSD:              : /2005/gmd/identification.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MD_RepresentativeFraction_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="denominator" type="gco:Integer_PropertyType"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_RepresentativeFraction" type="gmd:MD_RepresentativeFraction_Type"/>
// <xs:complexType name="MD_RepresentativeFraction_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_RepresentativeFraction"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces


using NDSH.Hashing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Identification {

  [Serializable]
  //[XmlType("MD_RepresentativeFraction", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_RepresentativeFraction", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_RepresentativeFraction")]
  public class MD_RepresentativeFraction_Type : MetadataObject, IComparable<MD_RepresentativeFraction_Type>, IEquatable<MD_RepresentativeFraction_Type> {

    // WARNING: VALUE TYPE

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_RepresentativeFraction_Type"/>.
    /// </summary>
    public MD_RepresentativeFraction_Type() {
      _denominator = default; //  new Integer_PropertyType();
    }

    #endregion

    #region Public Properties

    private int _denominator;

    /// <summary>
    /// The number below the line in a vulgar fraction.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("denominator", Order = 0)]
    [JsonProperty("denominator", Order = 0)]
    public int Denominator {
      get => _denominator;
      // TODO: SetProperty
      set {
        if (_denominator == value) {
          return;
        }
        if (/*_denominator == null || */_denominator.Equals(value) != true) {
          _denominator = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="MD_RepresentativeFraction_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="MD_RepresentativeFraction_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(MD_RepresentativeFraction_Type? other) {
      return (other is null) ? 1 : Denominator.CompareTo(other.Denominator);
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="MD_RepresentativeFraction_Type"/> is equal to the current <see cref="MD_RepresentativeFraction_Type"/>.
    /// </summary>
    /// <param name="other">The <see cref="MD_RepresentativeFraction_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(MD_RepresentativeFraction_Type? other) {
      return other != null && Denominator == other.Denominator;
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="MD_RepresentativeFraction_Type"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as MD_RepresentativeFraction_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="MD_RepresentativeFraction_Type"/> using <see cref="NdshHashCode"/>.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();
      hash.Add(Denominator);
      return hash.ToHashCode();
    }

    #endregion

  }

}
