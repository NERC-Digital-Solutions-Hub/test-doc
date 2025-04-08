
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 02/01/2023, 20:16, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Numerics {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("UnlimitedInteger", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("UnlimitedInteger")]
  public class UnlimitedInteger_Type : Model {
    
    #region Public Properties

    private bool _isInfinite;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("isInfinite")]
    [JsonProperty("isInfinite")]
    public bool IsInfinite {
      get {
        return _isInfinite;
      }
      set {
        if (_isInfinite.Equals(value) != true) {
          _isInfinite = value;
          OnPropertyChanged();
        }
      }
    }

    private string _value;

    /// <summary>
    /// 
    /// </summary>
    [XmlText(DataType = "nonNegativeInteger")]
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
