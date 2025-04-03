
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 04:26, @gisvlasta.
// Updated by        : 09/01/2023, 20:56, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/spatialRepresentation.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MD_GeometricObjects_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="geometricObjectType" type="gmd:MD_GeometricObjectTypeCode_PropertyType"/>
//         <xs:element name="geometricObjectCount" type="gco:Integer_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_GeometricObjects" type="gmd:MD_GeometricObjects_Type"/>
// <xs:complexType name="MD_GeometricObjects_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_GeometricObjects"/>
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

  [Serializable]
  //[XmlType("MD_GeometricObjects", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_GeometricObjects", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_GeometricObjects")]
  public class MD_GeometricObjects_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_GeometricObjects_Type"/>.
    /// </summary>
    public MD_GeometricObjects_Type() {
      _geometricObjectType = default; //  new MD_GeometricObjectTypeCode_PropertyType();
      _geometricObjectCount = default; //  new Integer_PropertyType();
    }

    #endregion

    #region Public Properties

    private MD_GeometricObjectTypeCode_CodeList _geometricObjectType;

    /// <summary>
    /// Name of point or vector objects used to locate zero-, one-, two-,
    /// or three-dimensional spatial locations in the dataset.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("geometricObjectType", Order = 0)]
    [JsonProperty("geometricObjectType", Order = 0)]
    public MD_GeometricObjectTypeCode_CodeList GeometricObjectType {
      get => _geometricObjectType;
      set => SetProperty(ref _geometricObjectType, value);
    }

    private int? _geometricObjectCount;

    /// <summary>
    /// Total number of the point of vector object type occurring in the dataset.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("geometricObjectCount", Order = 1)]
    [JsonProperty("geometricObjectCount", Order = 1)]
    public int? GeometricObjectCount {
      get => _geometricObjectCount;
      // TODO: SetProperty
      set {
        if (_geometricObjectCount == value) {
          return;
        }
        if (/*_geometricObjectCount == null ||*/ _geometricObjectCount.Equals(value) != true) {
          _geometricObjectCount = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
