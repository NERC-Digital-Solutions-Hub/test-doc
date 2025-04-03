
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
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.Content;
using NDSH.Geospatial.Metadata.V2003.DataQuality;
using NDSH.Geospatial.Metadata.V2003.Distribution;
using NDSH.Geospatial.Metadata.V2003.Identification;
using NDSH.Geospatial.Metadata.V2003.SpatialRepresentation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Imagery.DataQuality {

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
      _resultSpatialRepresentation = default; // new MD_SpatialRepresentation_PropertyType();
      _resultContentDescription = default; // new MD_CoverageDescription_PropertyType();
      _resultFormat = default; // new MD_Format_PropertyType();
      _resultFile = default; // new MX_DataFile_PropertyType();

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

    private MD_SpatialRepresentationTypeCode_PropertyType _spatialRepresentationType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("spatialRepresentationType", Order = 0)]
    [JsonProperty("spatialRepresentationType", Order = 0)]
    public MD_SpatialRepresentationTypeCode_PropertyType SpatialRepresentationType {
      get {
        return _spatialRepresentationType;
      }
      set {
        if (_spatialRepresentationType == value) {
          return;
        }
        if (_spatialRepresentationType == null || _spatialRepresentationType.Equals(value) != true) {
          _spatialRepresentationType = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_SpatialRepresentation_PropertyType _resultSpatialRepresentation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("resultSpatialRepresentation", Order = 1)]
    [JsonProperty("resultSpatialRepresentation", Order = 1)]
    public MD_SpatialRepresentation_PropertyType ResultSpatialRepresentation {
      get {
        return _resultSpatialRepresentation;
      }
      set {
        if (_resultSpatialRepresentation == value) {
          return;
        }
        if (_resultSpatialRepresentation == null || _resultSpatialRepresentation.Equals(value) != true) {
          _resultSpatialRepresentation = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_CoverageDescription_PropertyType _resultContentDescription;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("resultContentDescription", Order = 2)]
    [JsonProperty("resultContentDescription", Order = 2)]
    public MD_CoverageDescription_PropertyType ResultContentDescription {
      get {
        return _resultContentDescription;
      }
      set {
        if (_resultContentDescription == value) {
          return;
        }
        if (_resultContentDescription == null || _resultContentDescription.Equals(value) != true) {
          _resultContentDescription = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_Format_PropertyType _resultFormat;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("resultFormat", Order = 3)]
    [JsonProperty("resultFormat", Order = 3)]
    public MD_Format_PropertyType ResultFormat {
      get {
        return _resultFormat;
      }
      set {
        if (_resultFormat == value) {
          return;
        }
        if (_resultFormat == null || _resultFormat.Equals(value) != true) {
          _resultFormat = value;
          OnPropertyChanged();
        }
      }
    }

    private MX_ImgDataFile_PropertyType _resultFile;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("resultFile", Order = 4)]
    [JsonProperty("resultFile", Order = 4)]
    public MX_ImgDataFile_PropertyType ResultFile {
      get {
        return _resultFile;
      }
      set {
        if (_resultFile == value) {
          return;
        }
        if (_resultFile == null || _resultFile.Equals(value) != true) {
          _resultFile = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
