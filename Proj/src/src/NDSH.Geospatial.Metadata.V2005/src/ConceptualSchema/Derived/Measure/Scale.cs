
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

using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Derived.UnitsOfMeasure;
using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Primitive.Numerics;
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

namespace NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Derived.Measure {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [DebuggerStepThrough]
  [XmlRoot(Namespace = "", IsNullable = false)]
  [JsonObject("Scale")]
  public class Scale : Model {

    // TODO: Constructor, id, uuid, UoM, Value - SourceUnits, TargetUnits

    #region Constructors - Destructors

    /// <summary>
    /// Initialize the <see cref="Scale"/>.
    /// </summary>
    public Scale() {
      _targetUnits = new UomLength();
      _sourceUnits = new UomLength();
      _uom = new UomScale();
      _value = new Value();
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

    private Value _value; // TODO: IMPORTANT - What about Value???

    /// <summary>
    /// 
    /// </summary>
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "value")]
    [JsonProperty("value", Order = 0)]
    public Value Value {
      get {
        return _value;
      }
      set {
        if (_value == value) {
          return;
        }
        if (_value == null || _value.Equals(value) != true) {
          _value = value;
          OnPropertyChanged();
        }
      }
    }

    private UomScale _uom;

    /// <summary>
    /// 
    /// </summary>
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "uom")]
    [JsonProperty("uom", Order = 1)]
    public UomScale Uom {
      get {
        return _uom;
      }
      set {
        if (_uom == value) {
          return;
        }
        if (_uom == null || _uom.Equals(value) != true) {
          _uom = value;
          OnPropertyChanged();
        }
      }
    }

    private UomLength _sourceUnits;

    /// <summary>
    /// 
    /// </summary>
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "sourceUnits")]
    [JsonProperty("sourceUnits", Order = 2)]
    public UomLength SourceUnits {
      get {
        return _sourceUnits;
      }
      set {
        if (_sourceUnits == value) {
          return;
        }
        if (_sourceUnits == null || _sourceUnits.Equals(value) != true) {
          _sourceUnits = value;
          OnPropertyChanged();
        }
      }
    }

    private UomLength _targetUnits;

    /// <summary>
    /// 
    /// </summary>
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3, ElementName = "targetUnits")]
    [JsonProperty("targetUnits", Order = 3)]
    public UomLength TargetUnits {
      get {
        return _targetUnits;
      }
      set {
        if (_targetUnits == value) {
          return;
        }
        if (_targetUnits == null || _targetUnits.Equals(value) != true) {
          _targetUnits = value;
          OnPropertyChanged();
        }
      }
    }

    private string _id;

    /// <summary>
    /// 
    /// </summary>
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
