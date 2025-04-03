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
// <xs:complexType name="MD_Distributor_Type">
//   <xs:annotation>
//     <xs:documentation>Information about the distributor</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="distributorContact"
//                     type="gmd:CI_ResponsibleParty_PropertyType"/>
//         <xs:element name="distributionOrderProcess"
//                     type="gmd:MD_StandardOrderProcess_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="distributorFormat"
//                     type="gmd:MD_Format_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="distributorTransferOptions"
//                     type="gmd:MD_DigitalTransferOptions_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_Distributor" type="gmd:MD_Distributor_Type"/>
// <xs:complexType name="MD_Distributor_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_Distributor"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

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

  /// <summary>
  /// Information about the distributor.
  /// </summary>
  [Serializable]
  //[XmlType("MD_Distributor", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_Distributor", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_Distributor")]
  public class MD_Distributor_Type : MetadataObject, IComparable<MD_Distributor_Type>, IEquatable<MD_Distributor_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Distributor_Type"/>.
    /// </summary>
    public MD_Distributor_Type() {
      _distributorContact = default; //  new CI_ResponsibleParty_Type();
      _distributionOrderProcess = default; //  new List<MD_StandardOrderProcess_Type>();
      _distributorFormat = default; //  new List<MD_Format_Type>();
      _distributorTransferOptions = default; //  new List<MD_DigitalTransferOptions_Type>();
    }

    #endregion

    #region Public Properties

    private CI_ResponsibleParty_Type _distributorContact;

    /// <summary>
    /// Party from whom the resource may be obtained. This list need not be exhaustive.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("distributorContact", Order = 0)]
    [JsonProperty("distributorContact", Order = 0)]
    public CI_ResponsibleParty_Type DistributorContact {
      get => _distributorContact;
      set => SetProperty(ref _distributorContact, value);
    }

    private ObservableCollection<MD_StandardOrderProcess_Type>? _distributionOrderProcess;

    /// <summary>
    /// Provides information about how the resource may be obtained, and related instructions and fee information.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("distributionOrderProcess", Order = 1)]
    [JsonProperty("distributionOrderProcess", Order = 1)]
    public ObservableCollection<MD_StandardOrderProcess_Type>? DistributionOrderProcess {
      get => _distributionOrderProcess;
      set => SetProperty(ref _distributionOrderProcess, value);
    }

    private ObservableCollection<MD_Format_Type>? _distributorFormat;

    /// <summary>
    /// Provides information about the format used by the distributor.
    /// </summary>
    // TODO: OBL - C (MD_Distribution.distributionFormat not documented?)
    // TODO: CAR - N
    //[XmlElement("distributorFormat", Order = 2)]
    [JsonProperty("distributorFormat", Order = 2)]
    public ObservableCollection<MD_Format_Type>? DistributorFormat {
      get => _distributorFormat;
      set => SetProperty(ref _distributorFormat, value);
    }

    private ObservableCollection<MD_DigitalTransferOptions_Type>? _distributorTransferOptions;

    /// <summary>
    /// Provides information about the technical means and media used by the distributor.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("distributorTransferOptions", Order = 3)]
    [JsonProperty("distributorTransferOptions", Order = 3)]
    public ObservableCollection<MD_DigitalTransferOptions_Type>? DistributorTransferOptions {
      get => _distributorTransferOptions;
      set => SetProperty(ref _distributorTransferOptions, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="MD_Distributor_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="MD_Distributor_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(MD_Distributor_Type? other) {

      int result;

      return
        (other is null) ? 1 :
        (result = DistributorContact?.CompareTo(other.DistributorContact) ?? 1) != 0 ? result :
        (result = DistributionOrderProcess?.Count.CompareTo(other.DistributionOrderProcess?.Count ?? 0) ?? 1) != 0 ? result :
        (result = DistributorFormat?.Count.CompareTo(other.DistributorFormat?.Count ?? 0) ?? 1) != 0 ? result :
        DistributorTransferOptions?.Count.CompareTo(other.DistributorTransferOptions?.Count ?? 0) ?? 1;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="MD_Distributor_Type"/> is equal to the current <see cref="MD_Distributor_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="MD_Distributor_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(MD_Distributor_Type? other) {
      return other != null &&
         Equals(DistributorContact, other.DistributorContact) &&
         DistributionOrderProcess.SequenceEqualOrdered(other.DistributionOrderProcess) &&
         DistributorFormat.SequenceEqualOrdered(other.DistributorFormat) &&
         DistributorTransferOptions.SequenceEqualOrdered(other.DistributorTransferOptions);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="MD_Distributor_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as MD_Distributor_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="MD_Distributor_Type"/> using <see cref="NdshHashCode"/>. This will also order 
    /// collections before hashing them.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      hash.Add(DistributorContact);

      foreach (MD_StandardOrderProcess_Type orderProcess in DistributionOrderProcess.SafeOrderBy()) {
        hash.Add(orderProcess);
      }

      foreach (MD_Format_Type format in DistributorFormat.SafeOrderBy()) {
        hash.Add(format);
      }

      foreach (MD_DigitalTransferOptions_Type transferOption in DistributorTransferOptions.SafeOrderBy()) {
        hash.Add(transferOption);
      }

      return hash.ToHashCode();
    }

    #endregion

  }

}
