
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 22/12/2022, @gisvlasta
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

namespace NDSH.Geospatial.Metadata.V2003.Common.Extent {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("EX_GeographicExtent_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("EX_GeographicExtent_PropertyType")]
  public class EX_GeographicExtent_PropertyType : ObjectReference_PropertyType {

    #region Public Properties

    private AbstractEX_GeographicExtent_Type _abstractEX_GeographicExtent;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractEX_GeographicExtent", Order = 0)]
    [JsonProperty("AbstractEX_GeographicExtent", Order = 0)]
    public AbstractEX_GeographicExtent_Type AbstractEX_GeographicExtent {
      get => _abstractEX_GeographicExtent;
      set {
        if (_abstractEX_GeographicExtent == value) {
          return;
        }
        if (_abstractEX_GeographicExtent == null || !_abstractEX_GeographicExtent.Equals(value)) {
          _abstractEX_GeographicExtent = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
