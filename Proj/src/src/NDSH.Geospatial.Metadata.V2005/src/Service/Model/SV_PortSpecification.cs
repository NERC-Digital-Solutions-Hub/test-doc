
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
  [JsonObject("SV_PortSpecification")]
  public class SV_PortSpecification : EntityBase<SV_PortSpecification> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_PortSpecification"/>.
    /// </summary>
    public SV_PortSpecification() {
      _binding = new DCPList();
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

    private DCPList _binding;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "binding")]
    [JsonProperty("binding", Order = 0)]
    public DCPList Binding {
      get {
        return _binding;
      }
      set {
        if (_binding == value) {
          return;
        }
        if (_binding == null || _binding.Equals(value) != true) {
          _binding = value;
          OnPropertyChanged();
        }
      }
    }

    private string _address;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    [JsonProperty(Order = 1)]
    public string Address {
      get {
        return _address;
      }
      set {
        if (_address == value) {
          return;
        }
        if (_address == null || _address.Equals(value) != true) {
          _address = value;
          OnPropertyChanged();
        }
      }
    }

    private string _id;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(DataType = "ID", AttributeName = "id")]
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
