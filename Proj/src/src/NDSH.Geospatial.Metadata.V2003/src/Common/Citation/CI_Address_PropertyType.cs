
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
  [XmlType("CI_Address_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("CI_Address_PropertyType")]
  public class CI_Address_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_Address_PropertyType"/>.
    /// </summary>
    public CI_Address_PropertyType() {
      _ci_Address = default; //  new CI_Address_Type();
    }

    #endregion

    #region Public Properties

    private CI_Address_Type _ci_Address;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CI_Address", Order = 0)]
    [JsonProperty("CI_Address", Order = 0)]
    public CI_Address_Type CI_Address {
      get => _ci_Address;
      set {
        if (_ci_Address == value) {
          return;
        }
        if (_ci_Address == null || !_ci_Address.Equals(value)) {
          _ci_Address = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
