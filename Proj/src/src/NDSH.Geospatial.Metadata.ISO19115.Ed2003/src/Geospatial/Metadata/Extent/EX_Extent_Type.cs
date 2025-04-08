
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 22/12/2022, @gisvlasta
// History           : 17/03/2025, @gisvlasta - Added IsoTypeAttribute, and updated code.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/extent.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="EX_Extent_Type">
//   <xs:annotation>
//     <xs:documentation>Information about spatial, vertical, and temporal extent</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="description" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="geographicElement"
//                     type="gmd:EX_GeographicExtent_PropertyType"
//                     minOccurs="0"
//                     maxOccurs="unbounded"/>
//         <xs:element name="temporalElement"
//                     type="gmd:EX_TemporalExtent_PropertyType"
//                     minOccurs="0"
//                     maxOccurs="unbounded"/>
//         <xs:element name="verticalElement"
//                     type="gmd:EX_VerticalExtent_PropertyType"
//                     minOccurs="0"
//                     maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="EX_Extent" type="gmd:EX_Extent_Type"/>
// <xs:complexType name="EX_Extent_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:EX_Extent"/>
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

#endregion

namespace NDSH.Geospatial.Metadata.Extent {

  /// <summary>
  /// Information about spatial, vertical, and temporal extent.
  /// </summary>
  [IsoType("EX_Extent_Type", IsoType = IsoTypes.ComplexType)]
  //[XmlType("EX_Extent", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("EX_Extent", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("EX_Extent")]
  public class EX_Extent_Type : MetadataObject, IComparable<EX_Extent_Type>, IEquatable<EX_Extent_Type> {

    // TODO: Continue

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_Extent_Type"/>.
    /// </summary>
    public EX_Extent_Type() {
      _description = default; //  new CharacterString();
      _geographicElement = default; //  new List<AbstractEX_GeographicExtent_Type>();
      _temporalElement = default; //  new List<EX_TemporalExtent_Type>();
      _verticalElement = default; //  new List<EX_VerticalExtent_Type>();
    }

    #endregion

    #region Public Properties

    // TODO: OBJECT_REFERENCE

    private CharacterString? _description;

    /// <summary>
    /// Spatial and temporal extent for the referring object.
    /// </summary>
    // TODO: OBL - C (geographicElement and temporalElement and verticalElement not documented?)
    // TODO: CAR - 1
    //[XmlElement("description", Order = 0)]
    [JsonProperty("description", Order = 0)]
    public CharacterString? Description {
      get => _description;
      set => SetProperty(ref _description, value);
    }

    private ObservableCollection<AbstractEX_GeographicExtent_Type>? _geographicElement;

    /// <summary>
    /// Provides geographic component of the extent of the referring object.
    /// </summary>
    // TODO: OBL - C (description and temporalElement and verticalElement not documented?)
    // TODO: CAR - N
    //[XmlElement("geographicElement", Order = 1)]
    [JsonProperty("geographicElement", Order = 1)]
    public ObservableCollection<AbstractEX_GeographicExtent_Type>? GeographicElement {
      get => _geographicElement;
      set => SetProperty(ref _geographicElement, value);
    }

    private ObservableCollection<EX_TemporalExtent_Type>? _temporalElement;

    /// <summary>
    /// Provides temporal component of the extent of the referring object.
    /// </summary>
    // TODO: OBL - C (description and geographicElement and verticalElement not documented?)
    // TODO: CAR - N
    //[XmlElement("temporalElement", Order = 2)]
    [JsonProperty("temporalElement", Order = 2)]
    public ObservableCollection<EX_TemporalExtent_Type>? TemporalElement {
      get => _temporalElement;
      set => SetProperty(ref _temporalElement, value);
    }

    private ObservableCollection<EX_VerticalExtent_Type>? _verticalElement;

    /// <summary>
    /// Provides vertical component of the extent of the referring object.
    /// </summary>
    // TODO: OBL - C (description and geographicElement and temporalElement not documented?)
    // TODO: CAR - N
    //[XmlElement("verticalElement", Order = 3)]
    [JsonProperty("verticalElement", Order = 3)]
    public ObservableCollection<EX_VerticalExtent_Type>? VerticalElement {
      get => _verticalElement;
      set => SetProperty(ref _verticalElement, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="EX_Extent_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="EX_Extent_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(EX_Extent_Type? other) {
      int result;

      return
          other is null ? 1 :
          (result = Description?.CompareTo(other.Description) ?? 1) != 0 ? result :
          (result = GeographicElement?.Count.CompareTo(other.GeographicElement?.Count ?? 0) ?? 1) != 0 ? result :
          (result = TemporalElement?.Count.CompareTo(other.TemporalElement?.Count ?? 0) ?? 1) != 0 ? result :
          VerticalElement?.Count.CompareTo(other.VerticalElement?.Count ?? 0) ?? 1;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="EX_Extent_Type"/> is equal to the current <see cref="EX_Extent_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="EX_Extent_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(EX_Extent_Type? other) {
      return other != null &&
          Equals(Description, other.Description) &&
          GeographicElement.SequenceEqualOrdered(other.GeographicElement); // TODO: Implement the rest of the properties
                                                                           //TemporalElement.SequenceEqualOrdered(other.TemporalElement) &&
                                                                           //VerticalElement.SequenceEqualOrdered(other.VerticalElement);
    }

    #endregion

    #region Public Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="EX_Extent_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) => Equals(obj as EX_Extent_Type);

    /// <summary>
    /// Gets the hash code for the <see cref="EX_Extent_Type"/> using <see cref="NdshHashCode"/>. This will also order 
    /// collections before hashing them.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      hash.Add(Description);

      foreach (AbstractEX_GeographicExtent_Type geographicElement in GeographicElement.SafeOrderBy()) {
        hash.Add(geographicElement);
      }

      // TODO: Implement the rest of the properties
      //foreach (EX_TemporalExtent_Type temporalElement in TemporalElement.SafeOrderBy()) {
      //  hash.Add(temporalElement);
      //}

      //foreach (EX_VerticalExtent_Type verticalElement in VerticalElement.SafeOrderBy()) {
      //  hash.Add(verticalElement);
      //}

      return hash.ToHashCode();
    }

    #endregion

  }

}
