
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:39, @gisvlasta.
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
  [XmlType("MI_Objective_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_Objective_PropertyType")]
  public class MI_Objective_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Objective_PropertyType"/>.
    /// </summary>
    public MI_Objective_PropertyType() {
      _mi_Objective = default; // new MI_Objective_Type();
    }

    #endregion

    #region Public Properties

    private MI_Objective_Type _mi_Objective;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_Objective", Order = 0)]
    [JsonProperty("MI_Objective", Order = 0)]
    public MI_Objective_Type MI_Objective {
      get {
        return _mi_Objective;
      }
      set {
        if (_mi_Objective == value) {
          return;
        }
        if (_mi_Objective == null || _mi_Objective.Equals(value) != true) {
          _mi_Objective = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
