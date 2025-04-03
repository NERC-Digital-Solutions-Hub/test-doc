
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 03:02, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005;
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
  [XmlRoot("MD_Distribution", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_Distribution", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_Distribution")]
  public class MD_Distribution : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Distribution"/>.
    /// </summary>
    public MD_Distribution() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _distributionFormat = default; //new List<MD_Format>();
      _transferOptions = default; //new List<MD_DigitalTransferOptions>();
      _distributor = default; //new List<MD_Distributor>();

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

    private List<MD_Format> _distributionFormat;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("distributionFormat", Order = 0, ElementName = "distributionFormat")]
    [JsonProperty("distributionFormat", Order = 0)]
    public List<MD_Format> DistributionFormat {
      get {
        return _distributionFormat;
      }
      set {
        if (_distributionFormat == value) {
          return;
        }
        if (_distributionFormat == null || _distributionFormat.Equals(value) != true) {
          _distributionFormat = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_DigitalTransferOptions> _transferOptions;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("transferOptions", Order = 1, ElementName = "transferOptions")]
    [JsonProperty("transferOptions", Order = 1)]
    public List<MD_DigitalTransferOptions> TransferOptions {
      get {
        return _transferOptions;
      }
      set {
        if (_transferOptions == value) {
          return;
        }
        if (_transferOptions == null || _transferOptions.Equals(value) != true) {
          _transferOptions = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_Distributor> _distributor;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("distributor", Order = 2, ElementName = "distributor")]
    [JsonProperty("distributor", Order = 2)]
    public List<MD_Distributor> Distributor {
      get {
        return _distributor;
      }
      set {
        if (_distributor == value) {
          return;
        }
        if (_distributor == null || _distributor.Equals(value) != true) {
          _distributor = value;
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
