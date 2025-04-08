
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/01/2023, 01:30, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Imagery.SpatialRepresentation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MI_Georeferenceable_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_Georeferenceable_PropertyType")]
  public class MI_Georeferenceable_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Georeferenceable_PropertyType"/>.
    /// </summary>
    public MI_Georeferenceable_PropertyType() {
      _mi_Georeferenceable = default; // new MI_Georeferenceable_Type();
    }

    #endregion

    #region Public Properties

    private MI_Georeferenceable_Type _mi_Georeferenceable;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_Georeferenceable", Order = 0)]
    [JsonProperty("MI_Georeferenceable", Order = 0)]
    public MI_Georeferenceable_Type MI_Georeferenceable {
      get {
        return _mi_Georeferenceable;
      }
      set {
        if (_mi_Georeferenceable == value) {
          return;
        }
        if (_mi_Georeferenceable == null || _mi_Georeferenceable.Equals(value) != true) {
          _mi_Georeferenceable = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
