
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 16:02, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Maintenance {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_ScopeCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_ScopeCode_PropertyType")]
  public class MD_ScopeCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_ScopeCode_PropertyType"/>.
    /// </summary>
    public MD_ScopeCode_PropertyType() {
      _md_ScopeCode  = default; //  new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _md_ScopeCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_ScopeCode", Order = 0)]
    [JsonProperty("MD_ScopeCode", Order = 0)]
    public CodeListValue_Type MD_ScopeCode {
      get {
        return _md_ScopeCode;
      }
      set {
        if (_md_ScopeCode == value) {
          return;
        }
        if (_md_ScopeCode == null || _md_ScopeCode.Equals(value) != true) {
          _md_ScopeCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
