#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 22/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/extent.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="EX_GeographicBoundingBox_Type">
//   <xs:annotation>
//     <xs:documentation>Geographic area of the entire dataset referenced to WGS 84</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gmd:AbstractEX_GeographicExtent_Type">
//       <xs:sequence>
//         <xs:element name="westBoundLongitude" type="gco:Decimal_PropertyType"/>
//         <xs:element name="eastBoundLongitude" type="gco:Decimal_PropertyType"/>
//         <xs:element name="southBoundLatitude" type="gco:Decimal_PropertyType"/>
//         <xs:element name="northBoundLatitude" type="gco:Decimal_PropertyType"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="EX_GeographicBoundingBox"
//             type="gmd:EX_GeographicBoundingBox_Type"
//             substitutionGroup="gmd:AbstractEX_GeographicExtent"/>
// <xs:complexType name="EX_GeographicBoundingBox_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:EX_GeographicBoundingBox"/>
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Extent {

  /// <summary>
  /// Geographic area of the entire dataset referenced to WGS 84.
  /// </summary>
  [Serializable]
  //[XmlType("EX_GeographicBoundingBox", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("EX_GeographicBoundingBox", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("EX_GeographicBoundingBox")]
  public class EX_GeographicBoundingBox_Type : AbstractEX_GeographicExtent_Type, IComparable<EX_GeographicBoundingBox_Type>, IEquatable<EX_GeographicBoundingBox_Type> {

    // WARNING: Check which value types need to be nullable.

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_GeographicBoundingBox_Type"/>.
    /// </summary>
    public EX_GeographicBoundingBox_Type() {
      _westBoundLongitude = default; //  new Decimal_PropertyType();
      _eastBoundLongitude = default; //  new Decimal_PropertyType();
      _southBoundLatitude = default; //  new Decimal_PropertyType();
      _northBoundLatitude = default; //  new Decimal_PropertyType();
    }

    #endregion

    #region Public Properties

    private decimal _westBoundLongitude;

    /// <summary>
    /// Western-most coordinate of the limit of the dataset extent,
    /// expressed in longitude in decimal degrees (positive east).
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("westBoundLongitude", Order = 0)]
    [JsonProperty("westBoundLongitude", Order = 0)]
    public decimal WestBoundLongitude {
      get => _westBoundLongitude;
      // TODO: SetProperty
      set {
        if (_westBoundLongitude == value) {
          return;
        }
        if (!_westBoundLongitude.Equals(value)) {
          _westBoundLongitude = value;
          OnPropertyChanged();
        }
      }
    }

    private decimal _eastBoundLongitude;

    /// <summary>
    /// Eastern-most coordinate of the limit of the dataset extent,
    /// expressed in longitude in decimal degrees (positive east).
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("eastBoundLongitude", Order = 1)]
    [JsonProperty("eastBoundLongitude", Order = 1)]
    public decimal EastBoundLongitude {
      get => _eastBoundLongitude;
      // TODO: SetProperty
      set {
        if (_eastBoundLongitude == value) {
          return;
        }
        if (!_eastBoundLongitude.Equals(value)) {
          _eastBoundLongitude = value;
          OnPropertyChanged();
        }
      }
    }

    private decimal _southBoundLatitude;

    /// <summary>
    /// Southern-most coordinate of the limit of the dataset extent,
    /// expressed in latitude in decimal degrees (positive north).
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("southBoundLatitude", Order = 2)]
    [JsonProperty("southBoundLatitude", Order = 2)]
    public decimal SouthBoundLatitude {
      get => _southBoundLatitude;
      // TODO: SetProperty
      set {
        if (_southBoundLatitude == value) {
          return;
        }
        if (!_southBoundLatitude.Equals(value)) {
          _southBoundLatitude = value;
          OnPropertyChanged();
        }
      }
    }

    private decimal _northBoundLatitude;

    /// <summary>
    /// Northern-most coordinate of the limit of the dataset extent,
    /// expressed in latitude in decimal degrees (positive north).
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("northBoundLatitude", Order = 3)]
    [JsonProperty("northBoundLatitude", Order = 3)]
    public decimal NorthBoundLatitude {
      get => _northBoundLatitude;
      // TODO: SetProperty
      set {
        if (_northBoundLatitude == value) {
          return;
        }
        if (!_northBoundLatitude.Equals(value)) {
          _northBoundLatitude = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="EX_GeographicBoundingBox_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="EX_GeographicBoundingBox_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(EX_GeographicBoundingBox_Type? other) {
      int result;

      return
          other is null ? 1 :
          (result = base.CompareTo(other)) != 0 ? result :
          (result = WestBoundLongitude.CompareTo(other.WestBoundLongitude)) != 0 ? result :
          (result = EastBoundLongitude.CompareTo(other.EastBoundLongitude)) != 0 ? result :
          (result = SouthBoundLatitude.CompareTo(other.SouthBoundLatitude)) != 0 ? result :
          NorthBoundLatitude.CompareTo(other.NorthBoundLatitude);
    }

    /// <inheritdoc />
    public override int CompareTo(AbstractEX_GeographicExtent_Type? other) {
      return CompareTo(other as EX_GeographicBoundingBox_Type);
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="EX_GeographicBoundingBox_Type"/> is equal to the current <see cref="EX_GeographicBoundingBox_Type"/>.
    /// </summary>
    /// <param name="other">The <see cref="EX_GeographicBoundingBox_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(EX_GeographicBoundingBox_Type? other) {
      return other != null &&
          base.Equals(other) &&
          WestBoundLongitude == other.WestBoundLongitude &&
          EastBoundLongitude == other.EastBoundLongitude &&
          SouthBoundLatitude == other.SouthBoundLatitude &&
          NorthBoundLatitude == other.NorthBoundLatitude;
    }

    /// <inheritdoc />
    public override bool Equals(AbstractEX_GeographicExtent_Type? other) {
      return Equals(other as EX_GeographicBoundingBox_Type);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="EX_GeographicBoundingBox_Type"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as EX_GeographicBoundingBox_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="EX_GeographicBoundingBox_Type"/> using <see cref="NdshHashCode"/>.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();
      hash.Add(base.GetHashCode());
      hash.Add(WestBoundLongitude);
      hash.Add(EastBoundLongitude);
      hash.Add(SouthBoundLatitude);
      hash.Add(NorthBoundLatitude);
      return hash.ToHashCode();
    }

    #endregion

  }

}
