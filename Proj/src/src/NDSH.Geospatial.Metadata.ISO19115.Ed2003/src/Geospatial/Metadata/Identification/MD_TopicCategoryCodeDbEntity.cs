
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 29/12/2022, @gisvlasta
// History           : 06/03/2025, @gisvlasta
//                      Renamed from MD_TopicCategoryCode_PropertyType to MD_TopicCategoryCodeDbEntity,
//                      implemented IValue<MD_TopicCategoryCodes>, updated code, and documentation.
//                     14/03/2025, @pigeonwatcher - Added IComparable<T>, IEquatable<T>, and overrides.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : This class is an exception to the rule. It does not inherit from `IdentifiableObject`
//                      (xsd: `AbstractObject_Type`). Classes whose properties are of this type
//                      are not decorated with property metadata instances of type `ReferencedObject`;
//                      instead they are decorated with instances of `NilReasonEntity`.
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/identification.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:simpleType name="MD_TopicCategoryCode_Type">
//   <xs:restriction base="xs:string">
//     <xs:enumeration value="farming"/>
//     <xs:enumeration value="biota"/>
//     <xs:enumeration value="boundaries"/>
//     <xs:enumeration value="climatologyMeteorologyAtmosphere"/>
//     <xs:enumeration value="economy"/>
//     <xs:enumeration value="elevation"/>
//     <xs:enumeration value="environment"/>
//     <xs:enumeration value="geoscientificInformation"/>
//     <xs:enumeration value="health"/>
//     <xs:enumeration value="imageryBaseMapsEarthCover"/>
//     <xs:enumeration value="intelligenceMilitary"/>
//     <xs:enumeration value="inlandWaters"/>
//     <xs:enumeration value="location"/>
//     <xs:enumeration value="oceans"/>
//     <xs:enumeration value="planningCadastre"/>
//     <xs:enumeration value="society"/>
//     <xs:enumeration value="structure"/>
//     <xs:enumeration value="transportation"/>
//     <xs:enumeration value="utilitiesCommunication"/>
//   </xs:restriction>
// </xs:simpleType>
// <xs:element name="MD_TopicCategoryCode"
//             type="gmd:MD_TopicCategoryCode_Type" substitutionGroup="gco:CharacterString"/>
// <xs:complexType name="MD_TopicCategoryCode_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_TopicCategoryCode"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Database.Entities;
using NDSH.Geospatial.Gml.BasicTypes;
using NDSH.Hashing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.Identification {

  /// <summary>
  /// High-level geospatial data thematic classification to assist
  /// in the grouping and search of available geospatial datasets.
  /// </summary>
  /// <remarks>
  /// This class does not inherit from <see cref="MetadataObject"/> (xsd: AbstractObject_Type).
  /// Classes whose properties are of this type are not decorated with property metadata instances of type
  /// <see cref="ReferenceEntity"/>; instead they are decorated with instances of <see cref="NilReasonEntity"/>.
  /// </remarks>
  [Serializable]
  //[XmlType("MD_TopicCategoryCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_TopicCategoryCode_PropertyType")]
  public class MD_TopicCategoryCodeDbEntity : ObservableDbEntity,
    INullableValue<MD_TopicCategoryCodes>,
    IComparable<MD_TopicCategoryCodeDbEntity>,
    IEquatable<MD_TopicCategoryCodeDbEntity> {

    #region IValue<T> Interface

    private MD_TopicCategoryCodes? _md_TopicCategoryCode;

    /// <summary>
    /// Gets/Sets the high-level geographic data thematic classification to assist in the grouping and
    /// search of available geographic data sets. Can be used to group keywords as well.
    /// Listed examples are not exhaustive.
    /// </summary>
    /// <remarks>
    /// <para>
    /// It is understood there are overlaps between general categories and the user
    /// is encouraged to select the one most appropriate.
    /// </para>
    /// <para>
    /// This class does not inherit from <see cref="MetadataObject"/> (xsd: AbstractObject_Type).
    /// Classes whose properties are of this type are not decorated with property metadata instances of type
    /// <see cref="ReferenceEntity"/>; instead they are decorated with instances of <see cref="NilReasonEntity"/>.
    /// </para>
    /// </remarks>
    //[XmlElement("MD_TopicCategoryCode", Order = 0)]
    [JsonProperty("MD_TopicCategoryCode", Order = 0)]
    public MD_TopicCategoryCodes? Value {
      get => _md_TopicCategoryCode;
      set => SetProperty(ref _md_TopicCategoryCode, value);
    }

    #endregion

    #region IComparable<T> Interface

    /// <summary>
    /// Compares this instance to another <see cref="MD_TopicCategoryCodeDbEntity"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="MD_TopicCategoryCodeDbEntity"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(MD_TopicCategoryCodeDbEntity? other) =>
      (other is null) ? 1 : Value?.CompareTo(other.Value) ?? 1;

    #endregion

    #region IEquatable<T> Interface

    /// <summary>
    /// Determines whether the <see cref="MD_TopicCategoryCodeDbEntity"/>
    /// is equal to the current <see cref="MD_TopicCategoryCodeDbEntity"/>.
    /// </summary>
    /// <param name="other">The <see cref="MD_TopicCategoryCodeDbEntity"/> to compare.</param>
    /// <returns>
    /// <see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.
    /// </returns>
    public bool Equals(MD_TopicCategoryCodeDbEntity? other) =>
      other != null && Value == other.Value;

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/>
    /// is equal to the current <see cref="MD_TopicCategoryCodeDbEntity"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns>
    /// <see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.
    /// </returns>
    public override bool Equals(object? obj) => Equals(obj as MD_TopicCategoryCodeDbEntity);

    /// <summary>
    /// Gets the hash code for the <see cref="MD_TopicCategoryCodeDbEntity"/> using <see cref="NdshHashCode"/>.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();
      hash.Add(Value);

      return hash.ToHashCode();
    }

    #endregion

  }

}
