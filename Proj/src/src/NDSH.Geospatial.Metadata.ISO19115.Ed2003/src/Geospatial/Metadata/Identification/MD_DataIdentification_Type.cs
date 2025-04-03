#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 24/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/identification.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MD_DataIdentification_Type">
//   <xs:complexContent>
//     <xs:extension base="gmd:AbstractMD_Identification_Type">
//       <xs:sequence>
//         <xs:element name="spatialRepresentationType" type="gmd:MD_SpatialRepresentationTypeCode_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="spatialResolution" type="gmd:MD_Resolution_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="language" type="gco:CharacterString_PropertyType" maxOccurs="unbounded"/>
//         <xs:element name="characterSet" type="gmd:MD_CharacterSetCode_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="topicCategory" type="gmd:MD_TopicCategoryCode_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="environmentDescription" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="extent" type="gmd:EX_Extent_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="supplementalInformation" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_DataIdentification" type="gmd:MD_DataIdentification_Type" substitutionGroup="gmd:AbstractMD_Identification"/>
// <xs:complexType name="MD_DataIdentification_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_DataIdentification"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Extent;
using NDSH.Geospatial.Metadata.SpatialRepresentation;
using NDSH.Hashing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.Identification {

  [Serializable]
  //[XmlType("MD_DataIdentification", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_DataIdentification", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_DataIdentification")]
  public class MD_DataIdentification_Type : AbstractMD_Identification_Type, IComparable<MD_DataIdentification_Type>, IEquatable<MD_DataIdentification_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_DataIdentification_Type"/>.
    /// </summary>
    public MD_DataIdentification_Type() {
      _spatialRepresentationType = default; //  new List<MD_SpatialRepresentationTypeCode_PropertyType>();
      _spatialResolution = default; //  new List<MD_Resolution_PropertyType>();
      _language = default; //  new List<CharacterString>();
      _characterSet = default; //  new List<MD_CharacterSetCode_PropertyType>();
      _topicCategory = default; //  new List<MD_TopicCategoryCode_PropertyType>();
      _environmentDescription = default; //  new CharacterString();
      _extent = default; //  new List<EX_Extent_Type>();
      _supplementalInformation = default; //  new CharacterString();
    }

    #endregion

    #region Public Properties

    private ObservableCollection<MD_SpatialRepresentationTypeCode_CodeList>? _spatialRepresentationType;

    /// <summary>
    /// Method used to spatially represent geographic information.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("spatialRepresentationType", Order = 0)]
    [JsonProperty("spatialRepresentationType", Order = 0)]
    public ObservableCollection<MD_SpatialRepresentationTypeCode_CodeList>? SpatialRepresentationType {
      get => _spatialRepresentationType;
      set => SetProperty(ref _spatialRepresentationType, value);
    }

    private ObservableCollection<MD_Resolution_Type>? _spatialResolution;

    /// <summary>
    /// Factor which provides a general understanding of the density of spatial data in the dataset.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("spatialResolution", Order = 1)]
    [JsonProperty("spatialResolution", Order = 1)]
    public ObservableCollection<MD_Resolution_Type>? SpatialResolution {
      get => _spatialResolution;
      set => SetProperty(ref _spatialResolution, value);
    }

    private ObservableCollection<CharacterString> _language;

    /// <summary>
    /// Language(s) used within the dataset.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - N
    //[XmlElement("language", Order = 2)]
    [JsonProperty("language", Order = 2)]
    public ObservableCollection<CharacterString> Language {
      get => _language;
      set => SetProperty(ref _language, value);
    }

    private ObservableCollection<MD_CharacterSetCode_CodeList>? _characterSet;

    /// <summary>
    /// Full name of the character coding standard used for the dataset.
    /// </summary>
    // TODO: OBL - C (ISO/IEC 10646-1 not used?)
    // TODO: CAR - N
    //[XmlElement("characterSet", Order = 3)]
    [JsonProperty("characterSet", Order = 3)]
    public ObservableCollection<MD_CharacterSetCode_CodeList>? CharacterSet {
      get => _characterSet;
      set => SetProperty(ref _characterSet, value);
    }

    private ObservableCollection<MD_TopicCategoryCodeDbEntity>? _topicCategory;

    /// <summary>
    /// Main theme(s) of the dataset.
    /// </summary>
    // TODO: OBL - C (if hierarchyLevel equals "dataset"?)
    // TODO: CAR - N
    //[XmlElement("topicCategory", Order = 4)]
    [JsonProperty("topicCategory", Order = 4)]
    public ObservableCollection<MD_TopicCategoryCodeDbEntity>? TopicCategory {
      get => _topicCategory;
      set => SetProperty(ref _topicCategory, value);
    }

    private CharacterString? _environmentDescription;

    /// <summary>
    /// Description of the dataset in the producer's processing environment,
    /// including items such as the software, the computer operating system, file name, and the dataset size.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("environmentDescription", Order = 5)]
    [JsonProperty("environmentDescription", Order = 5)]
    public CharacterString? EnvironmentDescription {
      get => _environmentDescription;
      set => SetProperty(ref _environmentDescription, value);
    }

    private ObservableCollection<EX_Extent_Type>? _extent;

    /// <summary>
    /// Extent information including the bounding box, bounding polygon,
    /// vertical, and temporal extent of the dataset.
    /// </summary>
    // TODO: OBL - C (if hierarchyLevel equals "dataset"? either extent.geographicElement.EX_GeographicBoundingBox or extent.geographicElement.EX_GeographicDescription is required.)
    // TODO: CAR - N
    //[XmlElement("extent", Order = 6)]
    [JsonProperty("extent", Order = 6)]
    public ObservableCollection<EX_Extent_Type>? Extent {
      get => _extent;
      set => SetProperty(ref _extent, value);
    }

    private CharacterString? _supplementalInformation;

    /// <summary>
    /// Any other descriptive information about the dataset.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("supplementalInformation", Order = 7)]
    [JsonProperty("supplementalInformation", Order = 7)]
    public CharacterString? SupplementalInformation {
      get => _supplementalInformation;
      set => SetProperty(ref _supplementalInformation, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="MD_DataIdentification_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="MD_DataIdentification_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(MD_DataIdentification_Type? other) {
      int result;

      return
          (other is null) ? 1 :
          (result = base.CompareTo(other)) != 0 ? result :
          (result = SpatialRepresentationType?.Count.CompareTo(other.SpatialRepresentationType?.Count ?? 0) ?? 1) != 0 ? result :
          (result = SpatialResolution?.Count.CompareTo(other.SpatialResolution?.Count ?? 0) ?? 1) != 0 ? result :
          (result = Language?.Count.CompareTo(other.Language?.Count ?? 0) ?? 1) != 0 ? result :
          (result = CharacterSet?.Count.CompareTo(other.CharacterSet?.Count ?? 0) ?? 1) != 0 ? result :
          (result = TopicCategory?.Count.CompareTo(other.TopicCategory?.Count ?? 0) ?? 1) != 0 ? result :
          (result = EnvironmentDescription?.CompareTo(other.EnvironmentDescription) ?? 1) != 0 ? result :
          (result = Extent?.Count.CompareTo(other.Extent?.Count ?? 0) ?? 1) != 0 ? result :
          SupplementalInformation?.CompareTo(other.SupplementalInformation) ?? 1;
    }

    /// <inheritdoc />
    public override int CompareTo(AbstractMD_Identification_Type? other) {
      return CompareTo(other as MD_DataIdentification_Type);
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="MD_DataIdentification_Type"/> is equal to the current <see cref="MD_DataIdentification_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="MD_DataIdentification_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(MD_DataIdentification_Type? other) {
      return other != null &&
          base.Equals(other) &&
          SpatialRepresentationType.SequenceEqualOrdered(other.SpatialRepresentationType) &&
          SpatialResolution.SequenceEqualOrdered(other.SpatialResolution) &&
          Language.SequenceEqualOrdered(other.Language) &&
          CharacterSet.SequenceEqualOrdered(other.CharacterSet) &&
          TopicCategory.SequenceEqualOrdered(other.TopicCategory) &&
          Equals(EnvironmentDescription, other.EnvironmentDescription) &&
          Extent.SequenceEqualOrdered(other.Extent) &&
          Equals(SupplementalInformation, other.SupplementalInformation);
    }

    /// <inheritdoc />
    public override bool Equals(AbstractMD_Identification_Type? other) {
      return Equals(other as MD_DataIdentification_Type);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="MD_DataIdentification_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as MD_DataIdentification_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="MD_DataIdentification_Type"/> using <see cref="NdshHashCode"/>. This will also order 
    /// collections before hashing them.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();
      hash.Add(base.GetHashCode());

      foreach (MD_SpatialRepresentationTypeCode_CodeList representation in SpatialRepresentationType.SafeOrderBy()) {
        hash.Add(representation);
      }

      foreach (MD_Resolution_Type resolution in SpatialResolution.SafeOrderBy()) {
        hash.Add(resolution);
      }

      foreach (CharacterString characterString in Language.SafeOrderBy()) {
        hash.Add(characterString);
      }

      foreach (MD_CharacterSetCode_CodeList characterSet in CharacterSet.SafeOrderBy()) {
        hash.Add(characterSet);
      }

      foreach (MD_TopicCategoryCodeDbEntity topicCategory in TopicCategory.SafeOrderBy()) {
        hash.Add(topicCategory);
      }

      hash.Add(EnvironmentDescription);

      foreach (EX_Extent_Type extent in Extent.SafeOrderBy()) {
        hash.Add(extent);
      }

      hash.Add(SupplementalInformation);

      return hash.ToHashCode();
    }

    #endregion

  }

}
