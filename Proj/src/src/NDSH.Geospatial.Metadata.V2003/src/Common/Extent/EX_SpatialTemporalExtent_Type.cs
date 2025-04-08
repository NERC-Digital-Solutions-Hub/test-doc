
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
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Common.Extent {

  /// <summary>
  /// Extent with respect to date and time.
  /// </summary>
  [Serializable]
  [XmlType("EX_SpatialTemporalExtent", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("EX_SpatialTemporalExtent", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("EX_SpatialTemporalExtent")]
  public class EX_SpatialTemporalExtent_Type : EX_TemporalExtent_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_SpatialTemporalExtent_Type"/>.
    /// </summary>
    public EX_SpatialTemporalExtent_Type() {
      _spatialExtent = default; //  new List<EX_GeographicExtent_PropertyType>();
    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private List<EX_GeographicExtent_PropertyType> _spatialExtent;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("spatialExtent", Order = 0)]
    [JsonProperty("spatialExtent", Order = 0)]
    public List<EX_GeographicExtent_PropertyType> SpatialExtent {
      get => _spatialExtent;
      set {
        if (_spatialExtent == value) {
          return;
        }
        if (_spatialExtent == null || !_spatialExtent.Equals(value)) {
          _spatialExtent = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
