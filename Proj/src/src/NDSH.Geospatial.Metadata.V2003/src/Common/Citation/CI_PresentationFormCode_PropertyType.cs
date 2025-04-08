
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 21/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
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

namespace NDSH.Geospatial.Metadata.V2003.Common.Citation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("CI_PresentationFormCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("CI_PresentationFormCode_PropertyType")]
  public class CI_PresentationFormCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_PresentationFormCode_PropertyType"/>.
    /// </summary>
    public CI_PresentationFormCode_PropertyType() {
      _ci_PresentationFormCode = default; //  new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _ci_PresentationFormCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CI_PresentationFormCode", Order = 0)]
    [JsonProperty("CI_PresentationFormCode", Order = 0)]
    public CodeListValue_Type CI_PresentationFormCode {
      get => _ci_PresentationFormCode;
      set {
        if (_ci_PresentationFormCode == value) {
          return;
        }
        if (_ci_PresentationFormCode == null || !_ci_PresentationFormCode.Equals(value)) {
          _ci_PresentationFormCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
