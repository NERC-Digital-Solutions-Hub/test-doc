
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
  [XmlType("EX_GeographicBoundingBox_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("EX_GeographicBoundingBox_PropertyType")]
  public class EX_GeographicBoundingBox_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_GeographicBoundingBox_PropertyType"/>.
    /// </summary>
    public EX_GeographicBoundingBox_PropertyType() {
      _ex_GeographicBoundingBox = default; //  new EX_GeographicBoundingBox_Type();
    }

    #endregion

    #region Private fields

    private EX_GeographicBoundingBox_Type _ex_GeographicBoundingBox;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("EX_GeographicBoundingBox", Order = 0)]
    [JsonProperty("EX_GeographicBoundingBox", Order = 0)]
    public EX_GeographicBoundingBox_Type EX_GeographicBoundingBox {
      get => _ex_GeographicBoundingBox;
      set {
        if (_ex_GeographicBoundingBox == value) {
          return;
        }
        if (_ex_GeographicBoundingBox == null || !_ex_GeographicBoundingBox.Equals(value)) {
          _ex_GeographicBoundingBox = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
