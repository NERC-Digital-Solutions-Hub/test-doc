
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 21/12/2022, 19:28, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Common.Citation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("CI_RoleCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("CI_RoleCode_PropertyType")]
  public class CI_RoleCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_RoleCode_PropertyType"/>.
    /// </summary>
    public CI_RoleCode_PropertyType() {
      _ci_RoleCode  = default; //  new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _ci_RoleCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CI_RoleCode", Order = 0)]
    [JsonProperty("CI_RoleCode", Order = 0)]
    public CodeListValue_Type CI_RoleCode {
      get {
        return _ci_RoleCode;
      }
      set {
        if (_ci_RoleCode == value) {
          return;
        }
        if (_ci_RoleCode == null || _ci_RoleCode.Equals(value) != true) {
          _ci_RoleCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
