
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
  [XmlType("EX_BoundingPolygon_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("EX_BoundingPolygon_PropertyType")]
  public class EX_BoundingPolygon_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_BoundingPolygon_PropertyType"/>.
    /// </summary>
    public EX_BoundingPolygon_PropertyType() {
      _eX_BoundingPolygon = default; //  new EX_BoundingPolygon_Type();
    }

    #endregion

    #region Public Properties

    private EX_BoundingPolygon_Type _eX_BoundingPolygon;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("EX_BoundingPolygon", Order = 0)]
    [JsonProperty("EX_BoundingPolygon", Order = 0)]
    public EX_BoundingPolygon_Type EX_BoundingPolygon {
      get => _eX_BoundingPolygon;
      set {
        if (_eX_BoundingPolygon == value) {
          return;
        }
        if (_eX_BoundingPolygon == null || !_eX_BoundingPolygon.Equals(value)) {
          _eX_BoundingPolygon = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
