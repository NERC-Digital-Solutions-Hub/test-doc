
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 02:58, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005;
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
  [XmlRoot("MD_DigitalTransferOptions", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_DigitalTransferOptions", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_DigitalTransferOptions")]
  public class MD_DigitalTransferOptions : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_DigitalTransferOptions"/>.
    /// </summary>
    public MD_DigitalTransferOptions() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _unitsOfDistribution = default;
      _transferSize = default;
      _onLine = default; // new List<CI_OnlineResource>();
      _offline = default; // new MD_Medium();

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

    private string _unitsOfDistribution;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "unitsOfDistribution")]
    [JsonProperty("unitsOfDistribution", Order = 0)]
    public string UnitsOfDistribution {
      get {
        return _unitsOfDistribution;
      }
      set {
        if (_unitsOfDistribution == value) {
          return;
        }
        if (_unitsOfDistribution == null || _unitsOfDistribution.Equals(value) != true) {
          _unitsOfDistribution = value;
          OnPropertyChanged();
        }
      }
    }

    private double _transferSize;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "transferSize")]
    [RequiredAttribute()]
    [JsonProperty("transferSize", Order = 1)]
    public double TransferSize {
      get {
        return _transferSize;
      }
      set {
        if (_transferSize.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "TransferSize";
          Validator.ValidateProperty(value, validatorPropContext);
          _transferSize = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CI_OnlineResource> _onLine;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("onLine", Order = 2, ElementName = "onLine")]
    [JsonProperty("onLine", Order = 2)]
    public List<CI_OnlineResource> OnLine {
      get {
        return _onLine;
      }
      set {
        if (_onLine == value) {
          return;
        }
        if (_onLine == null || _onLine.Equals(value) != true) {
          _onLine = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_Medium _offline;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3, ElementName = "offline")]
    [JsonProperty("offline", Order = 3)]
    public MD_Medium Offline {
      get {
        return _offline;
      }
      set {
        if (_offline == value) {
          return;
        }
        if (_offline == null || _offline.Equals(value) != true) {
          _offline = value;
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
