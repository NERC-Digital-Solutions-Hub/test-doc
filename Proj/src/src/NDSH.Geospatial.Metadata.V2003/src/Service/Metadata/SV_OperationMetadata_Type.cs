
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 14/01/2023, 22:01, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Service.Metadata {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("SV_OperationMetadata", Namespace = "http://www.isotc211.org/2005/srv")]
  [XmlRoot("SV_OperationMetadata", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [JsonObject("SV_OperationMetadata")]
  public class SV_OperationMetadata_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_OperationMetadata_Type"/>
    /// </summary>
    public SV_OperationMetadata_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("srv", "http://www.isotc211.org/2005/srv");

      _operationName = default; // new CharacterString_PropertyType();
      _DCP = default; // new List<DCPList_PropertyType>();
      _operationDescription = default; // new CharacterString_PropertyType();
      _invocationName = default; // new CharacterString_PropertyType();
      _parameters = default; // new List<SV_Parameter_PropertyType>();"
      _connectPoint = default; // new List<CI_OnlineResource_PropertyType>();
      _dependsOn = default; // new List<SV_OperationMetadata_PropertyType();

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

    private CharacterString_PropertyType _operationName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("operationName", Order = 0)]
    [JsonProperty("operationName", Order = 0)]
    public CharacterString_PropertyType OperationName {
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

    private List<DCPList_PropertyType> _DCP;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DCP", Order = 1)]
    [JsonProperty("DCP", Order = 1)]
    public List<DCPList_PropertyType> DCP {
      get {
        return _DCP;
      }
      set {
        if (_DCP == value) {
          return;
        }
        if (_DCP == null || _DCP.Equals(value) != true) {
          _DCP = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _operationDescription;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("operationDescription", Order = 2)]
    [JsonProperty("operationDescription", Order = 2)]
    public CharacterString_PropertyType OperationDescription {
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

    private CharacterString_PropertyType _invocationName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("invocationName", Order = 3)]
    [JsonProperty("invocationName", Order = 3)]
    public CharacterString_PropertyType InvocationName {
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

    private List<SV_Parameter_PropertyType> _parameters;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("parameters", Order = 4)]
    [JsonProperty("parameters", Order = 4)]
    public List<SV_Parameter_PropertyType> Parameters {
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

    private List<CI_OnlineResource_PropertyType> _connectPoint;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("connectPoint", Order = 5)]
    [JsonProperty("connectPoint", Order = 5)]
    public List<CI_OnlineResource_PropertyType> ConnectPoint {
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

    private List<SV_OperationMetadata_PropertyType> _dependsOn;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("dependsOn", Order = 6)]
    [JsonProperty("dependsOn", Order = 6)]
    public List<SV_OperationMetadata_PropertyType> DependsOn {
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

    #endregion

  }

}
