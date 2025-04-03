
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 14/01/2023, 03:38, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Service.Metadata {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("SV_ParameterDirection_PropertyType", Namespace = "http://www.isotc211.org/2005/srv")]
  [JsonObject("SV_ParameterDirection_PropertyType")]
  public class SV_ParameterDirection_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_ParameterDirection_PropertyType"/>.
    /// </summary>
    public SV_ParameterDirection_PropertyType() {
      _sv_ParameterDirection = new SV_ParameterDirection_Type();
    }

    #endregion

    #region Public Properties

    private SV_ParameterDirection_Type _sv_ParameterDirection;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("SV_CoupledResource", Order = 0)]
    [JsonProperty("SV_CoupledResource", Order = 0)]
    public SV_ParameterDirection_Type SV_ParameterDirection {
      get {
        return _sv_ParameterDirection;
      }
      set {
        if (_sv_ParameterDirection == value) {
          return;
        }
        if (_sv_ParameterDirection == null || _sv_ParameterDirection.Equals(value) != true) {
          _sv_ParameterDirection = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
