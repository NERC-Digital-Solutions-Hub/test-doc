
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 11/01/2023, 02:59, @gisvlasta.
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
  [XmlType("SV_Port_PropertyType", Namespace = "http://www.isotc211.org/2005/srv")]
  [JsonObject("SV_Port_PropertyType")]
  public class SV_Port_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_Port_PropertyType"/>.
    /// </summary>
    public SV_Port_PropertyType() {
      _sv_Port = new SV_Port_Type();
    }

    #endregion

    #region Public Properties

    private SV_Port_Type _sv_Port;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("SV_Port", Order = 0)]
    [JsonProperty("SV_Port", Order = 0)]
    public SV_Port_Type SV_Port {
      get {
        return _sv_Port;
      }
      set {
        if (_sv_Port == value) {
          return;
        }
        if (_sv_Port == null || _sv_Port.Equals(value) != true) {
          _sv_Port = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
