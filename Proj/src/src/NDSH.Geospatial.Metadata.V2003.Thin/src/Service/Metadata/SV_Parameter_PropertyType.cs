
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 14/01/2023, 03:34, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Service.Metadata {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("SV_Parameter_PropertyType", Namespace = "http://www.isotc211.org/2005/srv")]
  [JsonObject("SV_Parameter_PropertyType")]
  public class SV_Parameter_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_Parameter_PropertyType"/>.
    /// </summary>
    public SV_Parameter_PropertyType() {
      _sv_Parameter = new SV_Parameter_Type();
    }

    #endregion

    #region Public Properties

    private SV_Parameter_Type _sv_Parameter;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("SV_CoupledResource", Order = 0)]
    [JsonProperty("SV_CoupledResource", Order = 0)]
    public SV_Parameter_Type SV_Parameter {
      get {
        return _sv_Parameter;
      }
      set {
        if (_sv_Parameter == value) {
          return;
        }
        if (_sv_Parameter == null || _sv_Parameter.Equals(value) != true) {
          _sv_Parameter = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
