
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:25, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Common.Extent;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text;
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
  /// Describes the characteristics, spatial and temporal extent
  /// of the intended object to be observed.
  /// </summary>
  /// <remarks>ShortName: TargetId</remarks>
  [XmlType("MI_Objective", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_Objective", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_Objective")]
  public class MI_Objective_Type : AbstractObject_Type {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Objective_Type"/>.
    /// </summary>
    public MI_Objective_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _identifier = default; // new MD_Identifier_PropertyType();
      _priority = default; // new CharacterString_PropertyType();
      _type = default; // new MI_ObjectiveTypeCode_PropertyType();
      _function = default; // new CharacterString_PropertyType();
      _extent = default; // new EX_Extent_PropertyType();
      _pass = default; // new MI_PlatformPass_PropertyType();
      _sensingInstrument = default; // new MI_Instrument_PropertyType();
      _objectiveOccurrence = default; // new MI_Event_PropertyType();

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
    
    private List<MD_Identifier_PropertyType> _identifier;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("identifier", Order = 0)]
    [JsonProperty("identifier", Order = 0)]
    public List<MD_Identifier_PropertyType> Identifier {
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

    private CharacterString_PropertyType _priority;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("priority", Order = 1)]
    [JsonProperty("priority", Order = 1)]
    public CharacterString_PropertyType Priority {
      get {
        return _priority;
      }
      set {
        if (_priority == value) {
          return;
        }
        if (_priority == null || _priority.Equals(value) != true) {
          _priority = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MI_ObjectiveTypeCode_PropertyType> _type;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("type", Order = 2)]
    [JsonProperty("type", Order = 2)]
    public List<MI_ObjectiveTypeCode_PropertyType> Type {
      get {
        return _type;
      }
      set {
        if (_type == value) {
          return;
        }
        if (_type == null || _type.Equals(value) != true) {
          _type = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CharacterString_PropertyType> _function;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("function", Order = 3)]
    [JsonProperty("function", Order = 3)]
    public List<CharacterString_PropertyType> Function {
      get {
        return _function;
      }
      set {
        if (_function == value) {
          return;
        }
        if (_function == null || _function.Equals(value) != true) {
          _function = value;
          OnPropertyChanged();
        }
      }
    }

    private List<EX_Extent_PropertyType> _extent;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("extent", Order = 4)]
    [JsonProperty("extent", Order = 4)]
    public List<EX_Extent_PropertyType> Extent {
      get {
        return _extent;
      }
      set {
        if (_extent == value) {
          return;
        }
        if (_extent == null || _extent.Equals(value) != true) {
          _extent = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MI_PlatformPass_PropertyType> _pass;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("pass", Order = 5)]
    [JsonProperty("pass", Order = 5)]
    public List<MI_PlatformPass_PropertyType> Pass {
      get {
        return _pass;
      }
      set {
        if (_pass == value) {
          return;
        }
        if (_pass == null || _pass.Equals(value) != true) {
          _pass = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MI_Instrument_PropertyType> _sensingInstrument;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("sensingInstrument", Order = 6)]
    [JsonProperty("sensingInstrument", Order = 6)]
    public List<MI_Instrument_PropertyType> SensingInstrument {
      get {
        return _sensingInstrument;
      }
      set {
        if (_sensingInstrument == value) {
          return;
        }
        if (_sensingInstrument == null || _sensingInstrument.Equals(value) != true) {
          _sensingInstrument = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MI_Event_PropertyType> _objectiveOccurrence;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("objectiveOccurrence", Order = 7)]
    [JsonProperty("objectiveOccurrence", Order = 7)]
    public List<MI_Event_PropertyType> ObjectiveOccurrence {
      get {
        return _objectiveOccurrence;
      }
      set {
        if (_objectiveOccurrence == value) {
          return;
        }
        if (_objectiveOccurrence == null || _objectiveOccurrence.Equals(value) != true) {
          _objectiveOccurrence = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
