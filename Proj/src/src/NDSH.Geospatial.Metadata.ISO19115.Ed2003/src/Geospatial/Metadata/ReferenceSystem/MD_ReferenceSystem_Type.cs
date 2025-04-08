#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 14:30, @gisvlasta.
// Updated by        : 09/01/2023, 20:47, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/referenceSystem.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MD_ReferenceSystem_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="referenceSystemIdentifier" type="gmd:RS_Identifier_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_ReferenceSystem" type="gmd:MD_ReferenceSystem_Type"/>
// <xs:complexType name="MD_ReferenceSystem_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_ReferenceSystem"/>
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

namespace NDSH.Geospatial.Metadata.ReferenceSystem {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_ReferenceSystem", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_ReferenceSystem", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_ReferenceSystem")]
  public class MD_ReferenceSystem_Type : MetadataObject,
    IComparable<MD_ReferenceSystem_Type>,
    IEquatable<MD_ReferenceSystem_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_ReferenceSystem_Type"/>.
    /// </summary>
    public MD_ReferenceSystem_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _referenceSystemIdentifier = default; //  new RS_Identifier_Type();

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private RS_Identifier_Type? _referenceSystemIdentifier;

    /// <summary>
    /// Name of the reference system.
    /// </summary>
    // TODO: OBL - O (refer to SC_CRS in ISO 19111 when coordinate reference is not given through ref. sys. id.)
    // TODO: CAR - 1
    [XmlElement("referenceSystemIdentifier", Order = 0)]
    [JsonProperty("referenceSystemIdentifier", Order = 0)]
    public RS_Identifier_Type? ReferenceSystemIdentifier {
      get {
        return _referenceSystemIdentifier;
      }
      set => SetProperty(ref _referenceSystemIdentifier, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="MD_ReferenceSystem_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="MD_ReferenceSystem_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(MD_ReferenceSystem_Type? other) {
      int result;

      return
          (other is null) ? 1 :
          (result = ReferenceSystemIdentifier?.CompareTo(other.ReferenceSystemIdentifier) ?? 1) != 0 ? result : 0;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="MD_ReferenceSystem_Type"/> is equal to the current <see cref="MD_ReferenceSystem_Type"/>.
    /// </summary>
    /// <param name="other">The <see cref="MD_ReferenceSystem_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(MD_ReferenceSystem_Type? other) {
      return other != null &&
             Equals(ReferenceSystemIdentifier, other.ReferenceSystemIdentifier);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="MD_ReferenceSystem_Type"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as MD_ReferenceSystem_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="MD_ReferenceSystem_Type"/> using <see cref="NdshHashCode"/>.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();
      hash.Add(ReferenceSystemIdentifier);
      return hash.ToHashCode();
    }

    #endregion

  }

}
