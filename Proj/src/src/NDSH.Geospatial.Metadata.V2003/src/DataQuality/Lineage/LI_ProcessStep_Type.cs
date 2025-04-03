
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 17:07, @gisvlasta.
// Updated by        : 09/01/2023, 18:51, @gisvlasta. - 1.0.1: Added xmlns field.
//                     08/02/2023, 01:20, @gisvlasta. - 1.0.2: Added [XmlInclude]s.
// Version           : 1.0.2
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common.Citation;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.DateTime;
using NDSH.Geospatial.Metadata.V2003.Imagery.DataQuality;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.DataQuality.Lineage {

  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(LE_ProcessStep_Type))]
  [Serializable]
  [XmlType("LI_ProcessStep", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("LI_ProcessStep", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("LI_ProcessStep")]
  public class LI_ProcessStep_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LI_ProcessStep_Type"/>.
    /// </summary>
    public LI_ProcessStep_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _description  = default; //  new CharacterString_PropertyType();
      _rationale  = default; //  new CharacterString_PropertyType();
      _dateTime  = default; //  new DateTime_PropertyType();
      _processor  = default; //  new List<CI_ResponsibleParty_PropertyType>();
      _source  = default; //  new List<LI_Source_PropertyType>();

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

    private CharacterString_PropertyType _description;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("description", Order = 0)]
    [JsonProperty("description", Order = 0)]
    public CharacterString_PropertyType Description {
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

    private CharacterString_PropertyType _rationale;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("rationale", Order = 1)]
    [JsonProperty("rationale", Order = 1)]
    public CharacterString_PropertyType Rationale {
      get {
        return _rationale;
      }
      set {
        if (_rationale == value) {
          return;
        }
        if (_rationale == null || _rationale.Equals(value) != true) {
          _rationale = value;
          OnPropertyChanged();
        }
      }
    }

    private DateTime_PropertyType _dateTime;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("dateTime", Order = 2)]
    [JsonProperty("dateTime", Order = 2)]
    public DateTime_PropertyType DateTime {
      get {
        return _dateTime;
      }
      set {
        if (_dateTime == value) {
          return;
        }
        if (_dateTime == null || _dateTime.Equals(value) != true) {
          _dateTime = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CI_ResponsibleParty_PropertyType> _processor;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("processor", Order = 3)]
    [JsonProperty("processor", Order = 3)]
    public List<CI_ResponsibleParty_PropertyType> Processor {
      get {
        return _processor;
      }
      set {
        if (_processor == value) {
          return;
        }
        if (_processor == null || _processor.Equals(value) != true) {
          _processor = value;
          OnPropertyChanged();
        }
      }
    }

    private List<LI_Source_PropertyType> _source;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("source", Order = 4)]
    [JsonProperty("source", Order = 4)]
    public List<LI_Source_PropertyType> Source {
      get {
        return _source;
      }
      set {
        if (_source == value) {
          return;
        }
        if (_source == null || _source.Equals(value) != true) {
          _source = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}