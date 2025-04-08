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
// <xs:complexType name="MD_Distribution_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="distributionFormat" type="gmd:MD_Format_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="distributor" type="gmd:MD_Distributor_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="transferOptions" type="gmd:MD_DigitalTransferOptions_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_Distribution" type="gmd:MD_Distribution_Type"/>
// <xs:complexType name="MD_Distribution_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_Distribution"/>
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
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Distribution {

  /// <summary>
  /// Information about the distributor of and options for obtaining the dataset
  /// </summary>
  [Serializable]
  //[XmlType("MD_Distribution", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_Distribution", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_Distribution")]
  public class MD_Distribution_Type : MetadataObject, IComparable<MD_Distribution_Type>, IEquatable<MD_Distribution_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Distribution_Type"/>.
    /// </summary>
    public MD_Distribution_Type() {
      _distributionFormat = default; //  new List<MD_Format_Type>();
      _distributor = default; //  new List<MD_Distributor_Type>();
      _transferOptions = default; //  new List<MD_DigitalTransferOptions_Type>();
    }

    #endregion

    #region Public Properties

    private ObservableCollection<MD_Format_Type>? _distributionFormat;

    /// <summary>
    /// Provides a description of the format of the data to be distributed.
    /// </summary>
    // TODO: OBL - C (MD_Distributor.distributionFormat not documented?)
    // TODO: CAR - N
    //[XmlElement("distributionFormat", Order = 0)]
    [JsonProperty("distributionFormat", Order = 0)]
    public ObservableCollection<MD_Format_Type>? DistributionFormat {
      get => _distributionFormat;
      set => SetProperty(ref _distributionFormat, value);
    }

    private ObservableCollection<MD_Distributor_Type>? _distributor;

    /// <summary>
    /// Provides information about the distributor.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("distributor", Order = 1)]
    [JsonProperty("distributor", Order = 1)]
    public ObservableCollection<MD_Distributor_Type>? Distributor {
      get => _distributor;
      set => SetProperty(ref _distributor, value);
    }

    private ObservableCollection<MD_DigitalTransferOptions_Type>? _transferOptions;

    /// <summary>
    /// Provides information about technical means and media by which a resource is obtained from the distributor.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("transferOptions", Order = 2)]
    [JsonProperty("transferOptions", Order = 2)]
    public ObservableCollection<MD_DigitalTransferOptions_Type>? TransferOptions {
      get => _transferOptions;
      set => SetProperty(ref _transferOptions, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="MD_Distribution_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="MD_Distribution_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(MD_Distribution_Type? other) {

      int result;

      return
        (other is null) ? 1 :
        (result = DistributionFormat?.Count.CompareTo(other.DistributionFormat?.Count ?? 0) ?? 1) != 0 ? result :
        (result = Distributor?.Count.CompareTo(other.Distributor?.Count ?? 0) ?? 1) != 0 ? result :
        TransferOptions?.Count.CompareTo(other.TransferOptions?.Count ?? 0) ?? 1;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="MD_Distribution_Type"/> is equal to the current <see cref="MD_Distribution_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="MD_Distribution_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(MD_Distribution_Type? other) {
      return other != null
        && DistributionFormat.SequenceEqualOrdered(other.DistributionFormat)
        && Distributor.SequenceEqualOrdered(other.Distributor)
        && TransferOptions.SequenceEqualOrdered(other.TransferOptions);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="MD_Distribution_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as MD_Distribution_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="MD_Distribution_Type"/> using <see cref="NdshHashCode"/>. This will also order 
    /// collections before hashing them.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      foreach (MD_Format_Type format in DistributionFormat.SafeOrderBy()) {
        hash.Add(format);
      }

      foreach (MD_Distributor_Type distributor in Distributor.SafeOrderBy()) {
        hash.Add(distributor);
      }

      foreach (MD_DigitalTransferOptions_Type transferOption in TransferOptions.SafeOrderBy()) {
        hash.Add(transferOption);
      }

      return hash.ToHashCode();
    }

    #endregion

  }

}
