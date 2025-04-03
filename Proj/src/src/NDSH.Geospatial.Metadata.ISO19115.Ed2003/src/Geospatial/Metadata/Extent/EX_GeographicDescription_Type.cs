#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 22/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/extent.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="EX_GeographicDescription_Type">
//   <xs:complexContent>
//     <xs:extension base="gmd:AbstractEX_GeographicExtent_Type">
//       <xs:sequence>
//         <xs:element name="geographicIdentifier" type="gmd:MD_Identifier_PropertyType"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="EX_GeographicDescription"
//             type="gmd:EX_GeographicDescription_Type"
//             substitutionGroup="gmd:AbstractEX_GeographicExtent"/>
// <xs:complexType name="EX_GeographicDescription_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:EX_GeographicDescription"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//  <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.ReferenceSystem;
using NDSH.Hashing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Extent {

  [Serializable]
  //[XmlType("EX_GeographicDescription", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("EX_GeographicDescription", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("EX_GeographicDescription")]
  public class EX_GeographicDescription_Type : AbstractEX_GeographicExtent_Type, IComparable<EX_GeographicDescription_Type>, IEquatable<EX_GeographicDescription_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_GeographicDescription_Type"/>.
    /// </summary>
    public EX_GeographicDescription_Type() {
      _geographicIdentifier = default; //  new MD_Identifier_Type();
    }

    #endregion

    #region Public Properties

    private MD_Identifier_Type _geographicIdentifier;

    /// <summary>
    /// Identifier used to represent a geographic area.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("geographicIdentifier", Order = 0)]
    [JsonProperty("geographicIdentifier", Order = 0)]
    public MD_Identifier_Type GeographicIdentifier {
      get => _geographicIdentifier;
      set => SetProperty(ref _geographicIdentifier, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="EX_GeographicDescription_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="EX_GeographicDescription_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(EX_GeographicDescription_Type? other) {
      int result;

      return
          other is null ? 1 :
          (result = base.CompareTo(other)) != 0 ? result :
          GeographicIdentifier.CompareTo(other.GeographicIdentifier);
    }

    /// <inheritdoc />
    public override int CompareTo(AbstractEX_GeographicExtent_Type? other) {
      return CompareTo(other as EX_GeographicDescription_Type);
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="EX_GeographicDescription_Type"/> is equal to the current <see cref="EX_GeographicDescription_Type"/>.
    /// </summary>
    /// <param name="other">The <see cref="EX_GeographicDescription_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(EX_GeographicDescription_Type? other) {
      return other != null &&
          base.Equals(other) &&
          Equals(GeographicIdentifier, other.GeographicIdentifier);
    }

    /// <inheritdoc />
    public override bool Equals(AbstractEX_GeographicExtent_Type? other) {
      return Equals(other as EX_GeographicDescription_Type);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="EX_GeographicDescription_Type"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as EX_GeographicDescription_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="EX_GeographicDescription_Type"/> using <see cref="NdshHashCode"/>.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();
      hash.Add(base.GetHashCode());
      hash.Add(GeographicIdentifier);
      return hash.ToHashCode();
    }

    #endregion

  }

}
