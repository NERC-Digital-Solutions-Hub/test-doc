
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 11/01/2023, 03:23, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Service.Model {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("SV_ServiceType_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("SV_ServiceType_PropertyType")]
  public class SV_ServiceType_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_ServiceType_PropertyType"/>.
    /// </summary>
    public SV_ServiceType_PropertyType() {
      _sv_ServiceType = new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _sv_ServiceType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("SV_ServiceType", Order = 0)]
    [JsonProperty("SV_ServiceType", Order = 0)]
    public CodeListValue_Type SV_ServiceType {
      get {
        return _sv_ServiceType;
      }
      set {
        if (_sv_ServiceType == value) {
          return;
        }
        if (_sv_ServiceType == null || _sv_ServiceType.Equals(value) != true) {
          _sv_ServiceType = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
