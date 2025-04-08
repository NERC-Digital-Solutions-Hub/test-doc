
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:43, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Imagery.Acquisition {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MI_Plan_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_Plan_PropertyType")]
  public class MI_Plan_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Plan_PropertyType"/>.
    /// </summary>
    public MI_Plan_PropertyType() {
      _mi_Plan = default; // new MI_Plan_Type();
    }

    #endregion

    #region Public Properties

    private MI_Plan_Type _mi_Plan;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_Plan", Order = 0)]
    [JsonProperty("MI_Plan", Order = 0)]
    public MI_Plan_Type MI_Plan {
      get {
        return _mi_Plan;
      }
      set {
        if (_mi_Plan == value) {
          return;
        }
        if (_mi_Plan == null || _mi_Plan.Equals(value) != true) {
          _mi_Plan = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
