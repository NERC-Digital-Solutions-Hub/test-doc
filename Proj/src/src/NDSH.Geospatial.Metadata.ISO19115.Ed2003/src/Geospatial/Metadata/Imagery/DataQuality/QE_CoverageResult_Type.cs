
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 27/01/2023, 01:48, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmi/dataQualityInformation.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="QE_CoverageResult_Type">
//   <xs:annotation>
//     <xs:documentation>Description: Result of a data quality measure organising the measured values as a coverage - shortName: CoverageResult</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gmd:AbstractDQ_Result_Type">
//       <xs:sequence>
//         <xs:element name="spatialRepresentationType" type="gmd:MD_SpatialRepresentationTypeCode_PropertyType"/>
//         <xs:element name="resultSpatialRepresentation" type="gmd:MD_SpatialRepresentation_PropertyType"/>
//         <xs:element name="resultContentDescription" type="gmd:MD_CoverageDescription_PropertyType"/>
//         <xs:element name="resultFormat" type="gmd:MD_Format_PropertyType"/>
//         <xs:element name="resultFile" type="gmi:MX_DataFile_PropertyType"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="QE_CoverageResult" type="gmi:QE_CoverageResult_Type" substitutionGroup="gmd:AbstractDQ_Result"/>
// <xs:complexType name="QE_CoverageResult_PropertyType">
//   <xs:sequence>
//     <xs:element ref="gmi:QE_CoverageResult" minOccurs="0"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.Content;
using NDSH.Geospatial.Metadata.DataQuality;
using NDSH.Geospatial.Metadata.Distribution;
using NDSH.Geospatial.Metadata.Identification;
using NDSH.Geospatial.Metadata.SpatialRepresentation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Imagery.DataQuality {

  /// <summary>
  /// Result of a data quality measure organising the measured values as a coverage.
  /// </summary>
  /// <remarks>ShortName: CoverageResult</remarks>
  [Serializable]
  [XmlType("QE_CoverageResult", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("QE_CoverageResult", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("QE_CoverageResult")]
  public class QE_CoverageResult_Type : AbstractDQ_Result_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="QE_CoverageResult_Type"/>
    /// </summary>
    public QE_CoverageResult_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _spatialRepresentationType = default; // new MD_SpatialRepresentationTypeCode_PropertyType();
      _resultSpatialRepresentation = default; // new AbstractMD_SpatialRepresentation_Type();
      _resultContentDescription = default; // new MD_CoverageDescription_Type();
      _resultFormat = default; // new MD_Format_Type();
      _resultFile = default; // new MX_DataFile_Type();

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

    private MD_SpatialRepresentationTypeCode_CodeList _spatialRepresentationType;

    /// <summary>
    /// Method used to spatially represent the coverage result.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    [XmlElement("spatialRepresentationType", Order = 0)]
    [JsonProperty("spatialRepresentationType", Order = 0)]
    public MD_SpatialRepresentationTypeCode_CodeList SpatialRepresentationType {
      get {
        return _spatialRepresentationType;
      }
      set => SetProperty(ref _spatialRepresentationType, value);
    }

    private AbstractMD_SpatialRepresentation_Type _resultSpatialRepresentation;

    /// <summary>
    /// Provides the digital representation of data quality measures composing the coverage result.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    [XmlElement("resultSpatialRepresentation", Order = 1)]
    [JsonProperty("resultSpatialRepresentation", Order = 1)]
    public AbstractMD_SpatialRepresentation_Type ResultSpatialRepresentation {
      get {
        return _resultSpatialRepresentation;
      }
      set => SetProperty(ref _resultSpatialRepresentation, value);
    }

    private MD_CoverageDescription_Type _resultContentDescription;

    /// <summary>
    /// Provides the description of content of the result coverage, i.e.: semantic definition of the data quality measures.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    [XmlElement("resultContentDescription", Order = 2)]
    [JsonProperty("resultContentDescription", Order = 2)]
    public MD_CoverageDescription_Type ResultContentDescription {
      get {
        return _resultContentDescription;
      }
      set => SetProperty(ref _resultContentDescription, value);
    }

    private MD_Format_Type _resultFormat;

    /// <summary>
    /// Provides information about the format of the result coverage data.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    [XmlElement("resultFormat", Order = 3)]
    [JsonProperty("resultFormat", Order = 3)]
    public MD_Format_Type ResultFormat {
      get {
        return _resultFormat;
      }
      set => SetProperty(ref _resultFormat, value);
    }

    private MX_ImgDataFile_Type _resultFile;

    /// <summary>
    /// Provides information about the data file containing the result coverage data.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    [XmlElement("resultFile", Order = 4)]
    [JsonProperty("resultFile", Order = 4)]
    public MX_ImgDataFile_Type ResultFile {
      get {
        return _resultFile;
      }
      set => SetProperty(ref _resultFile, value);
    }

    #endregion

  }

}
