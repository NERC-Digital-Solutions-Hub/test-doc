
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
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

namespace NDSH.Geospatial.Metadata.V2005.Service.Model {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [DebuggerStepThrough]
  [XmlRoot(Namespace = "", IsNullable = false)]
  [JsonObject("SV_OperationSpecification")]
  public class SV_OperationSpecification : EntityBase<SV_OperationSpecification> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_OperationSpecification"/>.
    /// </summary>
    public SV_OperationSpecification() {
      _parameter = new List<SV_Parameter>();
    }

    #endregion

    #region Private fields

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

    private string _operationDescription;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "operationDescription")]
    [JsonProperty("operationDescription", Order = 1)]
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
    [XmlElement(Order = 2, ElementName = "invocationName")]
    [JsonProperty("invocationName", Order = 2)]
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

    private List<SV_Parameter> _parameter;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("parameter", Order = 3, ElementName = "parameter")]
    [JsonProperty("parameter", Order = 3)]
    public List<SV_Parameter> Parameter {
      get {
        return _parameter;
      }
      set {
        if (_parameter == value) {
          return;
        }
        if (_parameter == null || _parameter.Equals(value) != true) {
          _parameter = value;
          OnPropertyChanged();
        }
      }
    }

    // TODO: MISSING id and uuid properties???

    #endregion

  }

}
