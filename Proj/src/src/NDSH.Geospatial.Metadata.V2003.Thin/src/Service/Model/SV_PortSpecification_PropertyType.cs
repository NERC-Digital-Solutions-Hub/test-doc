
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 11/01/2023, 03:04, @gisvlasta.
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
  [XmlType("SV_PortSpecification_PropertyType", Namespace = "http://www.isotc211.org/2005/srv")]
  [JsonObject("SV_PortSpecification_PropertyType")]
  public class SV_PortSpecification_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_PortSpecification_PropertyType"/>.
    /// </summary>
    public SV_PortSpecification_PropertyType() {
      _sv_PortSpecification = new SV_PortSpecification_Type();
    }

    #endregion

    #region Public Properties

    private SV_PortSpecification_Type _sv_PortSpecification;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("SV_PortSpecification", Order = 0)]
    [JsonProperty("SV_PortSpecification", Order = 0)]
    public SV_PortSpecification_Type SV_PortSpecification {
      get {
        return _sv_PortSpecification;
      }
      set {
        if (_sv_PortSpecification == value) {
          return;
        }
        if (_sv_PortSpecification == null || _sv_PortSpecification.Equals(value) != true) {
          _sv_PortSpecification = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
