
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 04:42, @gisvlasta.
// Updated by        : 09/01/2023, 20:58, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/spatialRepresentation.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MD_Dimension_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="dimensionName" type="gmd:MD_DimensionNameTypeCode_PropertyType"/>
//         <xs:element name="dimensionSize" type="gco:Integer_PropertyType"/>
//         <xs:element name="resolution" type="gco:Measure_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_Dimension" type="gmd:MD_Dimension_Type"/>
// <xs:complexType name="MD_Dimension_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_Dimension"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Derived.UnitsOfMeasure;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.SpatialRepresentation {

  [Serializable]
  //[XmlType("MD_Dimension", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_Dimension", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_Dimension")]
  public class MD_Dimension_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Dimension_Type"/>.
    /// </summary>
    public MD_Dimension_Type() {
      _dimensionName = default; //  new MD_DimensionNameTypeCode_PropertyType();
      _dimensionSize = default; //  new Integer_PropertyType();
      _resolution = default; //  new Measure_PropertyType();
    }

    #endregion

    #region Public Properties

    private MD_DimensionNameTypeCode_CodeList _dimensionName;

    /// <summary>
    /// Name of the axis.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("dimensionName", Order = 0)]
    [JsonProperty("dimensionName", Order = 0)]
    public MD_DimensionNameTypeCode_CodeList DimensionName {
      get => _dimensionName;
      set => SetProperty(ref _dimensionName, value);
    }

    private int _dimensionSize;

    /// <summary>
    /// Number of elements along the axis.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("dimensionSize", Order = 1)]
    [JsonProperty("dimensionSize", Order = 1)]
    public int DimensionSize {
      get => _dimensionSize;
      // TODO: SetProperty
      set {
        if (_dimensionSize == value) {
          return;
        }
        if (/*_dimensionSize == null || */_dimensionSize.Equals(value) != true) {
          _dimensionSize = value;
          OnPropertyChanged();
        }
      }
    }

    private Measure_PropertyType? _resolution;

    /// <summary>
    /// Degree of detail in the grid dataset.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("resolution", Order = 2)]
    [JsonProperty("resolution", Order = 2)]
    public Measure_PropertyType? Resolution {
      get => _resolution;
      set => SetProperty(ref _resolution, value);
    }

    #endregion

  }

}
