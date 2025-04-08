
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:28, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Thin.Common.Citation;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
using NDSH.Geospatial.Metadata.V2003.Thin.Identification;
using NDSH.Geospatial.Metadata.V2003.Thin.ReferenceSystem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Acquisition {

  /// <summary>
  /// Designations for the operation used to acquire the dataset.
  /// </summary>
  /// <remarks>ShortName: MssnId</remarks>
  [XmlType("MI_Operation", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_Operation", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_Operation")]
  public class MI_Operation_Type : AbstractObject_Type {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Operation_Type"/>.
    /// </summary>
    public MI_Operation_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _description = default; // new CharacterString_PropertyType();
      _citation = default; // new CI_Citation_PropertyType();
      _identifier = default; // new MD_Identifier_PropertyType();
      _status = default; // new MD_ProgressCode_PropertyType();
      _type = default; // new MI_OperationTypeCode_PropertyType();
      _objective = default; // new MI_Objective_PropertyType();
      _plan = default; // new MI_Plan_PropertyType();
      _childOperation = default; // new MI_Operation_PropertyType();
      _significantEvent = default; // new MI_Event_PropertyType();
      _platform = default; // new MI_Platform_PropertyType();

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
    
    private CharacterString _description;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("description", Order = 0)]
    [JsonProperty("description", Order = 0)]
    public CharacterString Description {
      get {
        return _description;
      }
      set {
        if (_description == value) {
          return;
        }
        if (_description == null || _description.Equals(value) != true) {
          _description = value;
          OnPropertyChanged();
        }
      }
    }

    private CI_Citation_PropertyType _citation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("citation", Order = 1)]
    [JsonProperty("citation", Order = 1)]
    public CI_Citation_PropertyType Citation {
      get {
        return _citation;
      }
      set {
        if (_citation == value) {
          return;
        }
        if (_citation == null || _citation.Equals(value) != true) {
          _citation = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_Identifier_PropertyType _identifier;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("identifier", Order = 2)]
    [JsonProperty("identifier", Order = 2)]
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

    private MD_ProgressCode_PropertyType _status;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("status", Order = 3)]
    [JsonProperty("status", Order = 3)]
    public MD_ProgressCode_PropertyType Status {
      get {
        return _status;
      }
      set {
        if (_status == value) {
          return;
        }
        if (_status == null || _status.Equals(value) != true) {
          _status = value;
          OnPropertyChanged();
        }
      }
    }

    private MI_OperationTypeCode_PropertyType _type;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("type", Order = 4)]
    [JsonProperty("type", Order = 4)]
    public MI_OperationTypeCode_PropertyType Type {
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

    private List<MI_Objective_PropertyType> _objective;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("objective", Order = 5)]
    [JsonProperty("objective", Order = 5)]
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

    private MI_Plan_PropertyType _plan;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("plan", Order = 6)]
    [JsonProperty("plan", Order = 6)]
    public MI_Plan_PropertyType Plan {
      get {
        return _plan;
      }
      set {
        if (_plan == value) {
          return;
        }
        if (_plan == null || _plan.Equals(value) != true) {
          _plan = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MI_Operation_PropertyType> _childOperation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("childOperation", Order = 7)]
    [JsonProperty("childOperation", Order = 7)]
    public List<MI_Operation_PropertyType> ChildOperation {
      get {
        return _childOperation;
      }
      set {
        if (_childOperation == value) {
          return;
        }
        if (_childOperation == null || _childOperation.Equals(value) != true) {
          _childOperation = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MI_Event_PropertyType> _significantEvent;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("significantEvent", Order = 8)]
    [JsonProperty("significantEvent", Order = 8)]
    public List<MI_Event_PropertyType> SignificantEvent {
      get {
        return _significantEvent;
      }
      set {
        if (_significantEvent == value) {
          return;
        }
        if (_significantEvent == null || _significantEvent.Equals(value) != true) {
          _significantEvent = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MI_Platform_PropertyType> _platform;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("platform", Order = 9)]
    [JsonProperty("platform", Order = 9)]
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

    #endregion

  }

}
