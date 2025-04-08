
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 11/01/2023, 03:28, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Service.Model {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("SV_Service_PropertyType", Namespace = "http://www.isotc211.org/2005/srv")]
  [JsonObject("SV_Service_PropertyType")]
  public class SV_Service_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_Service_PropertyType"/>.
    /// </summary>
    public SV_Service_PropertyType() {
      _sv_Service = new SV_Service_Type();
    }

    #endregion

    #region Public Properties

    private SV_Service_Type _sv_Service;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("SV_Service", Order = 0)]
    [JsonProperty("SV_Service", Order = 0)]
    public SV_Service_Type SV_Service {
      get {
        return _sv_Service;
      }
      set {
        if (_sv_Service == value) {
          return;
        }
        if (_sv_Service == null || _sv_Service.Equals(value) != true) {
          _sv_Service = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
