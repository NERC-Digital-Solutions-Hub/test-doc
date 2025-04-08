
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:45, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Acquisition {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MI_RequestedDate_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_RequestedDate_PropertyType")]
  public class MI_RequestedDate_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_RequestedDate_PropertyType"/>.
    /// </summary>
    public MI_RequestedDate_PropertyType() {
      _mi_RequestedDate = default; // new MI_RequestedDate_Type();
    }

    #endregion

    #region Public Properties

    private MI_RequestedDate_Type _mi_RequestedDate;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_RequestedDate", Order = 0)]
    [JsonProperty("MI_RequestedDate", Order = 0)]
    public MI_RequestedDate_Type MI_RequestedDate {
      get {
        return _mi_RequestedDate;
      }
      set {
        if (_mi_RequestedDate == value) {
          return;
        }
        if (_mi_RequestedDate == null || _mi_RequestedDate.Equals(value) != true) {
          _mi_RequestedDate = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
