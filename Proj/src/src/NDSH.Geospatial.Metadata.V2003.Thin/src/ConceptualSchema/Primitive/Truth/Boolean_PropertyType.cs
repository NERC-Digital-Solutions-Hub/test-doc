
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 02:56, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Truth {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("Boolean_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Boolean_PropertyType")]
  public class Boolean_PropertyType : NilReasonModel { // TODO: IMPORTANT - The name 'CodeList_PropertyType' DOES not make sense for this type. We need to CHANGE the name of CodeList_PropertyType
    
    #region Public Properties

    private bool _boolean;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Boolean", Order = 0)]
    [JsonProperty("Boolean", Order = 0)]
    public bool Boolean {
      get {
        return _boolean;
      }
      set {
        if (_boolean.Equals(value) != true) {
          _boolean = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
