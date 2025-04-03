
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
  [XmlType("EX_VerticalExtent_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("EX_VerticalExtent_PropertyType")]
  public class EX_VerticalExtent_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_VerticalExtent_PropertyType"/>.
    /// </summary>
    public EX_VerticalExtent_PropertyType() {
      _ex_VerticalExtent = default; //  new EX_VerticalExtent_Type();
    }

    #endregion

    #region Public Properties

    private EX_VerticalExtent_Type _ex_VerticalExtent;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("EX_VerticalExtent", Order = 0)]
    [JsonProperty("EX_VerticalExtent", Order = 0)]
    public EX_VerticalExtent_Type EX_VerticalExtent {
      get => _ex_VerticalExtent;
      set {
        if (_ex_VerticalExtent == value) {
          return;
        }
        if (_ex_VerticalExtent == null || !_ex_VerticalExtent.Equals(value)) {
          _ex_VerticalExtent = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
