
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 03:29, @gisvlasta.
// Updated by        : 09/01/2023, 20:56, @gisvlasta. - 1.0.1: Added xmlns field.
//                   : 08/02/2023, 01:54, @gisvlasta. - 1.0.2: Added [XmlInclude]s.
// Version           : 1.0.2
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/spatialRepresentation.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MD_Georectified_Type">
//   <xs:complexContent>
//     <xs:extension base="gmd:MD_GridSpatialRepresentation_Type">
//       <xs:sequence>
//         <xs:element name="checkPointAvailability" 
//                     type="gco:Boolean_PropertyType"/>
//         <xs:element name="checkPointDescription" 
//                     type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="cornerPoints" 
//                     type="gss:GM_Point_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="centerPoint" 
//                     type="gss:GM_Point_PropertyType" minOccurs="0"/>
//         <xs:element name="pointInPixel" 
//                     type="gmd:MD_PixelOrientationCode_PropertyType"/>
//         <xs:element name="transformationDimensionDescription" 
//                     type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="transformationDimensionMapping" 
//                     type="gco:CharacterString_PropertyType" minOccurs="0" maxOccurs="2"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_Georectified"
//             type="gmd:MD_Georectified_Type" substitutionGroup="gmd:MD_GridSpatialRepresentation"/>
// <xs:complexType name="MD_Georectified_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_Georectified"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Schema;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.SpatialRepresentation {

  //[XmlInclude(typeof(MI_Georectified_Type))]
  [Serializable]
  //[XmlType("MD_Georectified", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_Georectified", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_Georectified")]
  public class MD_Georectified_Type : MD_GridSpatialRepresentation_Type {

    // WARNING: Check which value types need to be nullable.

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Georectified_Type"/>.
    /// </summary>
    public MD_Georectified_Type() {
      _checkPointAvailability = default; //  new Boolean_PropertyType();
      _checkPointDescription = default; //  new CharacterString();
      _cornerPoints = default; //  new List<GM_Point_PropertyType>();
      _centerPoint = default; //  new GM_Point_PropertyType();
      _pointInPixel = default; //  new MD_PixelOrientationCode_PropertyType();
      _transformationDimensionDescription = default; //  new CharacterString();
      _transformationDimensionMapping = default; //  new List<CharacterString>();
    }

    #endregion

    #region Public Properties

    private bool _checkPointAvailability;

    /// <summary>
    /// Indication of whether or not geographic position points are
    /// available to test the accuracy of the georeferenced grid data.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("checkPointAvailability", Order = 0)]
    [JsonProperty("checkPointAvailability", Order = 0)]
    public bool CheckPointAvailability {
      get => _checkPointAvailability;
      // TODO: SetProperty
      set {
        if (_checkPointAvailability == value) {
          return;
        }
        if (/*_checkPointAvailability == null || */_checkPointAvailability.Equals(value) != true) {
          _checkPointAvailability = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString? _checkPointDescription;

    /// <summary>
    /// Description of geographic position points used to test the accuracy of the georeferenced grid data.
    /// </summary>
    // TODO: OBL - C (checkPointAvailability equals "yes"?)
    // TODO: CAR - 1
    //[XmlElement("checkPointDescription", Order = 1)]
    [JsonProperty("checkPointDescription", Order = 1)]
    public CharacterString? CheckPointDescription {
      get => _checkPointDescription;
      set => SetProperty(ref _checkPointDescription, value);
    }

    private List<GM_Point_PropertyType> _cornerPoints;

    /// <summary>
    /// Earth location in the coordinate system defined by the Spatial Reference System and
    /// the grid coordinate of the cells at opposite ends of grid coverage along two diagonals
    /// in the grid spatial dimensions.
    /// </summary>
    /// <remarks>
    /// There are four corner points in a georectified grid; at least two corner points along one
    /// diagonal are required. The first corner point corresponds to the origin of the grid.
    /// </remarks>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("cornerPoints", Order = 2)]
    [JsonProperty("cornerPoints", Order = 2)]
    public List<GM_Point_PropertyType> CornerPoints {
      get => _cornerPoints;
      set => SetProperty(ref _cornerPoints, value);
    }

    private GM_Point_PropertyType? _centerPoint;

    /// <summary>
    /// Earth location in the coordinate system defined by the Spatial Reference System and
    /// the grid coordinate of the cell halfway between opposite ends of the grid in the spatial dimensions.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("centerPoint", Order = 3)]
    [JsonProperty("centerPoint", Order = 3)]
    public GM_Point_PropertyType? CenterPoint {
      get => _centerPoint;
      set => SetProperty(ref _centerPoint, value);
    }

    private MD_PixelOrientationCode_PropertyType _pointInPixel;

    /// <summary>
    /// Point in a pixel corresponding to the Earth location of the pixel.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("pointInPixel", Order = 4)]
    [JsonProperty("pointInPixel", Order = 4)]
    public MD_PixelOrientationCode_PropertyType PointInPixel {
      get => _pointInPixel;
      set => SetProperty(ref _pointInPixel, value);
    }

    private CharacterString? _transformationDimensionDescription;

    /// <summary>
    /// General description of the transformation.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("transformationDimensionDescription", Order = 5)]
    [JsonProperty("transformationDimensionDescription", Order = 5)]
    public CharacterString? TransformationDimensionDescription {
      get => _transformationDimensionDescription;
      set => SetProperty(ref _transformationDimensionDescription, value);
    }

    private List<CharacterString>? _transformationDimensionMapping;

    /// <summary>
    /// Information about which grid axes are the spatial (map) axes.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 2
    //[XmlElement("transformationDimensionMapping", Order = 6)]
    [JsonProperty("transformationDimensionMapping", Order = 6)]
    public List<CharacterString>? TransformationDimensionMapping {
      get => _transformationDimensionMapping;
      set => SetProperty(ref _transformationDimensionMapping, value);
    }

    #endregion

  }

}
