
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 21/12/2022, 19:16, @gisvlasta.
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
  [XmlType("CI_OnLineFunctionCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("CI_OnLineFunctionCode_PropertyType")]
  public class CI_OnLineFunctionCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_OnLineFunctionCode_PropertyType"/>.
    /// </summary>
    public CI_OnLineFunctionCode_PropertyType() {
      _ci_OnLineFunctionCode  = default; //  new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _ci_OnLineFunctionCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CI_OnLineFunctionCode", Order = 0)]
    [JsonProperty("CI_OnLineFunctionCode", Order = 0)]
    public CodeListValue_Type CI_OnLineFunctionCode {
      get {
        return _ci_OnLineFunctionCode;
      }
      set {
        if (_ci_OnLineFunctionCode == value) {
          return;
        }
        if (_ci_OnLineFunctionCode == null || _ci_OnLineFunctionCode.Equals(value) != true) {
          _ci_OnLineFunctionCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}