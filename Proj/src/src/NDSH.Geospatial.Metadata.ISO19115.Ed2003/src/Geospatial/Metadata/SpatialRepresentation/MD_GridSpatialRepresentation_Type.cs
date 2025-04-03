
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 03:14, @gisvlasta.
// Updated by        : 09/01/2023, 20:55, @gisvlasta. - 1.0.1: Added xmlns field.
//                   : 08/02/2023, 02:01, @gisvlasta. - 1.0.2: Added [XmlInclude]s.
// Version           : 1.0.2
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/spatialRepresentation.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MD_GridSpatialRepresentation_Type">
//   <xs:complexContent>
//     <xs:extension base="gmd:AbstractMD_SpatialRepresentation_Type">
//       <xs:sequence>
//         <xs:element name="numberOfDimensions"
//                     type="gco:Integer_PropertyType"/>
//         <xs:element name="axisDimensionProperties"
//                     type="gmd:MD_Dimension_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="cellGeometry"
//                     type="gmd:MD_CellGeometryCode_PropertyType"/>
//         <xs:element name="transformationParameterAvailability"
//                     type="gco:Boolean_PropertyType"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_GridSpatialRepresentation"
//             type="gmd:MD_GridSpatialRepresentation_Type" substitutionGroup="gmd:AbstractMD_SpatialRepresentation"/>
// <xs:complexType name="MD_GridSpatialRepresentation_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_GridSpatialRepresentation"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.SpatialRepresentation {

  /// <summary>
  /// Types and numbers of raster spatial objects in the dataset.
  /// </summary>
  //[XmlInclude(typeof(MI_Georectified_Type))]
  //[XmlInclude(typeof(MI_Georeferenceable_Type))]
  //[XmlInclude(typeof(MD_Georectified_Type))]
  //[XmlInclude(typeof(MD_Georeferenceable_Type))]
  [Serializable]
  //[XmlType("MD_GridSpatialRepresentation", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_GridSpatialRepresentation", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_GridSpatialRepresentation")]
  public class MD_GridSpatialRepresentation_Type : AbstractMD_SpatialRepresentation_Type {

    // WARNING: Check which value types need to be nullable.

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_GridSpatialRepresentation_Type"/>.
    /// </summary>
    public MD_GridSpatialRepresentation_Type() {
      _numberOfDimensions = default; //  new Integer_PropertyType();
      _axisDimensionProperties = default; //  new List<MD_Dimension_Type>();
      _cellGeometry = default; //  new MD_CellGeometryCode_PropertyType();
      _transformationParameterAvailability = default; //  new Boolean_PropertyType();
    }

    #endregion

    #region Public Properties

    private int _numberOfDimensions;

    /// <summary>
    /// Number of independent spatial-temporal axes.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("numberOfDimensions", Order = 0)]
    [JsonProperty("numberOfDimensions", Order = 0)]
    public int NumberOfDimensions {
      get => _numberOfDimensions;
      // TODO: SetProperty
      set {
        if (_numberOfDimensions == value) {
          return;
        }
        if (/*_numberOfDimensions == null || */_numberOfDimensions.Equals(value) != true) {
          _numberOfDimensions = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_Dimension_Type> _axisDimensionProperties;

    /// <summary>
    /// Information about spatial-temporal axis properties.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("axisDimensionProperties", Order = 1)]
    [JsonProperty("axisDimensionProperties", Order = 1)]
    public List<MD_Dimension_Type> AxisDimensionProperties {
      get => _axisDimensionProperties;
      set => SetProperty(ref _axisDimensionProperties, value);
    }

    private MD_CellGeometryCode_CodeList _cellGeometry;

    /// <summary>
    /// Identification of grid data as point or cell.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("cellGeometry", Order = 2)]
    [JsonProperty("cellGeometry", Order = 2)]
    public MD_CellGeometryCode_CodeList CellGeometry {
      get => _cellGeometry;
      set => SetProperty(ref _cellGeometry, value);
    }

    private bool _transformationParameterAvailability;

    /// <summary>
    /// Indication of whether or not parameters for transformation between
    /// image coordinates and geographic or map coordinates exist (are available).
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("transformationParameterAvailability", Order = 3)]
    [JsonProperty("transformationParameterAvailability", Order = 3)]
    public bool TransformationParameterAvailability {
      get => _transformationParameterAvailability;
      // TODO: SetProperty
      set {
        if (_transformationParameterAvailability == value) {
          return;
        }
        if (/*_transformationParameterAvailability == null || */_transformationParameterAvailability.Equals(value) != true) {
          _transformationParameterAvailability = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
