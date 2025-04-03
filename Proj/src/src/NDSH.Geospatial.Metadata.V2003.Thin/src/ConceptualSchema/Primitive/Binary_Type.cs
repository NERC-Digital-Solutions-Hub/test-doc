﻿
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 19:26, @gisvlasta.
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
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("Binary", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Binary")]
  public class Binary_Type : Model { // TODO: Only Model???

    #region Public Properties

    private string _src;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("src", DataType = "anyURI")]
    [JsonProperty("src")]
    public string Src {
      get {
        return _src;
      }
      set {
        if (_src == value) {
          return;
        }
        if (_src == null || _src.Equals(value) != true) {
          _src = value;
          OnPropertyChanged();
        }
      }
    }

    private string _value;

    /// <summary>
    /// 
    /// </summary>
    [XmlText(DataType = "string")]
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
