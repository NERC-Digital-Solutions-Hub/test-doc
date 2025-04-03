
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
  [XmlType("CI_OnlineResource_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("CI_OnlineResource_PropertyType")]
  public class CI_OnlineResource_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_OnlineResource_PropertyType"/>.
    /// </summary>
    public CI_OnlineResource_PropertyType() {
      _ci_OnlineResource = default; //  new CI_OnlineResource_Type();
    }

    #endregion

    #region Private fields

    private CI_OnlineResource_Type _ci_OnlineResource;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CI_OnlineResource", Order = 0)]
    [JsonProperty("CI_OnlineResource", Order = 0)]
    public CI_OnlineResource_Type CI_OnlineResource {
      get => _ci_OnlineResource;
      set {
        if (_ci_OnlineResource == value) {
          return;
        }
        if (_ci_OnlineResource == null || !_ci_OnlineResource.Equals(value)) {
          _ci_OnlineResource = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
