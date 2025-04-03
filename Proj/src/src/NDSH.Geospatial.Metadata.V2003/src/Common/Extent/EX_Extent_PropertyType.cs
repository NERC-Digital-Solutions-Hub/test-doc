
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
  [XmlType("EX_Extent_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("EX_Extent_PropertyType")]
  public class EX_Extent_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_Extent_PropertyType"/>.
    /// </summary>
    public EX_Extent_PropertyType() {
      _ex_Extent = default; //  new EX_Extent_Type();
    }

    #endregion

    #region Public Properties

    private EX_Extent_Type _ex_Extent;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("EX_Extent", Order = 0)]
    [JsonProperty("EX_Extent", Order = 0)]
    public EX_Extent_Type EX_Extent {
      get => _ex_Extent;
      set {
        if (_ex_Extent == value) {
          return;
        }
        if (_ex_Extent == null || !_ex_Extent.Equals(value)) {
          _ex_Extent = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
