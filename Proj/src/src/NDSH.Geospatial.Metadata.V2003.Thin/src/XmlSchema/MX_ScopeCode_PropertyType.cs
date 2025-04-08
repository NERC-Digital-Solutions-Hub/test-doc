
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 07/01/2023, 16:30, @gisvlasta.
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
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MX_ScopeCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("MX_ScopeCode_PropertyType")]
  public class MX_ScopeCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MX_ScopeCode_PropertyType"/>.
    /// </summary>
    public MX_ScopeCode_PropertyType() {
      _mx_ScopeCode  = default; //  new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _mx_ScopeCode;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MX_ScopeCode", Order = 0)]
    [JsonProperty("MX_ScopeCode", Order = 0)]
    public CodeListValue_Type MX_ScopeCode {
      get {
        return _mx_ScopeCode;
      }
      set {
        if (_mx_ScopeCode == value) {
          return;
        }
        if (_mx_ScopeCode == null || _mx_ScopeCode.Equals(value) != true) {
          _mx_ScopeCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
