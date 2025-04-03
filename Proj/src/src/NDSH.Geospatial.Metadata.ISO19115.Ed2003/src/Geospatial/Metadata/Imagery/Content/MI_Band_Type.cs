
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 26/01/2023, 18:13, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmi/contentInformation.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MI_Band_Type">
//   <xs:annotation>
//     <xs:documentation>Description: extensions to electromagnetic spectrum wavelength description - shortName: BandExt</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gmd:MD_Band_Type">
//       <xs:sequence>
//         <xs:element name="bandBoundaryDefinition" type="gmi:MI_BandDefinition_PropertyType" minOccurs="0"/>
//         <xs:element name="nominalSpatialResolution" type="gco:Real_PropertyType" minOccurs="0"/>
//         <xs:element name="transferFunctionType" type="gmi:MI_TransferFunctionTypeCode_PropertyType" minOccurs="0"/>
//         <xs:element name="transmittedPolarisation" type="gmi:MI_PolarisationOrientationCode_PropertyType" minOccurs="0"/>
//         <xs:element name="detectedPolarisation" type="gmi:MI_PolarisationOrientationCode_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MI_Band" type="gmi:MI_Band_Type" substitutionGroup="gmd:MD_Band"/>
// <xs:complexType name="MI_Band_PropertyType">
//   <xs:sequence>
//     <xs:element ref="gmi:MI_Band" minOccurs="0"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.Content;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Imagery.Content {

  /// <summary>
  /// Extensions to electromagnetic spectrum wavelength description.
  /// </summary>
  /// <remarks>ShortName: BandExt</remarks>
  [Serializable]
  //[XmlType("MI_Band", Namespace = "http://www.isotc211.org/2005/gmi")]
  //[XmlRoot("MI_Band", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_Band")]
  public class MI_Band_Type : MD_Band_Type {

    // WARNING: VALUE TYPE

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Band_Type"/>
    /// </summary>
    public MI_Band_Type() {
      _bandBoundaryDefinition = default; // new MI_BandDefinition_PropertyType();
      _nominalSpatialResolution = default; // new Real_PropertyType();
      _transferFunctionType = default; // new MI_TransferFunctionTypeCode_PropertyType();
      _transmittedPolarisation = default; // new MI_PolarisationOrientationCode_PropertyType();
      _detectedPolarisation = default; // new MI_PolarisationOrientationCode_PropertyType();
    }

    #endregion

    #region Public Properties

    private MI_BandDefinition_CodeList _bandBoundaryDefinition;

    //[XmlElement("bandBoundaryDefinition", Order = 0)]
    [JsonProperty("bandBoundaryDefinition", Order = 0)]
    public MI_BandDefinition_CodeList BandBoundaryDefinition {
      get => _bandBoundaryDefinition;
      set => SetProperty(ref _bandBoundaryDefinition, value);
    }

    private double _nominalSpatialResolution;

    //[XmlElement("nominalSpatialResolution", Order = 1)]
    [JsonProperty("nominalSpatialResolution", Order = 1)]
    public double NominalSpatialResolution {
      get => _nominalSpatialResolution;
      // TODO: SetProperty
      set {
        if (_nominalSpatialResolution == value) {
          return;
        }
        if (/*_nominalSpatialResolution == null || */_nominalSpatialResolution.Equals(value) != true) {
          _nominalSpatialResolution = value;
          OnPropertyChanged();
        }
      }
    }

    private MI_TransferFunctionTypeCode_CodeList _transferFunctionType;

    //[XmlElement("transferFunctionType", Order = 2)]
    [JsonProperty("transferFunctionType", Order = 2)]
    public MI_TransferFunctionTypeCode_CodeList TransferFunctionType {
      get => _transferFunctionType;
      set => SetProperty(ref _transferFunctionType, value);
    }

    private MI_PolarisationOrientationCode_CodeList _transmittedPolarisation;

    //[XmlElement("transmittedPolarisation", Order = 3)]
    [JsonProperty("transmittedPolarisation", Order = 3)]
    public MI_PolarisationOrientationCode_CodeList TransmittedPolarisation {
      get => _transmittedPolarisation;
      set => SetProperty(ref _transmittedPolarisation, value);
    }

    private MI_PolarisationOrientationCode_CodeList _detectedPolarisation;

    //[XmlElement("detectedPolarisation", Order = 4)]
    [JsonProperty("detectedPolarisation", Order = 4)]
    public MI_PolarisationOrientationCode_CodeList DetectedPolarisation {
      get => _detectedPolarisation;
      set => SetProperty(ref _detectedPolarisation, value);
    }

    #endregion

  }

}
