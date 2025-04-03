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
// <xs:complexType name="MD_BrowseGraphic_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="fileName" type="gco:CharacterString_PropertyType"/>
//         <xs:element name="fileDescription" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="fileType" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_BrowseGraphic" type="gmd:MD_BrowseGraphic_Type"/>
// <xs:complexType name="MD_BrowseGraphic_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_BrowseGraphic"/>
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Identification {

  /// <summary>
  /// Graphic that provides an illustration of the dataset (should include a legend for the graphic).
  /// </summary>
  [Serializable]
  //[XmlType("MD_BrowseGraphic", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_BrowseGraphic", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_BrowseGraphic")]
  public class MD_BrowseGraphic_Type : MetadataObject, IComparable<MD_BrowseGraphic_Type>, IEquatable<MD_BrowseGraphic_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_BrowseGraphic_Type"/>.
    /// </summary>
    public MD_BrowseGraphic_Type() {
      _fileName = default; //  new CharacterString();
      _fileDescription = default; //  new CharacterString();
      _fileType = default; //  new CharacterString();
    }

    #endregion

    #region Public Properties

    private CharacterString _fileName;

    /// <summary>
    /// Name of the file that contains a graphic that provides an illustration of the dataset.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("fileName", Order = 0)]
    [JsonProperty("fileName", Order = 0)]
    public CharacterString FileName {
      get => _fileName;
      set => SetProperty(ref _fileName, value);
    }

    private CharacterString? _fileDescription;

    /// <summary>
    /// Text description of the illustration.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("fileDescription", Order = 1)]
    [JsonProperty("fileDescription", Order = 1)]
    public CharacterString? FileDescription {
      get => _fileDescription;
      set => SetProperty(ref _fileDescription, value);
    }

    private CharacterString? _fileType;

    /// <summary>
    /// Format in which the illustration is encoded.
    /// </summary>
    /// <example>CGM, EPS, GIF, JPEG, PBM, PS, TIFF, XWD</example> // TODO Should this be a bulleted list?
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("fileType", Order = 2)]
    [JsonProperty("fileType", Order = 2)]
    public CharacterString? FileType {
      get => _fileType;
      set => SetProperty(ref _fileType, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="MD_BrowseGraphic_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="MD_BrowseGraphic_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(MD_BrowseGraphic_Type? other) {
      int result;

      return
        (other is null) ? 1 :
        (result = FileName.CompareTo(other.FileName)) != 0 ? result :
        (result = FileDescription?.CompareTo(other.FileDescription) ?? 1) != 0 ? result :
        FileType?.CompareTo(other.FileType) ?? 1;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="MD_BrowseGraphic_Type"/> is equal to the current <see cref="MD_BrowseGraphic_Type"/>.
    /// </summary>
    /// <param name="other">The <see cref="MD_BrowseGraphic_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(MD_BrowseGraphic_Type? other) {
      return other != null &&
             Equals(FileName, other.FileName) &&
             Equals(FileDescription, other.FileDescription) &&
             Equals(FileType, other.FileType);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="MD_BrowseGraphic_Type"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as MD_BrowseGraphic_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="MD_BrowseGraphic_Type"/> using <see cref="NdshHashCode"/>.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      hash.Add(FileName);
      hash.Add(FileDescription);
      hash.Add(FileType);

      return hash.ToHashCode();
    }

    #endregion

  }

}
