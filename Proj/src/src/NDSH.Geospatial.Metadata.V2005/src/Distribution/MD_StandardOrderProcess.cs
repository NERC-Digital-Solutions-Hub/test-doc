
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 03:13, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.Common.Citation;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.Distribution {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("MD_StandardOrderProcess", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_StandardOrderProcess", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_StandardOrderProcess")]
  public class MD_StandardOrderProcess : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_StandardOrderProcess"/>.
    /// </summary>
    public MD_StandardOrderProcess() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _fees = default;
      _plannedAvailableDateTime = default;
      _orderingInstructions = default;
      _turnaround = default;

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

    private string _fees;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "fees")]
    [JsonProperty("fees", Order = 0)]
    public string Fees {
      get {
        return _fees;
      }
      set {
        if (_fees == value) {
          return;
        }
        if (_fees == null || _fees.Equals(value) != true) {
          _fees = value;
          OnPropertyChanged();
        }
      }
    }

    private DateTime _plannedAvailableDateTime;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "plannedAvailableDateTime")]
    [RequiredAttribute()]
    [JsonProperty("plannedAvailableDateTime", Order = 1)]
    public DateTime PlannedAvailableDateTime { // TODO: DateTime???
      get {
        return _plannedAvailableDateTime;
      }
      set {
        if (_plannedAvailableDateTime.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "PlannedAvailableDateTime";
          Validator.ValidateProperty(value, validatorPropContext);
          _plannedAvailableDateTime = value;
          OnPropertyChanged();
        }
      }
    }

    private string _orderingInstructions;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "orderingInstructions")]
    [JsonProperty("orderingInstructions", Order = 2)]
    public string OrderingInstructions {
      get {
        return _orderingInstructions;
      }
      set {
        if (_orderingInstructions == value) {
          return;
        }
        if (_orderingInstructions == null || _orderingInstructions.Equals(value) != true) {
          _orderingInstructions = value;
          OnPropertyChanged();
        }
      }
    }

    private string _turnaround;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3, ElementName = "turnaround")]
    [JsonProperty("turnaround", Order = 3)]
    public string Turnaround {
      get {
        return _turnaround;
      }
      set {
        if (_turnaround == value) {
          return;
        }
        if (_turnaround == null || _turnaround.Equals(value) != true) {
          _turnaround = value;
          OnPropertyChanged();
        }
      }
    }

    private string _id;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(DataType = "ID", AttributeName = "id")]
    [XmlIgnore()]
    [JsonProperty("id")]
    public string Id {
      get {
        return _id;
      }
      set {
        if (_id == value) {
          return;
        }
        if (_id == null || _id.Equals(value) != true) {
          _id = value;
          OnPropertyChanged();
        }
      }
    }

    private string _uuid;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "uuid")]
    [XmlIgnore()]
    [JsonProperty("uuid")]
    public string Uuid {
      get {
        return _uuid;
      }
      set {
        if (_uuid == value) {
          return;
        }
        if (_uuid == null || _uuid.Equals(value) != true) {
          _uuid = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
