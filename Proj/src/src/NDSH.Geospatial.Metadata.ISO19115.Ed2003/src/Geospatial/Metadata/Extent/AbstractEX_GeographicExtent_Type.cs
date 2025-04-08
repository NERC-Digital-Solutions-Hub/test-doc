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
// <xs:complexType name="AbstractEX_GeographicExtent_Type" abstract="true">
//   <xs:annotation>
//     <xs:documentation>Geographic area of the dataset</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="extentTypeCode" type="gco:Boolean_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="AbstractEX_GeographicExtent" type="gmd:AbstractEX_GeographicExtent_Type" abstract="true"/>
// <xs:complexType name="EX_GeographicExtent_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:AbstractEX_GeographicExtent"/>
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
  /// Geographic area of the dataset.
  /// </summary>
  //[XmlInclude(typeof(EX_GeographicDescription_Type))]
  //[XmlInclude(typeof(EX_GeographicBoundingBox_Type))]
  //[XmlInclude(typeof(EX_BoundingPolygon_Type))]
  [Serializable]
  //[XmlType("AbstractEX_GeographicExtent", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("AbstractEX_GeographicExtent", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("AbstractEX_GeographicExtent")]
  public abstract class AbstractEX_GeographicExtent_Type : MetadataObject, IComparable<AbstractEX_GeographicExtent_Type>, IEquatable<AbstractEX_GeographicExtent_Type> {

    // WARNING: Check which value types need to be nullable.

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractEX_GeographicExtent_Type"/>.
    /// </summary>
    public AbstractEX_GeographicExtent_Type() {
      _extentTypeCode = default; //  new Boolean_PropertyType();
    }

    #endregion

    #region Public Properties

    private bool? _extentTypeCode;

    /// <summary>
    /// Indication of whether the bounding polygon encompasses and
    /// area covered by the data or an area where data is not present.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("extentTypeCode", Order = 0)]
    [JsonProperty("extentTypeCode", Order = 0)]
    public bool? ExtentTypeCode {
      get => _extentTypeCode;
      // TODO: SetProperty
      set {
        if (_extentTypeCode == value) {
          return;
        }
        if (!_extentTypeCode.Equals(value)) {
          _extentTypeCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="AbstractEX_GeographicExtent_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="AbstractEX_GeographicExtent_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public virtual int CompareTo(AbstractEX_GeographicExtent_Type? other) {
      return
          other is null ? 1 :
          ExtentTypeCode?.CompareTo(other.ExtentTypeCode) ?? 0;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="AbstractEX_GeographicExtent_Type"/> is equal to the current <see cref="AbstractEX_GeographicExtent_Type"/>.
    /// </summary>
    /// <param name="other">The <see cref="AbstractEX_GeographicExtent_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public virtual bool Equals(AbstractEX_GeographicExtent_Type? other) {
      return other != null &&
          ExtentTypeCode == other.ExtentTypeCode;
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="AbstractEX_GeographicExtent_Type"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as AbstractEX_GeographicExtent_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="AbstractEX_GeographicExtent_Type"/> using <see cref="NdshHashCode"/>.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();
      hash.Add(ExtentTypeCode);
      return hash.ToHashCode();
    }

    #endregion

  }

}
