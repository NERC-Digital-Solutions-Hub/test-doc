
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/01/2023, 01:22, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Imagery.EntitySet {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MI_Metadata_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_Metadata_PropertyType")]
  public class MI_Metadata_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Metadata_PropertyType"/>.
    /// </summary>
    public MI_Metadata_PropertyType() {
      _mi_Metadata = default; // new MI_Metadata_Type();
    }

    #endregion

    #region Public Properties

    private MI_Metadata_Type _mi_Metadata;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_Metadata", Order = 0)]
    [JsonProperty("MI_Metadata", Order = 0)]
    public MI_Metadata_Type MI_Metadata {
      get {
        return _mi_Metadata;
      }
      set {
        if (_mi_Metadata == value) {
          return;
        }
        if (_mi_Metadata == null || _mi_Metadata.Equals(value) != true) {
          _mi_Metadata = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
