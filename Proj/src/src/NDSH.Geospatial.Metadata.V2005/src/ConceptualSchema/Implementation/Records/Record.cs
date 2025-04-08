
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

using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Implementation.Records;
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

namespace NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Implementation.Records {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [DebuggerStepThrough]
  [XmlRoot(Namespace = "", IsNullable = false)]
  [JsonObject("Record")]
  public class Record : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="Record"/>.
    /// </summary>
    public Record() {
      _recordType = new List<RecordType>();
      _attribute = new AttributeName();
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

    private AttributeName _attribute;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "attribute")]
    [JsonProperty("attribute", Order = 0)]
    public AttributeName Attribute {
      get {
        return _attribute;
      }
      set {
        if (_attribute == value) {
          return;
        }
        if (_attribute == null || _attribute.Equals(value) != true) {
          _attribute = value;
          OnPropertyChanged();
        }
      }
    }

    private List<RecordType> _recordType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("recordType", Order = 1, ElementName = "recordType")]
    [JsonProperty("recordType", Order = 1)]
    public List<RecordType> RecordType {
      get {
        return _recordType;
      }
      set {
        if (_recordType == value) {
          return;
        }
        if (_recordType == null || _recordType.Equals(value) != true) {
          _recordType = value;
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
