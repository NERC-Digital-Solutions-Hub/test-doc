
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
// <xs:complexType name="MD_Resolution_Type">
//   <xs:choice>
//     <xs:element name="equivalentScale" type="gmd:MD_RepresentativeFraction_PropertyType"/>
//     <xs:element name="distance" type="gco:Distance_PropertyType"/>
//   </xs:choice>
// </xs:complexType>
// <xs:element name="MD_Resolution" type="gmd:MD_Resolution_Type"/>
// <xs:complexType name="MD_Resolution_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_Resolution"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Apps;
using NDSH.Database.Entities;
using NDSH.Geospatial.Common.BasicTypes.Derived.UnitsOfMeasure;
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

  //[XmlType("MD_Resolution", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_Resolution", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_Resolution")]
  public class MD_Resolution_Type : ObservableDbEntity,
    IComparable<MD_Resolution_Type>,
    IEquatable<MD_Resolution_Type> { // TODO: Add in the <remarks> that it inherits from ObservableDbEntity and is decorated only by NilReason.

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Resolution_Type"/>.
    /// </summary>
    public MD_Resolution_Type() {

    }

    #endregion

    #region Public Properties

    // WARNING: The two properties of this class have a conditional relationship and validation rule. When one is null, the other needs to have a value.

    private MD_RepresentativeFraction_Type? _equivalentScale;

    /// <summary>
    /// Level of detail expressed as the scale of a comparable hardcopy map or chart.
    /// </summary>
    // TODO: OBL - C (distance not documented?)
    // TODO: CAR - 1
    //[XmlElement("equivalentScale", typeof(MD_RepresentativeFraction_Type), Order = 0)]
    [JsonProperty("equivalentScale", Order = 3)]
    public MD_RepresentativeFraction_Type? EquivalentScale {
      get => _equivalentScale;
      set => SetProperty(ref _equivalentScale, value);
    }

    private Distance_PropertyType? _distance;

    /// <summary>
    /// Ground sample distance.
    /// </summary>
    // TODO: OBL - C (equivalentScale not documented?)
    // TODO: CAR - 1
    //[XmlElement("distance", typeof(Distance_PropertyType), Order = 0)]
    [JsonProperty("distance", Order = 3)]
    public Distance_PropertyType? Distance {
      get => _distance;
      set => SetProperty(ref _distance, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="MD_Resolution_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="MD_Resolution_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(MD_Resolution_Type? other) {
      int result;

      return
        (other is null) ? 1 :
        (result = EquivalentScale?.CompareTo(other.EquivalentScale) ?? 1) != 0 ? result :
        Distance?.CompareTo(other.Distance) ?? 1;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="MD_Resolution_Type"/> is equal to the current <see cref="MD_Resolution_Type"/>.
    /// </summary>
    /// <param name="other">The <see cref="MD_Resolution_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(MD_Resolution_Type? other) {
      return other != null &&
         Equals(EquivalentScale, other.EquivalentScale) &&
         Equals(Distance, other.Distance);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="MD_Resolution_Type"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as MD_Resolution_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="MD_Resolution_Type"/> using <see cref="NdshHashCode"/>.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      hash.Add(EquivalentScale);
      hash.Add(Distance);

      return hash.ToHashCode();
    }

    #endregion

  }

}
