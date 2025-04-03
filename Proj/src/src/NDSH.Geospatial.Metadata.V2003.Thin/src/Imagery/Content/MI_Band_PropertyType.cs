
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 26/01/2023, 11:03, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Content {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MI_Band_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_Band_PropertyType")]
  public class MI_Band_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Band_PropertyType"/>.
    /// </summary>
    public MI_Band_PropertyType() {
      _mi_Band = default; // new MI_Band_Type();
    }

    #endregion

    #region Public Properties

    private MI_Band_Type _mi_Band;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_Band", Order = 0)]
    [JsonProperty("MI_Band", Order = 0)]
    public MI_Band_Type MI_Band {
      get {
        return _mi_Band;
      }
      set {
        if (_mi_Band == value) {
          return;
        }
        if (_mi_Band == null || _mi_Band.Equals(value) != true) {
          _mi_Band = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
