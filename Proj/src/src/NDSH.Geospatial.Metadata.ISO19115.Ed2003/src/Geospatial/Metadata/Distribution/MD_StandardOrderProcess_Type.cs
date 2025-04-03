#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 23/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/distribution.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MD_StandardOrderProcess_Type">
//   <xs:annotation>
//     <xs:documentation>Common ways in which the dataset may be obtained or received, and related instructions and fee information</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="fees" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="plannedAvailableDateTime" type="gco:DateTime_PropertyType" minOccurs="0"/>
//         <xs:element name="orderingInstructions" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="turnaround" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_StandardOrderProcess" type="gmd:MD_StandardOrderProcess_Type"/>
// <xs:complexType name="MD_StandardOrderProcess_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_StandardOrderProcess"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.DateTime;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;

using NDSH.Hashing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Distribution {

  /// <summary>
  /// Common ways in which the dataset may be obtained or received, and related instructions and fee information.
  /// </summary>
  [Serializable]
  //[XmlType("MD_StandardOrderProcess", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_StandardOrderProcess", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_StandardOrderProcess")]
  public class MD_StandardOrderProcess_Type : MetadataObject, IComparable<MD_StandardOrderProcess_Type>, IEquatable<MD_StandardOrderProcess_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_StandardOrderProcess_Type"/>.
    /// </summary>
    public MD_StandardOrderProcess_Type() {
      _fees = default; //  new CharacterString();
      _plannedAvailableDateTime = default; //  new DateTime_PropertyType();
      _orderingInstructions = default; //  new CharacterString();
      _turnaround = default; //  new CharacterString();
    }

    #endregion

    #region Public Properties

    private CharacterString? _fees;

    /// <summary>
    /// Fees and terms for retrieving the resource. Include monetary units (as specified in ISO 4217).
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("fees", Order = 0)]
    [JsonProperty("fees", Order = 0)]
    public CharacterString? Fees {
      get => _fees;
      set => SetProperty(ref _fees, value);
    }

    private DateTimeDbEntity? _plannedAvailableDateTime;

    /// <summary>
    /// Date and time when the resource will be available.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("plannedAvailableDateTime", Order = 1)]
    [JsonProperty("plannedAvailableDateTime", Order = 1)]
    public DateTimeDbEntity? PlannedAvailableDateTime {
      get => _plannedAvailableDateTime;
      set => SetProperty(ref _plannedAvailableDateTime, value);
    }

    private CharacterString? _orderingInstructions;

    /// <summary>
    /// General instructions, terms and services provided by the distributor.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("orderingInstructions", Order = 2)]
    [JsonProperty("orderingInstructions", Order = 2)]
    public CharacterString? OrderingInstructions {
      get => _orderingInstructions;
      set => SetProperty(ref _orderingInstructions, value);
    }

    private CharacterString? _turnaround;

    /// <summary>
    /// Typical turnaround time for the filling of an order.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("turnaround", Order = 3)]
    [JsonProperty("turnaround", Order = 3)]
    public CharacterString? Turnaround {
      get => _turnaround;
      set => SetProperty(ref _turnaround, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="MD_StandardOrderProcess_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="MD_StandardOrderProcess_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(MD_StandardOrderProcess_Type? other) {
      int result;

      return
        (other is null) ? 1 :
        (result = Fees?.CompareTo(other.Fees) ?? 1) != 0 ? result :
        (result = PlannedAvailableDateTime?.CompareTo(other.PlannedAvailableDateTime) ?? 1) != 0 ? result :
        (result = OrderingInstructions?.CompareTo(other.OrderingInstructions) ?? 1) != 0 ? result :
        Turnaround?.CompareTo(other.Turnaround) ?? 1;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="MD_StandardOrderProcess_Type"/> is equal to the current <see cref="MD_StandardOrderProcess_Type"/>.
    /// </summary>
    /// <param name="other">The <see cref="MD_StandardOrderProcess_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(MD_StandardOrderProcess_Type? other) {
      return other != null &&
        Equals(Fees, other.Fees) &&
        Equals(PlannedAvailableDateTime, other.PlannedAvailableDateTime) &&
        Equals(OrderingInstructions, other.OrderingInstructions) &&
        Equals(Turnaround, other.Turnaround);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="MD_StandardOrderProcess_Type"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as MD_StandardOrderProcess_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="MD_StandardOrderProcess_Type"/> using <see cref="NdshHashCode"/>.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      hash.Add(Fees);
      hash.Add(PlannedAvailableDateTime);
      hash.Add(OrderingInstructions);
      hash.Add(Turnaround);

      return hash.ToHashCode();
    }

    #endregion

  }

}
