
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

namespace NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Implementation.Names {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [DebuggerStepThrough]
  [XmlRoot(Namespace = "", IsNullable = false)]
  [JsonObject("NameSpace")]
  public class NameSpace : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="NameSpace"/>.
    /// </summary>
    public NameSpace() {
      _isGlobal = new Boolean();
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

    private Boolean _isGlobal;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "isGlobal")]
    [JsonProperty("isGlobal", Order = 0)]
    public Boolean IsGlobal {
      get {
        return _isGlobal;
      }
      set {
        if (_isGlobal == value) {
          return;
        }
        // TODO: CS0472 Boolean Nullability
        if (_isGlobal == null || _isGlobal.Equals(value) != true) {
          _isGlobal = value;
          OnPropertyChanged();
        }
      }
    }

    private string _namespace;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "namespace")]
    [JsonProperty("namespace", Order = 1)]
    public string Namespace {
      get {
        return _namespace;
      }
      set {
        if (_namespace == value) {
          return;
        }
        if (_namespace == null || _namespace.Equals(value) != true) {
          _namespace = value;
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
