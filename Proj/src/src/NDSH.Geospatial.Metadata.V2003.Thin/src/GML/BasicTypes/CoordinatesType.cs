
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/01/2023, 02:08, @gisvlasta.
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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.BasicTypes {

  /// <summary>
  /// This type is deprecated for tuples with ordinate values that are numbers.
  /// CoordinatesType is a text string, intended to be used to record an array of tuples or coordinates.
  /// While it is not possible to enforce the internal structure of the string through schema validation, some optional attributes have been provided in previous versions of GML to support a description of the internal structure. These attributes are deprecated. The attributes were intended to be used as follows:
  /// Decimal	symbol used for a decimal point (default=”.” a stop or period)
  /// cs        	symbol used to separate components within a tuple or coordinate string (default=”,” a comma)
  /// ts        	symbol used to separate tuples or coordinate strings (default=” “ a space)
  /// Since it is based on the XML Schema string type, CoordinatesType may be used in the construction of tables of tuples or arrays of tuples, including ones that contain mixed text and numeric values.
  /// </summary>
  [Serializable]
  [XmlType("CoordinatesType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CoordinatesType")]
  public class CoordinatesType : Model {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CoordinatesType"/>.
    /// </summary>
    public CoordinatesType() {
      _decimal  = default; //  ".";
      _cs  = default; //  ",";
      _ts  = default; //  " ";
    }

    #endregion

    #region Public Properties

    private string _decimal;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("decimal")]
    [DefaultValue(".")]
    [JsonProperty("decimal")]
    public string Decimal {
      get {
        return _decimal;
      }
      set {
        if (_decimal == value) {
          return;
        }
        if (_decimal == null || _decimal.Equals(value) != true) {
          _decimal = value;
          OnPropertyChanged();
        }
      }
    }

    private string _cs;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("cs")]
    [DefaultValue(",")]
    [JsonProperty("cs")]
    public string CS {
      get {
        return _cs;
      }
      set {
        if (_cs == value) {
          return;
        }
        if (_cs == null || _cs.Equals(value) != true) {
          _cs = value;
          OnPropertyChanged();
        }
      }
    }

    private string _ts;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("ts")]
    [DefaultValue(" ")]
    [JsonProperty("ts")]
    public string TS {
      get {
        return _ts;
      }
      set {
        if (_ts == value) {
          return;
        }
        if (_ts == null || _ts.Equals(value) != true) {
          _ts = value;
          OnPropertyChanged();
        }
      }
    }

    private string _value;

    /// <summary>
    /// 
    /// </summary>
    [XmlText]
    [JsonProperty("Value")]
    public string Value {
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

    #endregion

  }

}