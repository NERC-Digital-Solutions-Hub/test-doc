
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 11/01/2023, 02:43, @gisvlasta.
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
  [XmlType("SV_PlatformNeutralServiceSpecification_PropertyType", Namespace = "http://www.isotc211.org/2005/srv")]
  [JsonObject("SV_PlatformNeutralServiceSpecification_PropertyType")]
  public class SV_PlatformNeutralServiceSpecification_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_PlatformNeutralServiceSpecification_PropertyType"/>.
    /// </summary>
    public SV_PlatformNeutralServiceSpecification_PropertyType() {
      _sv_PlatformNeutralServiceSpecification = new SV_PlatformNeutralServiceSpecification_Type();
    }

    #endregion

    #region Public Properties

    private SV_PlatformNeutralServiceSpecification_Type _sv_PlatformNeutralServiceSpecification;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("SV_PlatformNeutralServiceSpecification", Order = 0)]
    [JsonProperty("SV_PlatformNeutralServiceSpecification", Order = 0)]
    public SV_PlatformNeutralServiceSpecification_Type SV_PlatformNeutralServiceSpecification {
      get {
        return _sv_PlatformNeutralServiceSpecification;
      }
      set {
        if (_sv_PlatformNeutralServiceSpecification == value) {
          return;
        }
        if (_sv_PlatformNeutralServiceSpecification == null || _sv_PlatformNeutralServiceSpecification.Equals(value) != true) {
          _sv_PlatformNeutralServiceSpecification = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
