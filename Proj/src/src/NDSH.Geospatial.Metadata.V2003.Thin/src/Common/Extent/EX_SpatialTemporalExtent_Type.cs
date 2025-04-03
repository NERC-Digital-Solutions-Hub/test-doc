
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 22/12/2022, 20:04, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Common.Extent {

  /// <summary>
  /// Extent with respect to date and time.
  /// </summary>
  [Serializable]
  [XmlType("EX_SpatialTemporalExtent", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("EX_SpatialTemporalExtent", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("EX_SpatialTemporalExtent")]
  public class EX_SpatialTemporalExtent_Type : EX_TemporalExtent_Type {

    #region Consturctors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_SpatialTemporalExtent_Type"/>.
    /// </summary>
    public EX_SpatialTemporalExtent_Type() {
      _spatialExtent  = default; //  new List<EX_GeographicExtent_PropertyType>();
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
      get {
        return _spatialExtent;
      }
      set {
        if (_spatialExtent == value) {
          return;
        }
        if (_spatialExtent == null || _spatialExtent.Equals(value) != true) {
          _spatialExtent = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}