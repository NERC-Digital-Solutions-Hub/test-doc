
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/01/2023, 01:41, @gisvlasta.
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
// <xs:complexType name="MI_GCP_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="geographicCoordinates" type="gmi:DirectPosition_PropertyType"/>
//         <xs:element name="accuracyReport" type="gmd:DQ_Element_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MI_GCP" type="gmi:MI_GCP_Type"/>
// <xs:complexType name="MI_GCP_PropertyType">
//   <xs:sequence>
//     <xs:element ref="gmi:MI_GCP" minOccurs="0"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Geometry.Basic0D1D;

using NDSH.Geospatial.Metadata.DataQuality;
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
  [XmlType("MI_GCP", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_GCP", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_GCP")]
  public class MI_GCP_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_GCP_Type"/>
    /// </summary>
    public MI_GCP_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _geographicCoordinates = default; // new DirectPositionType();
      _accuracyReport = default; // new List<AbstractDQ_Element_Type>();

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

    private DirectPositionType _geographicCoordinates;

    /// <summary>
    /// Geographic or map position of the control point, in either two or three dimensions.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    [XmlElement("geographicCoordinates", Order = 0)]
    [JsonProperty("geographicCoordinates", Order = 0)]
    public DirectPositionType GeographicCoordinates {
      get {
        return _geographicCoordinates;
      }
      set => SetProperty(ref _geographicCoordinates, value);
    }

    private List<AbstractDQ_Element_Type> _accuracyReport;

    /// <summary>
    /// Accuracy of a ground control point.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    [XmlElement("accuracyReport", Order = 1)]
    [JsonProperty("accuracyReport", Order = 1)]
    public List<AbstractDQ_Element_Type> AccuracyReport {
      get {
        return _accuracyReport;
      }
      set => SetProperty(ref _accuracyReport, value);
    }

    #endregion

  }

}
