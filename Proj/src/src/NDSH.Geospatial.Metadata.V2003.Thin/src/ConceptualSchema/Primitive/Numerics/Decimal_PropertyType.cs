
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 02/01/2023, 20:23, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
  [XmlType("Decimal_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Decimal_PropertyType")]
  public class Decimal_PropertyType : NilReasonModel {

    #region Public Properties

    private decimal _decimal;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Decimal", Order = 0)]
    [JsonProperty("Decimal", Order = 0)]
    public decimal Decimal {
      get {
        return _decimal;
      }
      set {
        if (_decimal.Equals(value) != true) {
          _decimal = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
