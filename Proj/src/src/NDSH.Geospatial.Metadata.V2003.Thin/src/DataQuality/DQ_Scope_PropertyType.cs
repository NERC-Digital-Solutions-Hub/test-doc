
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 01:43, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.DataQuality {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DQ_Scope_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_Scope_PropertyType")]
  public class DQ_Scope_PropertyType : ObjectReference_PropertyType {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_Scope_PropertyType"/>.
    /// </summary>
    public DQ_Scope_PropertyType() {
      _dq_Scope  = default; //  new DQ_Scope_Type();
    }

    #endregion

    #region Public Properties

    private DQ_Scope_Type _dq_Scope;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DQ_Scope", Order = 0)]
    [JsonProperty("DQ_Scope", Order = 0)]
    public DQ_Scope_Type DQ_Scope {
      get {
        return _dq_Scope;
      }
      set {
        if (_dq_Scope == value) {
          return;
        }
        if (_dq_Scope == null || _dq_Scope.Equals(value) != true) {
          _dq_Scope = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}