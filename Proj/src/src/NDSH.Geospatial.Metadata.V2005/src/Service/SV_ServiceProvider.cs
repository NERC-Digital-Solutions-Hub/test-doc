
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 17/12/2022, 03:56, @gisvlasta - Cleaned Xml Serialization Attributes.
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

namespace NDSH.Geospatial.Metadata.V2005.Service {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("SV_ServiceProvider", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [XmlType("SV_ServiceProvider", Namespace = "http://www.isotc211.org/2005/srv")]
  [JsonObject("SV_ServiceProvider")]
  public class SV_ServiceProvider : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_ServiceProvider"/>.
    /// </summary>
    public SV_ServiceProvider() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("srv", "http://www.isotc211.org/2005/srv");

      _serviceContact = default; //new CI_ResponsibleParty();
      _providerName = default;
      _services = default; //new List<SV_ServiceIdentification>();

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

    private CI_ResponsibleParty _serviceContact;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "serviceContact")]
    [JsonProperty("serviceContact", Order = 0)]
    public CI_ResponsibleParty ServiceContact {
      get {
        return _serviceContact;
      }
      set {
        if (_serviceContact == value) {
          return;
        }
        if (_serviceContact == null || _serviceContact.Equals(value) != true) {
          _serviceContact = value;
          OnPropertyChanged();
        }
      }
    }

    private string _providerName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "providerName")]
    [JsonProperty("providerName", Order = 1)]
    public string ProviderName {
      get {
        return _providerName;
      }
      set {
        if (_providerName == value) {
          return;
        }
        if (_providerName == null || _providerName.Equals(value) != true) {
          _providerName = value;
          OnPropertyChanged();
        }
      }
    }

    private List<SV_ServiceIdentification> _services;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("services", Order = 2, ElementName = "services")]
    [JsonProperty("services", Order = 2)]
    public List<SV_ServiceIdentification> Services {
      get {
        return _services;
      }
      set {
        if (_services == value) {
          return;
        }
        if (_services == null || _services.Equals(value) != true) {
          _services = value;
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
