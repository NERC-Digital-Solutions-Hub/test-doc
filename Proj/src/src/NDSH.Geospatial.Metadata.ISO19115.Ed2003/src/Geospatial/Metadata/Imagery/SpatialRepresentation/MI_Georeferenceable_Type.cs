
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/01/2023, 01:39, @gisvlasta.
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
// <xs:complexType name="MI_Georeferenceable_Type">
//   <xs:annotation>
//     <xs:documentation>Description: Description of information provided in metadata that allows the geographic or map location raster points to be located - FGDC: Georeferencing_Description - shortName: IGeoref</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gmd:MD_Georeferenceable_Type">
//       <xs:sequence>
//         <xs:element name="geolocationInformation" type="gmi:MI_GeolocationInformation_PropertyType" maxOccurs="unbounded"/>
//         <xs:element name="platformParameters" type="gmi:MI_Platform_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MI_Georeferenceable" type="gmi:MI_Georeferenceable_Type" substitutionGroup="gmd:MD_Georeferenceable"/>
// <xs:complexType name="MI_Georeferenceable_PropertyType">
//   <xs:sequence>
//     <xs:element ref="gmi:MI_Georeferenceable" minOccurs="0"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.Imagery.Acquisition;
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
  /// Description of information provided in metadata that allows
  /// the geographic or map location raster points to be located.
  /// </summary>
  /// <remarks>
  /// <para>FGDC: Georeferencing_Description</para>
  /// <para>ShortName: IGeoref</para>
  /// </remarks>
  [Serializable]
  [XmlType("MI_Georeferenceable", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_Georeferenceable", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_Georeferenceable")]
  public class MI_Georeferenceable_Type : MD_Georeferenceable_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Georeferenceable_Type"/>
    /// </summary>
    public MI_Georeferenceable_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _geolocationInformation = default; // new List<AbstractMI_GeolocationInformation_Type>();
      _platformParameters = default; // new MI_Platform_Type();

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

    private List<AbstractMI_GeolocationInformation_Type> _geolocationInformation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("geolocationInformation", Order = 0)]
    [JsonProperty("geolocationInformation", Order = 0)]
    public List<AbstractMI_GeolocationInformation_Type> GeolocationInformation {
      get {
        return _geolocationInformation;
      }
      set => SetProperty(ref _geolocationInformation, value);
    }

    private MI_Platform_Type _platformParameters;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("platformParameters", Order = 1)]
    [JsonProperty("platformParameters", Order = 1)]
    public MI_Platform_Type PlatformParameters {
      get {
        return _platformParameters;
      }
      set => SetProperty(ref _platformParameters, value);
    }

    #endregion

  }

}
