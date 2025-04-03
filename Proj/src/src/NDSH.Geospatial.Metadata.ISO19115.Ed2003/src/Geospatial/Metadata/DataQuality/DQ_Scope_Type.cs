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
// XSD               : /2005/gmd/dataQuality.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="DQ_Scope_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="level" type="gmd:MD_ScopeCode_PropertyType"/>
//         <xs:element name="extent" type="gmd:EX_Extent_PropertyType" minOccurs="0"/>
//         <xs:element name="levelDescription" type="gmd:MD_ScopeDescription_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="DQ_Scope" type="gmd:DQ_Scope_Type"/>
// <xs:complexType name="DQ_Scope_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:DQ_Scope"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------

#endregion

#region Imported Namespaces


using NDSH.Geospatial.Metadata.Extent;
using NDSH.Geospatial.Metadata.Maintenance;
using NDSH.Hashing;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

#endregion

namespace NDSH.Geospatial.Metadata.DataQuality {

  [Serializable]
  //[XmlType("DQ_Scope", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("DQ_Scope", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("DQ_Scope")]
  public class DQ_Scope_Type : MetadataObject, IComparable<DQ_Scope_Type>, IEquatable<DQ_Scope_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_Scope_Type"/>.
    /// </summary>
    public DQ_Scope_Type() {
      _level = default; //  new MD_ScopeCode_PropertyType();
      _extent = default; //  new EX_Extent_Type();
      _levelDescription = default; //  new List<MD_ScopeDescription_PropertyType>();
    }

    #endregion

    #region Public Properties

    private MD_ScopeCode_CodeList _level;

    /// <summary>
    /// Hierarchical level of the data specified by the scope.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("level", Order = 0)]
    [JsonProperty("level", Order = 0)]
    public MD_ScopeCode_CodeList Level {
      get => _level;
      set => SetProperty(ref _level, value);
    }

    private EX_Extent_Type? _extent;

    /// <summary>
    /// Information about the horizontal, vertical and temporal extent of the data specified by the scope.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("extent", Order = 1)]
    [JsonProperty("extent", Order = 1)]
    public EX_Extent_Type? Extent {
      get => _extent;
      set => SetProperty(ref _extent, value);
    }

    private ObservableCollection<MD_ScopeDescription_Type>? _levelDescription;

    /// <summary>
    /// Detailed description about the level of the data specified by the scope.
    /// </summary>
    // TODO: OBL - C (level not equal "dataset" or "series"?)
    // TODO: CAR - N
    //[XmlElement("levelDescription", Order = 2)]
    [JsonProperty("levelDescription", Order = 2)]
    public ObservableCollection<MD_ScopeDescription_Type>? LevelDescription {
      get => _levelDescription;
      set => SetProperty(ref _levelDescription, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="DQ_Scope_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="DQ_Scope_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(DQ_Scope_Type? other) {

      int result;

      return
        (other is null) ? 1 :
        (result = Level.CompareTo(other.Level)) != 0 ? result :
        (result = Extent?.CompareTo(other.Extent) ?? 1) != 0 ? result :
        LevelDescription?.Count.CompareTo(other.LevelDescription?.Count ?? 0) ?? 1;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="DQ_Scope_Type"/> is equal to the current <see cref="DQ_Scope_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="DQ_Scope_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(DQ_Scope_Type? other) {
      return other != null &&
         Equals(Level, other.Level) &&
         Equals(Extent, other.Extent) &&
         LevelDescription.SequenceEqualOrdered(other.LevelDescription);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="DQ_Scope_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as DQ_Scope_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="DQ_Scope_Type"/> using <see cref="NdshHashCode"/>. This will also order 
    /// collections before hashing them.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      hash.Add(Level);
      hash.Add(Extent);

      foreach (MD_ScopeDescription_Type description in LevelDescription.SafeOrderBy()) {
        hash.Add(description);
      }

      return hash.ToHashCode();
    }

    #endregion

  }

}
