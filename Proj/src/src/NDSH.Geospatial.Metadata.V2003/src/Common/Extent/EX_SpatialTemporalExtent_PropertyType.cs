
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
  [XmlType("EX_SpatialTemporalExtent_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("EX_SpatialTemporalExtent_PropertyType")]
  public class EX_SpatialTemporalExtent_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_SpatialTemporalExtent_PropertyType"/>.
    /// </summary>
    public EX_SpatialTemporalExtent_PropertyType() {
      _ex_SpatialTemporalExtent = default; //  new EX_SpatialTemporalExtent_Type();
    }

    #endregion

    #region Public Properties

    private EX_SpatialTemporalExtent_Type _ex_SpatialTemporalExtent;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("EX_SpatialTemporalExtent", Order = 0)]
    [JsonProperty("EX_SpatialTemporalExtent", Order = 0)]
    public EX_SpatialTemporalExtent_Type EX_SpatialTemporalExtent {
      get => _ex_SpatialTemporalExtent;
      set {
        if (_ex_SpatialTemporalExtent == value) {
          return;
        }
        if (_ex_SpatialTemporalExtent == null || !_ex_SpatialTemporalExtent.Equals(value)) {
          _ex_SpatialTemporalExtent = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
