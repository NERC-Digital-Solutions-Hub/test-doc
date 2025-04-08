
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
  [XmlType("MI_GCPCollection_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_GCPCollection_PropertyType")]
  public class MI_GCPCollection_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_GCPCollection_PropertyType"/>.
    /// </summary>
    public MI_GCPCollection_PropertyType() {
      _mi_GCPCollection = default; // new MI_GCPCollection_Type();
    }

    #endregion

    #region Public Properties

    private MI_GCPCollection_Type _mi_GCPCollection;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_GCPCollection", Order = 0)]
    [JsonProperty("MI_GCPCollection", Order = 0)]
    public MI_GCPCollection_Type MI_GCPCollection {
      get {
        return _mi_GCPCollection;
      }
      set {
        if (_mi_GCPCollection == value) {
          return;
        }
        if (_mi_GCPCollection == null || _mi_GCPCollection.Equals(value) != true) {
          _mi_GCPCollection = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
