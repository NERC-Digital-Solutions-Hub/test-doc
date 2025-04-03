
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

using NDSH.Geospatial.Metadata.V2003.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Imagery.SpatialRepresentation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MI_GCP_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_GCP_PropertyType")]
  public class MI_GCP_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_GCP_PropertyType"/>.
    /// </summary>
    public MI_GCP_PropertyType() {
      _mi_GCP = default; // new MI_GCP_Type();
    }

    #endregion

    #region Public Properties

    private MI_GCP_Type _mi_GCP;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_GCP", Order = 0)]
    [JsonProperty("MI_GCP", Order = 0)]
    public MI_GCP_Type MI_GCP {
      get {
        return _mi_GCP;
      }
      set {
        if (_mi_GCP == value) {
          return;
        }
        if (_mi_GCP == null || _mi_GCP.Equals(value) != true) {
          _mi_GCP = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
