
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 03:03, @gisvlasta.
// Updated by        : 09/01/2023, 20:55, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/spatialRepresentation.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MD_VectorSpatialRepresentation_Type">
//   <xs:complexContent>
//     <xs:extension base="gmd:AbstractMD_SpatialRepresentation_Type">
//       <xs:sequence>
//         <xs:element name="topologyLevel"
//                     type="gmd:MD_TopologyLevelCode_PropertyType" minOccurs="0"/>
//         <xs:element name="geometricObjects"
//                     type="gmd:MD_GeometricObjects_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_VectorSpatialRepresentation"
//             type="gmd:MD_VectorSpatialRepresentation_Type" substitutionGroup="gmd:AbstractMD_SpatialRepresentation"/>
// <xs:complexType name="MD_VectorSpatialRepresentation_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_VectorSpatialRepresentation"/>
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
  /// Information about the vector spatial objects in the dataset.
  /// </summary>
  [Serializable]
  [XmlType("MD_VectorSpatialRepresentation", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_VectorSpatialRepresentation", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_VectorSpatialRepresentation")]
  public class MD_VectorSpatialRepresentation_Type : AbstractMD_SpatialRepresentation_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_VectorSpatialRepresentation_Type"/>.
    /// </summary>
    public MD_VectorSpatialRepresentation_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _topologyLevel = default; //  new MD_TopologyLevelCode_PropertyType();
      _geometricObjects = default; //  new List<MD_GeometricObjects_Type>();

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private MD_TopologyLevelCode_CodeList? _topologyLevel;

    /// <summary>
    /// Code which identifies the degree of complexity of the spatial relationships.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    [XmlElement("topologyLevel", Order = 0)]
    [JsonProperty("topologyLevel", Order = 0)]
    public MD_TopologyLevelCode_CodeList? TopologyLevel {
      get {
        return _topologyLevel;
      }
      set => SetProperty(ref _topologyLevel, value);
    }

    private List<MD_GeometricObjects_Type>? _geometricObjects;

    /// <summary>
    /// Information about the geometric objects used in the dataset.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    [XmlElement("geometricObjects", Order = 1)]
    [JsonProperty("geometricObjects", Order = 1)]
    public List<MD_GeometricObjects_Type>? GeometricObjects {
      get {
        return _geometricObjects;
      }
      set => SetProperty(ref _geometricObjects, value);
    }

    #endregion

  }

}
