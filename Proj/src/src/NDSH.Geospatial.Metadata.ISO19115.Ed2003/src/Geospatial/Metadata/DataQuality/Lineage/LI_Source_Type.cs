#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 28/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/dataQuality.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="LI_Source_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="description" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="scaleDenominator" type="gmd:MD_RepresentativeFraction_PropertyType" minOccurs="0"/>
//         <xs:element name="sourceReferenceSystem" type="gmd:MD_ReferenceSystem_PropertyType" minOccurs="0"/>
//         <xs:element name="sourceCitation" type="gmd:CI_Citation_PropertyType" minOccurs="0"/>
//         <xs:element name="sourceExtent" type="gmd:EX_Extent_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="sourceStep" type="gmd:LI_ProcessStep_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="LI_Source" type="gmd:LI_Source_Type"/>
// <xs:complexType name="LI_Source_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:LI_Source"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;

using NDSH.Geospatial.Metadata.Extent;
using NDSH.Geospatial.Metadata.Identification;
using NDSH.Geospatial.Metadata.ReferenceSystem;
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

namespace NDSH.Geospatial.Metadata.DataQuality.Lineage {

  //[XmlInclude(typeof(LE_Source_Type))]
  [Serializable]
  //[XmlType("LI_Source", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("LI_Source", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("LI_Source")]
  public class LI_Source_Type : MetadataObject, IComparable<LI_Source_Type>, IEquatable<LI_Source_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LI_Source_Type"/>.
    /// </summary>
    public LI_Source_Type() {
      _description = default; //  new CharacterString();
      _scaleDenominator = default; //  new MD_RepresentativeFraction_Type();
      _sourceReferenceSystem = default; //  new MD_ReferenceSystem_Type();
      _sourceCitation = default; //  new CI_Citation_Type();
      _sourceExtent = default; //  new List<EX_Extent_Type>();
      _sourceStep = default; //  new List<LI_ProcessStep_Type>();
    }

    #endregion

    #region Public Properties

    private CharacterString? _description;

    /// <summary>
    /// Detailed description of the level of the source data.
    /// </summary>
    // TODO: OBL - C (sourceExtent not provided?)
    // TODO: CAR - 1
    //[XmlElement("description", Order = 0)]
    [JsonProperty("description", Order = 0)]
    public CharacterString? Description {
      get => _description;
      set => SetProperty(ref _description, value);
    }

    private MD_RepresentativeFraction_Type? _scaleDenominator;

    /// <summary>
    /// Denominator of the representative fraction on a source map.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("scaleDenominator", Order = 1)]
    [JsonProperty("scaleDenominator", Order = 1)]
    public MD_RepresentativeFraction_Type? ScaleDenominator {
      get => _scaleDenominator;
      set => SetProperty(ref _scaleDenominator, value);
    }

    private MD_ReferenceSystem_Type? _sourceReferenceSystem;

    /// <summary>
    /// Spatial reference system used by the source data.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("sourceReferenceSystem", Order = 2)]
    [JsonProperty("sourceReferenceSystem", Order = 2)]
    public MD_ReferenceSystem_Type? SourceReferenceSystem {
      get => _sourceReferenceSystem;
      set => SetProperty(ref _sourceReferenceSystem, value);
    }

    private CI_Citation_Type? _sourceCitation;

    /// <summary>
    /// Recommended reference to be used for the source data.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("sourceCitation", Order = 3)]
    [JsonProperty("sourceCitation", Order = 3)]
    public CI_Citation_Type? SourceCitation {
      get => _sourceCitation;
      set => SetProperty(ref _sourceCitation, value);
    }

    private ObservableCollection<EX_Extent_Type>? _sourceExtent;

    /// <summary>
    /// Information about the spatial, vertical, and temporal extent of the source data.
    /// </summary>
    // TODO: OBL - C (description not provided?)
    // TODO: CAR - N
    //[XmlElement("sourceExtent", Order = 4)]
    [JsonProperty("sourceExtent", Order = 4)]
    public ObservableCollection<EX_Extent_Type>? SourceExtent {
      get => _sourceExtent;
      set => SetProperty(ref _sourceExtent, value);
    }

    private ObservableCollection<LI_ProcessStep_Type>? _sourceStep;

    /// <summary>
    /// Information about an event in the creation process for the source data.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("sourceStep", Order = 5)]
    [JsonProperty("sourceStep", Order = 5)]
    public ObservableCollection<LI_ProcessStep_Type>? SourceStep {
      get => _sourceStep;
      set => SetProperty(ref _sourceStep, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="LI_Source_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="LI_Source_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(LI_Source_Type? other) {

      int result;

      return
        (other is null) ? 1 :
        (result = Description?.CompareTo(other.Description) ?? 1) != 0 ? result :
        (result = ScaleDenominator?.CompareTo(other.ScaleDenominator) ?? 1) != 0 ? result :
        (result = SourceReferenceSystem?.CompareTo(other.SourceReferenceSystem) ?? 1) != 0 ? result :
        (result = SourceCitation?.CompareTo(other.SourceCitation) ?? 1) != 0 ? result :
        (result = SourceExtent?.Count.CompareTo(other.SourceExtent?.Count ?? 0) ?? 1) != 0 ? result :
        SourceStep?.Count.CompareTo(other.SourceStep?.Count ?? 0) ?? 1;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="LI_Source_Type"/> is equal to the current <see cref="LI_Source_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="LI_Source_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(LI_Source_Type? other) {
      return other != null &&
         Equals(Description, other.Description) &&
         Equals(ScaleDenominator, other.ScaleDenominator) &&
         Equals(SourceReferenceSystem, other.SourceReferenceSystem) &&
         Equals(SourceCitation, other.SourceCitation) &&
         SourceExtent.SequenceEqualOrdered(other.SourceExtent) &&
         SourceStep.SequenceEqualOrdered(other.SourceStep);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="LI_Source_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as LI_Source_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="LI_Source_Type"/> using <see cref="NdshHashCode"/>. This will also order 
    /// collections before hashing them.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      hash.Add(Description);
      hash.Add(ScaleDenominator);
      hash.Add(SourceReferenceSystem);
      hash.Add(SourceCitation);

      foreach (EX_Extent_Type extent in SourceExtent.SafeOrderBy()) {
        hash.Add(extent);
      }

      foreach (LI_ProcessStep_Type step in SourceStep.SafeOrderBy()) {
        hash.Add(step);
      }

      return hash.ToHashCode();
    }

    #endregion

  }

}
