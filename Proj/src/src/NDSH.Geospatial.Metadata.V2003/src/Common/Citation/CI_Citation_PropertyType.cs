
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
  [XmlType("CI_Citation_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("CI_Citation_PropertyType")]
  public class CI_Citation_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_Citation_PropertyType"/>.
    /// </summary>
    public CI_Citation_PropertyType() {
      _ci_Citation = default; //  new CI_Citation_Type();
    }

    #endregion

    #region Public Properties

    private CI_Citation_Type _ci_Citation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CI_Citation", Order = 0)]
    [JsonProperty("CI_Citation", Order = 0)]
    public CI_Citation_Type CI_Citation {
      get => _ci_Citation;
      set {
        if (_ci_Citation == value) {
          return;
        }
        if (_ci_Citation == null || !_ci_Citation.Equals(value)) {
          _ci_Citation = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
