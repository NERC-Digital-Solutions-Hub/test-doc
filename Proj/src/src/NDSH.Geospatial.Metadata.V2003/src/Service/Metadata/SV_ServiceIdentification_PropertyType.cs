
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 02:41, @gisvlasta.
// Updated by        : 14/01/2023, 03:40, @gisvlasta.
// Version           : 1.0.1
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
  [XmlType("SV_ServiceIdentification_PropertyType", Namespace = "http://www.isotc211.org/2005/srv")]
  [JsonObject("SV_ServiceIdentification_PropertyType")]
  public class SV_ServiceIdentification_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_ServiceIdentification_PropertyType"/>.
    /// </summary>
    public SV_ServiceIdentification_PropertyType() {
      _sv_ServiceIdentification = new SV_ServiceIdentification_Type();
    }

    #endregion

    #region Public Properties

    private SV_ServiceIdentification_Type _sv_ServiceIdentification;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("SV_ServiceIdentification", Order = 0)]
    [JsonProperty("SV_ServiceIdentification", Order = 0)]
    public SV_ServiceIdentification_Type SV_ServiceIdentification {
      get {
        return _sv_ServiceIdentification;
      }
      set {
        if (_sv_ServiceIdentification == value) {
          return;
        }
        if (_sv_ServiceIdentification == null || _sv_ServiceIdentification.Equals(value) != true) {
          _sv_ServiceIdentification = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
