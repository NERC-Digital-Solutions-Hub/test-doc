
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 17/12/2022, 03:29, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

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
  [XmlRoot("SV_CoupledResource", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [XmlType("SV_CoupledResource", Namespace = "http://www.isotc211.org/2005/srv")]
  [JsonObject("SV_CoupledResource")]
  public class SV_CoupledResource : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_CoupledResource"/>.
    /// </summary>
    public SV_CoupledResource() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("srv", "http://www.isotc211.org/2005/srv");

      _identifier = default;
      _operationName = default;

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

    private string _identifier;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "identifier")]
    [JsonProperty("identifier", Order = 0)]
    public string Identifier {
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

    private string _operationName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "operationName")]
    [JsonProperty("operationName", Order = 1)]
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
