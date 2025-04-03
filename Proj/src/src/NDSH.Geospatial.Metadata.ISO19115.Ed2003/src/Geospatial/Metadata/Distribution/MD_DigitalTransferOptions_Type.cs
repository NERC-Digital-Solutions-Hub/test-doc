
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
// <xs:complexType name="MD_DigitalTransferOptions_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="unitsOfDistribution" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="transferSize" type="gco:Real_PropertyType" minOccurs="0"/>
//         <xs:element name="onLine" type="gmd:CI_OnlineResource_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="offLine" type="gmd:MD_Medium_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_DigitalTransferOptions" type="gmd:MD_DigitalTransferOptions_Type"/>
// <xs:complexType name="MD_DigitalTransferOptions_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_DigitalTransferOptions"/>
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

namespace NDSH.Geospatial.Metadata.Distribution {

  // WARNING: REFACTOR.
  // WARNING: Check if there are conditional properties

  /// <summary>
  /// Technical means and media by which a dataset is obtained from the distributor.
  /// </summary>
  [Serializable]
  //[XmlType("MD_DigitalTransferOptions", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_DigitalTransferOptions", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_DigitalTransferOptions")]
  public class MD_DigitalTransferOptions_Type : MetadataObject,
    IComparable<MD_DigitalTransferOptions_Type>,
    IEquatable<MD_DigitalTransferOptions_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_DigitalTransferOptions_Type"/>.
    /// </summary>
    public MD_DigitalTransferOptions_Type() {
      _unitsOfDistribution = default; //  new CharacterString();
      _transferSize = default; //  new Real_PropertyType();
      _onLine = default; //  new List<CI_OnlineResource_Type>();
      _offLine = default; //  new MD_Medium_Type();
    }

    #endregion

    #region Public Properties

    private CharacterString? _unitsOfDistribution;

    /// <summary>
    /// Tiles, layers, geographic areas, etc., in which data is available.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("unitsOfDistribution", Order = 0)]
    [JsonProperty("unitsOfDistribution", Order = 0)]
    public CharacterString? UnitsOfDistribution {
      get => _unitsOfDistribution;
      set => SetProperty(ref _unitsOfDistribution, value);
    }

    private double? _transferSize;

    /// <summary>
    /// Estimated size of a unit in the specified transfer format, expressed in megabytes.
    /// The transfer size is > 0.0.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    // WARNING Add validation here. The transfer size is > 0.0.
    //[XmlElement("transferSize", Order = 1)]
    [JsonProperty("transferSize", Order = 1)]
    public double? TransferSize {
      get => _transferSize;
      set => SetProperty(ref _transferSize, value);
    }

    private ObservableCollection<CI_OnlineResource_Type>? _onLine;

    /// <summary>
    /// Information about online sources from which the resource can be obtained.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("onLine", Order = 2)]
    [JsonProperty("onLine", Order = 2)]
    public ObservableCollection<CI_OnlineResource_Type>? OnLine {
      get => _onLine;
      set => SetProperty(ref _onLine, value);
    }

    private MD_Medium_Type? _offLine;

    /// <summary>
    /// Information about offline media on which the resource can be obtained.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("offLine", Order = 3)]
    [JsonProperty("offLine", Order = 3)]
    public MD_Medium_Type? OffLine {
      get => _offLine;
      set => SetProperty(ref _offLine, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="MD_DigitalTransferOptions_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="MD_DigitalTransferOptions_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(MD_DigitalTransferOptions_Type? other) {

      int result;

      return
        (other is null) ? 1 :
        (result = UnitsOfDistribution?.CompareTo(other.UnitsOfDistribution) ?? 1) != 0 ? result :
        (result = TransferSize?.CompareTo(other.TransferSize) ?? 1) != 0 ? result :
        (result = OnLine?.Count.CompareTo(other.OnLine?.Count ?? 0) ?? 1) != 0 ? result :
        OffLine?.CompareTo(other.OffLine) ?? 1;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="MD_DigitalTransferOptions_Type"/> is equal to the current <see cref="MD_DigitalTransferOptions_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="MD_DigitalTransferOptions_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(MD_DigitalTransferOptions_Type? other) {
      return other != null &&
         Equals(UnitsOfDistribution, other.UnitsOfDistribution) &&
         Equals(TransferSize, other.TransferSize) &&
         OnLine.SequenceEqualOrdered(other.OnLine) &&
         Equals(OffLine, other.OffLine);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="MD_DigitalTransferOptions_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as MD_DigitalTransferOptions_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="MD_DigitalTransferOptions_Type"/> using <see cref="NdshHashCode"/>. This will also order 
    /// collections before hashing them.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      hash.Add(UnitsOfDistribution);
      hash.Add(TransferSize);

      foreach (CI_OnlineResource_Type onlineResource in OnLine.SafeOrderBy()) {
        hash.Add(onlineResource);
      }

      hash.Add(OffLine);

      return hash.ToHashCode();
    }

    #endregion

  }

}
