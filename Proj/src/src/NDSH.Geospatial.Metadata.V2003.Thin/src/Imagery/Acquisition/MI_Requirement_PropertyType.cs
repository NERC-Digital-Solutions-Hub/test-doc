
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 18/01/2023, 17:56, @gisvlasta.
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
  [XmlType("MI_Requirement_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_Requirement_PropertyType")]
  public class MI_Requirement_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Requirement_PropertyType"/>.
    /// </summary>
    public MI_Requirement_PropertyType() {
      _mi_Requirement = default; // new MI_Requirement_Type();
    }

    #endregion

    #region Public Properties

    private MI_Requirement_Type _mi_Requirement;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_Requirement", Order = 0)]
    [JsonProperty("MI_Requirement", Order = 0)]
    public MI_Requirement_Type MI_Requirement {
      get {
        return _mi_Requirement;
      }
      set {
        if (_mi_Requirement == value) {
          return;
        }
        if (_mi_Requirement == null || _mi_Requirement.Equals(value) != true) {
          _mi_Requirement = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
