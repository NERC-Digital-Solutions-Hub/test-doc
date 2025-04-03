
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/01/2023, 01:44, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmi/spatialRepresentationInformation.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MI_GCPCollection_Type">
//   <xs:complexContent>
//     <xs:extension base="gmi:AbstractMI_GeolocationInformation_Type">
//       <xs:sequence>
//         <xs:element name="collectionIdentification" type="gco:Integer_PropertyType"/>
//         <xs:element name="collectionName" type="gco:CharacterString_PropertyType"/>
//         <xs:element name="coordinateReferenceSystem" type="gmd:MD_ReferenceSystem_PropertyType"/>
//         <xs:element name="gcp" type="gmi:MI_GCP_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MI_GCPCollection" type="gmi:MI_GCPCollection_Type" substitutionGroup="gmi:AbstractMI_GeolocationInformation"/>
// <xs:complexType name="MI_GCPCollection_PropertyType">
//   <xs:sequence>
//     <xs:element ref="gmi:MI_GCPCollection" minOccurs="0"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.ReferenceSystem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Imagery.SpatialRepresentation {

  [Serializable]
  //[XmlType("MI_GCPCollection", Namespace = "http://www.isotc211.org/2005/gmi")]
  //[XmlRoot("MI_GCPCollection", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_GCPCollection")]
  public class MI_GCPCollection_Type : AbstractMI_GeolocationInformation_Type {

    // WARNING: VALUE TYPE

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_GCPCollection_Type"/>
    /// </summary>
    public MI_GCPCollection_Type() {
      _collectionIdentification = default; // new Integer_PropertyType();
      _collectionName = default; // new CharacterString();
      _coordinateReferenceSystem = default; // new MD_ReferenceSystem_Type();
      _gcp = default; // new List<MI_GCP_Type>();
    }

    #endregion

    #region Public Properties

    private int _collectionIdentification;

    /// <summary>
    /// Identifier of the GCP collection.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("collectionIdentification", Order = 0)]
    [JsonProperty("collectionIdentification", Order = 0)]
    public int CollectionIdentification {
      get => _collectionIdentification;
      // TODO: SetProperty
      set {
        if (_collectionIdentification == value) {
          return;
        }
        if (/*_collectionIdentification == null || */_collectionIdentification.Equals(value) != true) {
          _collectionIdentification = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _collectionName;

    /// <summary>
    /// Name of the GCP collection.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("collectionName", Order = 1)]
    [JsonProperty("collectionName", Order = 1)]
    public CharacterString CollectionName {
      get => _collectionName;
      set => SetProperty(ref _collectionName, value);
    }

    private MD_ReferenceSystem_Type _coordinateReferenceSystem;

    /// <summary>
    /// Coordinate system in which the ground control points are defined.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("coordinateReferenceSystem", Order = 2)]
    [JsonProperty("coordinateReferenceSystem", Order = 2)]
    public MD_ReferenceSystem_Type CoordinateReferenceSystem {
      get => _coordinateReferenceSystem;
      set => SetProperty(ref _coordinateReferenceSystem, value);
    }

    private List<MI_GCP_Type> _gcp;

    /// <summary>
    /// Ground control point(s) used in the collection.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - *
    //[XmlElement("gcp", Order = 3)]
    [JsonProperty("gcp", Order = 3)]
    public List<MI_GCP_Type> Gcp {
      get => _gcp;
      set => SetProperty(ref _gcp, value);
    }

    #endregion

  }

}
