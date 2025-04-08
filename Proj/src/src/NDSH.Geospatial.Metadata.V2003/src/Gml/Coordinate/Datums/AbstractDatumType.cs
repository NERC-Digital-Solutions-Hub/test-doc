
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 02/02/2023, 20:42, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces


using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using NDSH.Geospatial.Metadata.V2003.Gml.BasicTypes;
using NDSH.Geospatial.Metadata.V2003.Gml.ReferenceSystems;
using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS.Multilingual;
using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS.Multilingual.Datums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Datums {

  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(DatumAlt_Type))] // GMX
  [XmlInclude(typeof(ML_EngineeringDatum_Type))] // GMX
  [XmlInclude(typeof(ML_GeodeticDatum_Type))] // GMX
  [XmlInclude(typeof(ML_ImageDatum_Type))] // GMX
  [XmlInclude(typeof(ML_TemporalDatum_Type))] // GMX
  [XmlInclude(typeof(ML_VerticalDatum_Type))] // GMX
  [XmlInclude(typeof(TemporalDatumBaseType))]
  [XmlInclude(typeof(TemporalDatumType))]
  [XmlInclude(typeof(VerticalDatumType))]
  [XmlInclude(typeof(ImageDatumType))]
  [XmlInclude(typeof(EngineeringDatumType))]
  [XmlInclude(typeof(GeodeticDatumType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractDatumType")]
  public abstract class AbstractDatumType : IdentifiedObjectType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractDatumType"/>.
    /// </summary>
    public AbstractDatumType() {
      _anchorDefinition = new CodeType();
      _scope = new List<string>();
      _domainOfValidity = new DomainOfValidity();
    }

    #endregion

    #region Public Properties

    private DomainOfValidity _domainOfValidity;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("domainOfValidity", Order = 0)]
    [JsonProperty("domainOfValidity", Order = 0)]
    public DomainOfValidity DomainOfValidity {
      get {
        return _domainOfValidity;
      }
      set {
        if (_domainOfValidity == value) {
          return;
        }
        if (_domainOfValidity == null || _domainOfValidity.Equals(value) != true) {
          _domainOfValidity = value;
          OnPropertyChanged();
        }
      }
    }

    private List<string> _scope;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("scope", Order = 1)]
    [JsonProperty("scope", Order = 1)]
    public List<string> Scope {
      get {
        return _scope;
      }
      set {
        if (_scope == value) {
          return;
        }
        if (_scope == null || _scope.Equals(value) != true) {
          _scope = value;
          OnPropertyChanged();
        }
      }
    }

    private CodeType _anchorDefinition;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("anchorDefinition", Order = 2)]
    [JsonProperty("anchorDefinition", Order = 2)]
    public CodeType AnchorDefinition {
      get {
        return _anchorDefinition;
      }
      set {
        if (_anchorDefinition == value) {
          return;
        }
        if (_anchorDefinition == null || _anchorDefinition.Equals(value) != true) {
          _anchorDefinition = value;
          OnPropertyChanged();
        }
      }
    }

    private DateTime _realizationEpoch;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("realizationEpoch", DataType = "date", Order = 3)]
    [JsonProperty("realizationEpoch", Order = 3)]
    public DateTime RealizationEpoch {
      get {
        return _realizationEpoch;
      }
      set {
        if (_realizationEpoch.Equals(value) != true) {
          _realizationEpoch = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
