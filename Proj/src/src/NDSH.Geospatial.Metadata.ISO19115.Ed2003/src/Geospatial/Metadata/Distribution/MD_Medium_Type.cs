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
// <xs:complexType name="MD_Medium_Type">
//   <xs:annotation>
//     <xs:documentation>Information about the media on which the data can be distributed</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="name"
//                     type="gmd:MD_MediumNameCode_PropertyType" minOccurs="0"/>
//         <xs:element name="density"
//                     type="gco:Real_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="densityUnits"
//                     type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="volumes"
//                     type="gco:Integer_PropertyType" minOccurs="0"/>
//         <xs:element name="mediumFormat"
//                     type="gmd:MD_MediumFormatCode_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="mediumNote"
//                     type="gco:CharacterString_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_Medium" type="gmd:MD_Medium_Type"/>
// <xs:complexType name="MD_Medium_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_Medium"/>
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
  /// Information about the media on which the data can be distributed.
  /// </summary>
  [Serializable]
  //[XmlType("MD_Medium", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_Medium", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_Medium")]
  public class MD_Medium_Type : MetadataObject, IComparable<MD_Medium_Type>, IEquatable<MD_Medium_Type> {

    // WARNING: Check which value types need to be nullable.

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Medium_Type"/>.
    /// </summary>
    public MD_Medium_Type() {
      _name = default; //  new MD_MediumNameCode_PropertyType();
      _density = default; //  new List<Real_PropertyType>();
      _densityUnits = default; //  new CharacterString();
      _volumes = default; //  new Integer_PropertyType();
      _mediumFormat = default; //  new List<MD_MediumFormatCode_PropertyType>();
      _mediumNote = default; //  new CharacterString();
    }

    #endregion

    #region Public Properties

    private MD_MediumNameCode_CodeList? _name;

    /// <summary>
    /// Name of the medium on which the resource can be received.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("name", Order = 0)]
    [JsonProperty("name", Order = 0)]
    public MD_MediumNameCode_CodeList? Name {
      get => _name;
      set => SetProperty(ref _name, value);
    }

    private ObservableCollection<double>? _density;

    /// <summary>
    ///  Density at which the data is recorded.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("density", Order = 1)]
    [JsonProperty("density", Order = 1)]
    public ObservableCollection<double>? Density {
      get => _density;
      set => SetProperty(ref _density, value);
    }

    private CharacterString? _densityUnits;

    /// <summary>
    /// Units of measure for the recording density.
    /// </summary>
    // TODO: OBL - C (density documented?)
    // TODO: CAR - 1
    //[XmlElement("densityUnits", Order = 2)]
    [JsonProperty("densityUnits", Order = 2)]
    public CharacterString? DensityUnits {
      get => _densityUnits;
      set => SetProperty(ref _densityUnits, value);
    }

    private int? _volumes;

    /// <summary>
    /// Number of items in the media identified.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("volumes", Order = 3)]
    [JsonProperty("volumes", Order = 3)]
    public int? Volumes {
      get => _volumes;
      // TODO: SetProperty
      set {
        if (_volumes == value) {
          return;
        }
        if (/*_volumes == null || */_volumes.Equals(value) != true) {
          _volumes = value;
          OnPropertyChanged();
        }
      }
    }

    private ObservableCollection<MD_MediumFormatCode_CodeList>? _mediumFormat;

    /// <summary>
    /// Method used to write to the medium.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("mediumFormat", Order = 4)]
    [JsonProperty("mediumFormat", Order = 4)]
    public ObservableCollection<MD_MediumFormatCode_CodeList>? MediumFormat {
      get => _mediumFormat;
      set => SetProperty(ref _mediumFormat, value);
    }

    private CharacterString? _mediumNote;

    /// <summary>
    /// Description for other limitations or requirements for using the medium.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("mediumNote", Order = 5)]
    [JsonProperty("mediumNote", Order = 5)]
    public CharacterString? MediumNote {
      get => _mediumNote;
      set => SetProperty(ref _mediumNote, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="MD_Medium_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="MD_Medium_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(MD_Medium_Type? other) {
      int result;

      return
        (other is null) ? 1 :
        (result = Name?.CompareTo(other.Name) ?? 1) != 0 ? result :
        (result = Density?.Count.CompareTo(other.Density?.Count ?? 0) ?? 1) != 0 ? result :
        (result = DensityUnits?.CompareTo(other.DensityUnits) ?? 1) != 0 ? result :
        (result = Volumes?.CompareTo(other.Volumes) ?? 1) != 0 ? result :
        (result = MediumFormat?.Count.CompareTo(other.MediumFormat?.Count ?? 0) ?? 1) != 0 ? result :
        MediumNote?.CompareTo(other.MediumNote) ?? 1;


      return 0;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="MD_Medium_Type"/> is equal to the current <see cref="MD_Medium_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="MD_Medium_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(MD_Medium_Type? other) {
      return other != null &&
         Equals(Name, other.Name) &&
         Density.SequenceEqualOrdered(other.Density) &&
         Equals(DensityUnits, other.DensityUnits) &&
         Equals(Volumes, other.Volumes) &&
         MediumFormat.SequenceEqualOrdered(other.MediumFormat) &&
         Equals(MediumNote, other.MediumNote);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="MD_Medium_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as MD_Medium_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="MD_Medium_Type"/> using <see cref="NdshHashCode"/>. This will also order 
    /// collections before hashing them.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      hash.Add(Name);

      foreach (double density in Density.SafeOrderBy()) {
        hash.Add(density);
      }

      hash.Add(DensityUnits);
      hash.Add(Volumes);

      foreach (MD_MediumFormatCode_CodeList format in MediumFormat.SafeOrderBy()) {
        hash.Add(format);
      }

      hash.Add(MediumNote);

      return hash.ToHashCode();
    }

    #endregion

  }

}
