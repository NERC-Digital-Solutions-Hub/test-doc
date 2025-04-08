
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 18:32, @gisvlasta.
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
  [XmlType("Integer_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Integer_PropertyType")]
  public class Integer_PropertyType : NilReasonModel {

    #region Public Properties
    
    private string _integer;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Integer", DataType = "integer", Order = 0)]
    [JsonProperty("Integer", Order = 0)]
    public string Integer {
      get {
        return _integer;
      }
      set {
        if (_integer == value) {
          return;
        }
        if (_integer == null || _integer.Equals(value) != true) {
          _integer = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
