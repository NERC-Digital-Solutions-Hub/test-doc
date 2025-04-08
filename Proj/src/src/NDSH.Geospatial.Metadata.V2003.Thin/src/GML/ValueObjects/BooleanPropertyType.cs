
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/02/2023, 01:29, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.GML.Base;
using Boolean = NDSH.Geospatial.Metadata.V2003.Thin.GML.BasicTypes.Boolean;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.ValueObjects {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("BooleanPropertyType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("BooleanPropertyType")]
  public class BooleanPropertyType : Association {

    #region Consturctors - Destructors

    /// <summary>
    /// Initializes the <see cref="BooleanPropertyType"/>.
    /// </summary>
    public BooleanPropertyType() {
      _boolean = new Boolean();
    }

    #endregion

    #region Public Properties

    private Boolean _boolean;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Boolean", IsNullable = true, Order = 0)]
    [JsonProperty("Boolean", Order = 0)]
    public Boolean Boolean {
      get {
        return _boolean;
      }
      set {
        if (_boolean == value) {
          return;
        }
        if (_boolean == null || _boolean.Equals(value) != true) {
          _boolean = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
