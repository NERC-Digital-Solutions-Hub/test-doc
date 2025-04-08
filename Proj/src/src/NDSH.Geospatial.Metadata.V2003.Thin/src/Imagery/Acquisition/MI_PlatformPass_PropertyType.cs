
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:44, @gisvlasta.
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
  [XmlType("MI_PlatformPass_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_PlatformPass_PropertyType")]
  public class MI_PlatformPass_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_PlatformPass_PropertyType"/>.
    /// </summary>
    public MI_PlatformPass_PropertyType() {
      _mi_PlatformPass = default; // new MI_PlatformPass_Type();
    }

    #endregion

    #region Public Properties

    private MI_PlatformPass_Type _mi_PlatformPass;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_PlatformPass", Order = 0)]
    [JsonProperty("MI_PlatformPass", Order = 0)]
    public MI_PlatformPass_Type MI_PlatformPass {
      get {
        return _mi_PlatformPass;
      }
      set {
        if (_mi_PlatformPass == value) {
          return;
        }
        if (_mi_PlatformPass == null || _mi_PlatformPass.Equals(value) != true) {
          _mi_PlatformPass = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
