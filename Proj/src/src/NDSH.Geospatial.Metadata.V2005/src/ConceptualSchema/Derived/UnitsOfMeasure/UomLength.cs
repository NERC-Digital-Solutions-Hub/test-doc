
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

namespace NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Derived.UnitsOfMeasure {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [DebuggerStepThrough]
  [XmlRoot(Namespace = "", IsNullable = false)]
  [JsonObject("UomLength")]
  public class UomLength : Model {

    // TODO: NO Constructor, id, uuid, UomName, ConversionToISOstandarUnit

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private string _uomName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "uomName")]
    [JsonProperty("uomName", Order = 0)]
    public string UomName {
      get {
        return _uomName;
      }
      set {
        if (_uomName == value) {
          return;
        }
        if (_uomName == null || _uomName.Equals(value) != true) {
          _uomName = value;
          OnPropertyChanged();
        }
      }
    }

    private string _conversionToISOstandarUnit;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "conversionToISOstandarUnit")]
    [JsonProperty("conversionToISOstandarUnit", Order = 1)]
    public string ConversionToISOstandarUnit {
      get {
        return _conversionToISOstandarUnit;
      }
      set {
        if (_conversionToISOstandarUnit == value) {
          return;
        }
        if (_conversionToISOstandarUnit == null || _conversionToISOstandarUnit.Equals(value) != true) {
          _conversionToISOstandarUnit = value;
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
