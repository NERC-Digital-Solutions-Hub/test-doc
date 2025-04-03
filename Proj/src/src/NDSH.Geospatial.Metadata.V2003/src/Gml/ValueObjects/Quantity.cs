
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 01/02/2023, 19:02, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.Gml.Measures;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.ValueObjects {

  /// <summary>
  /// An XML attribute uom (unit of measure) is required, whose value is a URI which identifies
  /// the definition of a ratio scale or units by which the numeric value shall be multiplied,
  /// or an interval or position scale on which the value occurs.
  /// </summary>
  [Serializable]
  [XmlType("Quantity", AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
  [JsonObject("Quantity")]
  public class Quantity : MeasureType, INilReason {
    
    #region Public Properties

    private string _nilReason;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("nilReason")]
    [JsonProperty("nilReason")]
    public string NilReason {
      get {
        return _nilReason;
      }
      set {
        if (_nilReason == value) {
          return;
        }
        if (_nilReason == null || _nilReason.Equals(value) != true) {
          _nilReason = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
