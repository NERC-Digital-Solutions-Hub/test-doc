
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/01/2023, 01:55, @gisvlasta.
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
// <xs:complexType name="MI_Georectified_Type">
//   <xs:annotation>
//     <xs:documentation>Description: extends georectified grid description to include associated checkpoints - shortName: IGeorect</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gmd:MD_Georectified_Type">
//       <xs:sequence>
//         <xs:element name="checkPoint" type="gmi:MI_GCP_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="geolocationIdentification" type="gmi:MI_GCPCollection_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MI_Georectified" type="gmi:MI_Georectified_Type" substitutionGroup="gmd:MD_Georectified"/>
// <xs:complexType name="MI_Georectified_PropertyType">
//   <xs:sequence>
//     <xs:element ref="gmi:MI_Georectified" minOccurs="0"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.SpatialRepresentation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Imagery.SpatialRepresentation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MI_Georectified", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_Georectified", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_Georectified")]
  public class MI_Georectified_Type : MD_Georectified_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Georectified_Type"/>
    /// </summary>
    public MI_Georectified_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _checkPoint = default; // new List<MI_GCP_Type>();
      _geolocationIdentification = default; // new List<MI_GCPCollection_Type>();

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public new XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private List<MI_GCP_Type> _checkPoint;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("checkPoint", Order = 0)]
    [JsonProperty("checkPoint", Order = 0)]
    public List<MI_GCP_Type> CheckPoint {
      get {
        return _checkPoint;
      }
      set => SetProperty(ref _checkPoint, value);
    }

    private List<MI_GCPCollection_Type> _geolocationIdentification;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("geolocationIdentification", Order = 1)]
    [JsonProperty("geolocationIdentification", Order = 1)]
    public List<MI_GCPCollection_Type> GeolocationIdentification {
      get {
        return _geolocationIdentification;
      }
      set => SetProperty(ref _geolocationIdentification, value);
    }

    #endregion

  }

}
