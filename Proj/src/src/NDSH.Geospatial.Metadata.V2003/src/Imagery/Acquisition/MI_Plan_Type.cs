
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:30, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Common.Citation;
using NDSH.Geospatial.Metadata.V2003.Identification;
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
  /// Designations for the planning information related to meeting requirements.
  /// </summary>
  /// <remarks>ShortName: PlanId</remarks>
  [XmlType("MI_Plan", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_Plan", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_Plan")]
  public class MI_Plan_Type : AbstractObject_Type {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Plan_Type"/>.
    /// </summary>
    public MI_Plan_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _type = default; // new MI_GeometryTypeCode_PropertyType();
      _status = default; // new MD_ProgressCode_PropertyType();
      _citation = default; // new CI_Citation_PropertyType();
      _satisfiedRequirement = default; // new MI_Requirement_PropertyType();
      _operation = default; // new MI_Operation_PropertyType();

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
    
    private MI_GeometryTypeCode_PropertyType _type;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("type", Order = 0)]
    [JsonProperty("type", Order = 0)]
    public MI_GeometryTypeCode_PropertyType Type {
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

    private MD_ProgressCode_PropertyType _status;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("status", Order = 1)]
    [JsonProperty("status", Order = 1)]
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

    private CI_Citation_PropertyType _citation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("citation", Order = 2)]
    [JsonProperty("citation", Order = 2)]
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

    private List<MI_Requirement_PropertyType> _satisfiedRequirement;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("satisfiedRequirement", Order = 3)]
    [JsonProperty("satisfiedRequirement", Order = 3)]
    public List<MI_Requirement_PropertyType> SatisfiedRequirement {
      get {
        return _satisfiedRequirement;
      }
      set {
        if (_satisfiedRequirement == value) {
          return;
        }
        if (_satisfiedRequirement == null || _satisfiedRequirement.Equals(value) != true) {
          _satisfiedRequirement = value;
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

    #endregion

  }

}
