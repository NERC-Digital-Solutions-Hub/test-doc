
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 03:04, @gisvlasta - Cleaned Xml Serialization Attributes.
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
  [XmlRoot("MD_Distributor", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_Distributor", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_Distributor")]
  public class MD_Distributor : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Distributor"/>.
    /// </summary>
    public MD_Distributor() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _distributorContact = default; // new CI_ResponsibleParty();
      _distributionOrderProcess = default; // new List<MD_StandardOrderProcess>();
      _distributorFormat = default; // new List<MD_Format>();
      _distributorTransferOptions = default; // new List<MD_DigitalTransferOptions>();

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

    private CI_ResponsibleParty _distributorContact;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "distributorContact")]
    [JsonProperty("distributorContact", Order = 0)]
    public CI_ResponsibleParty DistributorContact {
      get {
        return _distributorContact;
      }
      set {
        if (_distributorContact == value) {
          return;
        }
        if (_distributorContact == null || _distributorContact.Equals(value) != true) {
          _distributorContact = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_StandardOrderProcess> _distributionOrderProcess;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("distributionOrderProcess", Order = 1, ElementName = "distributionOrderProcess")]
    [JsonProperty("distributionOrderProcess", Order = 1)]
    public List<MD_StandardOrderProcess> DistributionOrderProcess {
      get {
        return _distributionOrderProcess;
      }
      set {
        if (_distributionOrderProcess == value) {
          return;
        }
        if (_distributionOrderProcess == null || _distributionOrderProcess.Equals(value) != true) {
          _distributionOrderProcess = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_Format> _distributorFormat;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("distributorFormat", Order = 2, ElementName = "distributorFormat")]
    [JsonProperty("distributorFormat", Order = 2)]
    public List<MD_Format> DistributorFormat {
      get {
        return _distributorFormat;
      }
      set {
        if (_distributorFormat == value) {
          return;
        }
        if (_distributorFormat == null || _distributorFormat.Equals(value) != true) {
          _distributorFormat = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_DigitalTransferOptions> _distributorTransferOptions;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("distributorTransferOptions", Order = 3, ElementName = "distributorTransferOptions")]
    [JsonProperty("distributorTransferOptions", Order = 3)]
    public List<MD_DigitalTransferOptions> DistributorTransferOptions {
      get {
        return _distributorTransferOptions;
      }
      set {
        if (_distributorTransferOptions == value) {
          return;
        }
        if (_distributorTransferOptions == null || _distributorTransferOptions.Equals(value) != true) {
          _distributorTransferOptions = value;
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
