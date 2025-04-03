
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
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Numerics;
using NDSH.Geospatial.Metadata.V2003.Thin.Content;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Content {

  /// <summary>
  /// Extensions to electromagnetic spectrum wavelength description.
  /// </summary>
  /// <remarks>ShortName: BandExt</remarks>
  [Serializable]
  [XmlType("MI_Band", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_Band", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_Band")]
  public class MI_Band_Type : MD_Band_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Band_Type"/>
    /// </summary>
    public MI_Band_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _bandBoundaryDefinition = default; // new MI_BandDefinition_PropertyType();
      _nominalSpatialResolution = default; // new Real_PropertyType();
      _transferFunctionType = default; // new MI_TransferFunctionTypeCode_PropertyType();
      _transmittedPolarisation = default; // new MI_PolarisationOrientationCode_PropertyType();
      _detectedPolarisation = default; // new MI_PolarisationOrientationCode_PropertyType();

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

    private MI_BandDefinition_PropertyType _bandBoundaryDefinition;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("bandBoundaryDefinition", Order = 0)]
    [JsonProperty("bandBoundaryDefinition", Order = 0)]
    public MI_BandDefinition_PropertyType BandBoundaryDefinition {
      get {
        return _bandBoundaryDefinition;
      }
      set {
        if (_bandBoundaryDefinition == value) {
          return;
        }
        if (_bandBoundaryDefinition == null || _bandBoundaryDefinition.Equals(value) != true) {
          _bandBoundaryDefinition = value;
          OnPropertyChanged();
        }
      }
    }
    
    private Real_PropertyType _nominalSpatialResolution;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("nominalSpatialResolution", Order = 1)]
    [JsonProperty("nominalSpatialResolution", Order = 1)]
    public Real_PropertyType NominalSpatialResolution {
      get {
        return _nominalSpatialResolution;
      }
      set {
        if (_nominalSpatialResolution == value) {
          return;
        }
        if (_nominalSpatialResolution == null || _nominalSpatialResolution.Equals(value) != true) {
          _nominalSpatialResolution = value;
          OnPropertyChanged();
        }
      }
    }

    private MI_TransferFunctionTypeCode_PropertyType _transferFunctionType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("transferFunctionType", Order = 2)]
    [JsonProperty("transferFunctionType", Order = 2)]
    public MI_TransferFunctionTypeCode_PropertyType TransferFunctionType {
      get {
        return _transferFunctionType;
      }
      set {
        if (_transferFunctionType == value) {
          return;
        }
        if (_transferFunctionType == null || _transferFunctionType.Equals(value) != true) {
          _transferFunctionType = value;
          OnPropertyChanged();
        }
      }
    }

    private MI_PolarisationOrientationCode_PropertyType _transmittedPolarisation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("transmittedPolarisation", Order = 3)]
    [JsonProperty("transmittedPolarisation", Order = 3)]
    public MI_PolarisationOrientationCode_PropertyType TransmittedPolarisation {
      get {
        return _transmittedPolarisation;
      }
      set {
        if (_transmittedPolarisation == value) {
          return;
        }
        if (_transmittedPolarisation == null || _transmittedPolarisation.Equals(value) != true) {
          _transmittedPolarisation = value;
          OnPropertyChanged();
        }
      }
    }

    private MI_PolarisationOrientationCode_PropertyType _detectedPolarisation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("detectedPolarisation", Order = 4)]
    [JsonProperty("detectedPolarisation", Order = 4)]
    public MI_PolarisationOrientationCode_PropertyType DetectedPolarisation {
      get {
        return _detectedPolarisation;
      }
      set {
        if (_detectedPolarisation == value) {
          return;
        }
        if (_detectedPolarisation == null || _detectedPolarisation.Equals(value) != true) {
          _detectedPolarisation = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
