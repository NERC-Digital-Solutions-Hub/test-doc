
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 16:07, @gisvlasta.
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
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Maintenance {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_ScopeDescription_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_ScopeDescription_PropertyType")]
  public class MD_ScopeDescription_PropertyType : NilReasonModel { // TODO: DANGEROUS - Why only nilReason??? Shouldn't ir be inherited from ObjectReference_PropertyType???

    /// <summary>
    /// Initializes the <see cref="MD_ScopeDescription_PropertyType"/>.
    /// </summary>
    public MD_ScopeDescription_PropertyType() {
      _md_ScopeDescription  = default; //  new MD_ScopeDescription_Type();
    }

    #region Public Properties

    private MD_ScopeDescription_Type _md_ScopeDescription;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_ScopeDescription", Order = 0)]
    [JsonProperty("MD_ScopeDescription", Order = 0)]
    public MD_ScopeDescription_Type MD_ScopeDescription {
      get {
        return _md_ScopeDescription;
      }
      set {
        if (_md_ScopeDescription == value) {
          return;
        }
        if (_md_ScopeDescription == null || _md_ScopeDescription.Equals(value) != true) {
          _md_ScopeDescription = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
