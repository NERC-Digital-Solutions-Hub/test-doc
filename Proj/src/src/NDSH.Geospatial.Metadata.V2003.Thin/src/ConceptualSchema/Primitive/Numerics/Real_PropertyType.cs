
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 19:22, @gisvlasta.
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
  [XmlType("Real_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Real_PropertyType")]
  public class Real_PropertyType : NilReasonModel {
    
    #region Public Properties

    private double _real;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Real", DataType = "decimal", Order = 0)]
    [JsonProperty("Real", Order = 0)]
    public double Real {
      get {
        return _real;
      }
      set {
        if (_real.Equals(value) != true) {
          _real = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
