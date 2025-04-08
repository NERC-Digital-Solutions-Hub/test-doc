
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
  [JsonObject("AngularVelocity")]
  public class AngularVelocity : Model {

    // TODO: Constructor, id, uuid, UoM, Value - Angle, Time

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AngularVelocity"/>
    /// </summary>
    public AngularVelocity() {
      _uom = new UomVelocity();
      _angle = new UomAngle();
      _time = new UomTime();
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

    private Value _value; // TODO: IMPORTANT - What do we do with Value?

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

    private UomTime _time;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "time")]
    [JsonProperty("time", Order = 1)]
    public UomTime Time {
      get {
        return _time;
      }
      set {
        if (_time == value) {
          return;
        }
        if (_time == null || _time.Equals(value) != true) {
          _time = value;
          OnPropertyChanged();
        }
      }
    }

    private UomAngle _angle;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "angle")]
    [JsonProperty("angle", Order = 2)]
    public UomAngle Angle {
      get {
        return _angle;
      }
      set {
        if (_angle == value) {
          return;
        }
        if (_angle == null || _angle.Equals(value) != true) {
          _angle = value;
          OnPropertyChanged();
        }
      }
    }

    private UomVelocity _uom;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3, ElementName = "uom")]
    [JsonProperty("uom", Order = 3)]
    public UomVelocity Uom {
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
