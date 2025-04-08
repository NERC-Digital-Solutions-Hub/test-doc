
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 26/01/2023, 17:17, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.DateTime;
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
  /// Requirement to be satisfied by the planned data acquisition.
  /// </summary>
  /// <remarks>ShortName: Requirement</remarks>
  [Serializable]
  [XmlType("MI_Requirement", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_Requirement", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_Requirement")]
  public class MI_Requirement_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Requirement_Type"/>.
    /// </summary>
    public MI_Requirement_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _citation = default; // new CI_Citation_PropertyType();
      _identifier = default; // new MD_Identifier_PropertyType();
      _requestor = default; // new List<CI_ResponsibleParty_PropertyType>();
      _recipient = default; // new List<CI_ResponsibleParty_PropertyType?();
      _priority = default; // new MI_PriorityCode_PropertyType();
      _requestedDate = default; // new MI_RequestedDate_PropertyType();
      _expiryDate = default; // new DateTime_PropertyType();
      _satisfiedPlan = default; // new List<MI_Plan_PropertyType>();

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

    private CI_Citation_PropertyType _citation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("citation", Order = 0)]
    [JsonProperty("citation", Order = 0)]
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
    [XmlElement("identifier", Order = 1)]
    [JsonProperty("identifier", Order = 1)]
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

    private List<CI_ResponsibleParty_PropertyType> _requestor;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("requestor", Order = 2)]
    [JsonProperty("requestor", Order = 2)]
    public List<CI_ResponsibleParty_PropertyType> Requestor {
      get {
        return _requestor;
      }
      set {
        if (_requestor == value) {
          return;
        }
        if (_requestor == null || _requestor.Equals(value) != true) {
          _requestor = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CI_ResponsibleParty_PropertyType> _recipient;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("recipient", Order = 3)]
    [JsonProperty("recipient", Order = 3)]
    public List<CI_ResponsibleParty_PropertyType> Recipient {
      get {
        return _recipient;
      }
      set {
        if (_recipient == value) {
          return;
        }
        if (_recipient == null || _recipient.Equals(value) != true) {
          _recipient = value;
          OnPropertyChanged();
        }
      }
    }

    private MI_PriorityCode_PropertyType _priority;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("priority", Order = 4)]
    [JsonProperty("priority", Order = 4)]
    public MI_PriorityCode_PropertyType Priority {
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

    private MI_RequestedDate_PropertyType _requestedDate;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("requestedDate", Order = 5)]
    [JsonProperty("requestedDate", Order = 5)]
    public MI_RequestedDate_PropertyType RequestedDate {
      get {
        return _requestedDate;
      }
      set {
        if (_requestedDate == value) {
          return;
        }
        if (_requestedDate == null || _requestedDate.Equals(value) != true) {
          _requestedDate = value;
          OnPropertyChanged();
        }
      }
    }

    private DateTime_PropertyType _expiryDate;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("expiryDate", Order = 6)]
    [JsonProperty("expiryDate", Order = 6)]
    public DateTime_PropertyType ExpiryDate {
      get {
        return _expiryDate;
      }
      set {
        if (_expiryDate == value) {
          return;
        }
        if (_expiryDate == null || _expiryDate.Equals(value) != true) {
          _expiryDate = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MI_Plan_PropertyType> _satisfiedPlan;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("satisifiedPlan", Order = 7)]
    [JsonProperty("satisifiedPlan", Order = 7)]
    public List<MI_Plan_PropertyType> SatisfiedPlan {
      get {
        return _satisfiedPlan;
      }
      set {
        if (_satisfiedPlan == value) {
          return;
        }
        if (_satisfiedPlan == null || _satisfiedPlan.Equals(value) != true) {
          _satisfiedPlan = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
