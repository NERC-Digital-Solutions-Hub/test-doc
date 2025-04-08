
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:20, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.DateTime;
using NDSH.Geospatial.Metadata.V2003.ReferenceSystem;
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
  /// Identification of a significant collection point within an operation.
  /// </summary>
  /// <remarks>
  /// ShortName: Event
  /// </remarks>
  [XmlType("MI_Event", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_Event", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_Event")]
  public class MI_Event_Type : AbstractObject_Type {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Event_Type"/>.
    /// </summary>
    public MI_Event_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _identifier = default; // new MD_Identifier_PropertyType();
      _trigger = default; // new MI_TriggerCode_PropertyType();
      _context = default; // new MI_ContextCode_PropertyType();
      _sequence = default; // new MI_SequenceCode_PropertyType();
      _time = default; // new DateTime_PropertyType();
      _expectedObjective = default; // new MI_Objective_PropertyType();
      _relatedSensor = default; // new MI_Instrument_PropertyType();
      _relatedPass = default; // new MI_PlatformPass_PropertyType();

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
    
    private MD_Identifier_PropertyType _identifier;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("identifier", Order = 0)]
    [JsonProperty("identifier", Order = 0)]
    public MD_Identifier_PropertyType Identifier {
      get {
        return _identifier;
      }
      set {
        if (_identifier == value) {
          return;
        }
        if (_identifier == null || _identifier.Equals(value) != true) {
          _identifier = value;
          OnPropertyChanged();
        }
      }
    }

    private MI_TriggerCode_PropertyType _trigger;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("trigger", Order = 1)]
    [JsonProperty("trigger", Order = 1)]
    public MI_TriggerCode_PropertyType Trigger {
      get {
        return _trigger;
      }
      set {
        if (_trigger == value) {
          return;
        }
        if (_trigger == null || _trigger.Equals(value) != true) {
          _trigger = value;
          OnPropertyChanged();
        }
      }
    }

    private MI_ContextCode_PropertyType _context;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("context", Order = 2)]
    [JsonProperty("context", Order = 2)]
    public MI_ContextCode_PropertyType Context {
      get {
        return _context;
      }
      set {
        if (_context == value) {
          return;
        }
        if (_context == null || _context.Equals(value) != true) {
          _context = value;
          OnPropertyChanged();
        }
      }
    }

    private MI_SequenceCode_PropertyType _sequence;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("sequence", Order = 3)]
    [JsonProperty("sequence", Order = 3)]
    public MI_SequenceCode_PropertyType Sequence {
      get {
        return _sequence;
      }
      set {
        if (_sequence == value) {
          return;
        }
        if (_sequence == null || _sequence.Equals(value) != true) {
          _sequence = value;
          OnPropertyChanged();
        }
      }
    }

    private DateTime_PropertyType _time;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("time", Order = 4)]
    [JsonProperty("time", Order = 4)]
    public DateTime_PropertyType Time {
      get {
        return _time;
      }
      set {
        if (_time == value) {
          return;
        }
        if (_time == null || _time.Equals(value) != true) {
          _time = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MI_Objective_PropertyType> _expectedObjective;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("expectedObjective", Order = 5)]
    [JsonProperty("expectedObjective", Order = 5)]
    public List<MI_Objective_PropertyType> ExpectedObjective {
      get {
        return _expectedObjective;
      }
      set {
        if (_expectedObjective == value) {
          return;
        }
        if (_expectedObjective == null || _expectedObjective.Equals(value) != true) {
          _expectedObjective = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MI_Instrument_PropertyType> _relatedSensor;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("relatedSensor", Order = 6)]
    [JsonProperty("relatedSensor", Order = 6)]
    public List<MI_Instrument_PropertyType> RelatedSensor {
      get {
        return _relatedSensor;
      }
      set {
        if (_relatedSensor == value) {
          return;
        }
        if (_relatedSensor == null || _relatedSensor.Equals(value) != true) {
          _relatedSensor = value;
          OnPropertyChanged();
        }
      }
    }

    private MI_PlatformPass_PropertyType _relatedPass;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("relatedPass", Order = 7)]
    [JsonProperty("relatedPass", Order = 7)]
    public MI_PlatformPass_PropertyType RelatedPass {
      get {
        return _relatedPass;
      }
      set {
        if (_relatedPass == value) {
          return;
        }
        if (_relatedPass == null || _relatedPass.Equals(value) != true) {
          _relatedPass = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
