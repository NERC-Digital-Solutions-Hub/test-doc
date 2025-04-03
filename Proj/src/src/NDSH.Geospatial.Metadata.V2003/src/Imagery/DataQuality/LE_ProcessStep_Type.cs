
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        :  27/01/2023, 01:39, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.DataQuality.Lineage;
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
  /// Information about an event or transformation in the life of the dataset
  /// including details of the algorithm and software used for processing.
  /// </summary>
  /// <remarks>ShortName: DetailProcStep</remarks>
  [Serializable]
  [XmlType("LE_ProcessStep", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("LE_ProcessStep", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("LE_ProcessStep")]
  public class LE_ProcessStep_Type : LI_ProcessStep_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LE_ProcessStep_Type"/>
    /// </summary>
    public LE_ProcessStep_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _output = default; // new List<LE_Source_PropertyType>();
      _report = default; // new List<LE_ProcessStepReport_PropertyType>();
      _processingInformation = default; // new LE_Processing_PropertyType();

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

    private List<LE_Source_PropertyType> _output;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("output", Order = 0)]
    [JsonProperty("output", Order = 0)]
    public List<LE_Source_PropertyType> Output {
      get {
        return _output;
      }
      set {
        if (_output == value) {
          return;
        }
        if (_output == null || _output.Equals(value) != true) {
          _output = value;
          OnPropertyChanged();
        }
      }
    }

    private List<LE_ProcessStepReport_PropertyType> _report;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("report", Order = 1)]
    [JsonProperty("report", Order = 1)]
    public List<LE_ProcessStepReport_PropertyType> Report {
      get {
        return _report;
      }
      set {
        if (_report == value) {
          return;
        }
        if (_report == null || _report.Equals(value) != true) {
          _report = value;
          OnPropertyChanged();
        }
      }
    }

    private LE_Processing_PropertyType _processingInformation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("processingInformation", Order = 2)]
    [JsonProperty("processingInformation", Order = 2)]
    public LE_Processing_PropertyType ProcessingInformation {
      get {
        return _processingInformation;
      }
      set {
        if (_processingInformation == value) {
          return;
        }
        if (_processingInformation == null || _processingInformation.Equals(value) != true) {
          _processingInformation = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
