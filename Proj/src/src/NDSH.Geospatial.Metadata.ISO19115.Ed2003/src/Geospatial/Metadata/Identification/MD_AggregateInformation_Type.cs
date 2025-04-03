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
// <xs:complexType name="MD_AggregateInformation_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="aggregateDataSetName" type="gmd:CI_Citation_PropertyType" minOccurs="0"/>
//         <xs:element name="aggregateDataSetIdentifier" type="gmd:MD_Identifier_PropertyType" minOccurs="0"/>
//         <xs:element name="associationType" type="gmd:DS_AssociationTypeCode_PropertyType"/>
//         <xs:element name="initiativeType" type="gmd:DS_InitiativeTypeCode_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_AggregateInformation" type="gmd:MD_AggregateInformation_Type"/>
// <xs:complexType name="MD_AggregateInformation_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_AggregateInformation"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.Citation;

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

namespace NDSH.Geospatial.Metadata.Identification {

  /// <summary>
  /// Encapsulates the dataset aggregation information.
  /// </summary>
  [Serializable]
  //[XmlType("MD_AggregateInformation", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_AggregateInformation", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_AggregateInformation")]
  public class MD_AggregateInformation_Type : MetadataObject, IComparable<MD_AggregateInformation_Type>, IEquatable<MD_AggregateInformation_Type> {

    #region Imported Namespaces 

    /// <summary>
    /// Initializes the <see cref="MD_AggregateInformation_Type"/>.
    /// </summary>
    public MD_AggregateInformation_Type() {
      _aggregateDataSetName = default; //  new CI_Citation_Type();
      _aggregateDataSetIdentifier = default; //  new MD_Identifier_Type();
      _associationType = default; //  new DS_AssociationTypeCode_PropertyType();
      _initiativeType = default; //  new DS_InitiativeTypeCode_PropertyType();
    }

    #endregion

    #region Public Properties

    private CI_Citation_Type? _aggregateDataSetName;

    /// <summary>
    /// Citation information about the aggregate dataset.
    /// </summary>
    // TODO: OBL - C (if aggregateDataSetIdentifier is not documented?)
    // TODO: CAR - 1
    //[XmlElement("aggregateDataSetName", Order = 0)]
    [JsonProperty("aggregateDataSetName", Order = 0)]
    public CI_Citation_Type? AggregateDataSetName {
      get => _aggregateDataSetName;
      set => SetProperty(ref _aggregateDataSetName, value);
    }

    private MD_Identifier_Type? _aggregateDataSetIdentifier;

    /// <summary>
    /// Identification information about aggregate dataset.
    /// </summary>
    // TODO: OBL - C (if aggregateDataSetName is not documented?)
    // TODO: CAR - 1
    //[XmlElement("aggregateDataSetIdentifier", Order = 1)]
    [JsonProperty("aggregateDataSetIdentifier", Order = 1)]
    public MD_Identifier_Type? AggregateDataSetIdentifier {
      get => _aggregateDataSetIdentifier;
      set => SetProperty(ref _aggregateDataSetIdentifier, value);
    }

    private DS_AssociationTypeCode_CodeList _associationType;

    /// <summary>
    /// Association type of the aggregate dataset.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("associationType", Order = 2)]
    [JsonProperty("associationType", Order = 2)]
    public DS_AssociationTypeCode_CodeList AssociationType {
      get => _associationType;
      set => SetProperty(ref _associationType, value);
    }

    private DS_InitiativeTypeCode_CodeList? _initiativeType;

    /// <summary>
    /// Type of initiative under which the aggregate dataset was produced.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("initiativeType", Order = 3)]
    [JsonProperty("initiativeType", Order = 3)]
    public DS_InitiativeTypeCode_CodeList? InitiativeType {
      get => _initiativeType;
      set => SetProperty(ref _initiativeType, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="MD_AggregateInformation_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="MD_AggregateInformation_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(MD_AggregateInformation_Type? other) {
      int result;

      return
        (other is null) ? 1 :
        (result = AggregateDataSetName?.CompareTo(other.AggregateDataSetName) ?? 1) != 0 ? result :
        (result = AggregateDataSetIdentifier?.CompareTo(other.AggregateDataSetIdentifier) ?? 1) != 0 ? result :
        (result = AssociationType?.CompareTo(other.AssociationType) ?? 1) != 0 ? result :
        InitiativeType?.CompareTo(other.InitiativeType) ?? 1;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="MD_AggregateInformation_Type"/> is equal to the current <see cref="MD_AggregateInformation_Type"/>.
    /// </summary>
    /// <param name="other">The <see cref="MD_AggregateInformation_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(MD_AggregateInformation_Type? other) {
      return other != null &&
             Equals(AggregateDataSetName, other.AggregateDataSetName) &&
             Equals(AggregateDataSetIdentifier, other.AggregateDataSetIdentifier) &&
             Equals(AssociationType, other.AssociationType) &&
             Equals(InitiativeType, other.InitiativeType);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="MD_AggregateInformation_Type"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as MD_AggregateInformation_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="MD_AggregateInformation_Type"/> using <see cref="NdshHashCode"/>.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      hash.Add(AggregateDataSetName);
      hash.Add(AggregateDataSetIdentifier);
      hash.Add(AssociationType);
      hash.Add(InitiativeType);

      return hash.ToHashCode();
    }

    #endregion

  }

}
