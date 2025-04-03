
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/01/2023, 01:46, @gisvlasta.
// Updated by        : 08/02/2023, 01:46, @gisvlasta. - 1.0.1: Added [XmlInclude]s.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmi/spatialRepresentationInformation.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="AbstractMI_GeolocationInformation_Type" abstract="true">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="qualityInfo" type="gmd:DQ_DataQuality_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="AbstractMI_GeolocationInformation" type="gmi:AbstractMI_GeolocationInformation_Type" abstract="true"/>
// <xs:complexType name="MI_GeolocationInformation_PropertyType">
//   <xs:sequence>
//     <xs:element ref="gmi:AbstractMI_GeolocationInformation" minOccurs="0"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces


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
  //[XmlInclude(typeof(MI_GCPCollection_Type))]
  [Serializable]
  //[XmlType("AbstractMI_GeolocationInformation", Namespace = "http://www.isotc211.org/2005/gmi")]
  //[XmlRoot("AbstractMI_GeolocationInformation", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("AbstractMI_GeolocationInformation")]
  public class AbstractMI_GeolocationInformation_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractMI_GeolocationInformation_Type"/>
    /// </summary>
    public AbstractMI_GeolocationInformation_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _qualityInfo = default; // new List<DQ_DataQuality_Type>();

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

    private List<DQ_DataQuality_Type> _qualityInfo;

    /// <summary>
    /// Provides an overall assessment of quality of geolocation information.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    [XmlElement("qualityInfo", Order = 0)]
    [JsonProperty("qualityInfo", Order = 0)]
    public List<DQ_DataQuality_Type> QualityInfo {
      get {
        return _qualityInfo;
      }
      set => SetProperty(ref _qualityInfo, value);
    }

    #endregion

  }

}
