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
// XSD               : /2005/gmd/distribution.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MD_Format_Type">
//   <xs:annotation>
//     <xs:documentation>Description of the form of the data to be distributed</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="name"
//                     type="gco:CharacterString_PropertyType"/>
//         <xs:element name="version"
//                     type="gco:CharacterString_PropertyType"/>
//         <xs:element name="amendmentNumber"
//                     type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="specification"
//                     type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="fileDecompressionTechnique"
//                     type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="formatDistributor"
//                     type="gmd:MD_Distributor_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_Format" type="gmd:MD_Format_Type"/>
// <xs:complexType name="MD_Format_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_Format"/>
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

namespace NDSH.Geospatial.Metadata.Distribution {

  /// <summary>
  /// Description of the form of the data to be distributed.
  /// </summary>
  [Serializable]
  //[XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_Format", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_Format")]
  public class MD_Format_Type : MetadataObject, IComparable<MD_Format_Type>, IEquatable<MD_Format_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Format_Type"/>.
    /// </summary>
    public MD_Format_Type() {
      _name = default; //  new CharacterString();
      _version = default; //  new CharacterString();
      _amendmentNumber = default; //  new CharacterString();
      _specification = default; //  new CharacterString();
      _fileDecompressionTechnique = default; //  new CharacterString();
      _formatDistributor = default; //  new List<MD_Distributor_Type>();
    }

    #endregion

    #region Public Properties

    private CharacterString _name;

    /// <summary>
    /// Name of the data transfer format(s).
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("name", Order = 0)]
    [JsonProperty("name", Order = 0)]
    public CharacterString Name {
      get => _name;
      set => SetProperty(ref _name, value);
    }

    private CharacterString _version;

    /// <summary>
    /// Version of the format (date, number, etc.).
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("version", Order = 1)]
    [JsonProperty("version", Order = 1)]
    public CharacterString Version {
      get => _version;
      set => SetProperty(ref _version, value);
    }

    private CharacterString? _amendmentNumber;

    /// <summary>
    /// Amendment number of the format version.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("amendmentNumber", Order = 2)]
    [JsonProperty("amendmentNumber", Order = 2)]
    public CharacterString? AmendmentNumber {
      get => _amendmentNumber;
      set => SetProperty(ref _amendmentNumber, value);
    }

    private CharacterString? _specification;

    /// <summary>
    /// Name of a subset, profile, or product specification of the format.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("specification", Order = 3)]
    [JsonProperty("specification", Order = 3)]
    public CharacterString? Specification {
      get => _specification;
      set => SetProperty(ref _specification, value);
    }

    private CharacterString? _fileDecompressionTechnique;

    /// <summary>
    /// Recommendations of algorithms or processes that can be applied to read or
    /// expand resources to which compression techniques have been applied.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("fileDecompressionTechnique", Order = 4)]
    [JsonProperty("fileDecompressionTechnique", Order = 4)]
    public CharacterString? FileDecompressionTechnique {
      get => _fileDecompressionTechnique;
      set => SetProperty(ref _fileDecompressionTechnique, value);
    }

    private ObservableCollection<MD_Distributor_Type>? _formatDistributor;

    /// <summary>
    /// Provides information about the distributor's format.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("formatDistributor", Order = 5)]
    [JsonProperty("formatDistributor", Order = 5)]
    public ObservableCollection<MD_Distributor_Type>? FormatDistributor {
      get => _formatDistributor;
      set => SetProperty(ref _formatDistributor, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="MD_Format_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="MD_Format_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(MD_Format_Type? other) {
      int result;

      return
        (other is null) ? 1 :
        (result = Name?.CompareTo(other.Name) ?? 1) != 0 ? result :
        (result = Version?.CompareTo(other.Version) ?? 1) != 0 ? result :
        (result = AmendmentNumber?.CompareTo(other.AmendmentNumber) ?? 1) != 0 ? result :
        (result = Specification?.CompareTo(other.Specification) ?? 1) != 0 ? result :
        (result = FileDecompressionTechnique?.CompareTo(other.FileDecompressionTechnique) ?? 1) != 0 ? result :
        FormatDistributor?.Count.CompareTo(other.FormatDistributor?.Count ?? 0) ?? 1;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="MD_Format_Type"/> is equal to the current <see cref="MD_Format_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="MD_Format_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(MD_Format_Type? other) {
      return other != null &&
         Equals(Name, other.Name) &&
         Equals(Version, other.Version) &&
         Equals(AmendmentNumber, other.AmendmentNumber) &&
         Equals(Specification, other.Specification) &&
         Equals(FileDecompressionTechnique, other.FileDecompressionTechnique) &&
         FormatDistributor.SequenceEqualOrdered(other.FormatDistributor);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="MD_Format_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as MD_Format_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="MD_Format_Type"/> using <see cref="NdshHashCode"/>. This will also order 
    /// collections before hashing them.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      hash.Add(Name);
      hash.Add(Version);
      hash.Add(AmendmentNumber);
      hash.Add(Specification);
      hash.Add(FileDecompressionTechnique);

      foreach (MD_Distributor_Type distributor in FormatDistributor.SafeOrderBy()) {
        hash.Add(distributor);
      }

      return hash.ToHashCode();
    }

    #endregion

  }

}
