
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 22/12/2022, @gisvlasta
// History           : 17/03/2025, @gisvlasta - Changed VerticalCRS property type to AbstractCRSType, and updated code.
//                     18/03/2025, @gisvlasta - Changed VerticalCRS property type to VerticalCRSType.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : The XSD definition requires the VerticalCRS property to have the type AbstractCRSType;
//                     however, the property's type was changed to VerticalCRSType to constrain the accepted instances
//                     only to those coordinate reference systems that are vertical.
// ---------------------------------------------------------------------------------------------------------------------
// XSD               :/2005/gsr/spatialReferencing.xsd
//                    /2005/gmd/extent.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="SC_CRS_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gml:AbstractCRS"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// 
// <xs:complexType name="EX_VerticalExtent_Type">
//   <xs:annotation>
//     <xs:documentation>Vertical domain of dataset</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="minimumValue" type="gco:Real_PropertyType"/>
//         <xs:element name="maximumValue" type="gco:Real_PropertyType"/>
//         <xs:element name="verticalCRS" type="gsr:SC_CRS_PropertyType"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="EX_VerticalExtent" type="gmd:EX_VerticalExtent_Type"/>
// <xs:complexType name="EX_VerticalExtent_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:EX_VerticalExtent"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Coordinate.ReferenceSystems;
using NDSH.Geospatial.Gml.ReferenceSystems;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.Extent {

  /// <summary>
  /// Vertical domain of dataset.
  /// </summary>
  //[XmlType("EX_VerticalExtent", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("EX_VerticalExtent", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("EX_VerticalExtent")]
  public class EX_VerticalExtent_Type : MetadataObject {

    // WARNING: Check which value types need to be nullable.

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_VerticalExtent_Type"/>.
    /// </summary>
    // WARNING: What is the required modifier?
    public EX_VerticalExtent_Type() {
      _minimumValue = default; //  new Real_PropertyType();
      _maximumValue = default; //  new Real_PropertyType();
      _verticalCRS = default; //  new SC_CRS_PropertyType();
    }

    #endregion

    #region Public Properties

    private double _minimumValue;

    /// <summary>
    /// Lowest vertical extent contained in the dataset.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("minimumValue", Order = 0)]
    [JsonProperty("minimumValue", Order = 0)]
    public double MinimumValue {
      get => _minimumValue;
      set => SetProperty(ref _minimumValue, value);
    }

    private double _maximumValue;

    /// <summary>
    /// Highest vertical extent contained in the dataset.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("maximumValue", Order = 1)]
    [JsonProperty("maximumValue", Order = 1)]
    public double MaximumValue {
      get => _maximumValue;
      set => SetProperty(ref _maximumValue, value);
    }

    private VerticalCRSType _verticalCRS;

    /// <summary>
    /// Provides information about the vertical coordinate reference system to
    /// which the maximum and minimum elevation values are measured.
    /// </summary>
    /// <remarks>
    ///   <para>The CRS identification includes unit of measure.</para>
    ///   <para>
    ///     The XSD definition requires the <see cref="VerticalCRS"/> to have the <see cref="Type"/>
    ///     <see cref="AbstractCRSType"/>; however, the property's <see cref="Type"/> was changed to
    ///     <see cref="VerticalCRSType"/> to constrain the accepted instances only to those
    ///     coordinate reference systems that are vertical.
    ///   </para>
    /// </remarks>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("verticalCRS", Order = 2)]
    [JsonProperty("verticalCRS", Order = 2)]
    public VerticalCRSType VerticalCRS {
      get => _verticalCRS;
      set => SetProperty(ref _verticalCRS, value);
    }

    #endregion

  }

}
