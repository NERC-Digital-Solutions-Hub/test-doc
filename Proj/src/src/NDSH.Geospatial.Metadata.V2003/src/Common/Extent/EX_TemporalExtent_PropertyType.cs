
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
  [XmlType("EX_TemporalExtent_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("EX_TemporalExtent_PropertyType")]
  public class EX_TemporalExtent_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_TemporalExtent_PropertyType"/>.
    /// </summary>
    public EX_TemporalExtent_PropertyType() {
      _ex_TemporalExtent = default; //  new EX_TemporalExtent_Type();
    }

    #endregion

    #region Public Properties

    private EX_TemporalExtent_Type _ex_TemporalExtent;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("EX_TemporalExtent", Order = 0)]
    [JsonProperty("EX_TemporalExtent", Order = 0)]
    public EX_TemporalExtent_Type EX_TemporalExtent {
      get => _ex_TemporalExtent;
      set {
        if (_ex_TemporalExtent == value) {
          return;
        }
        if (_ex_TemporalExtent == null || !_ex_TemporalExtent.Equals(value)) {
          _ex_TemporalExtent = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
