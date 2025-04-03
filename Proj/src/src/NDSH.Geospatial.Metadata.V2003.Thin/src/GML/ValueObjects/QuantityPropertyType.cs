
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/02/2023, 20:27, @gisvlasta.
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
  [XmlType("QuantityPropertyType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("QuantityPropertyType")]
  public class QuantityPropertyType : Association {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="QuantityPropertyType"/>.
    /// </summary>
    public QuantityPropertyType() {
      _quantity = new Quantity();
    }

    #endregion

    #region Public Properties

    private Quantity _quantity;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Quantity", IsNullable = true, Order = 0)]
    [JsonProperty("Quantity", Order = 0)]
    public Quantity Quantity {
      get {
        return _quantity;
      }
      set {
        if (_quantity == value) {
          return;
        }
        if (_quantity == null || _quantity.Equals(value) != true) {
          _quantity = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
