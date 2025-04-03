
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:18, @gisvlasta.
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
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Imagery.Acquisition {

  /// <summary>
  /// Designations for the measuring instruments and their bands,
  /// the platform carrying them, and the mission to which the data contributes.
  /// </summary>
  /// <remarks>
  /// <para>FGDC: Platform_and_Instrument_Identification, Mission_Information.</para>
  /// <para>ShortName: PltfrmInstId</para>
  /// </remarks>
  [XmlType("MI_AcquisitionInformation", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_AcquisitionInformation", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_AcquisitionInformation")]
  public class MI_AcquisitionInformation_Type : AbstractObject_Type {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_AcquisitionInformation_Type"/>.
    /// </summary>
    public MI_AcquisitionInformation_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _acquisitionRequirement = default; // new MI_Requirement_PropertyType();
      _objective = default; // new MI_Objective_PropertyType();
      _instrument = default; // new MI_Instrument_PropertyType();
      _acquisitionPlan = default; // new MI_Plan_PropertyType();
      _operation = default; // new MI_Operation_PropertyType();
      _platform = default; // new MI_Platform_PropertyType();
      _environmentalConditions = default; // new MI_EnvironmentalRecord_PropertyType();

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
    
    private List<MI_Requirement_PropertyType> _acquisitionRequirement;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("acquisitionRequirement", Order = 0)]
    [JsonProperty("acquisitionRequirement", Order = 0)]
    public List<MI_Requirement_PropertyType> AcquisitionRequirement {
      get {
        return _acquisitionRequirement;
      }
      set {
        if (_acquisitionRequirement == value) {
          return;
        }
        if (_acquisitionRequirement == null || _acquisitionRequirement.Equals(value) != true) {
          _acquisitionRequirement = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MI_Objective_PropertyType> _objective;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("objective", Order = 1)]
    [JsonProperty("objective", Order = 1)]
    public List<MI_Objective_PropertyType> Objective {
      get {
        return _objective;
      }
      set {
        if (_objective == value) {
          return;
        }
        if (_objective == null || _objective.Equals(value) != true) {
          _objective = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MI_Instrument_PropertyType> _instrument;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("instrument", Order = 2)]
    [JsonProperty("instrument", Order = 2)]
    public List<MI_Instrument_PropertyType> Instrument {
      get {
        return _instrument;
      }
      set {
        if (_instrument == value) {
          return;
        }
        if (_instrument == null || _instrument.Equals(value) != true) {
          _instrument = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MI_Plan_PropertyType> _acquisitionPlan;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("acquisitionPlan", Order = 3)]
    [JsonProperty("acquisitionPlan", Order = 3)]
    public List<MI_Plan_PropertyType> AcquisitionPlan {
      get {
        return _acquisitionPlan;
      }
      set {
        if (_acquisitionPlan == value) {
          return;
        }
        if (_acquisitionPlan == null || _acquisitionPlan.Equals(value) != true) {
          _acquisitionPlan = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MI_Operation_PropertyType> _operation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("operation", Order = 4)]
    [JsonProperty("operation", Order = 4)]
    public List<MI_Operation_PropertyType> Operation {
      get {
        return _operation;
      }
      set {
        if (_operation == value) {
          return;
        }
        if (_operation == null || _operation.Equals(value) != true) {
          _operation = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MI_Platform_PropertyType> _platform;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("platform", Order = 5)]
    [JsonProperty("platform", Order = 5)]
    public List<MI_Platform_PropertyType> Platform {
      get {
        return _platform;
      }
      set {
        if (_platform == value) {
          return;
        }
        if (_platform == null || _platform.Equals(value) != true) {
          _platform = value;
          OnPropertyChanged();
        }
      }
    }

    private MI_EnvironmentalRecord_PropertyType _environmentalConditions;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("environmentalConditions", Order = 6)]
    [JsonProperty("environmentalConditions", Order = 6)]
    public MI_EnvironmentalRecord_PropertyType EnvironmentalConditions {
      get {
        return _environmentalConditions;
      }
      set {
        if (_environmentalConditions == value) {
          return;
        }
        if (_environmentalConditions == null || _environmentalConditions.Equals(value) != true) {
          _environmentalConditions = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
