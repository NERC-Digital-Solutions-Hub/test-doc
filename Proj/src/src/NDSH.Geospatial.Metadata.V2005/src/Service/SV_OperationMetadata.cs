
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 17/12/2022, 03:47, @gisvlasta - Cleaned Xml Serialization Attributes.
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
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.Service {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("SV_OperationMetadata", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [XmlType("SV_OperationMetadata", Namespace = "http://www.isotc211.org/2005/srv")]
  [JsonObject("SV_OperationMetadata")]
  public class SV_OperationMetadata : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_OperationMetadata"/>.
    /// </summary>
    public SV_OperationMetadata() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("srv", "http://www.isotc211.org/2005/srv");

      _operationName = default;
      _dCP = default; //new List<DCPList>();
      _operationDescription = default;
      _invocationName = default;
      _parameters = default; //new List<string>();
      _connectPoint = default; //new List<CI_OnlineResource>();
      _dependsOn = default; //new List<string>();

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

    private string _operationName;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "operationName")]
    [JsonProperty("operationName", Order = 0)]
    public string OperationName {
      get {
        return _operationName;
      }
      set {
        if (_operationName == value) {
          return;
        }
        if (_operationName == null || _operationName.Equals(value) != true) {
          _operationName = value;
          OnPropertyChanged();
        }
      }
    }

    private List<DCPList> _dCP;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DCP", Order = 1)]
    [JsonProperty(Order = 1)]
    public List<DCPList> DCP {
      get {
        return _dCP;
      }
      set {
        if (_dCP == value) {
          return;
        }
        if (_dCP == null || _dCP.Equals(value) != true) {
          _dCP = value;
          OnPropertyChanged();
        }
      }
    }

    private string _operationDescription;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "operationDescription")]
    [JsonProperty("operationDescription", Order = 2)]
    public string OperationDescription {
      get {
        return _operationDescription;
      }
      set {
        if (_operationDescription == value) {
          return;
        }
        if (_operationDescription == null || _operationDescription.Equals(value) != true) {
          _operationDescription = value;
          OnPropertyChanged();
        }
      }
    }

    private string _invocationName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3, ElementName = "invocationName")]
    [JsonProperty("invocationName", Order = 3)]
    public string InvocationName {
      get {
        return _invocationName;
      }
      set {
        if (_invocationName == value) {
          return;
        }
        if (_invocationName == null || _invocationName.Equals(value) != true) {
          _invocationName = value;
          OnPropertyChanged();
        }
      }
    }

    private List<string> _parameters;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("parameters", Order = 4, ElementName = "parameters")]
    [JsonProperty("parameters", Order = 4)]
    public List<string> Parameters {
      get {
        return _parameters;
      }
      set {
        if (_parameters == value) {
          return;
        }
        if (_parameters == null || _parameters.Equals(value) != true) {
          _parameters = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CI_OnlineResource> _connectPoint;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("connectPoint", Order = 5, ElementName = "connectPoint")]
    [JsonProperty("connectPoint", Order = 5)]
    public List<CI_OnlineResource> ConnectPoint {
      get {
        return _connectPoint;
      }
      set {
        if (_connectPoint == value) {
          return;
        }
        if (_connectPoint == null || _connectPoint.Equals(value) != true) {
          _connectPoint = value;
          OnPropertyChanged();
        }
      }
    }

    private List<string> _dependsOn;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("dependsOn", Order = 6, ElementName = "dependsOn")]
    [JsonProperty("dependsOn", Order = 6)]
    public List<string> DependsOn {
      get {
        return _dependsOn;
      }
      set {
        if (_dependsOn == value) {
          return;
        }
        if (_dependsOn == null || _dependsOn.Equals(value) != true) {
          _dependsOn = value;
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
